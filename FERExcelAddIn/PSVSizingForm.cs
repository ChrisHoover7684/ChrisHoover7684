using OfficeOpenXml.Packaging.Ionic.Zlib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static FERExcelAddIn.PSVSizingForm;
using Excel = Microsoft.Office.Interop.Excel;

namespace FERExcelAddIn
{
    public partial class PSVSizingForm : Form
    {
        // Constants
        private const double GAS_CONVERSION_FACTOR = 0.17256;
        private const double STANDARD_ATM_PRESSURE = 14.7;
        private const double FIRE_CALCULATION_FACTOR = 21000;

        // Added missing type definitions
        public enum VesselType { HorizontalCylindrical, VerticalWithHeads, Spherical }

        public class VesselGeometry
        {
            public VesselType Type { get; set; }
            public double Diameter { get; set; }
            public double Length { get; set; }
            public double Height { get; set; }
        }

        public class TwoPhaseResult
        {
            public double OmegaParameter { get; set; }
            public bool IsFlashingFlow { get; set; }
            public double ReliefArea { get; set; }
        }

        public class PressureDropResult
        {
            public double PressureDrop { get; set; }
            public bool IsAcceptable { get; set; }
        }

        public PSVSizingForm()
        {
            InitializeComponent();
            InitializeComponentDefaults();
            SetupScenarios();
            WireUpEvents();
            InitializeMaterialDatabase();
            InitializeStaggeredPsvGrid();

            // Add columns to the staggered PSVs grid
            //staggeredPsvsDataGridView.Columns.Add("SetPressure", "Set Pressure (psig)");
            this.psvConfigGroupBox.Controls.Add(this.staggeredPsvsDataGridView);

            //this.inputGroupBox.Controls.Add(this.lblOperatingPressure);
           // this.inputGroupBox.Controls.Add(this.operatingPressureInput);

            this.lblOperatingPressure.AutoSize = true;
            this.lblOperatingPressure.Location = new System.Drawing.Point(20, 350);
            this.lblOperatingPressure.Name = "lblOperatingPressure";
            this.lblOperatingPressure.Size = new System.Drawing.Size(180, 20);
            this.lblOperatingPressure.TabIndex = 16;
            this.lblOperatingPressure.Text = "Operating Pressure (psig):";

            this.operatingPressureInput.Location = new System.Drawing.Point(274, 352);
            this.operatingPressureInput.Name = "operatingPressureInput";
            this.operatingPressureInput.Size = new System.Drawing.Size(100, 26);
            this.operatingPressureInput.TabIndex = 17;
            this.operatingPressureInput.Text = "80";
        }

        private void InitializeMaterialDatabase()
        {
            // Populate fluid type combo box
            fluidTypeCombo.Items.Clear();
            fluidTypeCombo.Items.AddRange(MaterialDatabase.Materials.Keys.ToArray());
            fluidTypeCombo.SelectedIndex = 0; // Select first item
        }

        private void InitializeComponentDefaults()
        {
            // Fluid type setup
            cmbAccumulation.SelectedIndex = 0;

            // Default values
            fluidTypeCombo.SelectedIndex = 0;
            pressureInput.Text = "100";
            temperatureInput.Text = "60";
            flowRateInput.Text = "500";
            molecularWeightInput.Text = "28.97";
            specificHeatRatioInput.Text = "1.4";
            compressibilityInput.Text = "1.0";
            viscosityInput.Text = "1.0";
            specificGravityInput.Text = "1.0";
            vesselDiameterInput.Text = "10";
            vesselLengthInput.Text = "20";
            txtMAWP.Text = "150";
            txtDesignTemp.Text = "300";
            txtFillLevel.Text = "100";

            // Set initial visibility
            UpdateScenarioSpecificFields();
        }
        private void WireUpEvents()
        {
            // Existing event wiring...
            fluidTypeCombo.SelectedIndexChanged += FluidTypeCombo_SelectedIndexChanged;
            btnCalculate.Click += CalculateAllScenarios;
            btnExcelExport.Click += InsertToExcelButton_Click;

            // Radio button events
            radSinglePSV.CheckedChanged += PSVConfig_CheckedChanged;
            radMultiplePSV.CheckedChanged += PSVConfig_CheckedChanged;
            chkFireCase.CheckedChanged += PSVConfig_CheckedChanged;

            // Auto-calculate event handlers
            chkHorizontalVessel.CheckedChanged += VesselParameter_Changed;
            chkInsulated.CheckedChanged += VesselParameter_Changed;
            chkWaterSpray.CheckedChanged += VesselParameter_Changed;
            chkUnderground.CheckedChanged += VesselParameter_Changed;

            // Text changed events for auto-calculate
            txtMAWP.TextChanged += VesselParameter_Changed;
            txtDesignTemp.TextChanged += VesselParameter_Changed;
            txtFillLevel.TextChanged += VesselParameter_Changed;
            cmbAccumulation.SelectedIndexChanged += VesselParameter_Changed;

            // Scenario checkboxes
            chkBlockedOutlet.CheckedChanged += ScenarioCheckbox_Changed;
            chkExternalFire.CheckedChanged += chkExternalFire_CheckedChanged;
            chkCoolingFailure.CheckedChanged += ScenarioCheckbox_Changed;
            chkTubeRupture.CheckedChanged += ScenarioCheckbox_Changed;
            chkChemicalReaction.CheckedChanged += ScenarioCheckbox_Changed;
            chkThermalExpansion.CheckedChanged += ScenarioCheckbox_Changed;
            chkControlValveFailure.CheckedChanged += ScenarioCheckbox_Changed;
            chkPowerFailure.CheckedChanged += ScenarioCheckbox_Changed;
            chkHydraulicHammer.CheckedChanged += ScenarioCheckbox_Changed;
            chkRefluxFailure.CheckedChanged += ScenarioCheckbox_Changed;
            chkCompressorFailure.CheckedChanged += ScenarioCheckbox_Changed;
        }
        private void SetupScenarios()
        {
            chkBlockedOutlet.Checked = true;

            // Only set if items exist
            if (cmbAccumulation.Items.Count > 0)
            {
                cmbAccumulation.SelectedIndex = 0;
            }
            else
            {
                // Either initialize here or log a warning
                cmbAccumulation.Items.AddRange(new object[] { "10%", "16%", "21%" });
                cmbAccumulation.SelectedIndex = 0;
            }
        }
        private void PSVConfig_CheckedChanged(object sender, EventArgs e)
        {
            // Radio buttons are mutually exclusive by default, so we just need to update settings
            UpdateAccumulationSettings();

            if (radMultiplePSV.Checked || chkFireCase.Checked)
            {
                staggeredPsvsDataGridView.Visible = true;
                PopulateStaggeredPsvsGrid();
            }
            else
            {
                staggeredPsvsDataGridView.Visible = false;
            }

            // Optional: Auto-calculate if enabled
            if (autoCalculateCheckBox.Checked && ValidateInputs(silent: true))
            {
                CalculateAllScenarios(null, EventArgs.Empty);
            }
        }

