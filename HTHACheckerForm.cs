using System;
using System.Drawing;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class HTHACheckerForm : Form
    {
        public HTHACheckerForm()
        {
            InitializeComponent();
            InitializeMaterialDropdown();
            SetupDisclaimerLabel();
            this.Load += HTHACheckerForm_Load;
        }

        private void SetupDisclaimerLabel()
        {
            lblDisclaimer.Dock = DockStyle.Bottom;
            lblDisclaimer.BackColor = Color.LightYellow;
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
            lblDisclaimer.AutoSize = false;
            lblDisclaimer.Height = 60;
            lblDisclaimer.Padding = new Padding(5);
            lblDisclaimer.Font = new Font(lblDisclaimer.Font, FontStyle.Italic);
        }

        private void HTHACheckerForm_Load(object sender, EventArgs e)
        {
            lblDisclaimer.Text = "Disclaimer: This tool uses approximated Nelson Curve equations based on API 941. " +
                               "It is intended for preliminary screening only. Always consult the latest edition of API 941 " +
                               "and perform metallurgical evaluation for final decisions.";
        }

        private void InitializeMaterialDropdown()
        {
            cboMaterial.Items.AddRange(new object[] {
                "Carbon Steel (C ≤ 0.3%, PWHT)",
                "Carbon Steel (C ≤ 0.3%, non-PWHT)",
                "C-0.5Mo (Not Recommended)",
                "1.0Cr-0.5Mo",
                "1.25Cr-0.5Mo",
                "2.25Cr-1.0Mo",
                "2.25Cr-1.0Mo-V",
                "3Cr-1Mo",
                "5Cr-0.5Mo",
                "6Cr-0.5Mo",
                "Type 304/316 Stainless"
            });
            cboMaterial.SelectedIndex = 0;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string material = cboMaterial.SelectedItem.ToString();
                double temperature = double.Parse(txtTemperature.Text);
                double h2Pressure = double.Parse(txtH2Pressure.Text);

                string result = AssessHTHA(material, temperature, h2Pressure);
                lblResult.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in calculation: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTemperature.Text) ||
                string.IsNullOrWhiteSpace(txtH2Pressure.Text))
            {
                MessageBox.Show("Please enter both temperature and H₂ pressure.",
                              "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtTemperature.Text, out double temp) ||
                !double.TryParse(txtH2Pressure.Text, out double pressure))
            {
                MessageBox.Show("Please enter valid numeric values.",
                              "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (temp <= 0 || pressure <= 0)
            {
                MessageBox.Show("Values must be greater than zero.",
                              "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string AssessHTHA(string material, double tempF, double pressurePsia)
        {
            double maxAllowablePressure = 0;
            string riskLevel;
            string recommendation;

            // Temperature threshold checks
            if (tempF < 400 && !material.Contains("Stainless"))
            {
                return FormatResult(
                    material, tempF, pressurePsia,
                    "ℹ️ BELOW HTHA THRESHOLD",
                    "No HTHA risk below 400°F (204°C).\n" +
                    "Check for:\n1. Wet H₂S corrosion (NACE MR0175)\n" +
                    "2. Hydrogen embrittlement"
                );
            }

            // Material-specific calculations
            switch (material)
            {
                case "Carbon Steel (C ≤ 0.3%, PWHT)":
                    maxAllowablePressure = Math.Pow(10, 7.469 - (4440 / (tempF + 460)));
                    recommendation = "Ensure PWHT was performed per ASME standards.";
                    break;

                case "Carbon Steel (C ≤ 0.3%, non-PWHT)":
                    if (tempF < 450)
                    {
                        return FormatResult(
                            material, tempF, pressurePsia,
                            "✅ SAFE (Below HTHA threshold)",
                            "No HTHA risk. Verify weld integrity for wet H₂S."
                        );
                    }
                    maxAllowablePressure = Math.Pow(10, 7.469 - (4440 / (tempF + 50 + 460)));
                    recommendation = "🚨 Weld zones are high-risk above 450°F! Perform PWHT or upgrade material.";
                    break;

                case "C-0.5Mo (Not Recommended)":
                    maxAllowablePressure = Math.Pow(10, 7.469 - (4440 / (tempF + 50 + 460)));
                    recommendation = "⛔ Avoid C-0.5Mo in H₂ service (API 941 warns against it).";
                    break;

                case "1.0Cr-0.5Mo":
                    if (tempF < 500) return BelowThresholdSafe(material, tempF, pressurePsia);
                    maxAllowablePressure = Math.Pow(10, 7.800 - (4800 / (tempF + 460)));
                    recommendation = "Verify Cr content ≥1.0%. Limited data available.";
                    break;

                case "1.25Cr-0.5Mo":
                    if (tempF < 500) return BelowThresholdSafe(material, tempF, pressurePsia);
                    maxAllowablePressure = Math.Pow(10, 7.966 - (4900 / (tempF + 460)));
                    recommendation = "Standard refinery material. Monitor for HTHA in welds.";
                    break;

                case "2.25Cr-1.0Mo":
                    if (tempF < 600) return BelowThresholdSafe(material, tempF, pressurePsia, "Check for creep above 800°F");
                    maxAllowablePressure = Math.Pow(10, 8.160 - (5200 / (tempF + 460)));
                    recommendation = "Preferred for high-pressure H₂ service.";
                    break;

                case "2.25Cr-1.0Mo-V":
                    if (tempF < 600) return BelowThresholdSafe(material, tempF, pressurePsia, "Check for temper embrittlement");
                    maxAllowablePressure = Math.Pow(10, 8.300 - (5400 / (tempF + 460)));
                    recommendation = "Vanadium improves resistance. Check for temper embrittlement.";
                    break;

                case "3Cr-1Mo":
                    if (tempF < 600) return BelowThresholdSafe(material, tempF, pressurePsia, "Check for temper embrittlement");
                    maxAllowablePressure = Math.Pow(10, 8.300 - (5400 / (tempF + 460)));
                    recommendation = "Higher Cr content improves resistance. Check for temper embrittlement.";
                    break;

                case "5Cr-0.5Mo":
                    if (tempF < 700) return BelowThresholdSafe(material, tempF, pressurePsia, "Limited field data available");
                    maxAllowablePressure = Math.Pow(10, 8.450 - (5600 / (tempF + 460)));
                    recommendation = "Rare. Consult API 941 for specific guidance.";
                    break;

                case "6Cr-0.5Mo":
                    if (tempF < 700) return BelowThresholdSafe(material, tempF, pressurePsia, "Limited field data available");
                    maxAllowablePressure = Math.Pow(10, 8.500 - (5700 / (tempF + 460)));
                    recommendation = "Limited field data. Use with caution.";
                    break;

                case "Type 304/316 Stainless":
                    return FormatResult(
                        material, tempF, pressurePsia,
                        "✅ IMMUNE (No HTHA risk in refinery conditions)",
                        "No special requirements for HTHA."
                    );

                default:
                    return FormatResult(
                        material, tempF, pressurePsia,
                        "❓ UNKNOWN MATERIAL",
                        "Consult API 941 Figure 1 for this material"
                    );
            }

            // Risk assessment
            if (pressurePsia > maxAllowablePressure)
            {
                riskLevel = "🚨 CRITICAL RISK (Above Nelson Curve)";
            }
            else if (pressurePsia > 0.9 * maxAllowablePressure)
            {
                riskLevel = "⚠️ HIGH RISK (Near Nelson Curve)";
            }
            else if (pressurePsia > 0.7 * maxAllowablePressure)
            {
                riskLevel = "⚠️ WARNING (Approaching Curve)";
            }
            else
            {
                riskLevel = "✅ SAFE (Below Nelson Curve)";
            }

            // Additional warnings
            if (tempF > 800 && pressurePsia < 50)
                recommendation += "\n⚠️ Check for surface decarburization at high temp/low pressure.";

            if (tempF > 900 && material.Contains("Carbon Steel"))
                recommendation += "\n⚠️ Potential graphitization above 900°F.";

            recommendation += $"\nMax Allowable H₂ Pressure: {maxAllowablePressure:F1} psia at {tempF}°F";

            return FormatResult(material, tempF, pressurePsia, riskLevel, recommendation);
        }

        private string BelowThresholdSafe(string material, double tempF, double pressurePsia, string additionalNote = "")
        {
            return FormatResult(
                material, tempF, pressurePsia,
                "✅ SAFE (Below HTHA threshold)",
                $"No HTHA risk. {additionalNote}".Trim()
            );
        }

        private string FormatResult(string material, double tempF, double pressurePsia, string riskLevel, string recommendation)
        {
            return $"HTHA Risk Assessment (API RP 941)\n" +
                   $"──────────────────────────────\n" +
                   $"Material: {material}\n" +
                   $"Temperature: {tempF}°F ({(tempF - 32) * 5 / 9:F1}°C)\n" +
                   $"H₂ Partial Pressure: {pressurePsia} psia ({pressurePsia * 0.00689476:F2} MPa)\n\n" +
                   $"Result: {riskLevel}\n\n" +
                   $"Recommendations:\n{recommendation}";
        }
    }
}
