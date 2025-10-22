using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class B31_3PipeCalculator : Form
    {
        private List<MaterialData> _materialData = new List<MaterialData>();
        private Dictionary<string, List<string>> _materialSpecs = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, List<string>> _specGrades = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
        private Dictionary<string, double> _npsToOd = new Dictionary<string, double>();
        private List<EFactorData> _eFactorData = new List<EFactorData>();
        private double currentStressValuePsi = 0;


        // ADD THESE NEW FIELDS RIGHT HERE:
        private bool _isInitializing = false;
        private string _pendingGradeSelection = "";


        // Track last selections to maintain state
        private string _lastSelectedMaterial = "";
        private string _lastSelectedSpec = "";
        private string _lastSelectedGrade = "";

        public B31_3PipeCalculator()
        {
            InitializeComponent();
            InitializeNPSData();
            InitializeEFactorData();
            LoadMaterialData();
            InitializeMaterialDropdown();
            InitializeQualityFactorDropdown();
            InitializeWeldJointFactor();
            WireUpEvents();
            InitializeDefaultValues();
        }

        private void InitializeNPSData()
        {
            _npsToOd = new Dictionary<string, double>
            {
                {"0.5", 0.840}, {"0.75", 1.050}, {"1", 1.315},
                {"1.5", 1.900}, {"2", 2.375}, {"2.5", 2.875},
                {"3", 3.500}, {"4", 4.500}, {"5", 5.563},
                {"6", 6.625}, {"8", 8.625}, {"10", 10.750},
                {"12", 12.750}, {"14", 14.000}, {"16", 16.000},
                {"18", 18.000}, {"20", 20.000}, {"24", 24.000}
            };

            cmbNPS.DataSource = new BindingSource(_npsToOd, null);
            cmbNPS.DisplayMember = "Key";
            cmbNPS.ValueMember = "Value";
            cmbNPS.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeEFactorData()
        {
            _eFactorData = new List<EFactorData>
            {
                new EFactorData("All Materials", "All Specs", "", "Seamless (No Longitudinal Weld)", 1.00, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "Furnace Butt Welded (Continuous Weld)", 0.60, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "Electric Resistance Welded (ERW)", 0.85, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (No RT)", 0.80, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (Spot RT)", 0.90, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (100% RT)", 1.00, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (No RT)", 0.85, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (Spot RT)", 0.90, "B31.3 Table A-1B"),
                new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (100% RT)", 1.00, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "API 5L", "", "EFW Double Butt (No RT)", 0.95, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "API 5L", "", "EFW Double Butt (100% RT)", 1.00, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "A53", "Type S", "Seamless", 1.00, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "A53", "Type E", "ERW", 0.85, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "A53", "Type F", "Furnace Butt Welded", 0.60, "B31.3 Table A-1B"),
                new EFactorData("Carbon Steel", "A106", "", "Seamless", 1.00, "B31.3 Table A-1B"),
                new EFactorData("Stainless Steel", "A312", "", "Seamless", 1.00, "B31.3 Table A-1B"),
                new EFactorData("Stainless Steel", "A312", "", "EFW Double Butt", 0.85, "B31.3 Table A-1B"),
                new EFactorData("Stainless Steel", "A312", "", "EFW Single Butt", 0.80, "B31.3 Table A-1B"),
                new EFactorData("Stainless Steel", "A312", "", "EFW 100% RT", 1.00, "B31.3 Table A-1B")
            };
        }

        private void InitializeQualityFactorDropdown()
        {
            cmbQualityFactor.DisplayMember = "Description";
            cmbQualityFactor.ValueMember = "EFactor";
            cmbQualityFactor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeWeldJointFactor()
        {
            txtWeldJointFactor.Text = "1.00";
            txtWeldJointFactor.Validating += TxtWeldJointFactor_Validating;
        }

        private void VerifyLoadedData()
        {
            Debug.WriteLine("=== MATERIAL DATA VERIFICATION ===");
            Debug.WriteLine($"Total materials loaded: {_materialData.Count}");
            Debug.WriteLine($"Material-Spec mappings: {_materialSpecs.Count}");
            Debug.WriteLine($"Spec-Grade mappings: {_specGrades.Count}");

            // Log some sample data
            foreach (var material in _materialSpecs.Keys.Take(5))
            {
                Debug.WriteLine($"Material: {material}");
                foreach (var spec in _materialSpecs[material])
                {
                    string key = $"{material}|{spec}";
                    if (_specGrades.TryGetValue(key, out var grades))
                    {
                        Debug.WriteLine($"  Spec: {spec} (Grades: {string.Join(", ", grades)})");
                    }
                    else
                    {
                        Debug.WriteLine($"  Spec: {spec} (No grades found)");
                    }
                }
            }
        }
        private void LoadMaterialData()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames()
                    .FirstOrDefault(name => name.EndsWith("B31_3_Materials.csv"));

                if (string.IsNullOrEmpty(resourceName))
                    throw new FileNotFoundException("Material data resource not found");

                Debug.WriteLine($"Found resource: {resourceName}");

                // Clear existing data
                _materialData.Clear();
                _materialSpecs.Clear();
                _specGrades.Clear();

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line;
                    bool isFirstLine = true;
                    int lineNumber = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        lineNumber++;
                        try
                        {
                            if (isFirstLine)
                            {
                                Debug.WriteLine($"CSV Header: {line}");
                                isFirstLine = false;
                                continue;
                            }

                            var values = line.Split(',');
                            if (values.Length < 5)
                            {
                                Debug.WriteLine($"Skipping line {lineNumber} - insufficient columns");
                                continue;
                            }

                            string material = values[0].Trim();
                            string spec = values[3].Trim();
                            string grade = values[4].Trim();

                            if (string.IsNullOrEmpty(material) || string.IsNullOrEmpty(spec))
                            {
                                Debug.WriteLine($"Skipping line {lineNumber} - missing material or spec");
                                continue;
                            }

                            // Add material data
                            _materialData.Add(new MaterialData
                            {
                                Material = material,
                                Spec = spec,
                                Grade = grade,
                                Temperature = values.Length > 8 ? ParseDouble(values[8], 0) : 0,
                                StressValue = values.Length > 9 ? ParseDouble(values[9], 0) : 0,
                                MinTemp = TryParseMinTemp(values.Length > 10 ? values[10].Trim() : ""),
                                Tensile = values.Length > 11 ? ParseDouble(values[11], 0) : 0,
                                Yield = values.Length > 12 ? ParseDouble(values[12], 0) : 0
                            });

                            // Build material-spec mapping
                            if (!_materialSpecs.TryGetValue(material, out var specs))
                            {
                                specs = new List<string>();
                                _materialSpecs[material] = specs;
                                Debug.WriteLine($"New material added: {material}");
                            }

                            if (!specs.Contains(spec, StringComparer.OrdinalIgnoreCase))
                            {
                                specs.Add(spec);
                                Debug.WriteLine($"Added spec {spec} to material {material}");
                            }

                            // Build spec-grade mapping
                            string specKey = $"{material}|{spec}";
                            if (!_specGrades.TryGetValue(specKey, out var grades))
                            {
                                grades = new List<string>();
                                _specGrades[specKey] = grades;
                                Debug.WriteLine($"New spec-grade mapping created: {specKey}");
                            }

                            if (!string.IsNullOrEmpty(grade))
                            {
                                if (!grades.Any(g => string.Equals(g, grade, StringComparison.OrdinalIgnoreCase)))
                                {
                                    grades.Add(grade);
                                    Debug.WriteLine($"Added grade {grade} to {specKey}");
                                }
                            }
                            else
                            {
                                Debug.WriteLine($"Empty grade for {specKey} at line {lineNumber}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error processing line {lineNumber}: {ex.Message}");
                        }
                    }
                }

                // Sort all collections
                foreach (var material in _materialSpecs.Keys.ToList())
                {
                    _materialSpecs[material] = _materialSpecs[material]
                        .OrderBy(s => s)
                        .ToList();
                }

                foreach (var specKey in _specGrades.Keys.ToList())
                {
                    _specGrades[specKey] = _specGrades[specKey]
                        .OrderBy(g => g)
                        .ToList();
                }

                // Verify loaded data
                Debug.WriteLine("=== MATERIAL DATA SUMMARY ===");
                Debug.WriteLine($"Total materials: {_materialData.Count}");
                Debug.WriteLine($"Material-Spec mappings: {_materialSpecs.Count}");
                Debug.WriteLine($"Spec-Grade mappings: {_specGrades.Count}");

                // Sample some data for verification
                foreach (var material in _materialSpecs.Keys.Take(5))
                {
                    Debug.WriteLine($"Material: {material}");
                    foreach (var spec in _materialSpecs[material].Take(3))
                    {
                        string key = $"{material}|{spec}";
                        if (_specGrades.TryGetValue(key, out var grades))
                        {
                            Debug.WriteLine($"  Spec: {spec} (Grades: {string.Join(", ", grades)})");
                        }
                        else
                        {
                            Debug.WriteLine($"  Spec: {spec} (No grades)");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CRITICAL ERROR LOADING MATERIAL DATA: {ex.ToString()}");
                MessageBox.Show($"Error loading material data: {ex.Message}\n\nCheck debug output for details.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double TryParseMinTemp(string minTempText)
        {
            if (string.IsNullOrWhiteSpace(minTempText))
                return -459.67;

            var match = Regex.Match(minTempText, @"-?\d+");
            return match.Success && double.TryParse(match.Value, out double result) ? result : -459.67;
        }

        private double ParseDouble(string value, double defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value)) return defaultValue;
            return double.TryParse(value.Trim(), out double result) ? result : defaultValue;
        }

        private void InitializeMaterialDropdown()
        {
            var materials = _materialData
                .Select(m => m.Material)
                .Distinct()
                .OrderBy(m => m)
                .ToList();

            cmbMaterial.DataSource = materials;
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void WireUpEvents()
        {
            cmbMaterial.SelectedIndexChanged += CmbMaterial_SelectedIndexChanged;
            cmbSpec.SelectedIndexChanged += CmbSpec_SelectedIndexChanged;
            cmbGrade.SelectedIndexChanged += CmbGrade_SelectedIndexChanged;
            cmbNPS.SelectedIndexChanged += CmbNPS_SelectedIndexChanged;
            cmbQualityFactor.SelectedIndexChanged += CmbQualityFactor_SelectedIndexChanged;
            txtTemperature.TextChanged += TxtTemperature_TextChanged;
            txtPressure.TextChanged += TxtPressure_TextChanged;
            txtWeldJointFactor.Validating += TxtWeldJointFactor_Validating;
            txtTemperature.Validating += ValidateNumericInput;
            txtPressure.Validating += ValidateNumericInput;
            txtYCoefficient.Validating += ValidateNumericInput;
            btnCalculate.Click += BtnCalculate_Click;
            btnReset.Click += BtnReset_Click;
        }

        private void InitializeDefaultValues()
        {
            _isInitializing = true;
            try
            {
                cmbMaterial.SelectedItem = "Carbon Steel - Pipes and Tubes";
                Application.DoEvents(); // Allow the selection to process

                cmbSpec.SelectedItem = "A106";
                Application.DoEvents();

                cmbGrade.SelectedItem = "B";
                cmbNPS.SelectedItem = _npsToOd.FirstOrDefault(x => x.Key == "2");
                txtTemperature.Text = "500";
                txtPressure.Text = "200";
                txtYCoefficient.Text = "0.4";
                txtWeldJointFactor.Text = "1.00";
            }
            finally
            {
                _isInitializing = false;
            }
        }

        private void CmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing || cmbMaterial.SelectedItem == null)
                return;

            string selectedMaterial = cmbMaterial.SelectedItem.ToString();

            // Temporarily suspend the Spec SelectedIndexChanged event
            cmbSpec.SelectedIndexChanged -= CmbSpec_SelectedIndexChanged;

            try
            {
                if (_materialSpecs.TryGetValue(selectedMaterial, out List<string> specs))
                {
                    cmbSpec.DataSource = specs.OrderBy(s => s).ToList();
                    cmbSpec.Enabled = true;

                    // Try to maintain the previous spec selection if possible
                    if (!string.IsNullOrEmpty(_pendingGradeSelection))
                    {
                        var matchingSpec = _materialSpecs[selectedMaterial]
                            .FirstOrDefault(s => _specGrades.ContainsKey($"{selectedMaterial}|{s}") &&
                                               _specGrades[$"{selectedMaterial}|{s}"].Contains(_pendingGradeSelection));

                        if (matchingSpec != null)
                        {
                            cmbSpec.SelectedItem = matchingSpec;
                        }
                        else if (specs.Count > 0)
                        {
                            cmbSpec.SelectedIndex = 0;
                        }
                    }
                    else if (specs.Count > 0)
                    {
                        cmbSpec.SelectedIndex = 0;
                    }
                }
                else
                {
                    cmbSpec.DataSource = new List<string>();
                    cmbSpec.Enabled = false;
                }

                // Clear grade dropdown
                cmbGrade.DataSource = new List<string>();
                cmbGrade.Enabled = false;
            }
            finally
            {
                cmbSpec.SelectedIndexChanged += CmbSpec_SelectedIndexChanged;
                // Manually trigger the event to load grades for the new spec
                if (cmbSpec.SelectedItem != null)
                {
                    CmbSpec_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }

            UpdateStressValue();
        }

        private void CmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing || cmbMaterial.SelectedItem == null || cmbSpec.SelectedItem == null)
                return;

            string material = cmbMaterial.SelectedItem.ToString();
            string spec = cmbSpec.SelectedItem.ToString();
            string specKey = $"{material}|{spec}";

            Debug.WriteLine($"Loading grades for: {specKey}");

            // Temporarily disable the grade event
            cmbGrade.SelectedIndexChanged -= CmbGrade_SelectedIndexChanged;

            try
            {
                if (_specGrades.TryGetValue(specKey, out List<string> grades))
                {
                    Debug.WriteLine($"Found {grades.Count} grades for {specKey}");

                    var distinctGrades = grades
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .OrderBy(g => g)
                        .ToList();

                    cmbGrade.DataSource = distinctGrades;
                    cmbGrade.Enabled = true;

                    // Try to restore previous selection
                    if (!string.IsNullOrEmpty(_pendingGradeSelection))
                    {
                        var match = distinctGrades.FirstOrDefault(g =>
                            g.Equals(_pendingGradeSelection, StringComparison.OrdinalIgnoreCase));

                        if (match != null)
                        {
                            cmbGrade.SelectedItem = match;
                            Debug.WriteLine($"Restored grade selection: {match}");
                        }
                        else if (distinctGrades.Count > 0)
                        {
                            cmbGrade.SelectedIndex = 0;
                            Debug.WriteLine("No matching grade found, selected first item");
                        }
                    }
                    else if (distinctGrades.Count > 0)
                    {
                        cmbGrade.SelectedIndex = 0;
                        Debug.WriteLine("No pending grade, selected first item");
                    }
                }
                else
                {
                    Debug.WriteLine($"No grades found for {specKey}");
                    cmbGrade.DataSource = new List<string>();
                    cmbGrade.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading grades: {ex.Message}");
            }
            finally
            {
                cmbGrade.SelectedIndexChanged += CmbGrade_SelectedIndexChanged;
                // Manually trigger the event to update stress value and quality factor
                if (cmbGrade.SelectedItem != null)
                {
                    CmbGrade_SelectedIndexChanged(this, EventArgs.Empty);
                }
            }

            UpdateStressValue();
            UpdateQualityFactorOptions();
        }

        private void CmbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing || cmbGrade.SelectedItem == null)
                return;

            // Store the selected grade for potential restoration
            _pendingGradeSelection = cmbGrade.SelectedItem.ToString();

            UpdateStressValue();
            UpdateQualityFactorOptions();
        }

        private void CmbNPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNPS.SelectedItem != null)
            {
                KeyValuePair<string, double> selectedNPS = (KeyValuePair<string, double>)cmbNPS.SelectedItem;
                txtOuterDiameter.Text = selectedNPS.Value.ToString("F3");
                UpdateCurrentNPSThickness();
            }
        }

        private void CmbQualityFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEFactorTooltip();
            UpdateCurrentNPSThickness();
        }

        private void TxtTemperature_TextChanged(object sender, EventArgs e)
        {
            UpdateStressValue();
            UpdateYCoefficient();
        }

        private void TxtPressure_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentNPSThickness();
        }

        private void UpdateQualityFactorOptions()
        {
            if (cmbSpec.SelectedItem == null || cmbMaterial.SelectedItem == null) return;

            string selectedSpec = cmbSpec.SelectedItem.ToString();
            string selectedMaterial = cmbMaterial.SelectedItem.ToString();
            string selectedGrade = cmbGrade.SelectedItem?.ToString() ?? "";

            var availableFactors = _eFactorData
                .Where(x => (x.SpecNo.Equals("All Specs", StringComparison.OrdinalIgnoreCase) ||
                             x.SpecNo.Equals(selectedSpec, StringComparison.OrdinalIgnoreCase)) &&
                            (x.Material.Equals("All Materials", StringComparison.OrdinalIgnoreCase) ||
                             x.Material.Equals(selectedMaterial, StringComparison.OrdinalIgnoreCase)) &&
                            (string.IsNullOrEmpty(x.TypeGrade) ||
                             x.TypeGrade.Equals(selectedGrade, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(x => x.EFactor)
                .ToList();

            cmbQualityFactor.DataSource = availableFactors;
            if (availableFactors.Count > 0)
                cmbQualityFactor.SelectedIndex = 0;
        }

        private void UpdateEFactorTooltip()
        {
            if (cmbQualityFactor.SelectedItem is EFactorData selectedFactor)
            {
                toolTip1.SetToolTip(cmbQualityFactor,
                    $"E = {selectedFactor.EFactor}\nSpec: {selectedFactor.SpecNo}\n{selectedFactor.Notes}");
            }
        }

        private void UpdateStressValue()
        {
            txtStressValue.Text = string.Empty;
            currentStressValuePsi = 0;

            if (cmbMaterial.SelectedItem == null ||
                cmbSpec.SelectedItem == null ||
                cmbGrade.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtTemperature.Text))
            {
                return;
            }

            if (!double.TryParse(txtTemperature.Text, out double temperature))
            {
                txtStressValue.Text = "Invalid temperature";
                return;
            }

            string material = cmbMaterial.SelectedItem.ToString();
            string spec = cmbSpec.SelectedItem.ToString();
            string grade = cmbGrade.SelectedItem.ToString();

            try
            {
                var materialPoints = _materialData
                    .Where(m => m.Material.Equals(material, StringComparison.OrdinalIgnoreCase) &&
                                 m.Spec.Equals(spec, StringComparison.OrdinalIgnoreCase) &&
                                 m.Grade.Equals(grade, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(m => m.Temperature)
                    .ToList();

                if (!materialPoints.Any())
                {
                    txtStressValue.Text = "No data for selected material";
                    return;
                }

                double minTemp = materialPoints.First().MinTemp;
                if (temperature < minTemp)
                {
                    txtStressValue.Text = $"Below min temp ({minTemp}°F)";
                    return;
                }

                var lower = materialPoints.LastOrDefault(m => m.Temperature <= temperature);
                var higher = materialPoints.FirstOrDefault(m => m.Temperature >= temperature);

                double stressValueKsi = 0;

                if (lower == null && higher == null)
                {
                    txtStressValue.Text = "No data for temperature";
                    return;
                }
                else if (lower != null && higher != null)
                {
                    if (lower.Temperature == higher.Temperature)
                    {
                        stressValueKsi = lower.StressValue;
                    }
                    else
                    {
                        stressValueKsi = LinearInterpolate(
                            lower.Temperature, lower.StressValue,
                            higher.Temperature, higher.StressValue,
                            temperature);
                    }
                }
                else if (lower != null)
                {
                    stressValueKsi = lower.StressValue;
                }
                else
                {
                    stressValueKsi = higher.StressValue;
                }

                currentStressValuePsi = stressValueKsi * 1000;
                txtStressValue.Text = currentStressValuePsi.ToString("F0");
            }
            catch (Exception ex)
            {
                txtStressValue.Text = "Error calculating stress";
                Debug.WriteLine($"Error calculating stress value: {ex.Message}");
            }
        }

        private double GetSelectedYCoefficient()
        {
            if (double.TryParse(txtYCoefficient.Text, out double yValue) && yValue >= 0 && yValue <= 0.7)
            {
                return yValue;
            }
            return 0.4;
        }

        private void TxtWeldJointFactor_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtWeldJointFactor.Text, out double result) || result <= 0 || result > 1)
            {
                MessageBox.Show("Weld Joint Factor must be between 0 and 1", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeldJointFactor.Text = "1.00";
                txtWeldJointFactor.SelectAll();
                e.Cancel = true;
            }
        }

        private void ValidateNumericInput(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                if (!double.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    textBox.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                double pressure = double.Parse(txtPressure.Text);
                double qualityFactor = ((EFactorData)cmbQualityFactor.SelectedItem).EFactor;
                double weldJointFactor = double.Parse(txtWeldJointFactor.Text);
                double yCoefficient = GetSelectedYCoefficient();

                dgvResults.Rows.Clear();

                foreach (var npsItem in _npsToOd)
                {
                    double outerDiameter = npsItem.Value;
                    double denominator = 2 * (currentStressValuePsi * qualityFactor * weldJointFactor + pressure * yCoefficient);
                    double minThicknessB313 = (pressure * outerDiameter) / denominator;
                    double minThicknessBarlow = (pressure * outerDiameter) / (2 * currentStressValuePsi);

                    dgvResults.Rows.Add(
                        npsItem.Key,
                        outerDiameter.ToString("F3"),
                        minThicknessB313.ToString("F4"),
                        minThicknessBarlow.ToString("F4")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Calculation error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCurrentNPSThickness()
        {
            try
            {
                // Check if NPS is selected
                if (cmbNPS.SelectedItem == null)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    return;
                }

                // Get selected NPS
                var selectedNPS = cmbNPS.SelectedItem as KeyValuePair<string, double>?;
                if (!selectedNPS.HasValue)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    return;
                }

                double outerDiameter = selectedNPS.Value.Value;

                // Check pressure input
                if (!double.TryParse(txtPressure.Text, out double pressure) || pressure <= 0)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    return;
                }

                // Check quality factor selection
                if (cmbQualityFactor.SelectedItem == null || !(cmbQualityFactor.SelectedItem is EFactorData))
                {
                    txtMinThicknessResult.Text = string.Empty;
                    return;
                }

                double qualityFactor = ((EFactorData)cmbQualityFactor.SelectedItem).EFactor;

                // Check weld joint factor
                if (!double.TryParse(txtWeldJointFactor.Text, out double weldJointFactor) || weldJointFactor <= 0)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    return;
                }

                double yCoefficient = GetSelectedYCoefficient();

                // Validate calculation parameters
                if (currentStressValuePsi <= 0)
                {
                    txtMinThicknessResult.Text = "Invalid stress";
                    return;
                }

                double denominator = 2 * (currentStressValuePsi * qualityFactor * weldJointFactor + pressure * yCoefficient);

                if (denominator <= 0)
                {
                    txtMinThicknessResult.Text = "Invalid params";
                    return;
                }

                double minThicknessB313 = (pressure * outerDiameter) / denominator;
                txtMinThicknessResult.Text = Math.Round(minThicknessB313, 4).ToString();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in UpdateCurrentNPSThickness: {ex.Message}");
                txtMinThicknessResult.Text = "Error";
            }
        }

        private void UpdateYCoefficient()
        {
            if (cmbMaterial.SelectedItem == null || string.IsNullOrEmpty(txtTemperature.Text))
                return;

            if (!double.TryParse(txtTemperature.Text, out double temperature))
            {
                txtYCoefficient.Text = "0.4";
                return;
            }

            string material = cmbMaterial.SelectedItem.ToString();
            string category = MaterialClassifier.GetMaterialCategory(material);
            double yValue = GetInterpolatedYValue(category, temperature);
            txtYCoefficient.Text = yValue.ToString("F1");
        }

        private double GetInterpolatedYValue(string category, double temperature)
        {
            var ferriticPoints = new Dictionary<double, double>
            {
                { 900, 0.4 },
                { 950, 0.5 },
                { double.MaxValue, 0.7 }
            };

            var austeniticPoints = new Dictionary<double, double>
            {
                { 1050, 0.4 },
                { 1100, 0.5 },
                { double.MaxValue, 0.7 }
            };

            var nickelPoints = new Dictionary<double, double>
            {
                { 1150, 0.4 },
                { 1200, 0.5 },
                { double.MaxValue, 0.7 }
            };

            switch (category)
            {
                case "Gray iron": return 0.0;
                case "Ferritic": return InterpolateYValue(temperature, ferriticPoints);
                case "Austenitic": return InterpolateYValue(temperature, austeniticPoints);
                case "Nickel alloy": return InterpolateYValue(temperature, nickelPoints);
                default: return 0.4;
            }
        }

        private double InterpolateYValue(double temperature, Dictionary<double, double> breakpoints)
        {
            double lowerTemp = 0;
            double upperTemp = 0;
            double lowerY = 0.4;
            double upperY = 0.4;

            foreach (var point in breakpoints.OrderBy(p => p.Key))
            {
                if (temperature <= point.Key)
                {
                    upperTemp = point.Key;
                    upperY = point.Value;
                    break;
                }
                lowerTemp = point.Key;
                lowerY = point.Value;
            }

            if (temperature <= breakpoints.First().Key)
                return breakpoints.First().Value;

            if (temperature > breakpoints.Last().Key)
                return breakpoints.Last().Value;

            return lowerY + (upperY - lowerY) * (temperature - lowerTemp) / (upperTemp - lowerTemp);
        }

        private double LinearInterpolate(double x0, double y0, double x1, double y1, double x)
        {
            if (x0 == x1) return y0;
            return y0 + (y1 - y0) * (x - x0) / (x1 - x0);
        }

        private bool ValidateInputs()
        {
            if (cmbMaterial.SelectedItem == null || cmbSpec.SelectedItem == null || cmbGrade.SelectedItem == null)
            {
                MessageBox.Show("Please select material, specification and grade", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtWeldJointFactor.Text, out double wFactor) || wFactor <= 0 || wFactor > 1)
            {
                MessageBox.Show("Weld Joint Factor must be between 0 and 1", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeldJointFactor.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTemperature.Text))
            {
                MessageBox.Show("Please enter a design temperature in °F.", "Temperature Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemperature.Focus();
                return false;
            }

            if (!double.TryParse(txtTemperature.Text, out double temp) || temp < -459.67)
            {
                MessageBox.Show("Please enter a valid temperature in °F.", "Invalid Temperature",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTemperature.SelectAll();
                txtTemperature.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPressure.Text))
            {
                MessageBox.Show("Please enter a design pressure in psi.", "Pressure Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPressure.Focus();
                return false;
            }

            if (!double.TryParse(txtPressure.Text, out double pressure) || pressure <= 0)
            {
                MessageBox.Show("Please enter a valid pressure in psi.", "Invalid Pressure",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPressure.SelectAll();
                txtPressure.Focus();
                return false;
            }

            if (currentStressValuePsi <= 0)
            {
                MessageBox.Show("Invalid stress value. Please check material/temperature inputs.",
                    "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            InitializeDefaultValues();
            dgvResults.Rows.Clear();
            txtStressValue.Text = "";
        }

        public class MaterialData
        {
            public string Material { get; set; }
            public string Spec { get; set; }
            public string Grade { get; set; }
            public double Temperature { get; set; }
            public double StressValue { get; set; }
            public double MinTemp { get; set; }
            public double Tensile { get; set; }
            public double Yield { get; set; }
        }

        public class EFactorData
        {
            public string Material { get; }
            public string SpecNo { get; }
            public string TypeGrade { get; }
            public string Description { get; }
            public double EFactor { get; }
            public string Notes { get; }

            public EFactorData(string material, string specNo, string typeGrade,
                string description, double eFactor, string notes)
            {
                Material = material;
                SpecNo = specNo;
                TypeGrade = typeGrade;
                Description = description;
                EFactor = eFactor;
                Notes = notes;
            }

            public override string ToString() => Description;
        }

        public static class MaterialClassifier
        {
            public static string GetMaterialCategory(string material)
            {
                if (string.IsNullOrWhiteSpace(material))
                    return "Other ductile metal";

                string baseMaterial = material.Split('-')[0].Trim();

                if (baseMaterial.Equals("Gray iron", StringComparison.OrdinalIgnoreCase))
                    return "Gray iron";

                if (baseMaterial.Equals("Carbon Steel", StringComparison.OrdinalIgnoreCase) ||
                    baseMaterial.Equals("Low and Intermediate Alloy Steel", StringComparison.OrdinalIgnoreCase))
                    return "Ferritic";

                if (baseMaterial.Equals("Stainless Steel", StringComparison.OrdinalIgnoreCase))
                    return "Austenitic";

                if (baseMaterial.Equals("Nickel Alloy", StringComparison.OrdinalIgnoreCase) ||
                    baseMaterial.Contains("N06617") ||
                    baseMaterial.Contains("N08800") ||
                    baseMaterial.Contains("N08810") ||
                    baseMaterial.Contains("N08825"))
                    return "Nickel alloy";

                return "Other ductile metal";
            }
        }
    }
}