        private void CheckForPilotValve()
        {
            double operatingPressure = double.Parse(operatingPressureInput.Text);
            double mawp = double.Parse(txtMAWP.Text);

            if (operatingPressure > mawp * 0.9)
            {
                MessageBox.Show("Operating pressure is greater than 90% of MAWP. A pilot-operated valve is recommended.", "Pilot Valve Recommendation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void InitializeStaggeredPsvGrid()
        {
            staggeredPsvsDataGridView.Columns.Clear();

            staggeredPsvsDataGridView.Columns.Add("SetPressure", "Set Pressure (psig)");
            staggeredPsvsDataGridView.Columns.Add("Accumulation", "Accumulation (%)");
            staggeredPsvsDataGridView.Columns.Add("RelievingPressure", "Relieving Pressure (psig)");
            staggeredPsvsDataGridView.Columns.Add("Status", "Status");

            // Format columns
            foreach (DataGridViewColumn col in staggeredPsvsDataGridView.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                if (col.Name == "Status")
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void PopulateStaggeredPsvsGrid()
        {
            staggeredPsvsDataGridView.Rows.Clear();
            double mawp = double.Parse(txtMAWP.Text);

            if (chkFireCase.Checked)
            {
                // Fire case - all valves get 21% accumulation
                AddPsvRow(mawp * 1.00, 0.10, "Primary");
                AddPsvRow(mawp * 1.05, 0.16, "Supplemental");
                AddPsvRow(mawp * 1.10, 0.21, "Standby");
            }
            else if (radMultiplePSV.Checked)
            {
                // Multiple PSVs - Primary gets 10%, Supplemental gets 16%
                AddPsvRow(mawp * 1.00, 0.10, "Primary");
                AddPsvRow(mawp * 1.05, 0.16, "Supplemental");
            }
            else // Single PSV
            {
                AddPsvRow(mawp * 1.00, 0.10, "Primary");
            }
        }

        private void AddPsvRowWithDetails(double setPressure, double accumulation, string status)
{
    staggeredPsvsDataGridView.Rows.Add(
        setPressure.ToString("F2"),
        (accumulation * 100).ToString("F0") + "%",
        (setPressure * (1 + accumulation)).ToString("F2"),
        status
    );
}
        private void AddPsvRow(double setPressure, double accumulation, string status)
        {
            int rowIdx = staggeredPsvsDataGridView.Rows.Add(
                setPressure.ToString("F2"),
                (accumulation * 100).ToString("F0") + "%",
                (setPressure * (1 + accumulation)).ToString("F2"),
                status
            );


        }




        private double GetCorrectionFactorFromChart(int overpressurePercent)
        {
            // Implement logic to get the correction factor from your chart/data
            // This is a placeholder - replace with actual lookup logic
            switch (overpressurePercent)
            {
                case 10: return 0.9; // Example value
                case 16: return 0.85; // Example value
                case 21: return 1.0; // As per note in the standard
                default: return 1.0;
            }
        }

        private bool IsLowSetValve()
        {
            // Implement logic to determine if this is the low set valve in a multiple PSV installation
            // This might depend on other parameters in your form
            return true; // Simplified for example
        }
        private void UpdateAccumulationSettings()
        {
            if (chkFireCase.Checked)
            {
                cmbAccumulation.SelectedIndex = 2; // 21% for fire case
            }
            else if (radMultiplePSV.Checked)  // Changed from chkMultiplePSV
            {
                cmbAccumulation.SelectedIndex = 1; // 16% for multiple PSVs
            }
            else
            {
                cmbAccumulation.SelectedIndex = 0; // 10% for single PSV
            }
        }

        private double GetBackpressureCorrectionFactor()
        {
            // Default correction factor
            double correctionFactor = 1.0;

            if (chkFireCase.Checked)
            {
                // For fire case, use 10% overpressure correction factor
                correctionFactor = GetCorrectionFactorFromChart(10);
            }
            else if (radMultiplePSV.Checked)  // Changed from chkMultiplePSV
            {
                // For multiple PSVs, low set valve uses 16%, high set uses 10%
                if (IsLowSetValve())
                {
                    correctionFactor = GetCorrectionFactorFromChart(16);
                }
                else
                {
                    correctionFactor = GetCorrectionFactorFromChart(10);
                }
            }
            else // Single PSV
            {
                correctionFactor = GetCorrectionFactorFromChart(10);
            }

            return correctionFactor;
        }
        private void ScenarioCheckbox_Changed(object sender, EventArgs e)
        {
            UpdateScenarioSpecificFields();

            // Optional: Auto-calculate if enabled
            if (autoCalculateCheckBox.Checked && ValidateInputs(silent: true))
            {
                CalculateAllScenarios(null, EventArgs.Empty);
            }
        }


        private void VesselParameter_Changed(object sender, EventArgs e)
        {
            if (autoCalculateCheckBox.Checked && ValidateInputs(silent: true))
            {
                CalculateAllScenarios(null, EventArgs.Empty);
            }
        }
        private void SaveCustomMaterial()
        {
            var props = new MaterialDatabase.MaterialProperties
            {
                Type = fluidTypeCombo.Text.Contains("Gas") ? Phase.Gas :
                      fluidTypeCombo.Text.Contains("Liquid") ? Phase.Liquid :
                      Phase.TwoPhase,
                MolecularWeight = double.Parse(molecularWeightInput.Text),
                SpecificHeatRatio = double.Parse(specificHeatRatioInput.Text),
                Compressibility = double.Parse(compressibilityInput.Text),
                Viscosity = double.Parse(viscosityInput.Text),
                SpecificGravity = double.Parse(specificGravityInput.Text)
            };

            MaterialDatabase.Materials.Add("Custom " + fluidTypeCombo.Text, props);
            MessageBox.Show("Custom material saved!");
        }
        private void FluidTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fluidTypeCombo.SelectedItem == null) return;

            string selectedMaterial = fluidTypeCombo.SelectedItem.ToString();

            // Get material properties from database
            if (MaterialDatabase.Materials.TryGetValue(selectedMaterial, out var props))
            {
                // Update input fields with material properties
                molecularWeightInput.Text = props.MolecularWeight.ToString("F2");

                // Set phase-specific properties
                switch (props.Type)
                {
                    case Phase.Gas:
                        specificHeatRatioInput.Text = props.SpecificHeatRatio.ToString("F3");
                        compressibilityInput.Text = props.Compressibility.ToString("F2");
                        specificGravityInput.Text = props.SpecificGravity.ToString("F3");
                        break;

                    case Phase.Liquid:
                        specificGravityInput.Text = props.SpecificGravityLiquid.ToString("F3");
                        viscosityInput.Text = props.Viscosity.ToString("F4");
                        break;

                    case Phase.TwoPhase:
                        specificHeatRatioInput.Text = props.SpecificHeatRatio.ToString("F3");
                        compressibilityInput.Text = props.Compressibility.ToString("F2");
                        specificGravityInput.Text = props.SpecificGravityVapor.ToString("F3");
                        viscosityInput.Text = props.Viscosity.ToString("F4");
                        break;
                }

                // Update temperature if available
                if (props.DefaultTemperature != 0)
                {
                    temperatureInput.Text = props.DefaultTemperature.ToString();
                }

                // Update visibility of fields
                UpdateInputFieldsVisibility();
            }
        }
        private void chkExternalFire_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExternalFire.Checked)
            {
                chkFireCase.Checked = true; // Auto-enable fire case design
                cmbAccumulation.SelectedIndex = 2; // Force 21% accumulation
            }
            UpdateScenarioSpecificFields();
        }

        private void chkFireCase_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkFireCase.Checked && chkExternalFire.Checked)
            {
                // Warn user if they're disabling fire case while external fire is selected
                if (MessageBox.Show("Disabling Fire Case will also disable External Fire scenario. Continue?",
                                  "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    chkExternalFire.Checked = false;
                }
                else
                {
                    chkFireCase.Checked = true;
                }
            }
        }


