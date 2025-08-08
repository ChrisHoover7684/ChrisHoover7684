using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static MaterialDatabase;

namespace FERExcelAddIn
{
    public partial class PSVSizing : Form
    {
        public PSVSizing()
        {
            InitializeComponent();
            SetupFormControls();
        }

        private void SetupFormControls()
        {
            // Initialize data sources
            cmbGasFluid.DataSource = MaterialDatabase.Materials
                .Where(kvp => kvp.Value.Type == Phase.Gas)
                .Select(kvp => kvp.Key)
                .OrderBy(name => name)
                .ToList();

            cmbLiquidFluid.DataSource = MaterialDatabase.Materials
                .Where(kvp => kvp.Value.Type == Phase.Liquid)
                .Select(kvp => kvp.Key)
                .OrderBy(name => name)
                .ToList();

            cmbSteamFluid.DataSource = MaterialDatabase.Materials
                .Where(kvp => kvp.Value.Type == Phase.Steam)
                .Select(kvp => kvp.Key)
                .OrderBy(name => name)
                .ToList();

            cmbTwoPhaseFluid.DataSource = MaterialDatabase.Materials
                .Select(kvp => kvp.Key)
                .OrderBy(name => name)
                .ToList();

            // Wire up event handlers
            cmbGasFluid.SelectedIndexChanged += FluidSelectionChanged;
            cmbLiquidFluid.SelectedIndexChanged += LiquidFluidSelectionChanged;
            cmbSteamFluid.SelectedIndexChanged += SteamFluidSelectionChanged;
            cmbTwoPhaseFluid.SelectedIndexChanged += FluidSelectionChanged;
            cmbEquipmentType.SelectedIndexChanged += CmbEquipmentType_SelectedIndexChanged;

            // Set default selections
            cmbGasFluid.SelectedIndex = 0;
            cmbLiquidFluid.SelectedIndex = 0;
            cmbSteamFluid.SelectedIndex = 0;
            cmbTwoPhaseFluid.SelectedIndex = 0;
            cmbEquipmentType.SelectedIndex = 0;
            cmbPumpType.SelectedIndex = 0;

            // Fire case checkbox event handlers
            chkFireCase.CheckedChanged += chkFireCaseGas_CheckedChanged;
            chkLiquidFireCase.CheckedChanged += chkFireCaseLiquid_CheckedChanged;
            chkSteamFireCase.CheckedChanged += chkFireCaseSteam_CheckedChanged;

            // Wetted/Unwetted radio button event handlers
            radioWettedGas.CheckedChanged += FireCaseGasRadio_CheckedChanged;
            radioUnwettedGas.CheckedChanged += FireCaseGasRadio_CheckedChanged;

            // Back pressure textboxes event handlers
            txtBuiltUpBP.TextChanged += txtBackPressure_TextChanged;
            txtConstantSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtVariableSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtInletLoss.TextChanged += txtInletLoss_TextChanged;
            radioWettedLiquid.CheckedChanged += FireCaseLiquidRadio_CheckedChanged;
            radioUnwettedLiquid.CheckedChanged += FireCaseLiquidRadio_CheckedChanged;
            txtLiquidBuiltUpBP.TextChanged += txtBackPressure_TextChanged;
            txtLiquidConstantSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtLiquidVariableSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtLiquidInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtLiquidInletLoss.TextChanged += txtInletLoss_TextChanged;

            radioWettedSteam.CheckedChanged += FireCaseSteamRadio_CheckedChanged;
            radioUnwettedSteam.CheckedChanged += FireCaseSteamRadio_CheckedChanged;
            txtSteamBuiltUpBP.TextChanged += txtBackPressure_TextChanged;
            txtSteamConstantSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtSteamVariableSuperimposedBP.TextChanged += txtBackPressure_TextChanged;
            txtSteamInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtSteamInletLoss.TextChanged += txtInletLoss_TextChanged;

            // Set initial visibility
            FireCaseGasRadio_CheckedChanged(null, EventArgs.Empty);
            FireCaseLiquidRadio_CheckedChanged(null, EventArgs.Empty);
            FireCaseSteamRadio_CheckedChanged(null, EventArgs.Empty);
            CmbEquipmentType_SelectedIndexChanged(null, EventArgs.Empty);

            // Scenario checkbox event handlers
            chkLiquidControlValveFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidPowerFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidHydraulicHammer.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidRefluxFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkGasControlValveFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkGasPowerFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkGasRefluxFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamControlValveFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamPowerFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamHydraulicHammer.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamRefluxFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkGasCompressorExpanderFailure.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkTubeRupture.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidTubeRupture.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamTubeRupture.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkThermalRelief.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidThermalRelief.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamThermalRelief.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkRunawayReaction.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidRunawayReaction.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamRunawayReaction.CheckedChanged += ScenarioCheckbox_CheckedChanged;

            // Add missing handlers for Blocked Outlet
            chkBlockedOutlet.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkLiquidBlockedOutlet.CheckedChanged += ScenarioCheckbox_CheckedChanged;
            chkSteamBlockedOutlet.CheckedChanged += ScenarioCheckbox_CheckedChanged;
        }

        private void FireCaseGasRadio_CheckedChanged(object sender, EventArgs e)
        {
            bool wetted = radioWettedGas.Checked;
            lblEnvFactorWettedGas.Visible = wetted;
            txtEnvFactorWettedGas.Visible = wetted;
            lblLatentHeatGas.Visible = wetted;
            txtLatentHeatGas.Visible = wetted;
            lblWettedAreaGas.Visible = wetted;
            txtWettedAreaGas.Visible = wetted;

            bool unwetted = radioUnwettedGas.Checked;
            lblEnvFactorUnwettedGas.Visible = unwetted;
            txtEnvFactorUnwettedGas.Visible = unwetted;
            lblFireSizingFactorGas.Visible = unwetted;
            txtFireSizingFactorGas.Visible = unwetted;
            lblSurfaceAreaUnwettedGas.Visible = unwetted;
            txtSurfaceAreaUnwettedGas.Visible = unwetted;
        }

        private void FireCaseLiquidRadio_CheckedChanged(object sender, EventArgs e)
        {
            bool wetted = radioWettedLiquid.Checked;
            lblEnvFactorWettedLiquid.Visible = wetted;
            txtEnvFactorWettedLiquid.Visible = wetted;
            lblLatentHeatLiquid.Visible = wetted;
            txtLatentHeatLiquid.Visible = wetted;
            lblWettedAreaLiquid.Visible = wetted;
            txtWettedAreaLiquid.Visible = wetted;

            bool unwetted = radioUnwettedLiquid.Checked;
            lblEnvFactorUnwettedLiquid.Visible = unwetted;
            txtEnvFactorUnwettedLiquid.Visible = unwetted;
            lblFireSizingFactorLiquid.Visible = unwetted;
            txtFireSizingFactorLiquid.Visible = unwetted;
            lblSurfaceAreaUnwettedLiquid.Visible = unwetted;
            txtSurfaceAreaUnwettedLiquid.Visible = unwetted;
        }

        private void FireCaseSteamRadio_CheckedChanged(object sender, EventArgs e)
        {
            bool wetted = radioWettedSteam.Checked;
            lblEnvFactorWettedSteam.Visible = wetted;
            txtEnvFactorWettedSteam.Visible = wetted;
            lblLatentHeatSteam.Visible = wetted;
            txtLatentHeatSteam.Visible = wetted;
            lblWettedAreaSteam.Visible = wetted;
            txtWettedAreaSteam.Visible = wetted;

            bool unwetted = radioUnwettedSteam.Checked;
            lblEnvFactorUnwettedSteam.Visible = unwetted;
            txtEnvFactorUnwettedSteam.Visible = unwetted;
            lblFireSizingFactorSteam.Visible = unwetted;
            txtFireSizingFactorSteam.Visible = unwetted;
            lblSurfaceAreaUnwettedSteam.Visible = unwetted;
            txtSurfaceAreaUnwettedSteam.Visible = unwetted;
        }