        private void UpdateInputFieldsVisibility()
        {
            if (fluidTypeCombo.SelectedItem == null) return;

            string selectedMaterial = fluidTypeCombo.SelectedItem.ToString();

            // Get material properties from database
            if (MaterialDatabase.Materials.TryGetValue(selectedMaterial, out var props))
            {
                // Set visibility based on phase
                switch (props.Type)
                {
                    case Phase.Gas:
                        // Gas phase - show gas-specific fields
                        molecularWeightInput.Visible = true;
                        lblMolecularWeight.Visible = true;
                        specificHeatRatioInput.Visible = true;
                        lblSpecificHeatRatio.Visible = true;
                        compressibilityInput.Visible = true;
                        lblCompressibility.Visible = true;
                        viscosityInput.Visible = false;
                        lblViscosity.Visible = false;
                        specificGravityInput.Visible = true;
                        lblSpecificGravity.Visible = true;
                        break;

                    case Phase.Liquid:
                        // Liquid phase - show liquid-specific fields
                        molecularWeightInput.Visible = false;
                        lblMolecularWeight.Visible = false;
                        specificHeatRatioInput.Visible = false;
                        lblSpecificHeatRatio.Visible = false;
                        compressibilityInput.Visible = false;
                        lblCompressibility.Visible = false;
                        viscosityInput.Visible = true;
                        lblViscosity.Visible = true;
                        specificGravityInput.Visible = true;
                        lblSpecificGravity.Visible = true;
                        break;

                    case Phase.TwoPhase:
                        // Two-phase - show combination of fields
                        molecularWeightInput.Visible = true;
                        lblMolecularWeight.Visible = true;
                        specificHeatRatioInput.Visible = true;
                        lblSpecificHeatRatio.Visible = true;
                        compressibilityInput.Visible = true;
                        lblCompressibility.Visible = true;
                        viscosityInput.Visible = true;
                        lblViscosity.Visible = true;
                        specificGravityInput.Visible = true;
                        lblSpecificGravity.Visible = true;
                        break;
                }

                // Update flow rate units based on phase
                UpdateFlowRateUnits(selectedMaterial, props.Type);
            }
        }
        private void UpdateFlowRateUnits(string fluidName, Phase phase)
        {
            string newUnit;
            switch (phase)
            {
                case Phase.Gas:
                    newUnit = "SCFM";
                    break;
                case Phase.Liquid:
                    newUnit = "gpm";
                    break;
                case Phase.TwoPhase:
                    newUnit = "lb/hr";
                    break;
                default:
                    newUnit = "lb/hr";
                    break;
            }

            // Update the label text
            lblFlowRate.Text = $"Flow Rate ({newUnit}):";
        }
        private void CalculateAllScenarios(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            CheckForPilotValve();

            resultsDataGridView.Rows.Clear();
            var scenarios = GetSelectedScenarios();

            if (scenarios.Count == 0)
            {
                MessageBox.Show("Please select at least one scenario.");
                return;
            }

            // Get common parameters once
            double temperature = double.Parse(temperatureInput.Text);
            double flowRate = double.Parse(flowRateInput.Text);
            string selectedMaterial = fluidTypeCombo.SelectedItem.ToString();
            MaterialDatabase.MaterialProperties props = MaterialDatabase.Materials[selectedMaterial];
            double molecularWeight = double.Parse(molecularWeightInput.Text);

            if (staggeredPsvsDataGridView.Visible)
            {
                // Staggered PSV calculation
                double totalFlowRate = 0;
                foreach (var scenario in scenarios)
                {
                    totalFlowRate += GetScenarioFlowRate(scenario, props.Type, flowRate);
                }

                double flowPerPsv = totalFlowRate / staggeredPsvsDataGridView.Rows.Count;

                double relievingPressure;
                if (chkFireCase.Checked)
                {
                    relievingPressure = double.Parse(txtMAWP.Text) * 1.21 + STANDARD_ATM_PRESSURE;
                }
                else
                {
                    relievingPressure = double.Parse(txtMAWP.Text) * 1.16 + STANDARD_ATM_PRESSURE;
                }

                foreach (DataGridViewRow row in staggeredPsvsDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;
                    double setPressure = double.Parse(row.Cells[0].Value.ToString());
                    double area = CalculateOrificeArea(props.Type, setPressure, temperature, flowPerPsv, relievingPressure);
                    string orificeSize = DetermineOrificeSize(area);

                    resultsDataGridView.Rows.Add(
                        "Staggered PSV",
                        flowPerPsv.ToString("F2"),
                        area.ToString("F6"),
                        orificeSize,
                        setPressure.ToString("F2")
                    );
                }
            }
            else
            {
                // Single PSV calculation
                foreach (var scenario in scenarios)
                {
                    try
                    {
                        double setPressure = double.Parse(pressureInput.Text);
                        double scenarioFlowRate = GetScenarioFlowRate(scenario, props.Type, flowRate);

                        if (props.Type == Phase.Gas && lblFlowRate.Text.Contains("SCFM"))
                        {
                            scenarioFlowRate = ConvertSCFMToLbPerHour(scenarioFlowRate, molecularWeight);
                        }

                        double accumulation = GetAccumulationPercentage();
                        double relievingPressure = setPressure * (1 + accumulation) + STANDARD_ATM_PRESSURE;
                        double area = CalculateOrificeArea(props.Type, setPressure, temperature, scenarioFlowRate, relievingPressure);
                        string orificeSize = DetermineOrificeSize(area);

                        resultsDataGridView.Rows.Add(
                            scenario,
                            scenarioFlowRate.ToString("F2"),
                            area.ToString("F6"),
                            orificeSize
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error calculating {scenario}: {ex.Message}");
                    }
                }
            }
        }

        private bool ValidateInputs(bool silent = false)
        {
            try
            {
                // Common validations
                if (!double.TryParse(pressureInput.Text, out _))
                    throw new Exception("Pressure must be a valid number");
                if (!double.TryParse(temperatureInput.Text, out _))
                    throw new Exception("Temperature must be a valid number");
                if (!double.TryParse(flowRateInput.Text, out _))
                    throw new Exception("Flow rate must be a valid number");

                // Fluid-specific validations
                string fluidType = fluidTypeCombo.SelectedItem.ToString();
                if ((fluidType == "Gas" || fluidType == "Two-Phase") && string.IsNullOrEmpty(molecularWeightInput.Text))
                    throw new Exception("Molecular weight is required for gas/two-phase");

                if (fluidType == "Liquid" && string.IsNullOrEmpty(viscosityInput.Text))
                    throw new Exception("Viscosity is required for liquid");

                if ((fluidType == "Liquid" || fluidType == "Two-Phase") && string.IsNullOrEmpty(specificGravityInput.Text))
                    throw new Exception("Specific gravity is required for liquid/two-phase");

                // Vessel parameter validations
                if (!double.TryParse(txtMAWP.Text, out _))
                    throw new Exception("MAWP must be a valid number");
                if (!double.TryParse(txtDesignTemp.Text, out _))
                    throw new Exception("Design temperature must be a valid number");
                if (cmbAccumulation.SelectedIndex == -1)
                    throw new Exception("Please select accumulation percentage");
                if (!double.TryParse(txtFillLevel.Text, out double fillLevel) || fillLevel < 0 || fillLevel > 100)
                    throw new Exception("Fill Level must be between 0 and 100%");

                return true;
            }
            catch (Exception ex)
            {
                if (!silent)
                {
                    MessageBox.Show($"Input validation failed: {ex.Message}", "Input Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

        private List<string> GetSelectedScenarios()
        {
            var selected = new List<string>();
            foreach (Control ctrl in scenarioGroupBox.Controls)
            {
                if (ctrl is CheckBox chk && chk.Checked)
                {
                    selected.Add(chk.Text);
                }
            }
            return selected;
        }

        private void CalculateScenario(string scenario)
        {
            try
            {
                string selectedMaterial = fluidTypeCombo.SelectedItem.ToString();
                MaterialDatabase.MaterialProperties props = MaterialDatabase.Materials[selectedMaterial];
                double setPressure = double.Parse(pressureInput.Text);
                double temperature = double.Parse(temperatureInput.Text);
                double flowRate = double.Parse(flowRateInput.Text);

                // Get scenario-specific flow rate
                double scenarioFlowRate = GetScenarioFlowRate(scenario, props.Type, flowRate);

                // Calculate orifice area
                double accumulation = GetAccumulationPercentage();
                double relievingPressure = setPressure * (1 + accumulation) + STANDARD_ATM_PRESSURE;
                double area = CalculateOrificeArea(props.Type, setPressure, temperature, scenarioFlowRate, relievingPressure);
                string orificeSize = DetermineOrificeSize(area);

                // Add to results (DataGridView instead of ListView)
                resultsDataGridView.Rows.Add(
                    scenario,
                    scenarioFlowRate.ToString("F2"),
                    area.ToString("F6"),
                    orificeSize
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating {scenario}: {ex.Message}", "Calculation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double GetScenarioFlowRate(string scenario, Phase fluidType, double baseFlowRate)
        {
            switch (scenario)
            {
                case "Blocked Outlet":
                    return CalculateBlockedOutletFlowRate(baseFlowRate);
                case "Fire Case (Pool/Enclosed)":
                    return CalculateFireCaseFlowRate();
                case "Thermal Expansion":
                    return CalculateThermalExpansionFlowRate();
                case "Cooling Failure":
                    // Simplified - would use actual heat input calculations
                    return baseFlowRate * 1.5;
                case "Heat Exchanger Tube Rupture":
                    // Simplified - based on typical flow rates
                    return (fluidType == Phase.Liquid ? baseFlowRate * 2.5 : baseFlowRate * 3.0);
                case "Chemical Reaction/Overpressure":
                    // Simplified - would use reaction kinetics
                    return baseFlowRate * 4.0;
                case "Control Valve Failure":
                    // Placeholder - Assumes valve fails open, leading to 125% of normal flow.
                    return baseFlowRate * 1.25;
                case "Power Failure":
                    // Placeholder - Assumes loss of cooling, similar to cooling failure but could be different.
                    return baseFlowRate * 1.6;
                case "Hydraulic Hammer/Water Hammer":
                    // Placeholder - Highly dependent on system specifics. This is a rough estimate.
                    return baseFlowRate * 2.0;
                case "Reflux Failure":
                    // Placeholder - Assumes loss of reflux leads to increased vapor load.
                    return baseFlowRate * 1.75;
                case "Compressor/Expander Failure":
                    // Placeholder - Assumes blocked discharge or other failure.
                    return baseFlowRate * 1.4;
                default:
                    return baseFlowRate;
            }
        }

        private double CalculateBlockedOutletFlowRate(double baseFlowRate)
        {
            double accumulation = 0.10; // Default
            if (cmbAccumulation.SelectedIndex == 1) accumulation = 0.16;
            else if (cmbAccumulation.SelectedIndex == 2) accumulation = 0.21;
            return baseFlowRate * (1 + accumulation);
        }

        private double CalculateFireCaseFlowRate()
        {
            try
            {
                var geometry = new VesselGeometry
                {
                    Type = chkHorizontalVessel.Checked ? VesselType.HorizontalCylindrical : VesselType.VerticalWithHeads,
                    Diameter = double.Parse(vesselDiameterInput.Text),
                    Length = double.Parse(vesselLengthInput.Text),
                    Height = double.Parse(vesselLengthInput.Text)
                };

                double fillLevel = double.Parse(txtFillLevel.Text) / 100;
                double latentHeat = GetLatentHeat(); // Implement this method

                var calculator = new FireCaseCalculator();
                var result = calculator.CalculateFireReliefLoad(geometry, fillLevel,
                              chkInsulated.Checked, chkWaterSpray.Checked, chkUnderground.Checked, latentHeat);

                return result.ReliefLoad;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fire case calculation error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private double CalculateThermalExpansionFlowRate()
        {
            double beta = GetExpansionCoefficient(fluidTypeCombo.SelectedItem.ToString());
            double volume = CalculateVesselVolume();
            return beta * volume * 50 / 3600; // Typical ΔT = 50°F/hr
        }

        private double CalculateWettedArea(VesselGeometry geometry, double fillLevel)
        {
            fillLevel = Math.Max(fillLevel, 0.25); // API 521 minimum

            if (geometry.Type == VesselType.HorizontalCylindrical)
            {
                double radius = geometry.Diameter / 2;
                double wettedLength = geometry.Length * fillLevel;

                // Partial cylinder + 2 dished ends
                return (Math.PI * geometry.Diameter * wettedLength) +
                       (1.2 * Math.PI * Math.Pow(radius, 2));
            }
            else // Vertical vessel
            {
                double wettedHeight = Math.Max(geometry.Height * fillLevel, MIN_WETTED_HEIGHT);
                return Math.PI * geometry.Diameter * wettedHeight;
            }
        }

        private double GetEnvironmentFactor()
        {
            // API 521 Table 7
            if (chkInsulated.Checked) return 0.3;
            if (chkWaterSpray.Checked) return 0.15;
            if (chkUnderground.Checked) return 0.0;
            return 1.0; // Bare vessel
        }

        private double GetExpansionCoefficient(string fluidType)
        {
            // Typical expansion coefficients (per °F)
            if (fluidType == "Water") return 0.00012;
            if (fluidType == "Hydrocarbon") return 0.0005;
            if (fluidType == "Ammonia") return 0.00022;
            return 0.0004; // Default for other liquids
        }

        private double CalculateVesselVolume()
        {
            double diameter = double.Parse(vesselDiameterInput.Text);
            double length = double.Parse(vesselLengthInput.Text);
            return Math.PI * Math.Pow(diameter / 2, 2) * length;
        }
        /// <summary>
        /// Updates the flow rate units and converts the current value when the fluid type changes.
        /// </summary>
        /// <param name="fluidType">The new fluid type.</param>
        private void UpdateFlowRateUnits(string fluidType)
        {
            string currentUnit = lblFlowRate.Text.Contains("SCFM") ? "SCFM" : "lb/hr";
            string newUnit = (fluidType == "Gas" || fluidType == "Air") ? "SCFM" : "lb/hr";

            // Only convert if the unit is actually changing
            if (currentUnit != newUnit && double.TryParse(flowRateInput.Text, out double currentValue))
            {
                double convertedValue;
                if (newUnit == "SCFM")
                {
                    // Convert from lb/hr to SCFM
                    convertedValue = ConvertLbPerHourToSCFM(currentValue,
                        double.Parse(molecularWeightInput.Text));
                }
                else
                {
                    // Convert from SCFM to lb/hr
                    convertedValue = ConvertSCFMToLbPerHour(currentValue,
                        double.Parse(molecularWeightInput.Text));
                }
                // WARNING: This automatically changes the user's input value.
                // This might be unexpected from a user's perspective.
                flowRateInput.Text = convertedValue.ToString("F2");
            }

            // Update the label text
            lblFlowRate.Text = (newUnit == "SCFM") ? "Flow Rate (SCFM):" : "Flow Rate (lb/hr):";
        }

        private double ConvertLbPerHourToSCFM(double lbPerHour, double molecularWeight)
        {
            if (Math.Abs(molecularWeight - 28.97) < 0.1)
            {
                return lbPerHour * 0.002123; // Pre-calculated constant for air
            }
            return lbPerHour * (379.3 / molecularWeight) / 60;
        }

        private double ConvertSCFMToLbPerHour(double scfm, double molecularWeight)
        {
            // Inverse conversion: lb/hr = SCFM * (MW / 379.3) * 60
            return scfm * (molecularWeight / 379.3) * 60;
        }
        private double CalculateOrificeArea(Phase fluidType, double setPressure, double temperature, double flowRate, double relievingPressure)
        {

            // Get material properties
            double molecularWeight = double.Parse(molecularWeightInput.Text);
            double heatRatio = double.Parse(specificHeatRatioInput.Text);
            double compressibility = double.Parse(compressibilityInput.Text);

            double area = 0;

            if (fluidType == Phase.Gas)
            {
                // API 520 Part I Eq. 3 (US Customary units)
                double rCritical = Math.Pow(2 / (heatRatio + 1), heatRatio / (heatRatio - 1));
                double kb = GetBackpressureCorrectionFactor();

                area = (flowRate / (315 * kb * 0.975 * relievingPressure * rCritical)) *
                       Math.Sqrt((compressibility * (temperature + 459.67) * molecularWeight) / heatRatio);
            }
            else if (fluidType == Phase.Liquid)
            {
                double specificGravity = double.Parse(specificGravityInput.Text);
                double viscosity = double.Parse(viscosityInput.Text);
                double kv = CalculateViscosityCorrection(flowRate, specificGravity, viscosity, relievingPressure);

                // API 520 Part I Eq. 7
                area = (flowRate / (38 * 0.65 * kv)) *
                       Math.Sqrt(specificGravity / (relievingPressure - setPressure));
            }
            else if (fluidType == Phase.Steam)
            {
                // Napier's equation for critical flow of steam
                double C = 0.975; // Coefficient of discharge
                area = flowRate / (51.45 * relievingPressure * C);
            }

            return area > 0.000001 ? area : 0;
        }
        private double GetAccumulationPercentage()
        {
            switch (cmbAccumulation.SelectedIndex)
            {
                case 0: return 0.10; // Single PSV
                case 1: return 0.16; // Multiple PSV
                case 2: return 0.21; // Fire Case
                default: return 0.10;
            }
        }




        private double CalculateTwoPhaseArea(double setPressure, double temperature, double flowRate,
                                   double molecularWeight, double heatRatio, double compressibility,
                                   double specificGravity, double vaporFraction)
        {
            // Simplified Omega method for two-phase flow
            double omega = CalculateOmegaParameter(vaporFraction, specificGravity);
            double criticalPressureRatio = Math.Pow(2 / (omega + 1), omega / (omega - 1));
            double relievingPressure = setPressure * (1 + criticalPressureRatio) + STANDARD_ATM_PRESSURE;

            // Convert flow rate to mass flow (lb/hr)
            double massFlow = flowRate; // Assuming already in lb/hr

            // Two-phase flow coefficient (conservative estimate)
            double C = 0.9 * 315; // Adjusted gas constant

            return (massFlow / (C * relievingPressure)) *
                   Math.Sqrt((compressibility * (temperature + 459.67) * molecularWeight) / heatRatio);
        }

        private double CalculateOmegaParameter(double vaporFraction, double specificGravity)
        {
            // Simplified omega calculation - should be replaced with proper fluid properties
            return vaporFraction * (62.4 / specificGravity) * Math.Pow(vaporFraction / (1 - vaporFraction), 2);
        }

        private double ConvertLbPerHourToGPM(double lbPerHour, double specificGravity)
        {
            // 1 gpm = 500.4 * SG lb/hr
            return lbPerHour / (500.4 * specificGravity);
        }

        private double CalculateViscosityCorrection(double flowRate, double G, double viscosity, double P)
        {
            if (viscosity <= 100) return 1.0;

            // Initial area estimate for Reynolds number
            double initialArea = (flowRate / (38 * 0.65 * 1.0)) *
                               Math.Sqrt(G / (1.25 * P * 0.1));

            double Re = (2800 * flowRate) / (viscosity * Math.Sqrt(initialArea));
            return Math.Pow((2.878 / Math.Pow(Re, 0.5)) + (0.00334 * Math.Pow(Re, 0.5) / viscosity), -1);
        }

        private string DetermineOrificeSize(double area)
        {
            var orificeSizes = new[]
            {
                new { Designation = "D", Area = 0.110 },
                new { Designation = "E", Area = 0.196 },
                new { Designation = "F", Area = 0.307 },
                new { Designation = "G", Area = 0.503 },
                new { Designation = "H", Area = 0.785 },
                new { Designation = "J", Area = 1.287 },
                new { Designation = "K", Area = 1.838 },
                new { Designation = "L", Area = 2.853 },
                new { Designation = "M", Area = 3.600 },
                new { Designation = "N", Area = 4.340 },
                new { Designation = "P", Area = 6.380 },
                new { Designation = "Q", Area = 11.05 },
                new { Designation = "R", Area = 16.00 },
                new { Designation = "T", Area = 26.00 }
            };

            if (area <= 0) return "N/A";

            foreach (var size in orificeSizes)
            {
                if (area <= size.Area) return size.Designation;
            }

            return "Custom (larger than T)";
        }

        private void InsertToExcelButton_Click(object sender, EventArgs e)
        {
            if (resultsDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No results to export. Please calculate first.", "Export Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Excel.Application excelApp = Globals.ThisAddIn.Application;
                Excel.Worksheet activeSheet = (Excel.Worksheet)excelApp.ActiveSheet;

                // Header
                int row = 1;
                activeSheet.Cells[row, 1].Value = $"PSV Sizing for Vessel: MAWP {txtMAWP.Text} psig, Design Temp {txtDesignTemp.Text}°F";
                activeSheet.Cells[row, 1].Font.Bold = true;
                row++;

                // Column headers
                for (int i = 0; i < resultsDataGridView.Columns.Count; i++)
                {
                    activeSheet.Cells[row, i + 1].Value = resultsDataGridView.Columns[i].HeaderText;
                    activeSheet.Cells[row, i + 1].Font.Bold = true;
                }
                row++;

                // Data rows
                foreach (DataGridViewRow dgvRow in resultsDataGridView.Rows)
                {
                    for (int i = 0; i < dgvRow.Cells.Count; i++)
                    {
                        activeSheet.Cells[row, i + 1].Value = dgvRow.Cells[i].Value;
                    }
                    row++;
                }

                // Add calculation notes
                activeSheet.Cells[row, 1].Value = "Calculation Notes:";
                activeSheet.Cells[row, 1].Font.Bold = true;
                activeSheet.Cells[row, 2].Value = $"Fluid: {fluidTypeCombo.Text}";
                row++;
                activeSheet.Cells[row, 2].Value = $"Vessel Dimensions: {vesselDiameterInput.Text}ft × {vesselLengthInput.Text}ft";
                row++;
                activeSheet.Cells[row, 2].Value = $"Governing Scenario: {DetermineWorstCaseScenario()}";

                // Formatting
                Excel.Range range = activeSheet.Range["A1:D" + (row - 1)];
                range.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                range.Columns.AutoFit();

                MessageBox.Show("Results successfully exported to Excel.", "Export Complete",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel export failed: {ex.Message}", "Export Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class BackpressureCalculator
        {
            private const double MAX_BALANCED_BACKPRESSURE = 0.5; // 50% for balanced bellows

            public BackpressureAnalysis CalculateBackpressureEffects(
                double superimposedBackpressure,
                double builtUpBackpressure,
                bool isBalancedBellows)
            {
                double totalBackpressure = superimposedBackpressure + builtUpBackpressure;
                double percentBackpressure = totalBackpressure / setPressure;

                return new BackpressureAnalysis
                {
                    TotalBackpressure = totalBackpressure,
                    SuperimposedBackpressure = superimposedBackpressure,
                    BuiltUpBackpressure = builtUpBackpressure,
                    CorrectionFactor = GetCorrectionFactor(percentBackpressure, isBalancedBellows),
                    IsWithinLimits = percentBackpressure <= (isBalancedBellows ?
                                          MAX_BALANCED_BACKPRESSURE : 0.1)
                };
            }

            private double GetCorrectionFactor(double backpressureRatio, bool isBalancedBellows)
            {
                if (isBalancedBellows)
                {
                    return backpressureRatio <= MAX_BALANCED_BACKPRESSURE ? 1.0 : 0.8;
                }
                else
                {
                    // Conventional valve - use interpolation from API 520 Fig. 30-32
                    return InterpolateFromBackpressureChart(backpressureRatio);
                }
            }
            private double InterpolateFromBackpressureChart(double ratio)
            {
                // Sample data points from API 520 Fig. 30
                var conventionalKbValues = new Dictionary<double, double>
        {
            {0.10, 1.0}, {0.20, 0.97}, {0.30, 0.93},
            {0.40, 0.88}, {0.50, 0.82}
        };

                // Linear interpolation
                if (ratio <= 0.1) return 1.0;
                if (ratio >= 0.5) return 0.82;

                var lower = conventionalKbValues.Last(x => x.Key <= ratio);
                var upper = conventionalKbValues.First(x => x.Key >= ratio);

                return lower.Value + (ratio - lower.Key) *
                       (upper.Value - lower.Value) / (upper.Key - lower.Key);
            }
        }

        public class TwoPhaseFlowCalculator
        {
            public TwoPhaseResult CalculateReliefArea(PhaseFlowProperties props, double setPressure)
            {
                if (props == null) throw new ArgumentNullException(nameof(props));
                if (setPressure <= 0) throw new ArgumentOutOfRangeException(nameof(setPressure));

                // 1. Determine flow regime (flashing or non-flashing)
                bool isFlashing = DetermineIfFlashingFlow(props);

                // 2. Calculate omega parameter
                double omega = CalculateOmegaParameter(props);

                // 3. Determine critical pressure ratio
                double criticalPressureRatio = CalculateCriticalPressureRatio(omega);

                // 4. Calculate mass flux
                double massFlux = CalculateMassFlux(props, omega, criticalPressureRatio);

                // 5. Calculate required relief area
                double area = props.MassFlow / massFlux;

                return new TwoPhaseResult
                {
                    OmegaParameter = omega,
                    IsFlashingFlow = isFlashing,
                    ReliefArea = area,
                    CriticalPressureRatio = criticalPressureRatio
                };
            }

            private bool DetermineIfFlashingFlow(PhaseFlowProperties props)
            {
                // Simplified check - should use fluid properties
                return props.VaporFraction > 0.1 &&
                       props.SaturationPressure < 0.9 * setPressure;
            }

            private double CalculateOmegaParameter(PhaseFlowProperties props)
            {
                double x = props.VaporQuality;
                double liquidDensity = props.LiquidDensity;
                double vaporDensity = props.VaporDensity;
                double hl = props.LiquidEnthalpy;
                double hv = props.VaporEnthalpy;
                double hf = hl; // Assuming liquid enthalpy is the same as saturated liquid

                return x * (liquidDensity / vaporDensity) * Math.Pow((hv - hl) / (hl - hf), 2);
            }

            private double CalculateCriticalPressureRatio(double omega)
            {
                return Math.Pow(2 / (omega + 1), omega / (omega - 1));
            }

            private double CalculateMassFlux(PhaseFlowProperties props, double omega, double eta)
            {
                // Homogeneous Equilibrium Model (HEM)
                double P = props.RelievingPressure;
                double C = 0.9 * 315; // Adjusted gas constant

                if (props.IsFlashingFlow)
                {
                    return C * P * Math.Sqrt(omega) /
                                Math.Sqrt(props.VaporDensity * (1 + (omega - 1) * eta));
                }
                else
                {
                    // Non-flashing flow calculation
                    return 0.61 * Math.Sqrt(2 * ρl * (P - Pback));
                }
            }
        }



        private double CalculateFlashingFlowArea(double omega)
            {
                double criticalPressureRatio = Math.Pow(2 / (omega + 1), omega / (omega - 1));
                return criticalPressureRatio * 1.5; // Simplified calculation
            }

            private double CalculateNonFlashingArea()
            {
                return 1.0; // Simplified calculation
            }
        }

    public class FireCaseCalculator
    {
        private const double FIRE_FACTOR = 21000; // BTU/hr/ft²
        private const double MIN_WETTED_HEIGHT = 10; // ft (API 521 requirement)

        public FireCaseResult CalculateFireReliefLoad(
            VesselGeometry geometry,
            double fillLevel,
            bool isInsulated,
            bool hasWaterSpray,
            double latentHeat)
        {
            // 1. Calculate wetted area
            double wettedArea = CalculateWettedArea(geometry, fillLevel);

            // 2. Apply environmental factor
            double F = GetEnvironmentalFactor(isInsulated, hasWaterSpray);

            // 3. Calculate total heat input
            double Q = FIRE_FACTOR * F * Math.Pow(wettedArea, 0.82);

            // 4. Calculate required relief load
            double W = Q / latentHeat; // lb/hr

            return new FireCaseResult
            {
                WettedArea = wettedArea,
                HeatInput = Q,
                ReliefLoad = W,
                EnvironmentalFactor = F
            };
        }


        private double GetEnvironmentalFactor(bool isInsulated, bool hasWaterSpray)
        {
            // API 521 Table 7
            if (hasWaterSpray) return 0.15;
            if (isInsulated) return 0.3;
            return 1.0; // Bare vessel
        }

        public double CalculateViscosityCorrection(double flowRate, double specificGravity,
                                         double viscosity, double pressureDrop)
        {
            // 1. Initial area estimate (in²)
            double A0 = (flowRate / (38 * 0.65 * 1.0)) *
                       Math.Sqrt(specificGravity / pressureDrop);

            // 2. Calculate Reynolds number
            double Re = (2800 * flowRate) / (viscosity * Math.Sqrt(A0));

            // 3. Determine Kv from API 520 Fig. 37
            if (Re <= 100) return 1.0;
            if (Re >= 100000) return 0.7;

            // Logarithmic interpolation for intermediate values
            double logRe = Math.Log10(Re);
            double Kv;

            if (logRe <= 3) Kv = 1.0 - 0.3 * (logRe - 2);
            else if (logRe <= 4) Kv = 0.7 - 0.2 * (logRe - 3);
            else Kv = 0.7 - 0.1 * (logRe - 4);

            return Math.Max(Kv, 0.5); // Never less than 0.5 per API
        }
        public class GasFlowCalculator
        {
            public GasFlowResult CalculateGasFlow(double setPressure, double backPressure,
                                                double k, double molecularWeight)
            {
                double criticalRatio = Math.Pow(2 / (k + 1), k / (k - 1));
                bool isCriticalFlow = backPressure <= setPressure * criticalRatio;

                if (isCriticalFlow)
                {
                    return CalculateCriticalFlow(setPressure, k, molecularWeight);
                }
                else
                {
                    return CalculateSubcriticalFlow(setPressure, backPressure, k, molecularWeight);
                }
            }

            private GasFlowResult CalculateCriticalFlow(double P1, double k, double MW)
            {
                double r = Math.Pow(2 / (k + 1), k / (k - 1));
                double C = 315 * 0.975; // API constant * discharge coeff

                double massFlux = C * P1 * Math.Sqrt(k * MW / (T * Z)) *
                                 Math.Pow(r, Math.Sqrt(k * (2 / (k + 1))));

                return new GasFlowResult
                {
                    MassFlux = massFlux,
                    IsCriticalFlow = true,
                    CriticalPressureRatio = r
                };
            }

            private GasFlowResult CalculateSubcriticalFlow(double P1, double P2,
                                                         double k, double MW)
            {
                double ratio = P2 / P1;
                double exponent = (k - 1) / k;

                double term1 = Math.Pow(ratio, 2 / k);
                double term2 = Math.Pow(ratio, (k + 1) / k);

                double massFlux = 0.9 * 315 * P1 *
                 Math.Sqrt((2 * k / (k - 1)) * (term1 - term2)) /
                 Math.Sqrt(MW / (1545 * T * Z));

                return new GasFlowResult
                {
                    MassFlux = massFlux,
                    IsCriticalFlow = false,
                    CriticalPressureRatio = Math.Pow(2 / (k + 1), k / (k - 1))
                };
            }
        }
        public double CalculateWettedArea(VesselGeometry geometry, double fillLevel)
            {
                switch (geometry.Type)
                {
                    case VesselType.HorizontalCylindrical:
                        return CalculateHorizontalWettedArea(geometry.Diameter, geometry.Length, fillLevel);
                    case VesselType.VerticalWithHeads:
                        return CalculateVerticalWettedArea(geometry.Diameter, geometry.Height, fillLevel);
                    case VesselType.Spherical:
                        return CalculateSphericalWettedArea(geometry.Diameter, fillLevel);
                    default:
                        throw new NotImplementedException();
                }
            }

            private double CalculateHorizontalWettedArea(double diameter, double length, double fillLevel)
            {
                double radius = diameter / 2;
                double angle = 2 * Math.Acos(1 - (2 * fillLevel));
                double segmentArea = (Math.Pow(radius, 2) / 2) * (angle - Math.Sin(angle));
                return segmentArea * length;
            }



            private double CalculateVerticalWettedArea(double diameter, double height, double fillLevel)
            {
                return Math.PI * diameter * height * fillLevel;
            }

            private double CalculateSphericalWettedArea(double diameter, double fillLevel)
            {
                double radius = diameter / 2;
                return 2 * Math.PI * radius * radius * fillLevel;
            }
        }

        private void UpdateScenarioSpecificFields()
        {
            // Determine which scenarios are selected
            bool showFireFields = this.chkExternalFire.Checked;
            bool showVesselFields = showFireFields || this.chkCoolingFailure.Checked || this.chkTubeRupture.Checked;

            // Vessel dimension fields (needed for fire, cooling failure, tube rupture)
            lblVesselDiameter.Visible = showVesselFields;
            vesselDiameterInput.Visible = showVesselFields;
            lblVesselLength.Visible = showVesselFields;
            vesselLengthInput.Visible = showVesselFields;

            // Fire-specific fields (from vessel design group)
            chkInsulated.Visible = showFireFields;
            chkWaterSpray.Visible = showFireFields;
            chkUnderground.Visible = showFireFields;
            lblVesselOrientation.Visible = showFireFields;


            this.lblVesselDiameter.Visible = showVesselFields;
            this.vesselDiameterInput.Visible = showVesselFields;

            // If you add chemical reaction specific fields later, you can control their visibility here
            // For example:
            // someReactionField.Visible = showReactionFields;
            // lblSomeReactionField.Visible = showReactionFields;
        }

        public double CalculateHeatInput(double wettedArea, bool isInsulated, bool hasWaterSpray, bool isUnderground)
        {
            double F = GetEnvironmentalFactor(isInsulated, hasWaterSpray, isUnderground);
            return FIRE_FACTOR * F * Math.Pow(wettedArea, 0.82);
        }

        public class InstallationEffects
        {
            public PressureDropResult CalculateInletPressureDrop(double flowRate,
                                                               double pipeDiameter,
                                                               double pipeLength,
                                                               double fluidDensity)
            {
                double velocity = flowRate / (Math.PI * Math.Pow(pipeDiameter, 2) / 4);
                double reynolds = (fluidDensity * velocity * pipeDiameter) / 0.00089; // Simplified viscosity
                double frictionFactor = 0.316 / Math.Pow(reynolds, 0.25); // Blasius formula

                double pressureDrop = frictionFactor * (pipeLength / pipeDiameter) *
                                     (fluidDensity * Math.Pow(velocity, 2)) / 2;

                return new PressureDropResult
                {
                    PressureDrop = pressureDrop,
                    IsAcceptable = pressureDrop < 0.03 * 100 // Example set pressure
                };
            }

            public double CalculateReactionForce(double flowRate, double pressure,
                                               double backpressure, double area)
            {
                return 1.27 * flowRate * Math.Sqrt(pressure / 1) +
                       (pressure - backpressure) * area;
            }
        }

        public static class UnitConverter
        {
            public static double ConvertPressure(double value, PressureUnit from, PressureUnit to)
            {
                var conversions = new Dictionary<PressureUnit, double>
                {
                    [PressureUnit.PSI] = 1.0,
                    [PressureUnit.BAR] = 14.5038,
                    [PressureUnit.KPA] = 0.145038,
                    [PressureUnit.MPA] = 145.038
                };

                return value * conversions[from] / conversions[to];
            }

            public enum PressureUnit { PSI, BAR, KPA, MPA }
        }

    public class PhaseFlowProperties
    {
        public double VaporFraction { get; set; }
        public double LiquidDensity { get; set; } // lb/ft³
        public double VaporDensity { get; set; }  // lb/ft³
        public double VaporQuality { get; set; }
        public double MassFlow { get; set; }      // lb/hr
        public double RelievingPressure { get; set; } // psia
        public double SaturationPressure { get; set; } // psia
        public double LiquidEnthalpy { get; set; } // BTU/lb
        public double VaporEnthalpy { get; set; }  // BTU/lb
        public bool IsFlashingFlow { get; set; }
    }

    public class FireCaseResult
    {
        public double WettedArea { get; set; }
        public double HeatInput { get; set; }
        public double ReliefLoad { get; set; }
        public double EnvironmentalFactor { get; set; }
    }

    public class GasFlowResult
    {
        public double MassFlux { get; set; }
        public bool IsCriticalFlow { get; set; }
        public double CriticalPressureRatio { get; set; }
}

// Add to existing TwoPhaseResult class
public double CriticalPressureRatio { get; set; }
    public class FluidProperties
        {
            public double MolecularWeight { get; set; }
            public double SpecificHeatRatio { get; set; }
            public double ThermalExpansionCoeff { get; set; }
            public double Viscosity { get; set; }
        }

        public class BackpressureAnalysis
        {
            public double TotalBackpressure { get; set; }
            public bool IsWithinLimits { get; set; }
            public double CorrectionFactor { get; set; }
        }


        private string DetermineWorstCaseScenario()
        {
            if (resultsDataGridView.Rows.Count == 0) return "N/A";

            double maxArea = 0;
            string worstCase = "";

            foreach (DataGridViewRow row in resultsDataGridView.Rows)
            {
                if (row.Cells[2].Value != null &&
                    double.TryParse(row.Cells[2].Value.ToString(), out double area))
                {
                    if (area > maxArea)
                    {
                        maxArea = area;
                        worstCase = row.Cells[0].Value.ToString();
                    }
                }
            }

            return worstCase;
        }

        private void PSVSizingForm_Load(object sender, EventArgs e)
        {
            staggeredPsvsDataGridView.Columns[staggeredPsvsDataGridView.Columns.Count - 1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