        private void txtBackPressure_TextChanged(object sender, EventArgs e)
        {
            double builtUp = 0;
            double constant = 0;
            double variable = 0;

            if (sender == txtBuiltUpBP || sender == txtConstantSuperimposedBP || sender == txtVariableSuperimposedBP)
            {
                double.TryParse(txtBuiltUpBP.Text, out builtUp);
                double.TryParse(txtConstantSuperimposedBP.Text, out constant);
                double.TryParse(txtVariableSuperimposedBP.Text, out variable);
                txtTotalBackPressure.Text = (builtUp + constant + variable).ToString("N2");
            }
            else if (sender == txtLiquidBuiltUpBP || sender == txtLiquidConstantSuperimposedBP || sender == txtLiquidVariableSuperimposedBP)
            {
                double.TryParse(txtLiquidBuiltUpBP.Text, out builtUp);
                double.TryParse(txtLiquidConstantSuperimposedBP.Text, out constant);
                double.TryParse(txtLiquidVariableSuperimposedBP.Text, out variable);
                txtLiquidTotalBackPressure.Text = (builtUp + constant + variable).ToString("N2");
            }
            else if (sender == txtSteamBuiltUpBP || sender == txtSteamConstantSuperimposedBP || sender == txtSteamVariableSuperimposedBP)
            {
                double.TryParse(txtSteamBuiltUpBP.Text, out builtUp);
                double.TryParse(txtSteamConstantSuperimposedBP.Text, out constant);
                double.TryParse(txtSteamVariableSuperimposedBP.Text, out variable);
                txtSteamTotalBackPressure.Text = (builtUp + constant + variable).ToString("N2");
            }
        }

        private void txtInletLoss_TextChanged(object sender, EventArgs e)
        {
            TextBox changedTextBox = sender as TextBox;
            if (changedTextBox == null) return;

            // Temporarily remove event handlers to prevent loops
            txtInletLossPercent.TextChanged -= txtInletLoss_TextChanged;
            txtInletLoss.TextChanged -= txtInletLoss_TextChanged;
            txtLiquidInletLossPercent.TextChanged -= txtInletLoss_TextChanged;
            txtLiquidInletLoss.TextChanged -= txtInletLoss_TextChanged;
            txtSteamInletLossPercent.TextChanged -= txtInletLoss_TextChanged;
            txtSteamInletLoss.TextChanged -= txtInletLoss_TextChanged;

            if (changedTextBox == txtInletLossPercent || changedTextBox == txtLiquidInletLossPercent || changedTextBox == txtSteamInletLossPercent)
            {
                TextBox percentBox = changedTextBox;
                TextBox valueBox = null;
                TextBox mawpBox = null;

                if (percentBox == txtInletLossPercent) { valueBox = txtInletLoss; mawpBox = txtSystemMAWP; }
                else if (percentBox == txtLiquidInletLossPercent) { valueBox = txtLiquidInletLoss; mawpBox = txtLiquidSystemMAWP; }
                else if (percentBox == txtSteamInletLossPercent) { valueBox = txtSteamInletLoss; mawpBox = txtSteamSystemMAWP; }

                if (double.TryParse(percentBox.Text, out double percent) && double.TryParse(mawpBox.Text, out double mawp))
                {
                    valueBox.Text = (mawp * (percent / 100.0)).ToString("N2");
                }
            }
            else if (changedTextBox == txtInletLoss || changedTextBox == txtLiquidInletLoss || changedTextBox == txtSteamInletLoss)
            {
                TextBox valueBox = changedTextBox;
                TextBox percentBox = null;
                TextBox mawpBox = null;

                if (valueBox == txtInletLoss) { percentBox = txtInletLossPercent; mawpBox = txtSystemMAWP; }
                else if (valueBox == txtLiquidInletLoss) { percentBox = txtLiquidInletLossPercent; mawpBox = txtLiquidSystemMAWP; }
                else if (valueBox == txtSteamInletLoss) { percentBox = txtSteamInletLossPercent; mawpBox = txtSteamSystemMAWP; }

                if (double.TryParse(valueBox.Text, out double value) && double.TryParse(mawpBox.Text, out double mawp) && mawp > 0)
                {
                    percentBox.Text = ((value / mawp) * 100.0).ToString("N2");
                }
            }

            // Re-attach event handlers
            txtInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtInletLoss.TextChanged += txtInletLoss_TextChanged;
            txtLiquidInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtLiquidInletLoss.TextChanged += txtInletLoss_TextChanged;
            txtSteamInletLossPercent.TextChanged += txtInletLoss_TextChanged;
            txtSteamInletLoss.TextChanged += txtInletLoss_TextChanged;
        }

        private void ScenarioCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk == null) return;

            // Derive the GroupBox name by stripping phase prefixes (Gas, Liquid, Steam)
            // from the CheckBox name. This allows multiple, phase-specific checkboxes
            // to control a single, shared GroupBox.
            // e.g., "chkLiquidPowerFailure" becomes "groupPowerFailure".
            string chkName = chk.Name;
            string baseName = chkName.Replace("Liquid", "").Replace("Gas", "").Replace("Steam", "");
            string groupBoxName = baseName.Replace("chk", "group");

            Control[] foundControls = this.Controls.Find(groupBoxName, true);
            GroupBox groupBox = foundControls.FirstOrDefault() as GroupBox;

            if (groupBox != null)
            {
                groupBox.Visible = chk.Checked;
            }
        }

        private void chkFireCaseGas_CheckedChanged(object sender, EventArgs e)
        {
            groupFireCaseGas.Visible = chkFireCase.Checked;
            if (chkFireCase.Checked)
            {
                radioSinglePSV.Checked = false;
                radioSinglePSV.Enabled = false;
                radioMultiplePSVs.Checked = true;
            }
            else
            {
                radioSinglePSV.Enabled = true;
            }
        }

        private void chkFireCaseLiquid_CheckedChanged(object sender, EventArgs e)
        {
            groupFireCaseLiquid.Visible = chkLiquidFireCase.Checked;
            if (chkLiquidFireCase.Checked)
            {
                radioLiquidSinglePSV.Checked = false;
                radioLiquidSinglePSV.Enabled = false;
                radioLiquidMultiplePSVs.Checked = true;
            }
            else
            {
                radioLiquidSinglePSV.Enabled = true;
            }
        }

        private void chkFireCaseSteam_CheckedChanged(object sender, EventArgs e)
        {
            groupFireCaseSteam.Visible = chkSteamFireCase.Checked;
            if (chkSteamFireCase.Checked)
            {
                radioSteamSinglePSV.Checked = false;
                radioSteamSinglePSV.Enabled = false;
                radioMultiplePSVs.Checked = true;
            }
            else
            {
                radioSteamSinglePSV.Enabled = true;
            }
        }

        private void FluidSelectionChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null || comboBox.SelectedItem == null) return;

            string selectedFluid = comboBox.SelectedItem.ToString();
            if (MaterialDatabase.Materials.TryGetValue(selectedFluid, out MaterialProperties properties))
            {
                // Update the properties display
                txtMolecularWeight.Text = properties.MolecularWeight.ToString("N2");
                txtCompressibility.Text = properties.Compressibility.ToString("N2");
                txtSpecificHeatRatio.Text = properties.SpecificHeatRatio.ToString("N2");


                txtSpecificGravity.Text = properties.SpecificGravity.ToString("N2");



            }
        }
        private void LiquidFluidSelectionChanged(object sender, EventArgs e)
        {
            if (cmbLiquidFluid.SelectedItem == null) return;

            string selectedFluid = cmbLiquidFluid.SelectedItem.ToString();
            if (MaterialDatabase.Materials.TryGetValue(selectedFluid, out MaterialProperties properties))
            {
                txtLiquidSpecificGravity.Text = properties.SpecificGravity.ToString("N4");
                txtLiquidViscosity.Text = properties.Viscosity.ToString("N6");
            }
        }

        private void SteamFluidSelectionChanged(object sender, EventArgs e)
        {
            if (cmbSteamFluid.SelectedItem == null) return;

            string selectedFluid = cmbSteamFluid.SelectedItem.ToString();
            if (MaterialDatabase.Materials.TryGetValue(selectedFluid, out MaterialProperties properties))
            {
                txtSteamMolecularWeight.Text = properties.MolecularWeight.ToString("N2");
                txtSteamSpecificHeatRatio.Text = properties.SpecificHeatRatio.ToString("N2");
                txtSteamCompressibility.Text = properties.Compressibility.ToString("N2");
            }
        }

        private void BtnCalculateGas_Click(object sender, EventArgs e)
        {
            if (!ValidateGasInputs()) return;

            resultsDataGridViewGas.Rows.Clear();
            var scenarios = GetSelectedScenarios("Gas");

            if (scenarios.Count == 0)
            {
                MessageBox.Show("Please select at least one sizing scenario.", "No Scenarios Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var scenario in scenarios)
            {
                double flowRate = GetScenarioFlowRate(scenario, "Gas");
                double.TryParse(txtSystemMAWP.Text, out double setPressure);
                double overPressure = 0.10 * setPressure; // API 520: 10% for non-fire cases
                if (chkFireCase.Checked)
                {
                    overPressure = 0.21 * setPressure; // API 520: 21% for fire case
                }
                double relievingPressure = setPressure + overPressure;

                var fluid = cmbGasFluid.SelectedItem.ToString();
                var props = MaterialDatabase.Materials[fluid];

                double totalArea = CalculateGasReliefArea(props, flowRate, setPressure, relievingPressure);

                int numberOfValves = 1;
                if (chkFireCase.Checked)
                {
                    numberOfValves = 3;
                }
                else if (radioMultiplePSVs.Checked)
                {
                    numberOfValves = 2;
                }

                double areaPerValve = (numberOfValves > 0) ? totalArea / numberOfValves : totalArea;
                string orificeSize = DetermineOrificeSize(areaPerValve);
                string orificeSelection = (numberOfValves > 1) ? $"{numberOfValves} x {orificeSize}" : orificeSize;

                resultsDataGridViewGas.Rows.Add(
                    scenario,
                    totalArea.ToString("F4"),
                    areaPerValve.ToString("F4"),
                    orificeSelection
                );
            }

            HighlightControllingCase(resultsDataGridViewGas);
        }

        private void HighlightControllingCase(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;

            double maxArea = 0;
            DataGridViewRow controllingRow = null;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value != null && double.TryParse(row.Cells[1].Value.ToString(), out double area))
                {
                    if (area > maxArea)
                    {
                        maxArea = area;
                        controllingRow = row;
                    }
                }
            }

            if (controllingRow != null)
            {
                controllingRow.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }

        private System.Collections.Generic.List<string> GetSelectedScenarios(string tabName)
        {
            var selectedScenarios = new System.Collections.Generic.List<string>();
            GroupBox scenarioGroupBox = null;

            if (tabName == "Gas")
            {
                scenarioGroupBox = groupSizingScenarios;
            }
            else if (tabName == "Liquid")
            {
                scenarioGroupBox = groupLiquidSizingScenarios;
            }
            else if (tabName == "Steam")
            {
                scenarioGroupBox = groupSteamSizingScenarios;
            }

            if (scenarioGroupBox != null)
            {
                foreach (CheckBox chk in scenarioGroupBox.Controls.OfType<CheckBox>())
                {
                    if (chk.Checked)
                    {
                        selectedScenarios.Add(chk.Text);
                    }
                }
            }

            return selectedScenarios;
        }

        private double GetScenarioFlowRate(string scenario, string tabName)
        {
            double baseFlowRate = 0;
            if (tabName == "Gas")
                double.TryParse(txtReqFlowCapacity.Text, out baseFlowRate);
            else if (tabName == "Liquid")
                double.TryParse(txtLiquidReqFlowCapacity.Text, out baseFlowRate);
            else if (tabName == "Steam")
                double.TryParse(txtSteamReqFlowCapacity.Text, out baseFlowRate);


            switch (scenario)
            {
                case "Blocked Outlet":
                    return CalculateBlockedOutletFlowRate(tabName, baseFlowRate);
                case "Fire Case (Pool/Enclosed)":
                    return CalculateFireCaseFlowRate(tabName);
                case "Thermal Relief":
                    return CalculateThermalReliefFlowRate(tabName);
                case "Tube Rupture":
                    return CalculateTubeRuptureFlowRate(tabName);
                case "Runaway Reaction":
                    return CalculateRunawayReactionFlowRate(baseFlowRate);
                case "Control Valve Failure":
                    return GetControlValveFailureFlowRate(tabName);
                case "Power Failure":
                    return CalculatePowerFailureFlowRate(tabName, baseFlowRate);
                case "Hydraulic Hammer/Water Hammer":
                    return CalculateHydraulicHammerFlowRate(tabName, baseFlowRate);
                case "Reflux Failure":
                    return CalculateRefluxFailureFlowRate(tabName, baseFlowRate);
                case "Compressor/Expander Failure":
                    return CalculateCompressorExpanderFailureFlowRate(tabName);
                default:
                    return baseFlowRate;
            }
        }

        private double GetControlValveFailureFlowRate(string tabName)
        {
            var input = new ControlValveInput();
            if (tabName == "Gas")
            {
                double.TryParse(txtCv.Text, out double cv);
                double.TryParse(txtUpstreamPressure.Text, out double p1);
                double.TryParse(txtDownstreamPressure.Text, out double p2);
                var props = MaterialDatabase.Materials[cmbGasFluid.SelectedItem.ToString()];
                input.Cv = cv;
                input.UpstreamPressure = p1;
                input.DownstreamPressure = p2;
                input.FluidPhase = Phase.Gas;
                input.DischargeCoefficient = 0.975;
                input.SpecificGravity = props.SpecificGravity;
                input.VaporPressure = 0;
                input.SpecificHeatRatio = props.SpecificHeatRatio;
                input.Compressibility = props.Compressibility;
                input.MolecularWeight = props.MolecularWeight;
                double.TryParse(txtRelievingTemp.Text, out double temp);
                input.Temperature = temp;
            }
            else if (tabName == "Liquid")
            {
                double.TryParse(txtCv.Text, out double cv);
                double.TryParse(txtUpstreamPressure.Text, out double p1);
                double.TryParse(txtDownstreamPressure.Text, out double p2);
                var props = MaterialDatabase.Materials[cmbLiquidFluid.SelectedItem.ToString()];
                input.Cv = cv;
                input.UpstreamPressure = p1;
                input.DownstreamPressure = p2;
                input.FluidPhase = Phase.Liquid;
                input.DischargeCoefficient = 0.65;
                input.SpecificGravity = props.SpecificGravity;
                input.VaporPressure = props.VaporPressure;
                input.SpecificHeatRatio = 0;
                input.Compressibility = 1;
                input.MolecularWeight = 0;
                input.Temperature = 0;
            }
            else if (tabName == "Steam")
            {
                double.TryParse(txtCv.Text, out double cv);
                double.TryParse(txtUpstreamPressure.Text, out double p1);
                double.TryParse(txtDownstreamPressure.Text, out double p2);
                var props = MaterialDatabase.Materials[cmbSteamFluid.SelectedItem.ToString()];
                input.Cv = cv;
                input.UpstreamPressure = p1;
                input.DownstreamPressure = p2;
                input.FluidPhase = Phase.Steam;
                input.DischargeCoefficient = 0.975;
                input.SpecificGravity = props.SpecificGravity;
                input.VaporPressure = 0;
                input.SpecificHeatRatio = props.SpecificHeatRatio;
                input.Compressibility = props.Compressibility;
                input.MolecularWeight = props.MolecularWeight;
                double.TryParse(txtSteamRelievingTemp.Text, out double temp);
                input.Temperature = temp;
            }
            return CalculateControlValveFailureFlowRate(input);
        }

        private void CmbEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isPump = cmbEquipmentType.SelectedItem?.ToString() == "Pump";
            lblPumpType.Visible = isPump;
            cmbPumpType.Visible = isPump;
            lblPumpCurve.Visible = isPump;
            txtPumpCurve.Visible = isPump;
        }

        /// <summary>
        /// Calculates the required relief rate for a blocked outlet scenario, following API 521 recommendations.
        /// </summary>
        private double CalculateBlockedOutletFlowRate(string tabName, double baseFlowRate)
        {
            string equipmentType = cmbEquipmentType.SelectedItem?.ToString();

            if (equipmentType == "Pump")
            {
                if (!double.TryParse(txtLiquidSystemMAWP.Text, out double setPressure) ||
                    !double.TryParse(txtLiquidSpecificGravity.Text, out double specificGravity))
                {
                    MessageBox.Show("Invalid MAWP or Specific Gravity.", "Input Error");
                    return baseFlowRate;
                }

                string pumpType = cmbPumpType.SelectedItem?.ToString();
                if (pumpType == "Positive Displacement")
                {
                    // For PD pumps, flow is essentially the rated capacity
                    return baseFlowRate;
                }
                else // Centrifugal
                {
                    // API 521 recommends 121% of set pressure for centrifugal pumps
                    double relievingPressure = setPressure * 1.21;
                    double relievingHead = (relievingPressure * 2.31) / specificGravity;

                    string pumpCurveText = txtPumpCurve.Text;
                    if (string.IsNullOrWhiteSpace(pumpCurveText))
                    {
                        MessageBox.Show("Pump curve data is required for centrifugal pumps.", "Input Error");
                        return baseFlowRate;
                    }

                    var curvePoints = new System.Collections.Generic.List<PointF>();
                    try
                    {
                        var points = pumpCurveText.Split(',');
                        foreach (var pointStr in points)
                        {
                            var parts = pointStr.Split('@');
                            if (parts.Length == 2 &&
                                float.TryParse(parts[0], out float head) &&
                                float.TryParse(parts[1], out float flow))
                            {
                                curvePoints.Add(new PointF(flow, head)); // X=Flow, Y=Head
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid Pump Curve format. Use 'Head1@Flow1,Head2@Flow2,...'", "Input Error");
                        return baseFlowRate;
                    }

                    if (curvePoints.Count < 2)
                    {
                        MessageBox.Show("At least 2 pump curve points are required.", "Input Error");
                        return baseFlowRate;
                    }

                    curvePoints = curvePoints.OrderByDescending(p => p.Y).ToList();
                    PointF p1 = curvePoints.FirstOrDefault(p => p.Y >= relievingHead);
                    PointF p2 = curvePoints.LastOrDefault(p => p.Y <= relievingHead);

                    if (p1.IsEmpty || p2.IsEmpty || p1.Y == p2.Y)
                    {
                        MessageBox.Show("Relieving head is outside the pump curve range.", "Warning");
                        return baseFlowRate;
                    }

                    float flowAtRelievingHead = p1.X + (float)(relievingHead - p1.Y) * (p2.X - p1.X) / (p2.Y - p1.Y);
                    return Math.Max(flowAtRelievingHead, 0);
                }
            }
            else if (equipmentType == "Compressor")
            {
                return CalculateCompressorExpanderFailureFlowRate(tabName);
            }
            else if (equipmentType == "Heat Exchanger")
            {
                return baseFlowRate;
            }

            return baseFlowRate;
        }

        /// <summary>
        /// Calculates the relief rate for a tube rupture scenario based on API 521.
        /// </summary>
        private double CalculateTubeRuptureFlowRate(string tabName)
        {
            if (!double.TryParse(txtUpstreamPressureTubeRupture.Text, out double upstreamPressure) || upstreamPressure <= 0)
            {
                MessageBox.Show("Invalid Upstream Pressure for Tube Rupture.", "Input Error");
                return 0;
            }
            if (!double.TryParse(txtDownstreamPressureTubeRupture.Text, out double downstreamPressure) || downstreamPressure < 0)
            {
                MessageBox.Show("Invalid Downstream Pressure for Tube Rupture.", "Input Error");
                return 0;
            }
            if (!double.TryParse(txtTubeInnerDiameter.Text, out double tubeId) || tubeId <= 0)
            {
                MessageBox.Show("Invalid Tube Inner Diameter for Tube Rupture.", "Input Error");
                return 0;
            }

            // Default discharge coefficient to 0.6 per API 521 for sharp-edged orifices if not provided or invalid.
            if (!double.TryParse(txtDischargeCoefficient.Text, out double dischargeCoeff) || dischargeCoeff <= 0)
            {
                dischargeCoeff = 0.6;
            }

            string fluidName = "";
            if (tabName == "Gas") fluidName = cmbGasFluid.SelectedItem?.ToString();
            else if (tabName == "Liquid") fluidName = cmbLiquidFluid.SelectedItem?.ToString();
            else if (tabName == "Steam") fluidName = cmbSteamFluid.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(fluidName) || !MaterialDatabase.Materials.TryGetValue(fluidName, out var props))
            {
                MessageBox.Show("Please select a valid fluid for tube rupture calculation.", "Input Error");
                return 0;
            }

            if (props.Type == Phase.Liquid)
            {
                return CalculateLiquidReliefLoad(props, upstreamPressure, downstreamPressure, tubeId, dischargeCoeff);
            }
            else
            {
                return CalculateGasReliefLoad(props, upstreamPressure, downstreamPressure, tubeId, dischargeCoeff);
            }
        }

        private double CalculateThermalReliefFlowRate(string tabName)
        {
            if (tabName == "Liquid")
            {
                if (!double.TryParse(txtLiquidVesselVolume.Text, out double volume) || volume <= 0)
                {
                    MessageBox.Show("Invalid vessel/line volume.", "Input Error");
                    return 0;
                }

                if (!double.TryParse(txtLiquidTempChange.Text, out double deltaT) || deltaT <= 0)
                {
                    MessageBox.Show("Invalid temperature change.", "Input Error");
                    return 0;
                }

                string fluid = cmbLiquidFluid.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(fluid) || !MaterialDatabase.Materials.TryGetValue(fluid, out var props))
                {
                    MessageBox.Show("Fluid properties not found.", "Input Error");
                    return 0;
                }

                // API 521 recommended formula for thermal relief (simplified)
                double density = props.Density; // kg/m³
                double cp = props.SpecificHeat; // kJ/kg·K

                // Convert volume from ft³ to m³
                double volumeM3 = volume * 0.0283168;

                // Calculate mass
                double mass = volumeM3 * density;

                // Calculate heat input (simplified, assuming it's the energy to heat the liquid)
                double Q_kJ = mass * cp * deltaT; // kJ

                // Assume 1 hour heat-up time (3600 seconds)
                double heatRate_kW = Q_kJ / 3600; // kW (or kJ/s)

                if (!double.TryParse(txtLatentHeatLiquid.Text, out double latentHeat_BTU_lb) || latentHeat_BTU_lb <= 0)
                {
                    MessageBox.Show("Invalid latent heat.", "Input Error");
                    return 0;
                }

                // Convert latent heat from BTU/lb to kJ/kg
                double latentHeat_kJ_kg = latentHeat_BTU_lb * 2.326;

                // Calculate relief rate in kg/s
                double reliefRate_kg_s = heatRate_kW / latentHeat_kJ_kg;

                // Convert mass flow rate (kg/s) to volumetric flow rate (GPM)
                if (density == 0) return 0;
                double reliefRate_m3_s = reliefRate_kg_s / density;
                double reliefRate_gpm = reliefRate_m3_s * 15850.3;

                return reliefRate_gpm;
            }
            else if (tabName == "Gas")
            {
                double volume = 0;
                double deltaT = 0;

                if (!double.TryParse(txtVesselVolume.Text, out volume) || volume <= 0)
                {
                    MessageBox.Show("Invalid vessel/line volume.", "Input Error");
                    return 0;
                }
                if (!double.TryParse(txtTemperatureChange.Text, out deltaT) || deltaT <= 0)
                {
                    MessageBox.Show("Invalid temperature change.", "Input Error");
                    return 0;
                }

                // Gas thermal expansion (pressure-based)
                if (!double.TryParse(txtInitialPressure.Text, out double p1) || p1 <= 0)
                {
                    MessageBox.Show("Invalid initial pressure.", "Input Error");
                    return 0;
                }

                if (!double.TryParse(txtReliefPressure.Text, out double p2) || p2 <= p1)
                {
                    MessageBox.Show("Invalid relief pressure.", "Input Error");
                    return 0;
                }

                double timeInHours = 1.0; // Default: 1-hour heat-up
                double compressibilityFactor = 1.0; // Default for ideal gas

                // Ideal gas law approximation
                return (p2 - p1) / p1 * (volume / timeInHours) * compressibilityFactor;
            }

            MessageBox.Show("Unsupported fluid type for thermal relief.", "Error");
            return 0;
        }

        private double CalculateRunawayReactionFlowRate(double baseFlowRate)
        {
            return baseFlowRate * 4.0; // Simplified
        }

        public double CalculateControlValveFailureFlowRate(ControlValveInput input)
        {
            switch (input.FluidPhase)
            {
                case Phase.Liquid:
                    return CalculateLiquidFlow(input);
                case Phase.Gas:
                    return CalculateGasFlow(input);
                case Phase.Steam:
                    return CalculateSteamFlow(input);
                default:
                    throw new ArgumentException("Invalid fluid phase.");
            }
        }

        private double CalculateLiquidFlow(ControlValveInput input)
        {
            if (input.DownstreamPressure < input.VaporPressure)
                throw new InvalidOperationException("Flashing occurs. Two-phase flow correction needed.");

            return input.Cv * Math.Sqrt((input.UpstreamPressure - input.DownstreamPressure) / input.SpecificGravity);
        }

        private double CalculateGasFlow(ControlValveInput input)
        {
            double criticalRatio = Math.Pow(2 / (input.SpecificHeatRatio + 1), input.SpecificHeatRatio / (input.SpecificHeatRatio - 1));
            bool isChoked = (input.DownstreamPressure / input.UpstreamPressure) <= criticalRatio;

            if (isChoked)
            {
                double chokedFactor = Math.Sin(3417 / (input.Cv / input.DischargeCoefficient)
                                    * Math.Sqrt((input.UpstreamPressure - input.DownstreamPressure) / input.UpstreamPressure))
                                    * (Math.PI / 180); // Degrees to radians
                return input.Cv * input.UpstreamPressure * chokedFactor
                       * Math.Sqrt(1 / (input.SpecificGravity * input.Temperature * input.Compressibility));
            }
            else
            {
                return input.Cv * Math.Sqrt(
                    (Math.Pow(input.UpstreamPressure, 2) - Math.Pow(input.DownstreamPressure, 2))
                    / (input.SpecificGravity * input.Temperature * input.Compressibility)
                );
            }
        }

        private double CalculateSteamFlow(ControlValveInput input)
        {
            // Approximate steam as gas with k=1.3
            input.SpecificHeatRatio = 1.3;
            input.Compressibility = 1.0;
            return CalculateGasFlow(input);
        }

        /// <summary>
        /// Calculates the relief rate for a power failure scenario. Currently a simplified placeholder.
        /// </summary>
        private double CalculatePowerFailureFlowRate(string tabName, double baseFlowRate)
        {
            if (tabName != "Liquid")
            {
                return baseFlowRate;
            }

            double pumpHead = 0;
            double specificGravity = 0;

            double.TryParse(txtPumpHead.Text, out pumpHead);
            double.TryParse(txtLiquidSpecificGravity.Text, out specificGravity);

            // Simplified calculation for flow from a pump based on head
            // Q = C * A * sqrt(2 * g * h)
            // This is highly simplified and assumes a constant flow coefficient and area.
            double flowCoefficient = 0.61; // Placeholder
            double area = 1.0; // Placeholder for pipe area in ft^2
            double g = 32.2; // ft/s^2
            double flowRate = flowCoefficient * area * Math.Sqrt(2 * g * pumpHead) * 7.48052 * 60; // Convert cfs to gpm
            return flowRate;
        }

        /// <summary>
        /// Calculates the relief rate for a hydraulic hammer scenario. Currently a simplified placeholder.
        /// </summary>
        private double CalculateHydraulicHammerFlowRate(string tabName, double baseFlowRate)
        {
            if (tabName != "Liquid")
            {
                return baseFlowRate;
            }

            double valveCloseTime = 0;
            double initialVelocity = 0; // This would need to be an input
            double pipeLength = 0; // This would need to be an input
            double waveSpeed = 0; // This would need to be an input

            double.TryParse(txtValveCloseTime.Text, out valveCloseTime);
            // For simplicity, we'll use placeholders for the other inputs
            initialVelocity = 10; // ft/s
            pipeLength = 1000; // ft
            waveSpeed = 4000; // ft/s

            // Joukowsky's equation: P = rho * c * delta_v
            // This is a very simplified approach.
            double pressureSpike = (initialVelocity * waveSpeed) / (32.2 * 144); // psi
            // A real calculation would then determine the flow rate based on this pressure spike.
            // For now, we'll return a value proportional to the pressure spike.
            return pressureSpike * 10; // Placeholder
        }

        /// <summary>
        /// Calculates the relief rate for a reflux failure scenario. Currently a simplified placeholder.
        /// </summary>
        private double CalculateRefluxFailureFlowRate(string tabName, double baseFlowRate)
        {
            if (tabName != "Liquid" && tabName != "Steam")
            {
                return baseFlowRate;
            }

            double refluxRatio = 0;
            double boilupRate = 0; // This would need to be an input

            double.TryParse(txtRefluxRatio.Text, out refluxRatio);
            // For simplicity, we'll use a placeholder for the boil-up rate
            boilupRate = 1000; // lb/hr

            // Simplified calculation for reflux failure
            // In a total reflux failure, the overhead vapor rate equals the boil-up rate.
            return boilupRate * (1 + refluxRatio);
        }

        private double CalculateCompressorExpanderFailureFlowRate(string tabName)
        {
            double ratedCapacity = 0;

            if (tabName == "Gas")
            {
                double.TryParse(txtCompressorCapacity.Text, out ratedCapacity);
            }

            // For a blocked outlet on a positive displacement compressor,
            // the relief valve must be sized for the rated capacity of the compressor.
            return ratedCapacity;
        }

        /// <summary>
        /// Calculates the required relief rate for a fire case scenario based on API 521.
        /// This method handles wetted-surface fire cases for Gas, Liquid, and Steam.
        /// </summary>
        /// <param name="tabName">The name of the active tab ("Gas", "Liquid", or "Steam").</param>
        /// <returns>The required flow rate in lb/hr.</returns>
        private double CalculateFireCaseFlowRate(string tabName)
        {
            double envFactor = 1.0;
            double latentHeat = 0;
            double wettedArea = 0;

            bool isWetted = false;

            if (tabName == "Gas")
            {
                isWetted = radioWettedGas.Checked;
                if (isWetted)
                {
                    if (!double.TryParse(txtEnvFactorWettedGas.Text, out envFactor)) envFactor = 1.0;
                    if (!double.TryParse(txtLatentHeatGas.Text, out latentHeat) || latentHeat <= 0)
                    {
                        MessageBox.Show("Invalid Latent Heat value for Gas fire case.", "Input Error");
                        return 0;
                    }
                    if (!double.TryParse(txtWettedAreaGas.Text, out wettedArea) || wettedArea <= 0)
                    {
                        MessageBox.Show("Invalid Wetted Area value for Gas fire case.", "Input Error");
                        return 0;
                    }
                }
            }
            else if (tabName == "Liquid")
            {
                isWetted = radioWettedLiquid.Checked;
                if (isWetted)
                {
                    if (!double.TryParse(txtEnvFactorWettedLiquid.Text, out envFactor)) envFactor = 1.0;
                    if (!double.TryParse(txtLatentHeatLiquid.Text, out latentHeat) || latentHeat <= 0)
                    {
                        MessageBox.Show("Invalid Latent Heat value for Liquid fire case.", "Input Error");
                        return 0;
                    }
                    if (!double.TryParse(txtWettedAreaLiquid.Text, out wettedArea) || wettedArea <= 0)
                    {
                        MessageBox.Show("Invalid Wetted Area value for Liquid fire case.", "Input Error");
                        return 0;
                    }
                }
            }
            else if (tabName == "Steam")
            {
                isWetted = radioWettedSteam.Checked;
                if (isWetted)
                {
                    if (!double.TryParse(txtEnvFactorWettedSteam.Text, out envFactor)) envFactor = 1.0;
                    if (!double.TryParse(txtLatentHeatSteam.Text, out latentHeat) || latentHeat <= 0)
                    {
                        MessageBox.Show("Invalid Latent Heat value for Steam fire case.", "Input Error");
                        return 0;
                    }
                    if (!double.TryParse(txtWettedAreaSteam.Text, out wettedArea) || wettedArea <= 0)
                    {
                        MessageBox.Show("Invalid Wetted Area value for Steam fire case.", "Input Error");
                        return 0;
                    }
                }
            }

            if (!isWetted)
            {
                // Unwetted fire case calculation is complex and not implemented.
                // For liquids, this is typically 0. For gases, it depends on vessel wall temperature.
                // Returning 0 is a safe placeholder.
                return 0;
            }

            // --- API 521 Wetted Surface Fire Case Calculation ---

            // 1. Convert inputs to SI units for calculation.
            // Wetted Area from ft^2 to m^2
            double wettedAreaM2 = wettedArea * 0.092903;
            // Latent Heat from BTU/lb to kJ/kg
            double latentHeatKjKg = latentHeat * 2.326;

            // 2. Calculate heat absorption (Q) in kW using API 521 formula (SI units).
            // Q = 43.2 * F * A^0.82
            double heatAbsorptionKw = 43.2 * envFactor * Math.Pow(wettedAreaM2, 0.82);

            // 3. Calculate relief rate (W) in kg/s.
            // W (kg/s) = Q (kW) / Latent Heat (kJ/kg)
            if (latentHeatKjKg == 0) return 0; // Avoid division by zero
            double reliefRateKgS = heatAbsorptionKw / latentHeatKjKg;

            // 4. Convert result back to Imperial units (lb/hr) for consistency with the application.
            // 1 kg/s = 7936.64 lb/hr
            double reliefRateLbHr = reliefRateKgS * 7936.64;

            return reliefRateLbHr;
        }

        private double CalculateFireCaseArea(string tabName)
        {
            if (tabName == "Gas")
            {
                if (radioWettedGas.Checked)
                {
                    double.TryParse(txtEnvFactorWettedGas.Text, out double envFactor);
                    double.TryParse(txtLatentHeatGas.Text, out double latentHeat);
                    double.TryParse(txtWettedAreaGas.Text, out double wettedArea);
                    // API 521 Section 5.15.2.2 - Wetted surface fire case
                    double Q = 21000 * envFactor * Math.Pow(wettedArea, 0.82);
                    double W = Q / latentHeat;
                    // Now calculate area from W (mass flow rate)
                    return W / 1000; // Placeholder
                }
                else // Unwetted
                {
                    double.TryParse(txtEnvFactorUnwettedGas.Text, out double envFactor);
                    double.TryParse(txtFireSizingFactorGas.Text, out double fireSizingFactor);
                    double.TryParse(txtSurfaceAreaUnwettedGas.Text, out double surfaceArea);
                    // This is a simplified approach. A real calculation is more complex.
                    return envFactor * fireSizingFactor * surfaceArea;
                }
            }
            else if (tabName == "Liquid")
            {
                if (radioWettedLiquid.Checked)
                {
                    double.TryParse(txtEnvFactorWettedLiquid.Text, out double envFactor);
                    double.TryParse(txtLatentHeatLiquid.Text, out double latentHeat);
                    double.TryParse(txtWettedAreaLiquid.Text, out double wettedArea);
                    // API 521 Section 5.15.2.2 - Wetted surface fire case
                    double Q = 21000 * envFactor * Math.Pow(wettedArea, 0.82);
                    double W = Q / latentHeat;
                    // This is a simplified placeholder. A real calculation would convert mass flow 'W'
                    // to a volumetric flow rate and then use the liquid sizing equation.
                    return W / 1000; // Placeholder
                }
                else // Unwetted
                {
                    // Fire on an unwetted surface is less common for liquids, but providing a placeholder.
                    double.TryParse(txtEnvFactorUnwettedLiquid.Text, out double envFactor);
                    double.TryParse(txtFireSizingFactorLiquid.Text, out double fireSizingFactor);
                    double.TryParse(txtSurfaceAreaUnwettedLiquid.Text, out double surfaceArea);
                    return envFactor * fireSizingFactor * surfaceArea;
                }
            }
            else if (tabName == "Steam")
            {
                if (radioWettedSteam.Checked)
                {
                    double.TryParse(txtEnvFactorWettedSteam.Text, out double envFactor);
                    double.TryParse(txtLatentHeatSteam.Text, out double latentHeat);
                    double.TryParse(txtWettedAreaSteam.Text, out double wettedArea);
                    // API 521 Section 5.15.2.2 - Wetted surface fire case
                    double Q = 21000 * envFactor * Math.Pow(wettedArea, 0.82);
                    double W = Q / latentHeat;
                    // Now calculate area from W (mass flow rate)
                    return W / 1000; // Placeholder
                }
                else // Unwetted
                {
                    double.TryParse(txtEnvFactorUnwettedSteam.Text, out double envFactor);
                    double.TryParse(txtFireSizingFactorSteam.Text, out double fireSizingFactor);
                    double.TryParse(txtSurfaceAreaUnwettedSteam.Text, out double surfaceArea);
                    // This is a simplified approach. A real calculation is more complex.
                    return envFactor * fireSizingFactor * surfaceArea;
                }
            }
            return 0;
        }

        private bool ValidateGasInputs()
        {
            if (cmbGasFluid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fluid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtSystemMAWP.Text, out _))
            {
                MessageBox.Show("Invalid System MAWP value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtRelievingTemp.Text, out _))
            {
                MessageBox.Show("Invalid Relieving Temperature value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!chkFireCase.Checked && !double.TryParse(txtReqFlowCapacity.Text, out _))
            {
                MessageBox.Show("Invalid flow rate value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chkFireCase.Checked)
            {
                if (radioWettedGas.Checked)
                {
                    if (!double.TryParse(txtEnvFactorWettedGas.Text, out _) || !double.TryParse(txtLatentHeatGas.Text, out _) || !double.TryParse(txtWettedAreaGas.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for wetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else // Unwetted
                {
                    if (!double.TryParse(txtEnvFactorUnwettedGas.Text, out _) || !double.TryParse(txtFireSizingFactorGas.Text, out _) || !double.TryParse(txtSurfaceAreaUnwettedGas.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for unwetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            return true;
        }

        private double CalculateGasReliefArea(MaterialProperties props, double flowRate, double setPressure, double relievingPressure)
        {
            double.TryParse(txtRelievingTemp.Text, out double temperature);
            double molecularWeight = props.MolecularWeight;
            double heatRatio = props.SpecificHeatRatio;
            double compressibility = props.Compressibility;

            double kb = GetBackpressureCorrectionFactor("Gas");
            double rCritical = Math.Pow(2 / (heatRatio + 1), heatRatio / (heatRatio - 1));

            // API 520 Part I Eq. 3, adapted for the available inputs
            double C = 315 * kb * 0.975; // Combining constants
            double area = (flowRate / (C * relievingPressure * rCritical)) *
                       Math.Sqrt((compressibility * (temperature + 459.67) * molecularWeight) / heatRatio);

            return area;
        }

        private double GetBackpressureCorrectionFactor(string tabName)
        {
            // This is a simplified placeholder. A real implementation would involve
            // complex calculations based on the type of valve and backpressure.
            // For now, returning 1.0, which assumes no backpressure effects.
            return 1.0;
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

            return "T+";
        }






        // Add similar methods for other tabs:
        private void BtnCalculateLiquid_Click(object sender, EventArgs e)
        {
            if (!ValidateLiquidInputs()) return;

            resultsDataGridViewLiquid.Rows.Clear();
            var scenarios = GetSelectedScenarios("Liquid");

            if (scenarios.Count == 0)
            {
                MessageBox.Show("Please select at least one sizing scenario.", "No Scenarios Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var scenario in scenarios)
            {
                double flowRate = GetScenarioFlowRate(scenario, "Liquid");
                double.TryParse(txtLiquidSystemMAWP.Text, out double setPressure);
                double overPressure = 0.10 * setPressure; // API 520: 10% for non-fire cases
                if (chkLiquidFireCase.Checked)
                {
                    overPressure = 0.21 * setPressure; // API 520: 21% for fire case
                }
                double relievingPressure = setPressure + overPressure;

                var fluid = cmbLiquidFluid.SelectedItem.ToString();
                var props = MaterialDatabase.Materials[fluid];

                double totalArea = CalculateLiquidReliefArea(props, flowRate, setPressure, relievingPressure);

                int numberOfValves = 1;
                if (chkLiquidFireCase.Checked)
                {
                    numberOfValves = 3;
                }
                else if (radioLiquidMultiplePSVs.Checked)
                {
                    numberOfValves = 2;
                }

                double areaPerValve = (numberOfValves > 0) ? totalArea / numberOfValves : totalArea;
                string orificeSize = DetermineOrificeSize(areaPerValve);
                string orificeSelection = (numberOfValves > 1) ? $"{numberOfValves} x {orificeSize}" : orificeSize;

                resultsDataGridViewLiquid.Rows.Add(
                    scenario,
                    totalArea.ToString("F4"),
                    areaPerValve.ToString("F4"),
                    orificeSelection
                );
            }

            HighlightControllingCase(resultsDataGridViewLiquid);
        }

        private bool ValidateLiquidInputs()
        {
            if (cmbLiquidFluid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fluid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtLiquidSystemMAWP.Text, out _))
            {
                MessageBox.Show("Invalid System MAWP value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!chkLiquidFireCase.Checked && !double.TryParse(txtLiquidReqFlowCapacity.Text, out _))
            {
                MessageBox.Show("Invalid flow rate value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtLiquidSpecificGravity.Text, out _))
            {
                MessageBox.Show("Invalid specific gravity value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtLiquidViscosity.Text, out _))
            {
                MessageBox.Show("Invalid viscosity value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtLiquidRelievingTemp.Text, out _))
            {
                MessageBox.Show("Invalid Relieving Temperature value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chkLiquidFireCase.Checked)
            {
                if (radioWettedLiquid.Checked)
                {
                    if (!double.TryParse(txtEnvFactorWettedLiquid.Text, out _) || !double.TryParse(txtLatentHeatLiquid.Text, out _) || !double.TryParse(txtWettedAreaLiquid.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for wetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else // Unwetted
                {
                    if (!double.TryParse(txtEnvFactorUnwettedLiquid.Text, out _) || !double.TryParse(txtFireSizingFactorLiquid.Text, out _) || !double.TryParse(txtSurfaceAreaUnwettedLiquid.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for unwetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private double CalculateLiquidReliefArea(MaterialProperties props, double flowRate, double setPressure, double relievingPressure)
        {
            double.TryParse(txtLiquidSpecificGravity.Text, out double specificGravity);
            double.TryParse(txtLiquidViscosity.Text, out double viscosity);


            // API 520 Part I Eq. 7 for liquid relief
            double Kw = 1.0; // Backpressure correction factor, simplified.
            double Kd = 0.65; // Coefficient of discharge for liquids, typical value.
            double A = (flowRate / (27.2 * Kd)) * Math.Sqrt(specificGravity / (relievingPressure - setPressure));
            double Re = (28200 * flowRate) / (viscosity * Math.Sqrt(A));

            double Kv = 1.0;
            if (Re < 60000)
            {
                Kv = 0.9935 + (2.878 / Math.Pow(Re, 0.5)) + (342.75 / Math.Pow(Re, 1.5));
            }


            double deltaP = relievingPressure - setPressure;
            if (deltaP <= 0)
            {
                deltaP = 0.1 * setPressure; // Assume 10% overpressure if not specified.
            }

            double area = (flowRate / (38 * Kd * Kw * Kv)) * Math.Sqrt(specificGravity / deltaP);
            return area;
        }

        private double CalculateSteamReliefArea(MaterialProperties props, double flowRate, double setPressure, double relievingPressure)
        {
            // Using Napier's equation for steam relief area
            double ksh = 1.0; // Superheat correction factor, placeholder
            double P1 = relievingPressure + 14.7; // Absolute pressure in psia
            double area = (flowRate * 51.5) / (P1 * ksh);
            return area;
        }

        private void BtnCalculateSteam_Click(object sender, EventArgs e)
        {
            if (!ValidateSteamInputs()) return;

            resultsDataGridViewSteam.Rows.Clear();
            var scenarios = GetSelectedScenarios("Steam");

            if (scenarios.Count == 0)
            {
                MessageBox.Show("Please select at least one sizing scenario.", "No Scenarios Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var scenario in scenarios)
            {
                double flowRate = GetScenarioFlowRate(scenario, "Steam");
                double.TryParse(txtSteamSystemMAWP.Text, out double setPressure);
                double overPressure = 0.10 * setPressure; // API 520: 10% for non-fire cases
                if (chkSteamFireCase.Checked)
                {
                    overPressure = 0.21 * setPressure; // API 520: 21% for fire case
                }
                double relievingPressure = setPressure + overPressure;

                var fluid = cmbSteamFluid.SelectedItem.ToString();
                var props = MaterialDatabase.Materials[fluid];

                double totalArea = CalculateSteamReliefArea(props, flowRate, setPressure, relievingPressure);

                int numberOfValves = 1;
                if (chkSteamFireCase.Checked)
                {
                    numberOfValves = 3;
                }
                else if (radioSteamMultiplePSVs.Checked)
                {
                    numberOfValves = 2;
                }

                double areaPerValve = (numberOfValves > 0) ? totalArea / numberOfValves : totalArea;
                string orificeSize = DetermineOrificeSize(areaPerValve);
                string orificeSelection = (numberOfValves > 1) ? $"{numberOfValves} x {orificeSize}" : orificeSize;

                resultsDataGridViewSteam.Rows.Add(
                    scenario,
                    totalArea.ToString("F4"),
                    areaPerValve.ToString("F4"),
                    orificeSelection
                );
            }

            HighlightControllingCase(resultsDataGridViewSteam);
        }

        private bool ValidateSteamInputs()
        {
            if (cmbSteamFluid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fluid.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtSteamSystemMAWP.Text, out _))
            {
                MessageBox.Show("Invalid System MAWP value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!double.TryParse(txtSteamRelievingTemp.Text, out _))
            {
                MessageBox.Show("Invalid Relieving Temperature value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!chkSteamFireCase.Checked && !double.TryParse(txtSteamReqFlowCapacity.Text, out _))
            {
                MessageBox.Show("Invalid flow rate value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chkSteamFireCase.Checked)
            {
                if (radioWettedSteam.Checked)
                {
                    if (!double.TryParse(txtEnvFactorWettedSteam.Text, out _) || !double.TryParse(txtLatentHeatSteam.Text, out _) || !double.TryParse(txtWettedAreaSteam.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for wetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else // Unwetted
                {
                    if (!double.TryParse(txtEnvFactorUnwettedSteam.Text, out _) || !double.TryParse(txtFireSizingFactorSteam.Text, out _) || !double.TryParse(txtSurfaceAreaUnwettedSteam.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for unwetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private void BtnCalculateTwoPhase_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTwoPhaseInputs())
                    return;

                // NOTE: Two-phase flow calculation is complex.
                // This is a highly simplified placeholder.
                double.TryParse(txtTwoPhaseReqFlowCapacity.Text, out double flowRate);
                double area = flowRate * 0.0005; // Placeholder calculation

                lblTwoPhaseResult.Text = $"PSV Requirements (Simplified):\n" +
                                   $"Minimum Orifice Area: {area:F4} in²\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Calculation Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateTwoPhaseInputs()
        {
            if (cmbTwoPhaseFluid.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a fluid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!chkSteamFireCase.Checked && !double.TryParse(txtSteamReqFlowCapacity.Text, out _))
            {
                MessageBox.Show("Invalid flow rate value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chkSteamFireCase.Checked)
            {
                if (radioWettedSteam.Checked)
                {
                    if (!double.TryParse(txtEnvFactorWettedSteam.Text, out _) || !double.TryParse(txtLatentHeatSteam.Text, out _) || !double.TryParse(txtWettedAreaSteam.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for wetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else // Unwetted
                {
                    if (!double.TryParse(txtEnvFactorUnwettedSteam.Text, out _) || !double.TryParse(txtFireSizingFactorSteam.Text, out _) || !double.TryParse(txtSurfaceAreaUnwettedSteam.Text, out _))
                    {
                        MessageBox.Show("Invalid fire case input for unwetted surface.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            return true;
        }

        private double CalculateLiquidReliefLoad(MaterialProperties fluid, double upstreamPressure, double downstreamPressure, double tubeInnerDiameter, double dischargeCoefficient)
        {
            // Using API 521 for liquid flow through a rupture
            double area = Math.PI * Math.Pow(tubeInnerDiameter / 2, 2);
            double deltaP = upstreamPressure - downstreamPressure;
            if (deltaP <= 0) return 0;

            // Flow in gpm
            double flow = 27.2 * dischargeCoefficient * area * Math.Sqrt(deltaP / fluid.SpecificGravity);
            return flow;
        }

        private double CalculateGasReliefLoad(MaterialProperties fluid, double upstreamPressure, double downstreamPressure, double tubeInnerDiameter, double dischargeCoefficient)
        {
            // Using API 521 for gas flow through a rupture
            double pressureRatio = downstreamPressure / upstreamPressure;
            double criticalPressureRatio = Math.Pow(2 / (fluid.SpecificHeatRatio + 1), fluid.SpecificHeatRatio / (fluid.SpecificHeatRatio - 1));

            if (pressureRatio > criticalPressureRatio)
            {
                // Subsonic flow
                return SubsonicFlow(fluid, pressureRatio, upstreamPressure, tubeInnerDiameter, dischargeCoefficient);
            }
            else
            {
                // Sonic (choked) flow
                return SonicFlow(fluid, upstreamPressure, tubeInnerDiameter, dischargeCoefficient);
            }
        }

        private double SonicFlow(MaterialProperties fluid, double upstreamPressure, double tubeInnerDiameter, double dischargeCoefficient)
        {
            double area = Math.PI * Math.Pow(tubeInnerDiameter / 2, 2);
            double C = 520 * dischargeCoefficient * 0.975; // API 520 C constant
            double T = 520; // Assume standard temp for simplicity, should be relieving temp
            double Z = fluid.Compressibility;
            double M = fluid.MolecularWeight;
            double k = fluid.SpecificHeatRatio;

            double flow = C * area * upstreamPressure * Math.Sqrt((k * M) / (T * Z)) * Math.Pow(2 / (k + 1), (k + 1) / (2 * (k - 1)));
            return flow; // Flow in scfh
        }

        private double SubsonicFlow(MaterialProperties fluid, double pressureRatio, double upstreamPressure, double tubeInnerDiameter, double dischargeCoefficient)
        {
            double area = Math.PI * Math.Pow(tubeInnerDiameter / 2, 2);
            double C = 520 * dischargeCoefficient * 0.975; // API 520 C constant
            double T = 520; // Assume standard temp
            double Z = fluid.Compressibility;
            double M = fluid.MolecularWeight;
            double k = fluid.SpecificHeatRatio;

            double flow = C * area * upstreamPressure * Math.Sqrt(((2 * k) / (k - 1)) * (M / (T * Z)) * (Math.Pow(pressureRatio, 2 / k) - Math.Pow(pressureRatio, (k + 1) / k)));
            return flow; // Flow in scfh
        }
    }

    public class ControlValveInput
    {
        public double Cv { get; set; }
        public double UpstreamPressure { get; set; }
        public double DownstreamPressure { get; set; }
        public Phase FluidPhase { get; set; }
        public double DischargeCoefficient { get; set; }
        public double SpecificGravity { get; set; }
        public double VaporPressure { get; set; }
        public double SpecificHeatRatio { get; set; }
        public double Compressibility { get; set; }
        public double MolecularWeight { get; set; }
        public double Temperature { get; set; }
    }
}
