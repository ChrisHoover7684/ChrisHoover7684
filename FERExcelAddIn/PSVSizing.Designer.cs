namespace FERExcelAddIn
{
    partial class PSVSizing
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbTwoPhaseFluid = new System.Windows.Forms.ComboBox();
            this.txtTwoPhaseReqFlowCapacity = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.btnCalculateTwoPhase = new System.Windows.Forms.Button();
            this.lblTwoPhaseResult = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupSteamFluidProperties = new System.Windows.Forms.GroupBox();
            this.txtSteamMolecularWeight = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txtSteamCompressibility = new System.Windows.Forms.TextBox();
            this.txtSteamSpecificHeatRatio = new System.Windows.Forms.TextBox();
            this.cmbSteamFluid = new System.Windows.Forms.ComboBox();
            this.groupSteamTemperatures = new System.Windows.Forms.GroupBox();
            this.txtSteamNormalInletTemp = new System.Windows.Forms.TextBox();
            this.txtSteamOperatingTemp = new System.Windows.Forms.TextBox();
            this.txtSteamRelievingTemp = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.groupSteamPSVConfig = new System.Windows.Forms.GroupBox();
            this.chkSteamFireCase = new System.Windows.Forms.CheckBox();
            this.radioSteamMultiplePSVs = new System.Windows.Forms.RadioButton();
            this.radioSteamSinglePSV = new System.Windows.Forms.RadioButton();
            this.groupSteamSizingScenarios = new System.Windows.Forms.GroupBox();
            this.chkSteamTubeRupture = new System.Windows.Forms.CheckBox();
            this.chkSteamThermalRelief = new System.Windows.Forms.CheckBox();
            this.chkSteamRunawayReaction = new System.Windows.Forms.CheckBox();
            this.chkSteamControlValveFailure = new System.Windows.Forms.CheckBox();
            this.chkSteamBlockedOutlet = new System.Windows.Forms.CheckBox();
            this.chkSteamPowerFailure = new System.Windows.Forms.CheckBox();
            this.chkSteamHydraulicHammer = new System.Windows.Forms.CheckBox();
            this.chkSteamRefluxFailure = new System.Windows.Forms.CheckBox();
            this.chkSteamRuptureDisc = new System.Windows.Forms.CheckBox();
            this.txtSteamReqFlowCapacity = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.lblSteamResult = new System.Windows.Forms.Label();
            this.groupSteamPressures = new System.Windows.Forms.GroupBox();
            this.groupSteamBackPressure = new System.Windows.Forms.GroupBox();
            this.txtSteamInletLoss = new System.Windows.Forms.TextBox();
            this.txtSteamInletLossPercent = new System.Windows.Forms.TextBox();
            this.txtSteamTotalBackPressure = new System.Windows.Forms.TextBox();
            this.txtSteamVariableSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtSteamConstantSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtSteamBuiltUpBP = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.lblSteamInletLossPsig = new System.Windows.Forms.Label();
            this.txtSteamOperatingPressure = new System.Windows.Forms.TextBox();
            this.txtSteamSystemMAWP = new System.Windows.Forms.TextBox();
            this.txtSteamAtmPressure = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.btnCalculateSteam = new System.Windows.Forms.Button();
            this.resultsDataGridViewSteam = new System.Windows.Forms.DataGridView();
            this.colSteamSizingScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSteamTotalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSteamAreaPerValve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSteamSelectedOrifice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupFireCaseSteam = new System.Windows.Forms.GroupBox();
            this.radioWettedSteam = new System.Windows.Forms.RadioButton();
            this.radioUnwettedSteam = new System.Windows.Forms.RadioButton();
            this.lblEnvFactorWettedSteam = new System.Windows.Forms.Label();
            this.txtEnvFactorWettedSteam = new System.Windows.Forms.TextBox();
            this.lblLatentHeatSteam = new System.Windows.Forms.Label();
            this.txtLatentHeatSteam = new System.Windows.Forms.TextBox();
            this.lblWettedAreaSteam = new System.Windows.Forms.Label();
            this.txtWettedAreaSteam = new System.Windows.Forms.TextBox();
            this.lblEnvFactorUnwettedSteam = new System.Windows.Forms.Label();
            this.txtEnvFactorUnwettedSteam = new System.Windows.Forms.TextBox();
            this.lblFireSizingFactorSteam = new System.Windows.Forms.Label();
            this.txtFireSizingFactorSteam = new System.Windows.Forms.TextBox();
            this.lblSurfaceAreaUnwettedSteam = new System.Windows.Forms.Label();
            this.txtSurfaceAreaUnwettedSteam = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.groupControlValveFailure = new System.Windows.Forms.GroupBox();
            this.txtCv = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.lblUpstreamPressure = new System.Windows.Forms.Label();
            this.txtUpstreamPressure = new System.Windows.Forms.TextBox();
            this.lblDownstreamPressure = new System.Windows.Forms.Label();
            this.txtDownstreamPressure = new System.Windows.Forms.TextBox();
            this.groupPowerFailure = new System.Windows.Forms.GroupBox();
            this.txtPumpHead = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.groupHydraulicHammer = new System.Windows.Forms.GroupBox();
            this.txtValveCloseTime = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.groupRefluxFailure = new System.Windows.Forms.GroupBox();
            this.txtRefluxRatio = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.lblBoilupRate = new System.Windows.Forms.Label();
            this.txtBoilupRate = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupLiquidFluidProperties = new System.Windows.Forms.GroupBox();
            this.txtLiquidVesselVolume = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.txtLiquidTempChange = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.txtLiquidPumpCurve = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtLiquidViscosity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLiquidSpecificGravity = new System.Windows.Forms.TextBox();
            this.cmbLiquidFluid = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupLiquidTemperatures = new System.Windows.Forms.GroupBox();
            this.txtLiquidNormalInletTemp = new System.Windows.Forms.TextBox();
            this.txtLiquidOperatingTemp = new System.Windows.Forms.TextBox();
            this.txtLiquidRelievingTemp = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.groupLiquidPSVConfig = new System.Windows.Forms.GroupBox();
            this.chkLiquidFireCase = new System.Windows.Forms.CheckBox();
            this.radioLiquidMultiplePSVs = new System.Windows.Forms.RadioButton();
            this.radioLiquidSinglePSV = new System.Windows.Forms.RadioButton();
            this.groupLiquidSizingScenarios = new System.Windows.Forms.GroupBox();
            this.chkLiquidTubeRupture = new System.Windows.Forms.CheckBox();
            this.chkLiquidThermalRelief = new System.Windows.Forms.CheckBox();
            this.chkLiquidRunawayReaction = new System.Windows.Forms.CheckBox();
            this.chkLiquidControlValveFailure = new System.Windows.Forms.CheckBox();
            this.chkLiquidBlockedOutlet = new System.Windows.Forms.CheckBox();
            this.chkLiquidPowerFailure = new System.Windows.Forms.CheckBox();
            this.chkLiquidHydraulicHammer = new System.Windows.Forms.CheckBox();
            this.chkLiquidRefluxFailure = new System.Windows.Forms.CheckBox();
            this.chkLiquidRuptureDisc = new System.Windows.Forms.CheckBox();
            this.txtLiquidReqFlowCapacity = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupLiquidPressures = new System.Windows.Forms.GroupBox();
            this.groupLiquidBackPressure = new System.Windows.Forms.GroupBox();
            this.txtLiquidInletLoss = new System.Windows.Forms.TextBox();
            this.txtLiquidInletLossPercent = new System.Windows.Forms.TextBox();
            this.txtLiquidTotalBackPressure = new System.Windows.Forms.TextBox();
            this.txtLiquidVariableSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtLiquidConstantSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtLiquidBuiltUpBP = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.lblLiquidInletLossPsig = new System.Windows.Forms.Label();
            this.txtLiquidOperatingPressure = new System.Windows.Forms.TextBox();
            this.txtLiquidSystemMAWP = new System.Windows.Forms.TextBox();
            this.txtLiquidAtmPressure = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.btnCalculateLiquid = new System.Windows.Forms.Button();
            this.lblLiquidResult = new System.Windows.Forms.Label();
            this.resultsDataGridViewLiquid = new System.Windows.Forms.DataGridView();
            this.colLiquidSizingScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLiquidTotalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLiquidAreaPerValve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLiquidSelectedOrifice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupFireCaseLiquid = new System.Windows.Forms.GroupBox();
            this.radioWettedLiquid = new System.Windows.Forms.RadioButton();
            this.radioUnwettedLiquid = new System.Windows.Forms.RadioButton();
            this.lblEnvFactorWettedLiquid = new System.Windows.Forms.Label();
            this.txtEnvFactorWettedLiquid = new System.Windows.Forms.TextBox();
            this.lblLatentHeatLiquid = new System.Windows.Forms.Label();
            this.txtLatentHeatLiquid = new System.Windows.Forms.TextBox();
            this.lblWettedAreaLiquid = new System.Windows.Forms.Label();
            this.txtWettedAreaLiquid = new System.Windows.Forms.TextBox();
            this.lblEnvFactorUnwettedLiquid = new System.Windows.Forms.Label();
            this.txtEnvFactorUnwettedLiquid = new System.Windows.Forms.TextBox();
            this.lblFireSizingFactorLiquid = new System.Windows.Forms.Label();
            this.txtFireSizingFactorLiquid = new System.Windows.Forms.TextBox();
            this.lblSurfaceAreaUnwettedLiquid = new System.Windows.Forms.Label();
            this.txtSurfaceAreaUnwettedLiquid = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tabGas = new System.Windows.Forms.TabPage();
            this.groupPSVConfiguration = new System.Windows.Forms.GroupBox();
            this.chkFireCase = new System.Windows.Forms.CheckBox();
            this.radioMultiplePSVs = new System.Windows.Forms.RadioButton();
            this.radioSinglePSV = new System.Windows.Forms.RadioButton();
            this.groupSizingScenarios = new System.Windows.Forms.GroupBox();
            this.chkTubeRupture = new System.Windows.Forms.CheckBox();
            this.chkThermalRelief = new System.Windows.Forms.CheckBox();
            this.chkRunawayReaction = new System.Windows.Forms.CheckBox();
            this.chkGasControlValveFailure = new System.Windows.Forms.CheckBox();
            this.chkBlockedOutlet = new System.Windows.Forms.CheckBox();
            this.chkGasPowerFailure = new System.Windows.Forms.CheckBox();
            this.chkGasRefluxFailure = new System.Windows.Forms.CheckBox();
            this.chkGasCompressorExpanderFailure = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtReqFlowCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupPressures = new System.Windows.Forms.GroupBox();
            this.groupBackPressure = new System.Windows.Forms.GroupBox();
            this.txtInletLoss = new System.Windows.Forms.TextBox();
            this.txtInletLossPercent = new System.Windows.Forms.TextBox();
            this.txtTotalBackPressure = new System.Windows.Forms.TextBox();
            this.txtVariableSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtConstantSuperimposedBP = new System.Windows.Forms.TextBox();
            this.txtBuiltUpBP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblInletLossPsig = new System.Windows.Forms.Label();
            this.txtOperatingPressure = new System.Windows.Forms.TextBox();
            this.txtSystemMAWP = new System.Windows.Forms.TextBox();
            this.txtAtmPressure = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupTemperatures = new System.Windows.Forms.GroupBox();
            this.txtNormalInletTemp = new System.Windows.Forms.TextBox();
            this.txtOperatingTemp = new System.Windows.Forms.TextBox();
            this.txtRelievingTemp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupFluidProperties = new System.Windows.Forms.GroupBox();
            this.txtSpecificGravity = new System.Windows.Forms.TextBox();
            this.txtMolecularWeight = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompressibility = new System.Windows.Forms.TextBox();
            this.txtSpecificHeatRatio = new System.Windows.Forms.TextBox();
            this.cmbGasFluid = new System.Windows.Forms.ComboBox();
            this.lblGasResult = new System.Windows.Forms.Label();
            this.btnCalculateGas = new System.Windows.Forms.Button();
            this.resultsDataGridViewGas = new System.Windows.Forms.DataGridView();
            this.colGasSizingScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGasTotalArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGasAreaPerValve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGasSelectedOrifice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupFireCaseGas = new System.Windows.Forms.GroupBox();
            this.radioWettedGas = new System.Windows.Forms.RadioButton();
            this.radioUnwettedGas = new System.Windows.Forms.RadioButton();
            this.lblEnvFactorWettedGas = new System.Windows.Forms.Label();
            this.txtEnvFactorWettedGas = new System.Windows.Forms.TextBox();
            this.lblLatentHeatGas = new System.Windows.Forms.Label();
            this.txtLatentHeatGas = new System.Windows.Forms.TextBox();
            this.lblWettedAreaGas = new System.Windows.Forms.Label();
            this.txtWettedAreaGas = new System.Windows.Forms.TextBox();
            this.lblEnvFactorUnwettedGas = new System.Windows.Forms.Label();
            this.txtEnvFactorUnwettedGas = new System.Windows.Forms.TextBox();
            this.lblFireSizingFactorGas = new System.Windows.Forms.Label();
            this.txtFireSizingFactorGas = new System.Windows.Forms.TextBox();
            this.lblSurfaceAreaUnwettedGas = new System.Windows.Forms.Label();
            this.txtSurfaceAreaUnwettedGas = new System.Windows.Forms.TextBox();
            this.groupCompressorExpanderFailure = new System.Windows.Forms.GroupBox();
            this.txtCompressorCapacity = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.scenarioDetailsPanel = new System.Windows.Forms.Panel();
            this.groupTubeRupture = new System.Windows.Forms.GroupBox();
            this.lblUpstreamPressureTubeRupture = new System.Windows.Forms.Label();
            this.txtUpstreamPressureTubeRupture = new System.Windows.Forms.TextBox();
            this.lblDownstreamPressureTubeRupture = new System.Windows.Forms.Label();
            this.txtDownstreamPressureTubeRupture = new System.Windows.Forms.TextBox();
            this.lblTubeInnerDiameter = new System.Windows.Forms.Label();
            this.txtTubeInnerDiameter = new System.Windows.Forms.TextBox();
            this.lblDischargeCoefficient = new System.Windows.Forms.Label();
            this.txtDischargeCoefficient = new System.Windows.Forms.TextBox();
            this.groupBlockedOutlet = new System.Windows.Forms.GroupBox();
            this.lblEquipmentType = new System.Windows.Forms.Label();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.lblPumpCurve = new System.Windows.Forms.Label();
            this.txtPumpCurve = new System.Windows.Forms.TextBox();
            this.chkControlValveFailure = new System.Windows.Forms.CheckBox();
            this.groupThermalRelief = new System.Windows.Forms.GroupBox();
            this.lblVesselVolume = new System.Windows.Forms.Label();
            this.txtVesselVolume = new System.Windows.Forms.TextBox();
            this.lblTemperatureChange = new System.Windows.Forms.Label();
            this.txtTemperatureChange = new System.Windows.Forms.TextBox();
            this.lblInitialPressure = new System.Windows.Forms.Label();
            this.txtInitialPressure = new System.Windows.Forms.TextBox();
            this.lblReliefPressure = new System.Windows.Forms.Label();
            this.txtReliefPressure = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupSteamFluidProperties.SuspendLayout();
            this.groupSteamTemperatures.SuspendLayout();
            this.groupSteamPSVConfig.SuspendLayout();
            this.groupSteamSizingScenarios.SuspendLayout();
            this.groupSteamPressures.SuspendLayout();
            this.groupSteamBackPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewSteam)).EndInit();
            this.groupFireCaseSteam.SuspendLayout();
            this.groupControlValveFailure.SuspendLayout();
            this.groupPowerFailure.SuspendLayout();
            this.groupHydraulicHammer.SuspendLayout();
            this.groupRefluxFailure.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupLiquidFluidProperties.SuspendLayout();
            this.groupLiquidTemperatures.SuspendLayout();
            this.groupLiquidPSVConfig.SuspendLayout();
            this.groupLiquidSizingScenarios.SuspendLayout();
            this.groupLiquidPressures.SuspendLayout();
            this.groupLiquidBackPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewLiquid)).EndInit();
            this.groupFireCaseLiquid.SuspendLayout();
            this.tabGas.SuspendLayout();
            this.groupPSVConfiguration.SuspendLayout();
            this.groupSizingScenarios.SuspendLayout();
            this.groupPressures.SuspendLayout();
            this.groupBackPressure.SuspendLayout();
            this.groupTemperatures.SuspendLayout();
            this.groupFluidProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewGas)).EndInit();
            this.groupFireCaseGas.SuspendLayout();
            this.groupCompressorExpanderFailure.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.scenarioDetailsPanel.SuspendLayout();
            this.groupTubeRupture.SuspendLayout();
            this.groupBlockedOutlet.SuspendLayout();
            this.groupThermalRelief.SuspendLayout();
            this.SuspendLayout();
            //
            // groupTubeRupture
            //
            this.groupTubeRupture.Controls.Add(this.lblUpstreamPressureTubeRupture);
            this.groupTubeRupture.Controls.Add(this.txtUpstreamPressureTubeRupture);
            this.groupTubeRupture.Controls.Add(this.lblDownstreamPressureTubeRupture);
            this.groupTubeRupture.Controls.Add(this.txtDownstreamPressureTubeRupture);
            this.groupTubeRupture.Controls.Add(this.lblTubeInnerDiameter);
            this.groupTubeRupture.Controls.Add(this.txtTubeInnerDiameter);
            this.groupTubeRupture.Controls.Add(this.lblDischargeCoefficient);
            this.groupTubeRupture.Controls.Add(this.txtDischargeCoefficient);
            this.groupTubeRupture.Location = new System.Drawing.Point(10, 930);
            this.groupTubeRupture.Name = "groupTubeRupture";
            this.groupTubeRupture.Size = new System.Drawing.Size(350, 220);
            this.groupTubeRupture.TabIndex = 31;
            this.groupTubeRupture.TabStop = false;
            this.groupTubeRupture.Tag = "ScenarioDetail";
            this.groupTubeRupture.Text = "Tube Rupture";
            this.groupTubeRupture.Visible = false;
            //
            // lblUpstreamPressureTubeRupture
            //
            this.lblUpstreamPressureTubeRupture.AutoSize = true;
            this.lblUpstreamPressureTubeRupture.Location = new System.Drawing.Point(30, 43);
            this.lblUpstreamPressureTubeRupture.Name = "lblUpstreamPressureTubeRupture";
            this.lblUpstreamPressureTubeRupture.Size = new System.Drawing.Size(146, 20);
            this.lblUpstreamPressureTubeRupture.TabIndex = 1;
            this.lblUpstreamPressureTubeRupture.Text = "Upstream Pressure";
            //
            // txtUpstreamPressureTubeRupture
            //
            this.txtUpstreamPressureTubeRupture.Location = new System.Drawing.Point(180, 40);
            this.txtUpstreamPressureTubeRupture.Name = "txtUpstreamPressureTubeRupture";
            this.txtUpstreamPressureTubeRupture.Size = new System.Drawing.Size(150, 26);
            this.txtUpstreamPressureTubeRupture.TabIndex = 0;
            //
            // lblDownstreamPressureTubeRupture
            //
            this.lblDownstreamPressureTubeRupture.AutoSize = true;
            this.lblDownstreamPressureTubeRupture.Location = new System.Drawing.Point(30, 83);
            this.lblDownstreamPressureTubeRupture.Name = "lblDownstreamPressureTubeRupture";
            this.lblDownstreamPressureTubeRupture.Size = new System.Drawing.Size(166, 20);
            this.lblDownstreamPressureTubeRupture.TabIndex = 3;
            this.lblDownstreamPressureTubeRupture.Text = "Downstream Pressure";
            //
            // txtDownstreamPressureTubeRupture
            //
            this.txtDownstreamPressureTubeRupture.Location = new System.Drawing.Point(180, 80);
            this.txtDownstreamPressureTubeRupture.Name = "txtDownstreamPressureTubeRupture";
            this.txtDownstreamPressureTubeRupture.Size = new System.Drawing.Size(150, 26);
            this.txtDownstreamPressureTubeRupture.TabIndex = 2;
            //
            // lblTubeInnerDiameter
            //
            this.lblTubeInnerDiameter.AutoSize = true;
            this.lblTubeInnerDiameter.Location = new System.Drawing.Point(30, 123);
            this.lblTubeInnerDiameter.Name = "lblTubeInnerDiameter";
            this.lblTubeInnerDiameter.Size = new System.Drawing.Size(155, 20);
            this.lblTubeInnerDiameter.TabIndex = 5;
            this.lblTubeInnerDiameter.Text = "Tube Inner Diameter";
            //
            // txtTubeInnerDiameter
            //
            this.txtTubeInnerDiameter.Location = new System.Drawing.Point(180, 120);
            this.txtTubeInnerDiameter.Name = "txtTubeInnerDiameter";
            this.txtTubeInnerDiameter.Size = new System.Drawing.Size(150, 26);
            this.txtTubeInnerDiameter.TabIndex = 4;
            //
            // lblDischargeCoefficient
            //
            this.lblDischargeCoefficient.AutoSize = true;
            this.lblDischargeCoefficient.Location = new System.Drawing.Point(30, 163);
            this.lblDischargeCoefficient.Name = "lblDischargeCoefficient";
            this.lblDischargeCoefficient.Size = new System.Drawing.Size(161, 20);
            this.lblDischargeCoefficient.TabIndex = 7;
            this.lblDischargeCoefficient.Text = "Discharge Coefficient";
            //
            // txtDischargeCoefficient
            //
            this.txtDischargeCoefficient.Location = new System.Drawing.Point(180, 160);
            this.txtDischargeCoefficient.Name = "txtDischargeCoefficient";
            this.txtDischargeCoefficient.Size = new System.Drawing.Size(150, 26);
            this.txtDischargeCoefficient.TabIndex = 6;
            //
            // groupThermalRelief
            //
            this.groupThermalRelief.Controls.Add(this.lblVesselVolume);
            this.groupThermalRelief.Controls.Add(this.txtVesselVolume);
            this.groupThermalRelief.Controls.Add(this.lblTemperatureChange);
            this.groupThermalRelief.Controls.Add(this.txtTemperatureChange);
            this.groupThermalRelief.Controls.Add(this.lblInitialPressure);
            this.groupThermalRelief.Controls.Add(this.txtInitialPressure);
            this.groupThermalRelief.Controls.Add(this.lblReliefPressure);
            this.groupThermalRelief.Controls.Add(this.txtReliefPressure);
            this.groupThermalRelief.Location = new System.Drawing.Point(10, 720);
            this.groupThermalRelief.Name = "groupThermalRelief";
            this.groupThermalRelief.Size = new System.Drawing.Size(350, 200);
            this.groupThermalRelief.TabIndex = 30;
            this.groupThermalRelief.TabStop = false;
            this.groupThermalRelief.Tag = "ScenarioDetail";
            this.groupThermalRelief.Text = "Thermal Relief";
            this.groupThermalRelief.Visible = false;
            //
            // lblVesselVolume
            //
            this.lblVesselVolume.AutoSize = true;
            this.lblVesselVolume.Location = new System.Drawing.Point(30, 43);
            this.lblVesselVolume.Name = "lblVesselVolume";
            this.lblVesselVolume.Size = new System.Drawing.Size(115, 20);
            this.lblVesselVolume.TabIndex = 1;
            this.lblVesselVolume.Text = "Vessel Volume";
            //
            // txtVesselVolume
            //
            this.txtVesselVolume.Location = new System.Drawing.Point(180, 40);
            this.txtVesselVolume.Name = "txtVesselVolume";
            this.txtVesselVolume.Size = new System.Drawing.Size(150, 26);
            this.txtVesselVolume.TabIndex = 0;
            //
            // lblTemperatureChange
            //
            this.lblTemperatureChange.AutoSize = true;
            this.lblTemperatureChange.Location = new System.Drawing.Point(30, 83);
            this.lblTemperatureChange.Name = "lblTemperatureChange";
            this.lblTemperatureChange.Size = new System.Drawing.Size(109, 20);
            this.lblTemperatureChange.TabIndex = 3;
            this.lblTemperatureChange.Text = "Temp Change";
            //
            // txtTemperatureChange
            //
            this.txtTemperatureChange.Location = new System.Drawing.Point(180, 80);
            this.txtTemperatureChange.Name = "txtTemperatureChange";
            this.txtTemperatureChange.Size = new System.Drawing.Size(150, 26);
            this.txtTemperatureChange.TabIndex = 2;
            //
            // lblInitialPressure
            //
            this.lblInitialPressure.AutoSize = true;
            this.lblInitialPressure.Location = new System.Drawing.Point(30, 123);
            this.lblInitialPressure.Name = "lblInitialPressure";
            this.lblInitialPressure.Size = new System.Drawing.Size(116, 20);
            this.lblInitialPressure.TabIndex = 5;
            this.lblInitialPressure.Text = "Initial Pressure";
            //
            // txtInitialPressure
            //
            this.txtInitialPressure.Location = new System.Drawing.Point(180, 120);
            this.txtInitialPressure.Name = "txtInitialPressure";
            this.txtInitialPressure.Size = new System.Drawing.Size(150, 26);
            this.txtInitialPressure.TabIndex = 4;
            //
            // lblReliefPressure
            //
            this.lblReliefPressure.AutoSize = true;
            this.lblReliefPressure.Location = new System.Drawing.Point(30, 163);
            this.lblReliefPressure.Name = "lblReliefPressure";
            this.lblReliefPressure.Size = new System.Drawing.Size(117, 20);
            this.lblReliefPressure.TabIndex = 7;
            this.lblReliefPressure.Text = "Relief Pressure";
            //
            // txtReliefPressure
            //
            this.txtReliefPressure.Location = new System.Drawing.Point(180, 160);
            this.txtReliefPressure.Name = "txtReliefPressure";
            this.txtReliefPressure.Size = new System.Drawing.Size(150, 26);
            this.txtReliefPressure.TabIndex = 6;
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.cmbTwoPhaseFluid);
            this.tabPage3.Controls.Add(this.txtTwoPhaseReqFlowCapacity);
            this.tabPage3.Controls.Add(this.label63);
            this.tabPage3.Controls.Add(this.btnCalculateTwoPhase);
            this.tabPage3.Controls.Add(this.lblTwoPhaseResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1172, 1161);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Two-Phase";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // cmbTwoPhaseFluid
            //
            this.cmbTwoPhaseFluid.FormattingEnabled = true;
            this.cmbTwoPhaseFluid.Location = new System.Drawing.Point(140, 32);
            this.cmbTwoPhaseFluid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTwoPhaseFluid.Name = "cmbTwoPhaseFluid";
            this.cmbTwoPhaseFluid.Size = new System.Drawing.Size(298, 28);
            this.cmbTwoPhaseFluid.TabIndex = 1;
            //
            // txtTwoPhaseReqFlowCapacity
            //
            this.txtTwoPhaseReqFlowCapacity.Location = new System.Drawing.Point(256, 80);
            this.txtTwoPhaseReqFlowCapacity.Name = "txtTwoPhaseReqFlowCapacity";
            this.txtTwoPhaseReqFlowCapacity.Size = new System.Drawing.Size(232, 26);
            this.txtTwoPhaseReqFlowCapacity.TabIndex = 4;
            //
            // label63
            //
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(57, 83);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(176, 20);
            this.label63.TabIndex = 5;
            this.label63.Text = "Required Flow Capacity";
            //
            // btnCalculateTwoPhase
            //
            this.btnCalculateTwoPhase.Location = new System.Drawing.Point(350, 200);
            this.btnCalculateTwoPhase.Name = "btnCalculateTwoPhase";
            this.btnCalculateTwoPhase.Size = new System.Drawing.Size(120, 35);
            this.btnCalculateTwoPhase.TabIndex = 2;
            this.btnCalculateTwoPhase.Text = "Calculate";
            this.btnCalculateTwoPhase.UseVisualStyleBackColor = true;
            this.btnCalculateTwoPhase.Click += new System.EventHandler(this.BtnCalculateTwoPhase_Click);
            //
            // lblTwoPhaseResult
            //
            this.lblTwoPhaseResult.AutoSize = true;
            this.lblTwoPhaseResult.Location = new System.Drawing.Point(30, 550);
            this.lblTwoPhaseResult.Name = "lblTwoPhaseResult";
            this.lblTwoPhaseResult.Size = new System.Drawing.Size(0, 20);
            this.lblTwoPhaseResult.TabIndex = 3;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.groupSteamFluidProperties);
            this.tabPage2.Controls.Add(this.groupSteamTemperatures);
            this.tabPage2.Controls.Add(this.groupSteamPSVConfig);
            this.tabPage2.Controls.Add(this.groupSteamSizingScenarios);
            this.tabPage2.Controls.Add(this.chkSteamRuptureDisc);
            this.tabPage2.Controls.Add(this.txtSteamReqFlowCapacity);
            this.tabPage2.Controls.Add(this.label62);
            this.tabPage2.Controls.Add(this.lblSteamResult);
            this.tabPage2.Controls.Add(this.groupSteamPressures);
            this.tabPage2.Controls.Add(this.btnCalculateSteam);
            this.tabPage2.Controls.Add(this.resultsDataGridViewSteam);
            this.tabPage2.Controls.Add(this.groupFireCaseSteam);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1172, 1161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Steam";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // groupSteamFluidProperties
            //
            this.groupSteamFluidProperties.Controls.Add(this.txtSteamMolecularWeight);
            this.groupSteamFluidProperties.Controls.Add(this.label44);
            this.groupSteamFluidProperties.Controls.Add(this.label45);
            this.groupSteamFluidProperties.Controls.Add(this.label46);
            this.groupSteamFluidProperties.Controls.Add(this.txtSteamCompressibility);
            this.groupSteamFluidProperties.Controls.Add(this.txtSteamSpecificHeatRatio);
            this.groupSteamFluidProperties.Controls.Add(this.cmbSteamFluid);
            this.groupSteamFluidProperties.Location = new System.Drawing.Point(20, 20);
            this.groupSteamFluidProperties.Name = "groupSteamFluidProperties";
            this.groupSteamFluidProperties.Size = new System.Drawing.Size(414, 258);
            this.groupSteamFluidProperties.TabIndex = 0;
            this.groupSteamFluidProperties.TabStop = false;
            this.groupSteamFluidProperties.Text = "Fluid Properties";
            //
            // txtSteamMolecularWeight
            //
            this.txtSteamMolecularWeight.Location = new System.Drawing.Point(212, 62);
            this.txtSteamMolecularWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSteamMolecularWeight.Name = "txtSteamMolecularWeight";
            this.txtSteamMolecularWeight.Size = new System.Drawing.Size(148, 26);
            this.txtSteamMolecularWeight.TabIndex = 6;
            //
            // label44
            //
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(48, 134);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(114, 20);
            this.label44.TabIndex = 5;
            this.label44.Text = "Compressibility";
            //
            // label45
            //
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(48, 100);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 20);
            this.label45.TabIndex = 5;
            this.label45.Text = "k. (Cp / Cv)";
            //
            // label46
            //
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(37, 65);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(131, 20);
            this.label46.TabIndex = 5;
            this.label46.Text = "Molecular Weight";
            //
            // txtSteamCompressibility
            //
            this.txtSteamCompressibility.Location = new System.Drawing.Point(212, 134);
            this.txtSteamCompressibility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSteamCompressibility.Name = "txtSteamCompressibility";
            this.txtSteamCompressibility.Size = new System.Drawing.Size(148, 26);
            this.txtSteamCompressibility.TabIndex = 1;
            //
            // txtSteamSpecificHeatRatio
            //
            this.txtSteamSpecificHeatRatio.Location = new System.Drawing.Point(212, 97);
            this.txtSteamSpecificHeatRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSteamSpecificHeatRatio.Name = "txtSteamSpecificHeatRatio";
            this.txtSteamSpecificHeatRatio.Size = new System.Drawing.Size(148, 26);
            this.txtSteamSpecificHeatRatio.TabIndex = 1;
            //
            // cmbSteamFluid
            //
            this.cmbSteamFluid.FormattingEnabled = true;
            this.cmbSteamFluid.Location = new System.Drawing.Point(133, 0);
            this.cmbSteamFluid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSteamFluid.Name = "cmbSteamFluid";
            this.cmbSteamFluid.Size = new System.Drawing.Size(281, 28);
            this.cmbSteamFluid.TabIndex = 1;
            //
            // groupSteamTemperatures
            //
            this.groupSteamTemperatures.Controls.Add(this.txtSteamNormalInletTemp);
            this.groupSteamTemperatures.Controls.Add(this.txtSteamOperatingTemp);
            this.groupSteamTemperatures.Controls.Add(this.txtSteamRelievingTemp);
            this.groupSteamTemperatures.Controls.Add(this.label59);
            this.groupSteamTemperatures.Controls.Add(this.label60);
            this.groupSteamTemperatures.Controls.Add(this.label61);
            this.groupSteamTemperatures.Location = new System.Drawing.Point(470, 24);
            this.groupSteamTemperatures.Name = "groupSteamTemperatures";
            this.groupSteamTemperatures.Size = new System.Drawing.Size(350, 250);
            this.groupSteamTemperatures.TabIndex = 2;
            this.groupSteamTemperatures.TabStop = false;
            this.groupSteamTemperatures.Text = "Temperatures (°F)";
            //
            // txtSteamNormalInletTemp
            //
            this.txtSteamNormalInletTemp.Location = new System.Drawing.Point(180, 120);
            this.txtSteamNormalInletTemp.Name = "txtSteamNormalInletTemp";
            this.txtSteamNormalInletTemp.Size = new System.Drawing.Size(100, 26);
            this.txtSteamNormalInletTemp.TabIndex = 2;
            //
            // txtSteamOperatingTemp
            //
            this.txtSteamOperatingTemp.Location = new System.Drawing.Point(180, 80);
            this.txtSteamOperatingTemp.Name = "txtSteamOperatingTemp";
            this.txtSteamOperatingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtSteamOperatingTemp.TabIndex = 1;
            //
            // txtSteamRelievingTemp
            //
            this.txtSteamRelievingTemp.Location = new System.Drawing.Point(180, 40);
            this.txtSteamRelievingTemp.Name = "txtSteamRelievingTemp";
            this.txtSteamRelievingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtSteamRelievingTemp.TabIndex = 0;
            //
            // label59
            //
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(30, 123);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(138, 20);
            this.label59.TabIndex = 5;
            this.label59.Text = "Normal Inlet Temp";
            //
            // label60
            //
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(30, 83);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(123, 20);
            this.label60.TabIndex = 4;
            this.label60.Text = "Operating Temp";
            //
            // label61
            //
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(30, 43);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(117, 20);
            this.label61.TabIndex = 3;
            this.label61.Text = "Relieving Temp";
            //
            // groupSteamPSVConfig
            //
            this.groupSteamPSVConfig.Controls.Add(this.chkSteamFireCase);
            this.groupSteamPSVConfig.Controls.Add(this.radioSteamMultiplePSVs);
            this.groupSteamPSVConfig.Controls.Add(this.radioSteamSinglePSV);
            this.groupSteamPSVConfig.Location = new System.Drawing.Point(852, 43);
            this.groupSteamPSVConfig.Name = "groupSteamPSVConfig";
            this.groupSteamPSVConfig.Size = new System.Drawing.Size(300, 150);
            this.groupSteamPSVConfig.TabIndex = 3;
            this.groupSteamPSVConfig.TabStop = false;
            this.groupSteamPSVConfig.Text = "PSV Configuration";
            //
            // chkSteamFireCase
            //
            this.chkSteamFireCase.AutoSize = true;
            this.chkSteamFireCase.Location = new System.Drawing.Point(20, 100);
            this.chkSteamFireCase.Name = "chkSteamFireCase";
            this.chkSteamFireCase.Size = new System.Drawing.Size(103, 24);
            this.chkSteamFireCase.TabIndex = 2;
            this.chkSteamFireCase.Text = "Fire Case";
            this.chkSteamFireCase.UseVisualStyleBackColor = true;
            //
            // radioSteamMultiplePSVs
            //
            this.radioSteamMultiplePSVs.AutoSize = true;
            this.radioSteamMultiplePSVs.Location = new System.Drawing.Point(20, 60);
            this.radioSteamMultiplePSVs.Name = "radioSteamMultiplePSVs";
            this.radioSteamMultiplePSVs.Size = new System.Drawing.Size(132, 24);
            this.radioSteamMultiplePSVs.TabIndex = 1;
            this.radioSteamMultiplePSVs.Text = "Multiple PSVs";
            this.radioSteamMultiplePSVs.UseVisualStyleBackColor = true;
            //
            // radioSteamSinglePSV
            //
            this.radioSteamSinglePSV.AutoSize = true;
            this.radioSteamSinglePSV.Checked = true;
            this.radioSteamSinglePSV.Location = new System.Drawing.Point(20, 30);
            this.radioSteamSinglePSV.Name = "radioSteamSinglePSV";
            this.radioSteamSinglePSV.Size = new System.Drawing.Size(114, 24);
            this.radioSteamSinglePSV.TabIndex = 0;
            this.radioSteamSinglePSV.TabStop = true;
            this.radioSteamSinglePSV.Text = "Single PSV";
            this.radioSteamSinglePSV.UseVisualStyleBackColor = true;
            //
            // groupSteamSizingScenarios
            //
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamTubeRupture);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamThermalRelief);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamRunawayReaction);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamControlValveFailure);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamBlockedOutlet);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamPowerFailure);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamHydraulicHammer);
            this.groupSteamSizingScenarios.Controls.Add(this.chkSteamRefluxFailure);
            this.groupSteamSizingScenarios.Location = new System.Drawing.Point(852, 208);
            this.groupSteamSizingScenarios.Name = "groupSteamSizingScenarios";
            this.groupSteamSizingScenarios.Size = new System.Drawing.Size(300, 260);
            this.groupSteamSizingScenarios.TabIndex = 4;
            this.groupSteamSizingScenarios.TabStop = false;
            this.groupSteamSizingScenarios.Text = "Sizing Scenarios";
            //
            // chkSteamTubeRupture
            //
            this.chkSteamTubeRupture.AutoSize = true;
            this.chkSteamTubeRupture.Location = new System.Drawing.Point(20, 166);
            this.chkSteamTubeRupture.Name = "chkSteamTubeRupture";
            this.chkSteamTubeRupture.Size = new System.Drawing.Size(133, 24);
            this.chkSteamTubeRupture.TabIndex = 3;
            this.chkSteamTubeRupture.Text = "Tube Rupture";
            this.chkSteamTubeRupture.UseVisualStyleBackColor = true;
            //
            // chkSteamThermalRelief
            //
            this.chkSteamThermalRelief.AutoSize = true;
            this.chkSteamThermalRelief.Location = new System.Drawing.Point(20, 136);
            this.chkSteamThermalRelief.Name = "chkSteamThermalRelief";
            this.chkSteamThermalRelief.Size = new System.Drawing.Size(137, 24);
            this.chkSteamThermalRelief.TabIndex = 2;
            this.chkSteamThermalRelief.Text = "Thermal Relief";
            this.chkSteamThermalRelief.UseVisualStyleBackColor = true;
            //
            // chkSteamRunawayReaction
            //
            this.chkSteamRunawayReaction.AutoSize = true;
            this.chkSteamRunawayReaction.Location = new System.Drawing.Point(20, 106);
            this.chkSteamRunawayReaction.Name = "chkSteamRunawayReaction";
            this.chkSteamRunawayReaction.Size = new System.Drawing.Size(169, 24);
            this.chkSteamRunawayReaction.TabIndex = 1;
            this.chkSteamRunawayReaction.Text = "Runaway Reaction";
            this.chkSteamRunawayReaction.UseVisualStyleBackColor = true;
            //
            // chkSteamControlValveFailure
            //
            this.chkSteamControlValveFailure.AutoSize = true;
            this.chkSteamControlValveFailure.Location = new System.Drawing.Point(20, 76);
            this.chkSteamControlValveFailure.Name = "chkSteamControlValveFailure";
            this.chkSteamControlValveFailure.Size = new System.Drawing.Size(181, 24);
            this.chkSteamControlValveFailure.TabIndex = 0;
            this.chkSteamControlValveFailure.Text = "Control Valve Failure";
            this.chkSteamControlValveFailure.UseVisualStyleBackColor = true;
            //
            // chkSteamBlockedOutlet
            //
            this.chkSteamBlockedOutlet.AutoSize = true;
            this.chkSteamBlockedOutlet.Location = new System.Drawing.Point(20, 46);
            this.chkSteamBlockedOutlet.Name = "chkSteamBlockedOutlet";
            this.chkSteamBlockedOutlet.Size = new System.Drawing.Size(139, 24);
            this.chkSteamBlockedOutlet.TabIndex = 12;
            this.chkSteamBlockedOutlet.Text = "Blocked Outlet";
            this.chkSteamBlockedOutlet.UseVisualStyleBackColor = true;
            //
            // chkSteamPowerFailure
            //
            this.chkSteamPowerFailure.Location = new System.Drawing.Point(20, 196);
            this.chkSteamPowerFailure.Name = "chkSteamPowerFailure";
            this.chkSteamPowerFailure.Size = new System.Drawing.Size(180, 24);
            this.chkSteamPowerFailure.TabIndex = 13;
            this.chkSteamPowerFailure.Text = "Power Failure";
            //
            // chkSteamHydraulicHammer
            //
            this.chkSteamHydraulicHammer.Location = new System.Drawing.Point(20, 226);
            this.chkSteamHydraulicHammer.Name = "chkSteamHydraulicHammer";
            this.chkSteamHydraulicHammer.Size = new System.Drawing.Size(180, 24);
            this.chkSteamHydraulicHammer.TabIndex = 14;
            this.chkSteamHydraulicHammer.Text = "Hydraulic Hammer/Water Hammer";
            //
            // chkSteamRefluxFailure
            //
            this.chkSteamRefluxFailure.Location = new System.Drawing.Point(20, 226);
            this.chkSteamRefluxFailure.Name = "chkSteamRefluxFailure";
            this.chkSteamRefluxFailure.Size = new System.Drawing.Size(157, 24);
            this.chkSteamRefluxFailure.TabIndex = 15;
            this.chkSteamRefluxFailure.Text = "Reflux Failure";
            //
            // chkSteamRuptureDisc
            //
            this.chkSteamRuptureDisc.AutoSize = true;
            this.chkSteamRuptureDisc.Location = new System.Drawing.Point(565, 596);
            this.chkSteamRuptureDisc.Name = "chkSteamRuptureDisc";
            this.chkSteamRuptureDisc.Size = new System.Drawing.Size(161, 24);
            this.chkSteamRuptureDisc.TabIndex = 7;
            this.chkSteamRuptureDisc.Text = "Has Rupture Disc";
            this.chkSteamRuptureDisc.UseVisualStyleBackColor = true;
            //
            // txtSteamReqFlowCapacity
            //
            this.txtSteamReqFlowCapacity.Location = new System.Drawing.Point(320, 597);
            this.txtSteamReqFlowCapacity.Name = "txtSteamReqFlowCapacity";
            this.txtSteamReqFlowCapacity.Size = new System.Drawing.Size(168, 26);
            this.txtSteamReqFlowCapacity.TabIndex = 6;
            //
            // label62
            //
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(57, 598);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(220, 20);
            this.label62.TabIndex = 5;
            this.label62.Text = "Required Flow Capacity (lb/hr)";
            //
            // lblSteamResult
            //
            this.lblSteamResult.AutoSize = true;
            this.lblSteamResult.Location = new System.Drawing.Point(30, 550);
            this.lblSteamResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteamResult.Name = "lblSteamResult";
            this.lblSteamResult.Size = new System.Drawing.Size(0, 20);
            this.lblSteamResult.TabIndex = 8;
            //
            // groupSteamPressures
            //
            this.groupSteamPressures.Controls.Add(this.groupSteamBackPressure);
            this.groupSteamPressures.Controls.Add(this.txtSteamOperatingPressure);
            this.groupSteamPressures.Controls.Add(this.txtSteamSystemMAWP);
            this.groupSteamPressures.Controls.Add(this.txtSteamAtmPressure);
            this.groupSteamPressures.Controls.Add(this.label47);
            this.groupSteamPressures.Controls.Add(this.label48);
            this.groupSteamPressures.Controls.Add(this.label49);
            this.groupSteamPressures.Location = new System.Drawing.Point(20, 280);
            this.groupSteamPressures.Name = "groupSteamPressures";
            this.groupSteamPressures.Size = new System.Drawing.Size(800, 300);
            this.groupSteamPressures.TabIndex = 1;
            this.groupSteamPressures.TabStop = false;
            this.groupSteamPressures.Text = "Pressures (psig)";
            //
            // groupSteamBackPressure
            //
            this.groupSteamBackPressure.Controls.Add(this.txtSteamInletLoss);
            this.groupSteamBackPressure.Controls.Add(this.txtSteamInletLossPercent);
            this.groupSteamBackPressure.Controls.Add(this.txtSteamTotalBackPressure);
            this.groupSteamBackPressure.Controls.Add(this.txtSteamVariableSuperimposedBP);
            this.groupSteamBackPressure.Controls.Add(this.txtSteamConstantSuperimposedBP);
            this.groupSteamBackPressure.Controls.Add(this.txtSteamBuiltUpBP);
            this.groupSteamBackPressure.Controls.Add(this.label54);
            this.groupSteamBackPressure.Controls.Add(this.label55);
            this.groupSteamBackPressure.Controls.Add(this.label56);
            this.groupSteamBackPressure.Controls.Add(this.label57);
            this.groupSteamBackPressure.Controls.Add(this.label58);
            this.groupSteamBackPressure.Controls.Add(this.lblSteamInletLossPsig);
            this.groupSteamBackPressure.Location = new System.Drawing.Point(300, 20);
            this.groupSteamBackPressure.Name = "groupSteamBackPressure";
            this.groupSteamBackPressure.Size = new System.Drawing.Size(480, 260);
            this.groupSteamBackPressure.TabIndex = 0;
            this.groupSteamBackPressure.TabStop = false;
            this.groupSteamBackPressure.Text = "Back Pressure (psig)";
            //
            // txtSteamInletLoss
            //
            this.txtSteamInletLoss.Location = new System.Drawing.Point(405, 67);
            this.txtSteamInletLoss.Name = "txtSteamInletLoss";
            this.txtSteamInletLoss.ReadOnly = true;
            this.txtSteamInletLoss.Size = new System.Drawing.Size(50, 26);
            this.txtSteamInletLoss.TabIndex = 5;
            this.txtSteamInletLoss.Text = "0";
            //
            // txtSteamInletLossPercent
            //
            this.txtSteamInletLossPercent.Location = new System.Drawing.Point(400, 27);
            this.txtSteamInletLossPercent.Name = "txtSteamInletLossPercent";
            this.txtSteamInletLossPercent.Size = new System.Drawing.Size(50, 26);
            this.txtSteamInletLossPercent.TabIndex = 4;
            //
            // txtSteamTotalBackPressure
            //
            this.txtSteamTotalBackPressure.Location = new System.Drawing.Point(150, 147);
            this.txtSteamTotalBackPressure.Name = "txtSteamTotalBackPressure";
            this.txtSteamTotalBackPressure.ReadOnly = true;
            this.txtSteamTotalBackPressure.Size = new System.Drawing.Size(50, 26);
            this.txtSteamTotalBackPressure.TabIndex = 3;
            this.txtSteamTotalBackPressure.Text = "0";
            //
            // txtSteamVariableSuperimposedBP
            //
            this.txtSteamVariableSuperimposedBP.Location = new System.Drawing.Point(150, 107);
            this.txtSteamVariableSuperimposedBP.Name = "txtSteamVariableSuperimposedBP";
            this.txtSteamVariableSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtSteamVariableSuperimposedBP.TabIndex = 2;
            this.txtSteamVariableSuperimposedBP.Text = "0";
            //
            // txtSteamConstantSuperimposedBP
            //
            this.txtSteamConstantSuperimposedBP.Location = new System.Drawing.Point(150, 67);
            this.txtSteamConstantSuperimposedBP.Name = "txtSteamConstantSuperimposedBP";
            this.txtSteamConstantSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtSteamConstantSuperimposedBP.TabIndex = 1;
            this.txtSteamConstantSuperimposedBP.Text = "0";
            //
            // txtSteamBuiltUpBP
            //
            this.txtSteamBuiltUpBP.Location = new System.Drawing.Point(150, 27);
            this.txtSteamBuiltUpBP.Name = "txtSteamBuiltUpBP";
            this.txtSteamBuiltUpBP.Size = new System.Drawing.Size(50, 26);
            this.txtSteamBuiltUpBP.TabIndex = 0;
            this.txtSteamBuiltUpBP.Text = "0";
            //
            // label54
            //
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(20, 30);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(70, 20);
            this.label54.TabIndex = 0;
            this.label54.Text = "Built-Up:";
            //
            // label55
            //
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(20, 70);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(129, 20);
            this.label55.TabIndex = 1;
            this.label55.Text = "Constant Super.:";
            //
            // label56
            //
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(20, 110);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(122, 20);
            this.label56.TabIndex = 2;
            this.label56.Text = "Variable Super.:";
            //
            // label57
            //
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(20, 150);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(136, 20);
            this.label57.TabIndex = 3;
            this.label57.Text = "Total Back Press.:";
            //
            // label58
            //
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(250, 30);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(100, 20);
            this.label58.TabIndex = 4;
            this.label58.Text = "Inlet Loss %:";
            //
            // lblSteamInletLossPsig
            //
            this.lblSteamInletLossPsig.AutoSize = true;
            this.lblSteamInletLossPsig.Location = new System.Drawing.Point(250, 70);
            this.lblSteamInletLossPsig.Name = "lblSteamInletLossPsig";
            this.lblSteamInletLossPsig.Size = new System.Drawing.Size(125, 20);
            this.lblSteamInletLossPsig.TabIndex = 6;
            this.lblSteamInletLossPsig.Text = "Inlet Loss (psig):";
            //
            // txtSteamOperatingPressure
            //
            this.txtSteamOperatingPressure.Location = new System.Drawing.Point(150, 107);
            this.txtSteamOperatingPressure.Name = "txtSteamOperatingPressure";
            this.txtSteamOperatingPressure.Size = new System.Drawing.Size(100, 26);
            this.txtSteamOperatingPressure.TabIndex = 3;
            //
            // txtSteamSystemMAWP
            //
            this.txtSteamSystemMAWP.Location = new System.Drawing.Point(150, 67);
            this.txtSteamSystemMAWP.Name = "txtSteamSystemMAWP";
            this.txtSteamSystemMAWP.Size = new System.Drawing.Size(100, 26);
            this.txtSteamSystemMAWP.TabIndex = 2;
            //
            // txtSteamAtmPressure
            //
            this.txtSteamAtmPressure.Location = new System.Drawing.Point(150, 27);
            this.txtSteamAtmPressure.Name = "txtSteamAtmPressure";
            this.txtSteamAtmPressure.Size = new System.Drawing.Size(100, 26);
            this.txtSteamAtmPressure.TabIndex = 1;
            this.txtSteamAtmPressure.Text = "14.696";
            //
            // label47
            //
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(20, 30);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(113, 20);
            this.label47.TabIndex = 0;
            this.label47.Text = "Atm. Pressure:";
            //
            // label48
            //
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(20, 70);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(119, 20);
            this.label48.TabIndex = 1;
            this.label48.Text = "System MAWP:";
            //
            // label49
            //
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(20, 110);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(150, 20);
            this.label49.TabIndex = 2;
            this.label49.Text = "Operating Pressure:";
            //
            // btnCalculateSteam
            //
            this.btnCalculateSteam.Location = new System.Drawing.Point(350, 850);
            this.btnCalculateSteam.Name = "btnCalculateSteam";
            this.btnCalculateSteam.Size = new System.Drawing.Size(120, 35);
            this.btnCalculateSteam.TabIndex = 13;
            this.btnCalculateSteam.Text = "Calculate";
            this.btnCalculateSteam.UseVisualStyleBackColor = true;
            this.btnCalculateSteam.Click += new System.EventHandler(this.BtnCalculateSteam_Click);
            //
            // resultsDataGridViewSteam
            //
            this.resultsDataGridViewSteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridViewSteam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSteamSizingScenario,
            this.colSteamTotalArea,
            this.colSteamAreaPerValve,
            this.colSteamSelectedOrifice});
            this.resultsDataGridViewSteam.Location = new System.Drawing.Point(20, 640);
            this.resultsDataGridViewSteam.Name = "resultsDataGridViewSteam";
            this.resultsDataGridViewSteam.RowHeadersWidth = 62;
            this.resultsDataGridViewSteam.RowTemplate.Height = 28;
            this.resultsDataGridViewSteam.Size = new System.Drawing.Size(700, 200);
            this.resultsDataGridViewSteam.TabIndex = 14;
            //
            // colSteamSizingScenario
            //
            this.colSteamSizingScenario.HeaderText = "Sizing Scenario";
            this.colSteamSizingScenario.MinimumWidth = 8;
            this.colSteamSizingScenario.Name = "colSteamSizingScenario";
            this.colSteamSizingScenario.Width = 150;
            //
            // colSteamTotalArea
            //
            this.colSteamTotalArea.HeaderText = "Total Required Area (in²)";
            this.colSteamTotalArea.MinimumWidth = 8;
            this.colSteamTotalArea.Name = "colSteamTotalArea";
            this.colSteamTotalArea.Width = 150;
            //
            // colSteamAreaPerValve
            //
            this.colSteamAreaPerValve.HeaderText = "Area per Valve (in²)";
            this.colSteamAreaPerValve.MinimumWidth = 8;
            this.colSteamAreaPerValve.Name = "colSteamAreaPerValve";
            this.colSteamAreaPerValve.Width = 150;
            //
            // colSteamSelectedOrifice
            //
            this.colSteamSelectedOrifice.HeaderText = "Selected Orifice";
            this.colSteamSelectedOrifice.MinimumWidth = 8;
            this.colSteamSelectedOrifice.Name = "colSteamSelectedOrifice";
            this.colSteamSelectedOrifice.Width = 150;
            //
            // groupFireCaseSteam
            //
            this.groupFireCaseSteam.Controls.Add(this.radioWettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.radioUnwettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblEnvFactorWettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtEnvFactorWettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblLatentHeatSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtLatentHeatSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblWettedAreaSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtWettedAreaSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblEnvFactorUnwettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtEnvFactorUnwettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblFireSizingFactorSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtFireSizingFactorSteam);
            this.groupFireCaseSteam.Controls.Add(this.lblSurfaceAreaUnwettedSteam);
            this.groupFireCaseSteam.Controls.Add(this.txtSurfaceAreaUnwettedSteam);
            this.groupFireCaseSteam.Location = new System.Drawing.Point(852, 500);
            this.groupFireCaseSteam.Name = "groupFireCaseSteam";
            this.groupFireCaseSteam.Size = new System.Drawing.Size(300, 340);
            this.groupFireCaseSteam.TabIndex = 15;
            this.groupFireCaseSteam.TabStop = false;
            this.groupFireCaseSteam.Text = "Fire Case Parameters";
            //
            // radioWettedSteam
            //
            this.radioWettedSteam.AutoSize = true;
            this.radioWettedSteam.Location = new System.Drawing.Point(20, 30);
            this.radioWettedSteam.Name = "radioWettedSteam";
            this.radioWettedSteam.Size = new System.Drawing.Size(86, 24);
            this.radioWettedSteam.TabIndex = 0;
            this.radioWettedSteam.TabStop = true;
            this.radioWettedSteam.Text = "Wetted";
            this.radioWettedSteam.UseVisualStyleBackColor = true;
            //
            // radioUnwettedSteam
            //
            this.radioUnwettedSteam.AutoSize = true;
            this.radioUnwettedSteam.Location = new System.Drawing.Point(150, 30);
            this.radioUnwettedSteam.Name = "radioUnwettedSteam";
            this.radioUnwettedSteam.Size = new System.Drawing.Size(103, 24);
            this.radioUnwettedSteam.TabIndex = 1;
            this.radioUnwettedSteam.TabStop = true;
            this.radioUnwettedSteam.Text = "Unwetted";
            this.radioUnwettedSteam.UseVisualStyleBackColor = true;
            //
            // lblEnvFactorWettedSteam
            //
            this.lblEnvFactorWettedSteam.AutoSize = true;
            this.lblEnvFactorWettedSteam.Location = new System.Drawing.Point(17, 100);
            this.lblEnvFactorWettedSteam.Name = "lblEnvFactorWettedSteam";
            this.lblEnvFactorWettedSteam.Size = new System.Drawing.Size(160, 20);
            this.lblEnvFactorWettedSteam.TabIndex = 2;
            this.lblEnvFactorWettedSteam.Text = "Env. Factor (Wetted):";
            //
            // txtEnvFactorWettedSteam
            //
            this.txtEnvFactorWettedSteam.Location = new System.Drawing.Point(180, 97);
            this.txtEnvFactorWettedSteam.Name = "txtEnvFactorWettedSteam";
            this.txtEnvFactorWettedSteam.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorWettedSteam.TabIndex = 3;
            //
            // lblLatentHeatSteam
            //
            this.lblLatentHeatSteam.AutoSize = true;
            this.lblLatentHeatSteam.Location = new System.Drawing.Point(17, 140);
            this.lblLatentHeatSteam.Name = "lblLatentHeatSteam";
            this.lblLatentHeatSteam.Size = new System.Drawing.Size(98, 20);
            this.lblLatentHeatSteam.TabIndex = 4;
            this.lblLatentHeatSteam.Text = "Latent Heat:";
            //
            // txtLatentHeatSteam
            //
            this.txtLatentHeatSteam.Location = new System.Drawing.Point(180, 137);
            this.txtLatentHeatSteam.Name = "txtLatentHeatSteam";
            this.txtLatentHeatSteam.Size = new System.Drawing.Size(100, 26);
            this.txtLatentHeatSteam.TabIndex = 5;
            //
            // lblWettedAreaSteam
            //
            this.lblWettedAreaSteam.AutoSize = true;
            this.lblWettedAreaSteam.Location = new System.Drawing.Point(17, 180);
            this.lblWettedAreaSteam.Name = "lblWettedAreaSteam";
            this.lblWettedAreaSteam.Size = new System.Drawing.Size(103, 20);
            this.lblWettedAreaSteam.TabIndex = 6;
            this.lblWettedAreaSteam.Text = "Wetted Area:";
            //
            // txtWettedAreaSteam
            //
            this.txtWettedAreaSteam.Location = new System.Drawing.Point(180, 177);
            this.txtWettedAreaSteam.Name = "txtWettedAreaSteam";
            this.txtWettedAreaSteam.Size = new System.Drawing.Size(100, 26);
            this.txtWettedAreaSteam.TabIndex = 7;
            //
            // lblEnvFactorUnwettedSteam
            //
            this.lblEnvFactorUnwettedSteam.AutoSize = true;
            this.lblEnvFactorUnwettedSteam.Location = new System.Drawing.Point(17, 220);
            this.lblEnvFactorUnwettedSteam.Name = "lblEnvFactorUnwettedSteam";
            this.lblEnvFactorUnwettedSteam.Size = new System.Drawing.Size(177, 20);
            this.lblEnvFactorUnwettedSteam.TabIndex = 8;
            this.lblEnvFactorUnwettedSteam.Text = "Env. Factor (Unwetted):";
            //
            // txtEnvFactorUnwettedSteam
            //
            this.txtEnvFactorUnwettedSteam.Location = new System.Drawing.Point(180, 217);
            this.txtEnvFactorUnwettedSteam.Name = "txtEnvFactorUnwettedSteam";
            this.txtEnvFactorUnwettedSteam.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorUnwettedSteam.TabIndex = 9;
            //
            // lblFireSizingFactorSteam
            //
            this.lblFireSizingFactorSteam.AutoSize = true;
            this.lblFireSizingFactorSteam.Location = new System.Drawing.Point(17, 260);
            this.lblFireSizingFactorSteam.Name = "lblFireSizingFactorSteam";
            this.lblFireSizingFactorSteam.Size = new System.Drawing.Size(137, 20);
            this.lblFireSizingFactorSteam.TabIndex = 10;
            this.lblFireSizingFactorSteam.Text = "Fire Sizing Factor:";
            //
            // txtFireSizingFactorSteam
            //
            this.txtFireSizingFactorSteam.Location = new System.Drawing.Point(180, 257);
            this.txtFireSizingFactorSteam.Name = "txtFireSizingFactorSteam";
            this.txtFireSizingFactorSteam.Size = new System.Drawing.Size(100, 26);
            this.txtFireSizingFactorSteam.TabIndex = 11;
            this.txtFireSizingFactorSteam.Text = "0.045";
            //
            // lblSurfaceAreaUnwettedSteam
            //
            this.lblSurfaceAreaUnwettedSteam.AutoSize = true;
            this.lblSurfaceAreaUnwettedSteam.Location = new System.Drawing.Point(17, 300);
            this.lblSurfaceAreaUnwettedSteam.Name = "lblSurfaceAreaUnwettedSteam";
            this.lblSurfaceAreaUnwettedSteam.Size = new System.Drawing.Size(171, 20);
            this.lblSurfaceAreaUnwettedSteam.TabIndex = 12;
            this.lblSurfaceAreaUnwettedSteam.Text = "Surface Area (Unwet.):";
            //
            // txtSurfaceAreaUnwettedSteam
            //
            this.txtSurfaceAreaUnwettedSteam.Location = new System.Drawing.Point(180, 297);
            this.txtSurfaceAreaUnwettedSteam.Name = "txtSurfaceAreaUnwettedSteam";
            this.txtSurfaceAreaUnwettedSteam.Size = new System.Drawing.Size(100, 26);
            this.txtSurfaceAreaUnwettedSteam.TabIndex = 13;
            //
            // label51
            //
            this.label51.Location = new System.Drawing.Point(0, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(100, 23);
            this.label51.TabIndex = 0;
            //
            // label52
            //
            this.label52.Location = new System.Drawing.Point(0, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(100, 23);
            this.label52.TabIndex = 0;
            //
            // label53
            //
            this.label53.Location = new System.Drawing.Point(0, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(100, 23);
            this.label53.TabIndex = 0;
            //
            // groupControlValveFailure
            //
            this.groupControlValveFailure.Controls.Add(this.txtCv);
            this.groupControlValveFailure.Controls.Add(this.label67);
            this.groupControlValveFailure.Controls.Add(this.lblUpstreamPressure);
            this.groupControlValveFailure.Controls.Add(this.txtUpstreamPressure);
            this.groupControlValveFailure.Controls.Add(this.lblDownstreamPressure);
            this.groupControlValveFailure.Controls.Add(this.txtDownstreamPressure);
            this.groupControlValveFailure.Location = new System.Drawing.Point(10, 340);
            this.groupControlValveFailure.Name = "groupControlValveFailure";
            this.groupControlValveFailure.Size = new System.Drawing.Size(350, 180);
            this.groupControlValveFailure.TabIndex = 24;
            this.groupControlValveFailure.TabStop = false;
            this.groupControlValveFailure.Tag = "ScenarioDetail";
            this.groupControlValveFailure.Text = "Control Valve Failure";
            this.groupControlValveFailure.Visible = false;
            //
            // txtCv
            //
            this.txtCv.Location = new System.Drawing.Point(180, 40);
            this.txtCv.Name = "txtCv";
            this.txtCv.Size = new System.Drawing.Size(100, 26);
            this.txtCv.TabIndex = 0;
            //
            // label67
            //
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(30, 43);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(27, 20);
            this.label67.TabIndex = 1;
            this.label67.Text = "Cv";
            //
            // lblUpstreamPressure
            //
            this.lblUpstreamPressure.AutoSize = true;
            this.lblUpstreamPressure.Location = new System.Drawing.Point(30, 83);
            this.lblUpstreamPressure.Name = "lblUpstreamPressure";
            this.lblUpstreamPressure.Size = new System.Drawing.Size(146, 20);
            this.lblUpstreamPressure.TabIndex = 2;
            this.lblUpstreamPressure.Text = "Upstream Pressure";
            //
            // txtUpstreamPressure
            //
            this.txtUpstreamPressure.Location = new System.Drawing.Point(180, 80);
            this.txtUpstreamPressure.Name = "txtUpstreamPressure";
            this.txtUpstreamPressure.Size = new System.Drawing.Size(100, 26);
            this.txtUpstreamPressure.TabIndex = 3;
            //
            // lblDownstreamPressure
            //
            this.lblDownstreamPressure.AutoSize = true;
            this.lblDownstreamPressure.Location = new System.Drawing.Point(30, 123);
            this.lblDownstreamPressure.Name = "lblDownstreamPressure";
            this.lblDownstreamPressure.Size = new System.Drawing.Size(166, 20);
            this.lblDownstreamPressure.TabIndex = 4;
            this.lblDownstreamPressure.Text = "Downstream Pressure";
            //
            // txtDownstreamPressure
            //
            this.txtDownstreamPressure.Location = new System.Drawing.Point(180, 120);
            this.txtDownstreamPressure.Name = "txtDownstreamPressure";
            this.txtDownstreamPressure.Size = new System.Drawing.Size(100, 26);
            this.txtDownstreamPressure.TabIndex = 5;
            //
            // groupPowerFailure
            //
            this.groupPowerFailure.Controls.Add(this.txtPumpHead);
            this.groupPowerFailure.Controls.Add(this.label68);
            this.groupPowerFailure.Location = new System.Drawing.Point(10, 450);
            this.groupPowerFailure.Name = "groupPowerFailure";
            this.groupPowerFailure.Size = new System.Drawing.Size(350, 100);
            this.groupPowerFailure.TabIndex = 25;
            this.groupPowerFailure.TabStop = false;
            this.groupPowerFailure.Tag = "ScenarioDetail";
            this.groupPowerFailure.Text = "Power Failure";
            this.groupPowerFailure.Visible = false;
            //
            // txtPumpHead
            //
            this.txtPumpHead.Location = new System.Drawing.Point(180, 40);
            this.txtPumpHead.Name = "txtPumpHead";
            this.txtPumpHead.Size = new System.Drawing.Size(100, 26);
            this.txtPumpHead.TabIndex = 0;
            //
            // label68
            //
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(30, 43);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(93, 20);
            this.label68.TabIndex = 1;
            this.label68.Text = "Pump Head";
            //
            // groupHydraulicHammer
            //
            this.groupHydraulicHammer.Controls.Add(this.txtValveCloseTime);
            this.groupHydraulicHammer.Controls.Add(this.label69);
            this.groupHydraulicHammer.Location = new System.Drawing.Point(10, 230);
            this.groupHydraulicHammer.Name = "groupHydraulicHammer";
            this.groupHydraulicHammer.Size = new System.Drawing.Size(350, 100);
            this.groupHydraulicHammer.TabIndex = 26;
            this.groupHydraulicHammer.TabStop = false;
            this.groupHydraulicHammer.Tag = "ScenarioDetail";
            this.groupHydraulicHammer.Text = "Hydraulic Hammer";
            this.groupHydraulicHammer.Visible = false;
            //
            // txtValveCloseTime
            //
            this.txtValveCloseTime.Location = new System.Drawing.Point(180, 40);
            this.txtValveCloseTime.Name = "txtValveCloseTime";
            this.txtValveCloseTime.Size = new System.Drawing.Size(100, 26);
            this.txtValveCloseTime.TabIndex = 0;
            //
            // label69
            //
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(30, 43);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(130, 20);
            this.label69.TabIndex = 1;
            this.label69.Text = "Valve Close Time";
            //
            // groupRefluxFailure
            //
            this.groupRefluxFailure.Controls.Add(this.txtRefluxRatio);
            this.groupRefluxFailure.Controls.Add(this.label70);
            this.groupRefluxFailure.Controls.Add(this.lblBoilupRate);
            this.groupRefluxFailure.Controls.Add(this.txtBoilupRate);
            this.groupRefluxFailure.Location = new System.Drawing.Point(10, 120);
            this.groupRefluxFailure.Name = "groupRefluxFailure";
            this.groupRefluxFailure.Size = new System.Drawing.Size(350, 120);
            this.groupRefluxFailure.TabIndex = 27;
            this.groupRefluxFailure.TabStop = false;
            this.groupRefluxFailure.Tag = "ScenarioDetail";
            this.groupRefluxFailure.Text = "Reflux Failure";
            this.groupRefluxFailure.Visible = false;
            //
            // txtRefluxRatio
            //
            this.txtRefluxRatio.Location = new System.Drawing.Point(180, 40);
            this.txtRefluxRatio.Name = "txtRefluxRatio";
            this.txtRefluxRatio.Size = new System.Drawing.Size(100, 26);
            this.txtRefluxRatio.TabIndex = 0;
            //
            // label70
            //
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(30, 43);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(96, 20);
            this.label70.TabIndex = 1;
            this.label70.Text = "Reflux Ratio";
            //
            // lblBoilupRate
            //
            this.lblBoilupRate.AutoSize = true;
            this.lblBoilupRate.Location = new System.Drawing.Point(30, 83);
            this.lblBoilupRate.Name = "lblBoilupRate";
            this.lblBoilupRate.Size = new System.Drawing.Size(141, 20);
            this.lblBoilupRate.TabIndex = 3;
            this.lblBoilupRate.Text = "Boil-up Rate (lb/hr)";
            //
            // txtBoilupRate
            //
            this.txtBoilupRate.Location = new System.Drawing.Point(180, 80);
            this.txtBoilupRate.Name = "txtBoilupRate";
            this.txtBoilupRate.Size = new System.Drawing.Size(100, 26);
            this.txtBoilupRate.TabIndex = 2;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.groupLiquidFluidProperties);
            this.tabPage1.Controls.Add(this.groupLiquidTemperatures);
            this.tabPage1.Controls.Add(this.groupLiquidPSVConfig);
            this.tabPage1.Controls.Add(this.groupLiquidSizingScenarios);
            this.tabPage1.Controls.Add(this.chkLiquidRuptureDisc);
            this.tabPage1.Controls.Add(this.txtLiquidReqFlowCapacity);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.groupLiquidPressures);
            this.tabPage1.Controls.Add(this.btnCalculateLiquid);
            this.tabPage1.Controls.Add(this.lblLiquidResult);
            this.tabPage1.Controls.Add(this.resultsDataGridViewLiquid);
            this.tabPage1.Controls.Add(this.groupFireCaseLiquid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1172, 1161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Liquid";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // groupLiquidFluidProperties
            //
            this.groupLiquidFluidProperties.Controls.Add(this.txtLiquidVesselVolume);
            this.groupLiquidFluidProperties.Controls.Add(this.label64);
            this.groupLiquidFluidProperties.Controls.Add(this.txtLiquidTempChange);
            this.groupLiquidFluidProperties.Controls.Add(this.label65);
            this.groupLiquidFluidProperties.Controls.Add(this.txtLiquidPumpCurve);
            this.groupLiquidFluidProperties.Controls.Add(this.label66);
            this.groupLiquidFluidProperties.Controls.Add(this.txtLiquidViscosity);
            this.groupLiquidFluidProperties.Controls.Add(this.label1);
            this.groupLiquidFluidProperties.Controls.Add(this.txtLiquidSpecificGravity);
            this.groupLiquidFluidProperties.Controls.Add(this.cmbLiquidFluid);
            this.groupLiquidFluidProperties.Controls.Add(this.label25);
            this.groupLiquidFluidProperties.Controls.Add(this.label24);
            this.groupLiquidFluidProperties.Location = new System.Drawing.Point(21, 41);
            this.groupLiquidFluidProperties.Name = "groupLiquidFluidProperties";
            this.groupLiquidFluidProperties.Size = new System.Drawing.Size(414, 280);
            this.groupLiquidFluidProperties.TabIndex = 3;
            this.groupLiquidFluidProperties.TabStop = false;
            this.groupLiquidFluidProperties.Text = "Fluid Properties (Liquid)";
            //
            // txtLiquidVesselVolume
            //
            this.txtLiquidVesselVolume.Location = new System.Drawing.Point(205, 160);
            this.txtLiquidVesselVolume.Name = "txtLiquidVesselVolume";
            this.txtLiquidVesselVolume.Size = new System.Drawing.Size(148, 26);
            this.txtLiquidVesselVolume.TabIndex = 8;
            //
            // label64
            //
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(41, 163);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(115, 20);
            this.label64.TabIndex = 9;
            this.label64.Text = "Vessel Volume";
            //
            // txtLiquidTempChange
            //
            this.txtLiquidTempChange.Location = new System.Drawing.Point(205, 200);
            this.txtLiquidTempChange.Name = "txtLiquidTempChange";
            this.txtLiquidTempChange.Size = new System.Drawing.Size(148, 26);
            this.txtLiquidTempChange.TabIndex = 10;
            //
            // label65
            //
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(41, 203);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(109, 20);
            this.label65.TabIndex = 11;
            this.label65.Text = "Temp Change";
            //
            // txtLiquidPumpCurve
            //
            this.txtLiquidPumpCurve.Location = new System.Drawing.Point(205, 240);
            this.txtLiquidPumpCurve.Name = "txtLiquidPumpCurve";
            this.txtLiquidPumpCurve.Size = new System.Drawing.Size(148, 26);
            this.txtLiquidPumpCurve.TabIndex = 12;
            //
            // label66
            //
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(41, 243);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(95, 20);
            this.label66.TabIndex = 13;
            this.label66.Text = "Pump Curve";
            //
            // txtLiquidViscosity
            //
            this.txtLiquidViscosity.Location = new System.Drawing.Point(205, 120);
            this.txtLiquidViscosity.Name = "txtLiquidViscosity";
            this.txtLiquidViscosity.Size = new System.Drawing.Size(148, 26);
            this.txtLiquidViscosity.TabIndex = 7;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fluid";
            //
            // txtLiquidSpecificGravity
            //
            this.txtLiquidSpecificGravity.Location = new System.Drawing.Point(205, 80);
            this.txtLiquidSpecificGravity.Name = "txtLiquidSpecificGravity";
            this.txtLiquidSpecificGravity.Size = new System.Drawing.Size(148, 26);
            this.txtLiquidSpecificGravity.TabIndex = 7;
            //
            // cmbLiquidFluid
            //
            this.cmbLiquidFluid.FormattingEnabled = true;
            this.cmbLiquidFluid.Location = new System.Drawing.Point(109, 27);
            this.cmbLiquidFluid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLiquidFluid.Name = "cmbLiquidFluid";
            this.cmbLiquidFluid.Size = new System.Drawing.Size(298, 28);
            this.cmbLiquidFluid.TabIndex = 1;
            //
            // label25
            //
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(71, 20);
            this.label25.TabIndex = 5;
            this.label25.Text = "Viscosity";
            //
            // label24
            //
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(118, 20);
            this.label24.TabIndex = 5;
            this.label24.Text = "Specific Gravity";
            //
            // groupLiquidTemperatures
            //
            this.groupLiquidTemperatures.Controls.Add(this.txtLiquidNormalInletTemp);
            this.groupLiquidTemperatures.Controls.Add(this.txtLiquidOperatingTemp);
            this.groupLiquidTemperatures.Controls.Add(this.txtLiquidRelievingTemp);
            this.groupLiquidTemperatures.Controls.Add(this.label26);
            this.groupLiquidTemperatures.Controls.Add(this.label27);
            this.groupLiquidTemperatures.Controls.Add(this.label28);
            this.groupLiquidTemperatures.Location = new System.Drawing.Point(470, 24);
            this.groupLiquidTemperatures.Name = "groupLiquidTemperatures";
            this.groupLiquidTemperatures.Size = new System.Drawing.Size(350, 250);
            this.groupLiquidTemperatures.TabIndex = 15;
            this.groupLiquidTemperatures.TabStop = false;
            this.groupLiquidTemperatures.Text = "Temperatures (°F)";
            //
            // txtLiquidNormalInletTemp
            //
            this.txtLiquidNormalInletTemp.Location = new System.Drawing.Point(180, 120);
            this.txtLiquidNormalInletTemp.Name = "txtLiquidNormalInletTemp";
            this.txtLiquidNormalInletTemp.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidNormalInletTemp.TabIndex = 2;
            //
            // txtLiquidOperatingTemp
            //
            this.txtLiquidOperatingTemp.Location = new System.Drawing.Point(180, 80);
            this.txtLiquidOperatingTemp.Name = "txtLiquidOperatingTemp";
            this.txtLiquidOperatingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidOperatingTemp.TabIndex = 1;
            //
            // txtLiquidRelievingTemp
            //
            this.txtLiquidRelievingTemp.Location = new System.Drawing.Point(180, 40);
            this.txtLiquidRelievingTemp.Name = "txtLiquidRelievingTemp";
            this.txtLiquidRelievingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidRelievingTemp.TabIndex = 0;
            //
            // label26
            //
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(30, 43);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(117, 20);
            this.label26.TabIndex = 3;
            this.label26.Text = "Relieving Temp";
            //
            // label27
            //
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(30, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(123, 20);
            this.label27.TabIndex = 4;
            this.label27.Text = "Operating Temp";
            //
            // label28
            //
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(30, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(138, 20);
            this.label28.TabIndex = 5;
            this.label28.Text = "Normal Inlet Temp";
            //
            // groupLiquidPSVConfig
            //
            this.groupLiquidPSVConfig.Controls.Add(this.chkLiquidFireCase);
            this.groupLiquidPSVConfig.Controls.Add(this.radioLiquidMultiplePSVs);
            this.groupLiquidPSVConfig.Controls.Add(this.radioLiquidSinglePSV);
            this.groupLiquidPSVConfig.Location = new System.Drawing.Point(852, 43);
            this.groupLiquidPSVConfig.Name = "groupLiquidPSVConfig";
            this.groupLiquidPSVConfig.Size = new System.Drawing.Size(300, 150);
            this.groupLiquidPSVConfig.TabIndex = 16;
            this.groupLiquidPSVConfig.TabStop = false;
            this.groupLiquidPSVConfig.Text = "PSV Configuration";
            //
            // chkLiquidFireCase
            //
            this.chkLiquidFireCase.AutoSize = true;
            this.chkLiquidFireCase.Location = new System.Drawing.Point(20, 100);
            this.chkLiquidFireCase.Name = "chkLiquidFireCase";
            this.chkLiquidFireCase.Size = new System.Drawing.Size(103, 24);
            this.chkLiquidFireCase.TabIndex = 2;
            this.chkLiquidFireCase.Text = "Fire Case";
            this.chkLiquidFireCase.UseVisualStyleBackColor = true;
            //
            // radioLiquidMultiplePSVs
            //
            this.radioLiquidMultiplePSVs.AutoSize = true;
            this.radioLiquidMultiplePSVs.Location = new System.Drawing.Point(20, 60);
            this.radioLiquidMultiplePSVs.Name = "radioLiquidMultiplePSVs";
            this.radioLiquidMultiplePSVs.Size = new System.Drawing.Size(132, 24);
            this.radioLiquidMultiplePSVs.TabIndex = 1;
            this.radioLiquidMultiplePSVs.Text = "Multiple PSVs";
            this.radioLiquidMultiplePSVs.UseVisualStyleBackColor = true;
            //
            // radioLiquidSinglePSV
            //
            this.radioLiquidSinglePSV.AutoSize = true;
            this.radioLiquidSinglePSV.Checked = true;
            this.radioLiquidSinglePSV.Location = new System.Drawing.Point(20, 30);
            this.radioLiquidSinglePSV.Name = "radioLiquidSinglePSV";
            this.radioLiquidSinglePSV.Size = new System.Drawing.Size(114, 24);
            this.radioLiquidSinglePSV.TabIndex = 0;
            this.radioLiquidSinglePSV.TabStop = true;
            this.radioLiquidSinglePSV.Text = "Single PSV";
            this.radioLiquidSinglePSV.UseVisualStyleBackColor = true;
            //
            // groupLiquidSizingScenarios
            //
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidTubeRupture);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidThermalRelief);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidRunawayReaction);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidControlValveFailure);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidBlockedOutlet);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidPowerFailure);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidHydraulicHammer);
            this.groupLiquidSizingScenarios.Controls.Add(this.chkLiquidRefluxFailure);
            this.groupLiquidSizingScenarios.Location = new System.Drawing.Point(852, 208);
            this.groupLiquidSizingScenarios.Name = "groupLiquidSizingScenarios";
            this.groupLiquidSizingScenarios.Size = new System.Drawing.Size(300, 352);
            this.groupLiquidSizingScenarios.TabIndex = 17;
            this.groupLiquidSizingScenarios.TabStop = false;
            this.groupLiquidSizingScenarios.Text = "Sizing Scenarios";
            //
            // chkLiquidTubeRupture
            //
            this.chkLiquidTubeRupture.AutoSize = true;
            this.chkLiquidTubeRupture.Location = new System.Drawing.Point(20, 166);
            this.chkLiquidTubeRupture.Name = "chkLiquidTubeRupture";
            this.chkLiquidTubeRupture.Size = new System.Drawing.Size(133, 24);
            this.chkLiquidTubeRupture.TabIndex = 3;
            this.chkLiquidTubeRupture.Text = "Tube Rupture";
            this.chkLiquidTubeRupture.UseVisualStyleBackColor = true;
            //
            // chkLiquidThermalRelief
            //
            this.chkLiquidThermalRelief.AutoSize = true;
            this.chkLiquidThermalRelief.Location = new System.Drawing.Point(20, 136);
            this.chkLiquidThermalRelief.Name = "chkLiquidThermalRelief";
            this.chkLiquidThermalRelief.Size = new System.Drawing.Size(137, 24);
            this.chkLiquidThermalRelief.TabIndex = 2;
            this.chkLiquidThermalRelief.Text = "Thermal Relief";
            this.chkLiquidThermalRelief.UseVisualStyleBackColor = true;
            //
            // chkLiquidRunawayReaction
            //
            this.chkLiquidRunawayReaction.AutoSize = true;
            this.chkLiquidRunawayReaction.Location = new System.Drawing.Point(20, 106);
            this.chkLiquidRunawayReaction.Name = "chkLiquidRunawayReaction";
            this.chkLiquidRunawayReaction.Size = new System.Drawing.Size(169, 24);
            this.chkLiquidRunawayReaction.TabIndex = 1;
            this.chkLiquidRunawayReaction.Text = "Runaway Reaction";
            this.chkLiquidRunawayReaction.UseVisualStyleBackColor = true;
            //
            // chkLiquidControlValveFailure
            //
            this.chkLiquidControlValveFailure.AutoSize = true;
            this.chkLiquidControlValveFailure.Location = new System.Drawing.Point(20, 76);
            this.chkLiquidControlValveFailure.Name = "chkLiquidControlValveFailure";
            this.chkLiquidControlValveFailure.Size = new System.Drawing.Size(181, 24);
            this.chkLiquidControlValveFailure.TabIndex = 0;
            this.chkLiquidControlValveFailure.Text = "Control Valve Failure";
            this.chkLiquidControlValveFailure.UseVisualStyleBackColor = true;
            //
            // chkLiquidBlockedOutlet
            //
            this.chkLiquidBlockedOutlet.AutoSize = true;
            this.chkLiquidBlockedOutlet.Location = new System.Drawing.Point(20, 46);
            this.chkLiquidBlockedOutlet.Name = "chkLiquidBlockedOutlet";
            this.chkLiquidBlockedOutlet.Size = new System.Drawing.Size(139, 24);
            this.chkLiquidBlockedOutlet.TabIndex = 12;
            this.chkLiquidBlockedOutlet.Text = "Blocked Outlet";
            this.chkLiquidBlockedOutlet.UseVisualStyleBackColor = true;
            //
            // chkLiquidPowerFailure
            //
            this.chkLiquidPowerFailure.Location = new System.Drawing.Point(20, 196);
            this.chkLiquidPowerFailure.Name = "chkLiquidPowerFailure";
            this.chkLiquidPowerFailure.Size = new System.Drawing.Size(180, 24);
            this.chkLiquidPowerFailure.TabIndex = 13;
            this.chkLiquidPowerFailure.Text = "Power Failure";
            //
            // chkLiquidHydraulicHammer
            //
            this.chkLiquidHydraulicHammer.Location = new System.Drawing.Point(20, 226);
            this.chkLiquidHydraulicHammer.Name = "chkLiquidHydraulicHammer";
            this.chkLiquidHydraulicHammer.Size = new System.Drawing.Size(180, 24);
            this.chkLiquidHydraulicHammer.TabIndex = 14;
            this.chkLiquidHydraulicHammer.Text = "Hydraulic Hammer/Water Hammer";
            //
            // chkLiquidRefluxFailure
            //
            this.chkLiquidRefluxFailure.Location = new System.Drawing.Point(20, 256);
            this.chkLiquidRefluxFailure.Name = "chkLiquidRefluxFailure";
            this.chkLiquidRefluxFailure.Size = new System.Drawing.Size(157, 24);
            this.chkLiquidRefluxFailure.TabIndex = 15;
            this.chkLiquidRefluxFailure.Text = "Reflux Failure";
            //
            // chkLiquidRuptureDisc
            //
            this.chkLiquidRuptureDisc.AutoSize = true;
            this.chkLiquidRuptureDisc.Location = new System.Drawing.Point(565, 596);
            this.chkLiquidRuptureDisc.Name = "chkLiquidRuptureDisc";
            this.chkLiquidRuptureDisc.Size = new System.Drawing.Size(161, 24);
            this.chkLiquidRuptureDisc.TabIndex = 19;
            this.chkLiquidRuptureDisc.Text = "Has Rupture Disc";
            this.chkLiquidRuptureDisc.UseVisualStyleBackColor = true;
            //
            // txtLiquidReqFlowCapacity
            //
            this.txtLiquidReqFlowCapacity.Location = new System.Drawing.Point(320, 597);
            this.txtLiquidReqFlowCapacity.Name = "txtLiquidReqFlowCapacity";
            this.txtLiquidReqFlowCapacity.Size = new System.Drawing.Size(168, 26);
            this.txtLiquidReqFlowCapacity.TabIndex = 18;
            //
            // label29
            //
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(57, 598);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(226, 20);
            this.label29.TabIndex = 17;
            this.label29.Text = "Required Flow Capacity (GPM)";
            //
            // groupLiquidPressures
            //
            this.groupLiquidPressures.Controls.Add(this.groupLiquidBackPressure);
            this.groupLiquidPressures.Controls.Add(this.txtLiquidOperatingPressure);
            this.groupLiquidPressures.Controls.Add(this.txtLiquidSystemMAWP);
            this.groupLiquidPressures.Controls.Add(this.txtLiquidAtmPressure);
            this.groupLiquidPressures.Controls.Add(this.label30);
            this.groupLiquidPressures.Controls.Add(this.label31);
            this.groupLiquidPressures.Controls.Add(this.label32);
            this.groupLiquidPressures.Location = new System.Drawing.Point(20, 327);
            this.groupLiquidPressures.Name = "groupLiquidPressures";
            this.groupLiquidPressures.Size = new System.Drawing.Size(800, 300);
            this.groupLiquidPressures.TabIndex = 18;
            this.groupLiquidPressures.TabStop = false;
            this.groupLiquidPressures.Text = "Pressures (psig)";
            //
            // groupLiquidBackPressure
            //
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidInletLoss);
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidInletLossPercent);
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidTotalBackPressure);
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidVariableSuperimposedBP);
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidConstantSuperimposedBP);
            this.groupLiquidBackPressure.Controls.Add(this.txtLiquidBuiltUpBP);
            this.groupLiquidBackPressure.Controls.Add(this.label37);
            this.groupLiquidBackPressure.Controls.Add(this.label38);
            this.groupLiquidBackPressure.Controls.Add(this.label39);
            this.groupLiquidBackPressure.Controls.Add(this.label40);
            this.groupLiquidBackPressure.Controls.Add(this.label41);
            this.groupLiquidBackPressure.Controls.Add(this.lblLiquidInletLossPsig);
            this.groupLiquidBackPressure.Location = new System.Drawing.Point(300, 20);
            this.groupLiquidBackPressure.Name = "groupLiquidBackPressure";
            this.groupLiquidBackPressure.Size = new System.Drawing.Size(480, 260);
            this.groupLiquidBackPressure.TabIndex = 0;
            this.groupLiquidBackPressure.TabStop = false;
            this.groupLiquidBackPressure.Text = "Back Pressure (psig)";
            //
            // txtLiquidInletLoss
            //
            this.txtLiquidInletLoss.Location = new System.Drawing.Point(405, 70);
            this.txtLiquidInletLoss.Name = "txtLiquidInletLoss";
            this.txtLiquidInletLoss.ReadOnly = true;
            this.txtLiquidInletLoss.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidInletLoss.TabIndex = 5;
            this.txtLiquidInletLoss.Text = "0";
            //
            // txtLiquidInletLossPercent
            //
            this.txtLiquidInletLossPercent.Location = new System.Drawing.Point(400, 27);
            this.txtLiquidInletLossPercent.Name = "txtLiquidInletLossPercent";
            this.txtLiquidInletLossPercent.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidInletLossPercent.TabIndex = 4;
            //
            // txtLiquidTotalBackPressure
            //
            this.txtLiquidTotalBackPressure.Location = new System.Drawing.Point(150, 147);
            this.txtLiquidTotalBackPressure.Name = "txtLiquidTotalBackPressure";
            this.txtLiquidTotalBackPressure.ReadOnly = true;
            this.txtLiquidTotalBackPressure.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidTotalBackPressure.TabIndex = 3;
            this.txtLiquidTotalBackPressure.Text = "0";
            //
            // txtLiquidVariableSuperimposedBP
            //
            this.txtLiquidVariableSuperimposedBP.Location = new System.Drawing.Point(150, 107);
            this.txtLiquidVariableSuperimposedBP.Name = "txtLiquidVariableSuperimposedBP";
            this.txtLiquidVariableSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidVariableSuperimposedBP.TabIndex = 2;
            this.txtLiquidVariableSuperimposedBP.Text = "0";
            //
            // txtLiquidConstantSuperimposedBP
            //
            this.txtLiquidConstantSuperimposedBP.Location = new System.Drawing.Point(150, 67);
            this.txtLiquidConstantSuperimposedBP.Name = "txtLiquidConstantSuperimposedBP";
            this.txtLiquidConstantSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidConstantSuperimposedBP.TabIndex = 1;
            this.txtLiquidConstantSuperimposedBP.Text = "0";
            //
            // txtLiquidBuiltUpBP
            //
            this.txtLiquidBuiltUpBP.Location = new System.Drawing.Point(150, 27);
            this.txtLiquidBuiltUpBP.Name = "txtLiquidBuiltUpBP";
            this.txtLiquidBuiltUpBP.Size = new System.Drawing.Size(50, 26);
            this.txtLiquidBuiltUpBP.TabIndex = 0;
            this.txtLiquidBuiltUpBP.Text = "0";
            //
            // label37
            //
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(20, 30);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(70, 20);
            this.label37.TabIndex = 0;
            this.label37.Text = "Built-Up:";
            //
            // label38
            //
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 70);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(129, 20);
            this.label38.TabIndex = 1;
            this.label38.Text = "Constant Super.:";
            //
            // label39
            //
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(20, 110);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(122, 20);
            this.label39.TabIndex = 2;
            this.label39.Text = "Variable Super.:";
            //
            // label40
            //
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(20, 150);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(136, 20);
            this.label40.TabIndex = 3;
            this.label40.Text = "Total Back Press.:";
            //
            // label41
            //
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(250, 30);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 20);
            this.label41.TabIndex = 4;
            this.label41.Text = "Inlet Loss %:";
            //
            // lblLiquidInletLossPsig
            //
            this.lblLiquidInletLossPsig.AutoSize = true;
            this.lblLiquidInletLossPsig.Location = new System.Drawing.Point(250, 73);
            this.lblLiquidInletLossPsig.Name = "lblLiquidInletLossPsig";
            this.lblLiquidInletLossPsig.Size = new System.Drawing.Size(125, 20);
            this.lblLiquidInletLossPsig.TabIndex = 6;
            this.lblLiquidInletLossPsig.Text = "Inlet Loss (psig):";
            //
            // txtLiquidOperatingPressure
            //
            this.txtLiquidOperatingPressure.Location = new System.Drawing.Point(150, 107);
            this.txtLiquidOperatingPressure.Name = "txtLiquidOperatingPressure";
            this.txtLiquidOperatingPressure.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidOperatingPressure.TabIndex = 3;
            //
            // txtLiquidSystemMAWP
            //
            this.txtLiquidSystemMAWP.Location = new System.Drawing.Point(150, 67);
            this.txtLiquidSystemMAWP.Name = "txtLiquidSystemMAWP";
            this.txtLiquidSystemMAWP.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidSystemMAWP.TabIndex = 2;
            //
            // txtLiquidAtmPressure
            //
            this.txtLiquidAtmPressure.Location = new System.Drawing.Point(150, 27);
            this.txtLiquidAtmPressure.Name = "txtLiquidAtmPressure";
            this.txtLiquidAtmPressure.Size = new System.Drawing.Size(100, 26);
            this.txtLiquidAtmPressure.TabIndex = 1;
            this.txtLiquidAtmPressure.Text = "14.696";
            //
            // label30
            //
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(20, 30);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(113, 20);
            this.label30.TabIndex = 0;
            this.label30.Text = "Atm. Pressure:";
            //
            // label31
            //
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 20);
            this.label31.TabIndex = 1;
            this.label31.Text = "System MAWP:";
            //
            // label32
            //
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 110);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(150, 20);
            this.label32.TabIndex = 2;
            this.label32.Text = "Operating Pressure:";
            //
            // btnCalculateLiquid
            //
            this.btnCalculateLiquid.Location = new System.Drawing.Point(350, 850);
            this.btnCalculateLiquid.Name = "btnCalculateLiquid";
            this.btnCalculateLiquid.Size = new System.Drawing.Size(120, 35);
            this.btnCalculateLiquid.TabIndex = 20;
            this.btnCalculateLiquid.Text = "Calculate";
            this.btnCalculateLiquid.UseVisualStyleBackColor = true;
            this.btnCalculateLiquid.Click += new System.EventHandler(this.BtnCalculateLiquid_Click);
            //
            // lblLiquidResult
            //
            this.lblLiquidResult.AutoSize = true;
            this.lblLiquidResult.Location = new System.Drawing.Point(30, 550);
            this.lblLiquidResult.Name = "lblLiquidResult";
            this.lblLiquidResult.Size = new System.Drawing.Size(0, 20);
            this.lblLiquidResult.TabIndex = 21;
            //
            // resultsDataGridViewLiquid
            //
            this.resultsDataGridViewLiquid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridViewLiquid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLiquidSizingScenario,
            this.colLiquidTotalArea,
            this.colLiquidAreaPerValve,
            this.colLiquidSelectedOrifice});
            this.resultsDataGridViewLiquid.Location = new System.Drawing.Point(20, 640);
            this.resultsDataGridViewLiquid.Name = "resultsDataGridViewLiquid";
            this.resultsDataGridViewLiquid.RowHeadersWidth = 62;
            this.resultsDataGridViewLiquid.RowTemplate.Height = 28;
            this.resultsDataGridViewLiquid.Size = new System.Drawing.Size(800, 200);
            this.resultsDataGridViewLiquid.TabIndex = 22;
            //
            // colLiquidSizingScenario
            //
            this.colLiquidSizingScenario.HeaderText = "Sizing Scenario";
            this.colLiquidSizingScenario.MinimumWidth = 8;
            this.colLiquidSizingScenario.Name = "colLiquidSizingScenario";
            this.colLiquidSizingScenario.Width = 150;
            //
            // colLiquidTotalArea
            //
            this.colLiquidTotalArea.HeaderText = "Total Required Area (in²)";
            this.colLiquidTotalArea.MinimumWidth = 8;
            this.colLiquidTotalArea.Name = "colLiquidTotalArea";
            this.colLiquidTotalArea.Width = 150;
            //
            // colLiquidAreaPerValve
            //
            this.colLiquidAreaPerValve.HeaderText = "Area per Valve (in²)";
            this.colLiquidAreaPerValve.MinimumWidth = 8;
            this.colLiquidAreaPerValve.Name = "colLiquidAreaPerValve";
            this.colLiquidAreaPerValve.Width = 150;
            //
            // colLiquidSelectedOrifice
            //
            this.colLiquidSelectedOrifice.HeaderText = "Selected Orifice";
            this.colLiquidSelectedOrifice.MinimumWidth = 8;
            this.colLiquidSelectedOrifice.Name = "colLiquidSelectedOrifice";
            this.colLiquidSelectedOrifice.Width = 150;
            //
            // groupFireCaseLiquid
            //
            this.groupFireCaseLiquid.Controls.Add(this.radioWettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.radioUnwettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblEnvFactorWettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtEnvFactorWettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblLatentHeatLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtLatentHeatLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblWettedAreaLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtWettedAreaLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblEnvFactorUnwettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtEnvFactorUnwettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblFireSizingFactorLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtFireSizingFactorLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.lblSurfaceAreaUnwettedLiquid);
            this.groupFireCaseLiquid.Controls.Add(this.txtSurfaceAreaUnwettedLiquid);
            this.groupFireCaseLiquid.Location = new System.Drawing.Point(852, 500);
            this.groupFireCaseLiquid.Name = "groupFireCaseLiquid";
            this.groupFireCaseLiquid.Size = new System.Drawing.Size(300, 340);
            this.groupFireCaseLiquid.TabIndex = 23;
            this.groupFireCaseLiquid.TabStop = false;
            this.groupFireCaseLiquid.Text = "Fire Case Parameters";
            //
            // radioWettedLiquid
            //
            this.radioWettedLiquid.AutoSize = true;
            this.radioWettedLiquid.Location = new System.Drawing.Point(20, 30);
            this.radioWettedLiquid.Name = "radioWettedLiquid";
            this.radioWettedLiquid.Size = new System.Drawing.Size(86, 24);
            this.radioWettedLiquid.TabIndex = 0;
            this.radioWettedLiquid.TabStop = true;
            this.radioWettedLiquid.Text = "Wetted";
            this.radioWettedLiquid.UseVisualStyleBackColor = true;
            //
            // radioUnwettedLiquid
            //
            this.radioUnwettedLiquid.AutoSize = true;
            this.radioUnwettedLiquid.Location = new System.Drawing.Point(150, 30);
            this.radioUnwettedLiquid.Name = "radioUnwettedLiquid";
            this.radioUnwettedLiquid.Size = new System.Drawing.Size(103, 24);
            this.radioUnwettedLiquid.TabIndex = 1;
            this.radioUnwettedLiquid.TabStop = true;
            this.radioUnwettedLiquid.Text = "Unwetted";
            this.radioUnwettedLiquid.UseVisualStyleBackColor = true;
            //
            // lblEnvFactorWettedLiquid
            //
            this.lblEnvFactorWettedLiquid.AutoSize = true;
            this.lblEnvFactorWettedLiquid.Location = new System.Drawing.Point(17, 100);
            this.lblEnvFactorWettedLiquid.Name = "lblEnvFactorWettedLiquid";
            this.lblEnvFactorWettedLiquid.Size = new System.Drawing.Size(160, 20);
            this.lblEnvFactorWettedLiquid.TabIndex = 2;
            this.lblEnvFactorWettedLiquid.Text = "Env. Factor (Wetted):";
            //
            // txtEnvFactorWettedLiquid
            //
            this.txtEnvFactorWettedLiquid.Location = new System.Drawing.Point(180, 97);
            this.txtEnvFactorWettedLiquid.Name = "txtEnvFactorWettedLiquid";
            this.txtEnvFactorWettedLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorWettedLiquid.TabIndex = 3;
            //
            // lblLatentHeatLiquid
            //
            this.lblLatentHeatLiquid.AutoSize = true;
            this.lblLatentHeatLiquid.Location = new System.Drawing.Point(17, 140);
            this.lblLatentHeatLiquid.Name = "lblLatentHeatLiquid";
            this.lblLatentHeatLiquid.Size = new System.Drawing.Size(98, 20);
            this.lblLatentHeatLiquid.TabIndex = 4;
            this.lblLatentHeatLiquid.Text = "Latent Heat:";
            //
            // txtLatentHeatLiquid
            //
            this.txtLatentHeatLiquid.Location = new System.Drawing.Point(180, 137);
            this.txtLatentHeatLiquid.Name = "txtLatentHeatLiquid";
            this.txtLatentHeatLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtLatentHeatLiquid.TabIndex = 5;
            //
            // lblWettedAreaLiquid
            //
            this.lblWettedAreaLiquid.AutoSize = true;
            this.lblWettedAreaLiquid.Location = new System.Drawing.Point(17, 180);
            this.lblWettedAreaLiquid.Name = "lblWettedAreaLiquid";
            this.lblWettedAreaLiquid.Size = new System.Drawing.Size(103, 20);
            this.lblWettedAreaLiquid.TabIndex = 6;
            this.lblWettedAreaLiquid.Text = "Wetted Area:";
            //
            // txtWettedAreaLiquid
            //
            this.txtWettedAreaLiquid.Location = new System.Drawing.Point(180, 177);
            this.txtWettedAreaLiquid.Name = "txtWettedAreaLiquid";
            this.txtWettedAreaLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtWettedAreaLiquid.TabIndex = 7;
            //
            // lblEnvFactorUnwettedLiquid
            //
            this.lblEnvFactorUnwettedLiquid.AutoSize = true;
            this.lblEnvFactorUnwettedLiquid.Location = new System.Drawing.Point(17, 220);
            this.lblEnvFactorUnwettedLiquid.Name = "lblEnvFactorUnwettedLiquid";
            this.lblEnvFactorUnwettedLiquid.Size = new System.Drawing.Size(177, 20);
            this.lblEnvFactorUnwettedLiquid.TabIndex = 8;
            this.lblEnvFactorUnwettedLiquid.Text = "Env. Factor (Unwetted):";
            //
            // txtEnvFactorUnwettedLiquid
            //
            this.txtEnvFactorUnwettedLiquid.Location = new System.Drawing.Point(180, 217);
            this.txtEnvFactorUnwettedLiquid.Name = "txtEnvFactorUnwettedLiquid";
            this.txtEnvFactorUnwettedLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorUnwettedLiquid.TabIndex = 9;
            //
            // lblFireSizingFactorLiquid
            //
            this.lblFireSizingFactorLiquid.AutoSize = true;
            this.lblFireSizingFactorLiquid.Location = new System.Drawing.Point(17, 260);
            this.lblFireSizingFactorLiquid.Name = "lblFireSizingFactorLiquid";
            this.lblFireSizingFactorLiquid.Size = new System.Drawing.Size(137, 20);
            this.lblFireSizingFactorLiquid.TabIndex = 10;
            this.lblFireSizingFactorLiquid.Text = "Fire Sizing Factor:";
            //
            // txtFireSizingFactorLiquid
            //
            this.txtFireSizingFactorLiquid.Location = new System.Drawing.Point(180, 257);
            this.txtFireSizingFactorLiquid.Name = "txtFireSizingFactorLiquid";
            this.txtFireSizingFactorLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtFireSizingFactorLiquid.TabIndex = 11;
            this.txtFireSizingFactorLiquid.Text = "0.045";
            //
            // lblSurfaceAreaUnwettedLiquid
            //
            this.lblSurfaceAreaUnwettedLiquid.AutoSize = true;
            this.lblSurfaceAreaUnwettedLiquid.Location = new System.Drawing.Point(17, 300);
            this.lblSurfaceAreaUnwettedLiquid.Name = "lblSurfaceAreaUnwettedLiquid";
            this.lblSurfaceAreaUnwettedLiquid.Size = new System.Drawing.Size(171, 20);
            this.lblSurfaceAreaUnwettedLiquid.TabIndex = 12;
            this.lblSurfaceAreaUnwettedLiquid.Text = "Surface Area (Unwet.):";
            //
            // txtSurfaceAreaUnwettedLiquid
            //
            this.txtSurfaceAreaUnwettedLiquid.Location = new System.Drawing.Point(180, 297);
            this.txtSurfaceAreaUnwettedLiquid.Name = "txtSurfaceAreaUnwettedLiquid";
            this.txtSurfaceAreaUnwettedLiquid.Size = new System.Drawing.Size(100, 26);
            this.txtSurfaceAreaUnwettedLiquid.TabIndex = 13;
            //
            // label34
            //
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 23);
            this.label34.TabIndex = 0;
            //
            // label35
            //
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 23);
            this.label35.TabIndex = 0;
            //
            // label36
            //
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 23);
            this.label36.TabIndex = 0;
            //
            // tabGas
            //
            this.tabGas.Controls.Add(this.groupPSVConfiguration);
            this.tabGas.Controls.Add(this.groupSizingScenarios);
            this.tabGas.Controls.Add(this.checkBox1);
            this.tabGas.Controls.Add(this.txtReqFlowCapacity);
            this.tabGas.Controls.Add(this.label3);
            this.tabGas.Controls.Add(this.groupPressures);
            this.tabGas.Controls.Add(this.groupTemperatures);
            this.tabGas.Controls.Add(this.groupFluidProperties);
            this.tabGas.Controls.Add(this.lblGasResult);
            this.tabGas.Controls.Add(this.btnCalculateGas);
            this.tabGas.Controls.Add(this.resultsDataGridViewGas);
            this.tabGas.Controls.Add(this.groupFireCaseGas);
            this.tabGas.Location = new System.Drawing.Point(4, 29);
            this.tabGas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGas.Name = "tabGas";
            this.tabGas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabGas.Size = new System.Drawing.Size(1172, 1161);
            this.tabGas.TabIndex = 0;
            this.tabGas.Text = "Gas/Vapor";
            this.tabGas.UseVisualStyleBackColor = true;
            //
            // groupPSVConfiguration
            //
            this.groupPSVConfiguration.Controls.Add(this.chkFireCase);
            this.groupPSVConfiguration.Controls.Add(this.radioMultiplePSVs);
            this.groupPSVConfiguration.Controls.Add(this.radioSinglePSV);
            this.groupPSVConfiguration.Location = new System.Drawing.Point(852, 43);
            this.groupPSVConfiguration.Name = "groupPSVConfiguration";
            this.groupPSVConfiguration.Size = new System.Drawing.Size(300, 150);
            this.groupPSVConfiguration.TabIndex = 14;
            this.groupPSVConfiguration.TabStop = false;
            this.groupPSVConfiguration.Text = "PSV Configuration";
            //
            // chkFireCase
            //
            this.chkFireCase.AutoSize = true;
            this.chkFireCase.Location = new System.Drawing.Point(20, 100);
            this.chkFireCase.Name = "chkFireCase";
            this.chkFireCase.Size = new System.Drawing.Size(103, 24);
            this.chkFireCase.TabIndex = 2;
            this.chkFireCase.Text = "Fire Case";
            this.chkFireCase.UseVisualStyleBackColor = true;
            //
            // radioMultiplePSVs
            //
            this.radioMultiplePSVs.AutoSize = true;
            this.radioMultiplePSVs.Location = new System.Drawing.Point(20, 60);
            this.radioMultiplePSVs.Name = "radioMultiplePSVs";
            this.radioMultiplePSVs.Size = new System.Drawing.Size(132, 24);
            this.radioMultiplePSVs.TabIndex = 1;
            this.radioMultiplePSVs.Text = "Multiple PSVs";
            this.radioMultiplePSVs.UseVisualStyleBackColor = true;
            //
            // radioSinglePSV
            //
            this.radioSinglePSV.AutoSize = true;
            this.radioSinglePSV.Checked = true;
            this.radioSinglePSV.Location = new System.Drawing.Point(20, 30);
            this.radioSinglePSV.Name = "radioSinglePSV";
            this.radioSinglePSV.Size = new System.Drawing.Size(114, 24);
            this.radioSinglePSV.TabIndex = 0;
            this.radioSinglePSV.TabStop = true;
            this.radioSinglePSV.Text = "Single PSV";
            this.radioSinglePSV.UseVisualStyleBackColor = true;
            //
            // groupSizingScenarios
            //
            this.groupSizingScenarios.Controls.Add(this.chkTubeRupture);
            this.groupSizingScenarios.Controls.Add(this.chkThermalRelief);
            this.groupSizingScenarios.Controls.Add(this.chkRunawayReaction);
            this.groupSizingScenarios.Controls.Add(this.chkGasControlValveFailure);
            this.groupSizingScenarios.Controls.Add(this.chkBlockedOutlet);
            this.groupSizingScenarios.Controls.Add(this.chkGasPowerFailure);
            this.groupSizingScenarios.Controls.Add(this.chkGasRefluxFailure);
            this.groupSizingScenarios.Controls.Add(this.chkGasCompressorExpanderFailure);
            this.groupSizingScenarios.Location = new System.Drawing.Point(852, 208);
            this.groupSizingScenarios.Name = "groupSizingScenarios";
            this.groupSizingScenarios.Size = new System.Drawing.Size(300, 352);
            this.groupSizingScenarios.TabIndex = 13;
            this.groupSizingScenarios.TabStop = false;
            this.groupSizingScenarios.Text = "Sizing Scenarios";
            //
            // chkTubeRupture
            //
            this.chkTubeRupture.AutoSize = true;
            this.chkTubeRupture.Location = new System.Drawing.Point(20, 166);
            this.chkTubeRupture.Name = "chkTubeRupture";
            this.chkTubeRupture.Size = new System.Drawing.Size(133, 24);
            this.chkTubeRupture.TabIndex = 3;
            this.chkTubeRupture.Text = "Tube Rupture";
            this.chkTubeRupture.UseVisualStyleBackColor = true;
            //
            // chkThermalRelief
            //
            this.chkThermalRelief.AutoSize = true;
            this.chkThermalRelief.Location = new System.Drawing.Point(20, 136);
            this.chkThermalRelief.Name = "chkThermalRelief";
            this.chkThermalRelief.Size = new System.Drawing.Size(137, 24);
            this.chkThermalRelief.TabIndex = 2;
            this.chkThermalRelief.Text = "Thermal Relief";
            this.chkThermalRelief.UseVisualStyleBackColor = true;
            //
            // chkRunawayReaction
            //
            this.chkRunawayReaction.AutoSize = true;
            this.chkRunawayReaction.Location = new System.Drawing.Point(20, 106);
            this.chkRunawayReaction.Name = "chkRunawayReaction";
            this.chkRunawayReaction.Size = new System.Drawing.Size(169, 24);
            this.chkRunawayReaction.TabIndex = 1;
            this.chkRunawayReaction.Text = "Runaway Reaction";
            this.chkRunawayReaction.UseVisualStyleBackColor = true;
            //
            // chkGasControlValveFailure
            //
            this.chkGasControlValveFailure.AutoSize = true;
            this.chkGasControlValveFailure.Location = new System.Drawing.Point(20, 76);
            this.chkGasControlValveFailure.Name = "chkGasControlValveFailure";
            this.chkGasControlValveFailure.Size = new System.Drawing.Size(181, 24);
            this.chkGasControlValveFailure.TabIndex = 0;
            this.chkGasControlValveFailure.Text = "Control Valve Failure";
            this.chkGasControlValveFailure.UseVisualStyleBackColor = true;
            //
            // chkBlockedOutlet
            //
            this.chkBlockedOutlet.AutoSize = true;
            this.chkBlockedOutlet.Location = new System.Drawing.Point(20, 46);
            this.chkBlockedOutlet.Name = "chkBlockedOutlet";
            this.chkBlockedOutlet.Size = new System.Drawing.Size(139, 24);
            this.chkBlockedOutlet.TabIndex = 12;
            this.chkBlockedOutlet.Text = "Blocked Outlet";
            this.chkBlockedOutlet.UseVisualStyleBackColor = true;
            //
            // chkGasPowerFailure
            //
            this.chkGasPowerFailure.Location = new System.Drawing.Point(21, 226);
            this.chkGasPowerFailure.Name = "chkGasPowerFailure";
            this.chkGasPowerFailure.Size = new System.Drawing.Size(180, 24);
            this.chkGasPowerFailure.TabIndex = 13;
            this.chkGasPowerFailure.Text = "Power Failure";
            //
            // chkGasRefluxFailure
            //
            this.chkGasRefluxFailure.Location = new System.Drawing.Point(21, 196);
            this.chkGasRefluxFailure.Name = "chkGasRefluxFailure";
            this.chkGasRefluxFailure.Size = new System.Drawing.Size(157, 24);
            this.chkGasRefluxFailure.TabIndex = 15;
            this.chkGasRefluxFailure.Text = "Reflux Failure";
            //
            // chkGasCompressorExpanderFailure
            //
            this.chkGasCompressorExpanderFailure.Location = new System.Drawing.Point(21, 258);
            this.chkGasCompressorExpanderFailure.Name = "chkGasCompressorExpanderFailure";
            this.chkGasCompressorExpanderFailure.Size = new System.Drawing.Size(253, 24);
            this.chkGasCompressorExpanderFailure.TabIndex = 16;
            this.chkGasCompressorExpanderFailure.Text = "Compressor Expander Failure";
            //
            // checkBox1
            //
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(565, 596);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Has Rupture Disc";
            this.checkBox1.UseVisualStyleBackColor = true;
            //
            // txtReqFlowCapacity
            //
            this.txtReqFlowCapacity.Location = new System.Drawing.Point(334, 597);
            this.txtReqFlowCapacity.Name = "txtReqFlowCapacity";
            this.txtReqFlowCapacity.Size = new System.Drawing.Size(154, 26);
            this.txtReqFlowCapacity.TabIndex = 10;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 598);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Required Flow Capacity (SCFM)";
            //
            // groupPressures
            //
            this.groupPressures.Controls.Add(this.groupBackPressure);
            this.groupPressures.Controls.Add(this.txtOperatingPressure);
            this.groupPressures.Controls.Add(this.txtSystemMAWP);
            this.groupPressures.Controls.Add(this.txtAtmPressure);
            this.groupPressures.Controls.Add(this.label10);
            this.groupPressures.Controls.Add(this.label11);
            this.groupPressures.Controls.Add(this.label12);
            this.groupPressures.Location = new System.Drawing.Point(20, 284);
            this.groupPressures.Name = "groupPressures";
            this.groupPressures.Size = new System.Drawing.Size(800, 230);
            this.groupPressures.TabIndex = 8;
            this.groupPressures.TabStop = false;
            this.groupPressures.Text = "Pressures (psig)";
            //
            // groupBackPressure
            //
            this.groupBackPressure.Controls.Add(this.txtInletLoss);
            this.groupBackPressure.Controls.Add(this.txtInletLossPercent);
            this.groupBackPressure.Controls.Add(this.txtTotalBackPressure);
            this.groupBackPressure.Controls.Add(this.txtVariableSuperimposedBP);
            this.groupBackPressure.Controls.Add(this.txtConstantSuperimposedBP);
            this.groupBackPressure.Controls.Add(this.txtBuiltUpBP);
            this.groupBackPressure.Controls.Add(this.label17);
            this.groupBackPressure.Controls.Add(this.label18);
            this.groupBackPressure.Controls.Add(this.label19);
            this.groupBackPressure.Controls.Add(this.label20);
            this.groupBackPressure.Controls.Add(this.label21);
            this.groupBackPressure.Controls.Add(this.lblInletLossPsig);
            this.groupBackPressure.Location = new System.Drawing.Point(300, 20);
            this.groupBackPressure.Name = "groupBackPressure";
            this.groupBackPressure.Size = new System.Drawing.Size(480, 184);
            this.groupBackPressure.TabIndex = 0;
            this.groupBackPressure.TabStop = false;
            this.groupBackPressure.Text = "Back Pressure (psig)";
            //
            // txtInletLoss
            //
            this.txtInletLoss.Location = new System.Drawing.Point(405, 67);
            this.txtInletLoss.Name = "txtInletLoss";
            this.txtInletLoss.ReadOnly = true;
            this.txtInletLoss.Size = new System.Drawing.Size(50, 26);
            this.txtInletLoss.TabIndex = 5;
            this.txtInletLoss.Text = "0";
            //
            // txtInletLossPercent
            //
            this.txtInletLossPercent.Location = new System.Drawing.Point(400, 27);
            this.txtInletLossPercent.Name = "txtInletLossPercent";
            this.txtInletLossPercent.Size = new System.Drawing.Size(50, 26);
            this.txtInletLossPercent.TabIndex = 4;
            //
            // txtTotalBackPressure
            //
            this.txtTotalBackPressure.Location = new System.Drawing.Point(150, 147);
            this.txtTotalBackPressure.Name = "txtTotalBackPressure";
            this.txtTotalBackPressure.ReadOnly = true;
            this.txtTotalBackPressure.Size = new System.Drawing.Size(50, 26);
            this.txtTotalBackPressure.TabIndex = 3;
            this.txtTotalBackPressure.Text = "0";
            //
            // txtVariableSuperimposedBP
            //
            this.txtVariableSuperimposedBP.Location = new System.Drawing.Point(150, 107);
            this.txtVariableSuperimposedBP.Name = "txtVariableSuperimposedBP";
            this.txtVariableSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtVariableSuperimposedBP.TabIndex = 2;
            this.txtVariableSuperimposedBP.Text = "0";
            //
            // txtConstantSuperimposedBP
            //
            this.txtConstantSuperimposedBP.Location = new System.Drawing.Point(150, 67);
            this.txtConstantSuperimposedBP.Name = "txtConstantSuperimposedBP";
            this.txtConstantSuperimposedBP.Size = new System.Drawing.Size(50, 26);
            this.txtConstantSuperimposedBP.TabIndex = 1;
            this.txtConstantSuperimposedBP.Text = "0";
            //
            // txtBuiltUpBP
            //
            this.txtBuiltUpBP.Location = new System.Drawing.Point(150, 27);
            this.txtBuiltUpBP.Name = "txtBuiltUpBP";
            this.txtBuiltUpBP.Size = new System.Drawing.Size(50, 26);
            this.txtBuiltUpBP.TabIndex = 0;
            this.txtBuiltUpBP.Text = "0";
            //
            // label17
            //
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Built-Up:";
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "Constant Super.:";
            //
            // label19
            //
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Variable Super.:";
            //
            // label20
            //
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 20);
            this.label20.TabIndex = 3;
            this.label20.Text = "Total Back Press.:";
            //
            // label21
            //
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(250, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 20);
            this.label21.TabIndex = 4;
            this.label21.Text = "Inlet Loss %:";
            //
            // lblInletLossPsig
            //
            this.lblInletLossPsig.AutoSize = true;
            this.lblInletLossPsig.Location = new System.Drawing.Point(250, 70);
            this.lblInletLossPsig.Name = "lblInletLossPsig";
            this.lblInletLossPsig.Size = new System.Drawing.Size(125, 20);
            this.lblInletLossPsig.TabIndex = 6;
            this.lblInletLossPsig.Text = "Inlet Loss (psig):";
            //
            // txtOperatingPressure
            //
            this.txtOperatingPressure.Location = new System.Drawing.Point(150, 107);
            this.txtOperatingPressure.Name = "txtOperatingPressure";
            this.txtOperatingPressure.Size = new System.Drawing.Size(100, 26);
            this.txtOperatingPressure.TabIndex = 3;
            //
            // txtSystemMAWP
            //
            this.txtSystemMAWP.Location = new System.Drawing.Point(150, 67);
            this.txtSystemMAWP.Name = "txtSystemMAWP";
            this.txtSystemMAWP.Size = new System.Drawing.Size(100, 26);
            this.txtSystemMAWP.TabIndex = 2;
            //
            // txtAtmPressure
            //
            this.txtAtmPressure.Location = new System.Drawing.Point(150, 27);
            this.txtAtmPressure.Name = "txtAtmPressure";
            this.txtAtmPressure.Size = new System.Drawing.Size(100, 26);
            this.txtAtmPressure.TabIndex = 1;
            this.txtAtmPressure.Text = "14.696";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Atm. Pressure:";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "System MAWP:";
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Operating Pressure:";
            //
            // groupTemperatures
            //
            this.groupTemperatures.Controls.Add(this.txtNormalInletTemp);
            this.groupTemperatures.Controls.Add(this.txtOperatingTemp);
            this.groupTemperatures.Controls.Add(this.txtRelievingTemp);
            this.groupTemperatures.Controls.Add(this.label9);
            this.groupTemperatures.Controls.Add(this.label8);
            this.groupTemperatures.Controls.Add(this.label7);
            this.groupTemperatures.Location = new System.Drawing.Point(470, 24);
            this.groupTemperatures.Name = "groupTemperatures";
            this.groupTemperatures.Size = new System.Drawing.Size(350, 185);
            this.groupTemperatures.TabIndex = 7;
            this.groupTemperatures.TabStop = false;
            this.groupTemperatures.Text = "Temperatures (°F)";
            //
            // txtNormalInletTemp
            //
            this.txtNormalInletTemp.Location = new System.Drawing.Point(180, 120);
            this.txtNormalInletTemp.Name = "txtNormalInletTemp";
            this.txtNormalInletTemp.Size = new System.Drawing.Size(100, 26);
            this.txtNormalInletTemp.TabIndex = 2;
            //
            // txtOperatingTemp
            //
            this.txtOperatingTemp.Location = new System.Drawing.Point(180, 80);
            this.txtOperatingTemp.Name = "txtOperatingTemp";
            this.txtOperatingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtOperatingTemp.TabIndex = 1;
            //
            // txtRelievingTemp
            //
            this.txtRelievingTemp.Location = new System.Drawing.Point(180, 40);
            this.txtRelievingTemp.Name = "txtRelievingTemp";
            this.txtRelievingTemp.Size = new System.Drawing.Size(100, 26);
            this.txtRelievingTemp.TabIndex = 0;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Normal Inlet Temp";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Operating Temp";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Relieving Temp";
            //
            // groupFluidProperties
            //
            this.groupFluidProperties.Controls.Add(this.txtSpecificGravity);
            this.groupFluidProperties.Controls.Add(this.txtMolecularWeight);
            this.groupFluidProperties.Controls.Add(this.label22);
            this.groupFluidProperties.Controls.Add(this.label6);
            this.groupFluidProperties.Controls.Add(this.label5);
            this.groupFluidProperties.Controls.Add(this.label4);
            this.groupFluidProperties.Controls.Add(this.label2);
            this.groupFluidProperties.Controls.Add(this.txtCompressibility);
            this.groupFluidProperties.Controls.Add(this.txtSpecificHeatRatio);
            this.groupFluidProperties.Controls.Add(this.cmbGasFluid);
            this.groupFluidProperties.Location = new System.Drawing.Point(20, 20);
            this.groupFluidProperties.Name = "groupFluidProperties";
            this.groupFluidProperties.Size = new System.Drawing.Size(414, 221);
            this.groupFluidProperties.TabIndex = 6;
            this.groupFluidProperties.TabStop = false;
            this.groupFluidProperties.Text = "Fluid Properties";
            //
            // txtSpecificGravity
            //
            this.txtSpecificGravity.Location = new System.Drawing.Point(209, 96);
            this.txtSpecificGravity.Name = "txtSpecificGravity";
            this.txtSpecificGravity.Size = new System.Drawing.Size(145, 26);
            this.txtSpecificGravity.TabIndex = 7;
            //
            // txtMolecularWeight
            //
            this.txtMolecularWeight.Location = new System.Drawing.Point(212, 62);
            this.txtMolecularWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMolecularWeight.Name = "txtMolecularWeight";
            this.txtMolecularWeight.Size = new System.Drawing.Size(148, 26);
            this.txtMolecularWeight.TabIndex = 6;
            //
            // label22
            //
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(37, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 20);
            this.label22.TabIndex = 5;
            this.label22.Text = "Specific Gravity";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Compressibility";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "k. (Cp / Cv)";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Molecular Weight";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fluid";
            //
            // txtCompressibility
            //
            this.txtCompressibility.Location = new System.Drawing.Point(205, 169);
            this.txtCompressibility.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCompressibility.Name = "txtCompressibility";
            this.txtCompressibility.Size = new System.Drawing.Size(148, 26);
            this.txtCompressibility.TabIndex = 1;
            //
            // txtSpecificHeatRatio
            //
            this.txtSpecificHeatRatio.Location = new System.Drawing.Point(205, 132);
            this.txtSpecificHeatRatio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecificHeatRatio.Name = "txtSpecificHeatRatio";
            this.txtSpecificHeatRatio.Size = new System.Drawing.Size(148, 26);
            this.txtSpecificHeatRatio.TabIndex = 1;
            //
            // cmbGasFluid
            //
            this.cmbGasFluid.FormattingEnabled = true;
            this.cmbGasFluid.Location = new System.Drawing.Point(114, 32);
            this.cmbGasFluid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbGasFluid.Name = "cmbGasFluid";
            this.cmbGasFluid.Size = new System.Drawing.Size(298, 28);
            this.cmbGasFluid.TabIndex = 0;
            //
            // lblGasResult
            //
            this.lblGasResult.AutoSize = true;
            this.lblGasResult.Location = new System.Drawing.Point(30, 550);
            this.lblGasResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGasResult.Name = "lblGasResult";
            this.lblGasResult.Size = new System.Drawing.Size(0, 20);
            this.lblGasResult.TabIndex = 3;
            //
            // btnCalculateGas
            //
            this.btnCalculateGas.Location = new System.Drawing.Point(350, 850);
            this.btnCalculateGas.Name = "btnCalculateGas";
            this.btnCalculateGas.Size = new System.Drawing.Size(120, 35);
            this.btnCalculateGas.TabIndex = 15;
            this.btnCalculateGas.Text = "Calculate Gas";
            this.btnCalculateGas.UseVisualStyleBackColor = true;
            this.btnCalculateGas.Click += new System.EventHandler(this.BtnCalculateGas_Click);
            //
            // resultsDataGridViewGas
            //
            this.resultsDataGridViewGas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridViewGas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGasSizingScenario,
            this.colGasTotalArea,
            this.colGasAreaPerValve,
            this.colGasSelectedOrifice});
            this.resultsDataGridViewGas.Location = new System.Drawing.Point(20, 640);
            this.resultsDataGridViewGas.Name = "resultsDataGridViewGas";
            this.resultsDataGridViewGas.RowHeadersWidth = 62;
            this.resultsDataGridViewGas.RowTemplate.Height = 28;
            this.resultsDataGridViewGas.Size = new System.Drawing.Size(700, 200);
            this.resultsDataGridViewGas.TabIndex = 16;
            //
            // colGasSizingScenario
            //
            this.colGasSizingScenario.HeaderText = "Sizing Scenario";
            this.colGasSizingScenario.MinimumWidth = 8;
            this.colGasSizingScenario.Name = "colGasSizingScenario";
            this.colGasSizingScenario.Width = 150;
            //
            // colGasTotalArea
            //
            this.colGasTotalArea.HeaderText = "Total Required Area (in²)";
            this.colGasTotalArea.MinimumWidth = 8;
            this.colGasTotalArea.Name = "colGasTotalArea";
            this.colGasTotalArea.Width = 150;
            //
            // colGasAreaPerValve
            //
            this.colGasAreaPerValve.HeaderText = "Area per Valve (in²)";
            this.colGasAreaPerValve.MinimumWidth = 8;
            this.colGasAreaPerValve.Name = "colGasAreaPerValve";
            this.colGasAreaPerValve.Width = 150;
            //
            // colGasSelectedOrifice
            //
            this.colGasSelectedOrifice.HeaderText = "Selected Orifice";
            this.colGasSelectedOrifice.MinimumWidth = 8;
            this.colGasSelectedOrifice.Name = "colGasSelectedOrifice";
            this.colGasSelectedOrifice.Width = 150;
            //
            // groupFireCaseGas
            //
            this.groupFireCaseGas.Controls.Add(this.radioWettedGas);
            this.groupFireCaseGas.Controls.Add(this.radioUnwettedGas);
            this.groupFireCaseGas.Controls.Add(this.lblEnvFactorWettedGas);
            this.groupFireCaseGas.Controls.Add(this.txtEnvFactorWettedGas);
            this.groupFireCaseGas.Controls.Add(this.lblLatentHeatGas);
            this.groupFireCaseGas.Controls.Add(this.txtLatentHeatGas);
            this.groupFireCaseGas.Controls.Add(this.lblWettedAreaGas);
            this.groupFireCaseGas.Controls.Add(this.txtWettedAreaGas);
            this.groupFireCaseGas.Controls.Add(this.lblEnvFactorUnwettedGas);
            this.groupFireCaseGas.Controls.Add(this.txtEnvFactorUnwettedGas);
            this.groupFireCaseGas.Controls.Add(this.lblFireSizingFactorGas);
            this.groupFireCaseGas.Controls.Add(this.txtFireSizingFactorGas);
            this.groupFireCaseGas.Controls.Add(this.lblSurfaceAreaUnwettedGas);
            this.groupFireCaseGas.Controls.Add(this.txtSurfaceAreaUnwettedGas);
            this.groupFireCaseGas.Location = new System.Drawing.Point(852, 587);
            this.groupFireCaseGas.Name = "groupFireCaseGas";
            this.groupFireCaseGas.Size = new System.Drawing.Size(300, 370);
            this.groupFireCaseGas.TabIndex = 17;
            this.groupFireCaseGas.TabStop = false;
            this.groupFireCaseGas.Text = "Fire Case Parameters";
            //
            // radioWettedGas
            //
            this.radioWettedGas.AutoSize = true;
            this.radioWettedGas.Location = new System.Drawing.Point(20, 30);
            this.radioWettedGas.Name = "radioWettedGas";
            this.radioWettedGas.Size = new System.Drawing.Size(86, 24);
            this.radioWettedGas.TabIndex = 0;
            this.radioWettedGas.TabStop = true;
            this.radioWettedGas.Text = "Wetted";
            this.radioWettedGas.UseVisualStyleBackColor = true;
            //
            // radioUnwettedGas
            //
            this.radioUnwettedGas.AutoSize = true;
            this.radioUnwettedGas.Location = new System.Drawing.Point(150, 30);
            this.radioUnwettedGas.Name = "radioUnwettedGas";
            this.radioUnwettedGas.Size = new System.Drawing.Size(103, 24);
            this.radioUnwettedGas.TabIndex = 1;
            this.radioUnwettedGas.TabStop = true;
            this.radioUnwettedGas.Text = "Unwetted";
            this.radioUnwettedGas.UseVisualStyleBackColor = true;
            //
            // lblEnvFactorWettedGas
            //
            this.lblEnvFactorWettedGas.AutoSize = true;
            this.lblEnvFactorWettedGas.Location = new System.Drawing.Point(17, 100);
            this.lblEnvFactorWettedGas.Name = "lblEnvFactorWettedGas";
            this.lblEnvFactorWettedGas.Size = new System.Drawing.Size(160, 20);
            this.lblEnvFactorWettedGas.TabIndex = 2;
            this.lblEnvFactorWettedGas.Text = "Env. Factor (Wetted):";
            //
            // txtEnvFactorWettedGas
            //
            this.txtEnvFactorWettedGas.Location = new System.Drawing.Point(180, 97);
            this.txtEnvFactorWettedGas.Name = "txtEnvFactorWettedGas";
            this.txtEnvFactorWettedGas.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorWettedGas.TabIndex = 3;
            //
            // lblLatentHeatGas
            //
            this.lblLatentHeatGas.AutoSize = true;
            this.lblLatentHeatGas.Location = new System.Drawing.Point(17, 140);
            this.lblLatentHeatGas.Name = "lblLatentHeatGas";
            this.lblLatentHeatGas.Size = new System.Drawing.Size(98, 20);
            this.lblLatentHeatGas.TabIndex = 4;
            this.lblLatentHeatGas.Text = "Latent Heat:";
            //
            // txtLatentHeatGas
            //
            this.txtLatentHeatGas.Location = new System.Drawing.Point(180, 137);
            this.txtLatentHeatGas.Name = "txtLatentHeatGas";
            this.txtLatentHeatGas.Size = new System.Drawing.Size(100, 26);
            this.txtLatentHeatGas.TabIndex = 5;
            //
            // lblWettedAreaGas
            //
            this.lblWettedAreaGas.AutoSize = true;
            this.lblWettedAreaGas.Location = new System.Drawing.Point(17, 180);
            this.lblWettedAreaGas.Name = "lblWettedAreaGas";
            this.lblWettedAreaGas.Size = new System.Drawing.Size(103, 20);
            this.lblWettedAreaGas.TabIndex = 6;
            this.lblWettedAreaGas.Text = "Wetted Area:";
            //
            // txtWettedAreaGas
            //
            this.txtWettedAreaGas.Location = new System.Drawing.Point(180, 177);
            this.txtWettedAreaGas.Name = "txtWettedAreaGas";
            this.txtWettedAreaGas.Size = new System.Drawing.Size(100, 26);
            this.txtWettedAreaGas.TabIndex = 7;
            //
            // lblEnvFactorUnwettedGas
            //
            this.lblEnvFactorUnwettedGas.AutoSize = true;
            this.lblEnvFactorUnwettedGas.Location = new System.Drawing.Point(17, 220);
            this.lblEnvFactorUnwettedGas.Name = "lblEnvFactorUnwettedGas";
            this.lblEnvFactorUnwettedGas.Size = new System.Drawing.Size(177, 20);
            this.lblEnvFactorUnwettedGas.TabIndex = 8;
            this.lblEnvFactorUnwettedGas.Text = "Env. Factor (Unwetted):";
            //
            // txtEnvFactorUnwettedGas
            //
            this.txtEnvFactorUnwettedGas.Location = new System.Drawing.Point(180, 217);
            this.txtEnvFactorUnwettedGas.Name = "txtEnvFactorUnwettedGas";
            this.txtEnvFactorUnwettedGas.Size = new System.Drawing.Size(100, 26);
            this.txtEnvFactorUnwettedGas.TabIndex = 9;
            //
            // lblFireSizingFactorGas
            //
            this.lblFireSizingFactorGas.AutoSize = true;
            this.lblFireSizingFactorGas.Location = new System.Drawing.Point(17, 260);
            this.lblFireSizingFactorGas.Name = "lblFireSizingFactorGas";
            this.lblFireSizingFactorGas.Size = new System.Drawing.Size(137, 20);
            this.lblFireSizingFactorGas.TabIndex = 10;
            this.lblFireSizingFactorGas.Text = "Fire Sizing Factor:";
            //
            // txtFireSizingFactorGas
            //
            this.txtFireSizingFactorGas.Location = new System.Drawing.Point(180, 257);
            this.txtFireSizingFactorGas.Name = "txtFireSizingFactorGas";
            this.txtFireSizingFactorGas.Size = new System.Drawing.Size(100, 26);
            this.txtFireSizingFactorGas.TabIndex = 11;
            this.txtFireSizingFactorGas.Text = "0.045";
            //
            // lblSurfaceAreaUnwettedGas
            //
            this.lblSurfaceAreaUnwettedGas.AutoSize = true;
            this.lblSurfaceAreaUnwettedGas.Location = new System.Drawing.Point(17, 300);
            this.lblSurfaceAreaUnwettedGas.Name = "lblSurfaceAreaUnwettedGas";
            this.lblSurfaceAreaUnwettedGas.Size = new System.Drawing.Size(171, 20);
            this.lblSurfaceAreaUnwettedGas.TabIndex = 12;
            this.lblSurfaceAreaUnwettedGas.Text = "Surface Area (Unwet.):";
            //
            // txtSurfaceAreaUnwettedGas
            //
            this.txtSurfaceAreaUnwettedGas.Location = new System.Drawing.Point(180, 297);
            this.txtSurfaceAreaUnwettedGas.Name = "txtSurfaceAreaUnwettedGas";
            this.txtSurfaceAreaUnwettedGas.Size = new System.Drawing.Size(100, 26);
            this.txtSurfaceAreaUnwettedGas.TabIndex = 13;
            //
            // groupCompressorExpanderFailure
            //
            this.groupCompressorExpanderFailure.Controls.Add(this.txtCompressorCapacity);
            this.groupCompressorExpanderFailure.Controls.Add(this.label71);
            this.groupCompressorExpanderFailure.Location = new System.Drawing.Point(10, 10);
            this.groupCompressorExpanderFailure.Name = "groupCompressorExpanderFailure";
            this.groupCompressorExpanderFailure.Size = new System.Drawing.Size(350, 100);
            this.groupCompressorExpanderFailure.TabIndex = 28;
            this.groupCompressorExpanderFailure.TabStop = false;
            this.groupCompressorExpanderFailure.Tag = "ScenarioDetail";
            this.groupCompressorExpanderFailure.Text = "Compressor/Expander Failure";
            this.groupCompressorExpanderFailure.Visible = false;
            //
            // txtCompressorCapacity
            //
            this.txtCompressorCapacity.Location = new System.Drawing.Point(180, 40);
            this.txtCompressorCapacity.Name = "txtCompressorCapacity";
            this.txtCompressorCapacity.Size = new System.Drawing.Size(100, 26);
            this.txtCompressorCapacity.TabIndex = 0;
            //
            // label71
            //
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(30, 43);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(118, 20);
            this.label71.TabIndex = 1;
            this.label71.Text = "Rated Capacity";
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabGas);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1180, 1194);
            this.tabControl1.TabIndex = 0;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.scenarioDetailsPanel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1582, 1200);
            this.tableLayoutPanel1.TabIndex = 1;
            //
            // scenarioDetailsPanel
            //
            this.scenarioDetailsPanel.Controls.Add(this.groupTubeRupture);
            this.scenarioDetailsPanel.Controls.Add(this.groupControlValveFailure);
            this.scenarioDetailsPanel.Controls.Add(this.groupPowerFailure);
            this.scenarioDetailsPanel.Controls.Add(this.groupHydraulicHammer);
            this.scenarioDetailsPanel.Controls.Add(this.groupRefluxFailure);
            this.scenarioDetailsPanel.Controls.Add(this.groupCompressorExpanderFailure);
            this.scenarioDetailsPanel.Controls.Add(this.groupBlockedOutlet);
            this.scenarioDetailsPanel.Controls.Add(this.groupThermalRelief);
            this.scenarioDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioDetailsPanel.Location = new System.Drawing.Point(1189, 3);
            this.scenarioDetailsPanel.Name = "scenarioDetailsPanel";
            this.scenarioDetailsPanel.Size = new System.Drawing.Size(390, 1194);
            this.scenarioDetailsPanel.TabIndex = 1;
            //
            // groupBlockedOutlet
            //
            this.groupBlockedOutlet.Controls.Add(this.lblEquipmentType);
            this.groupBlockedOutlet.Controls.Add(this.cmbEquipmentType);
            this.groupBlockedOutlet.Controls.Add(this.lblPumpType);
            this.groupBlockedOutlet.Controls.Add(this.cmbPumpType);
            this.groupBlockedOutlet.Controls.Add(this.lblPumpCurve);
            this.groupBlockedOutlet.Controls.Add(this.txtPumpCurve);
            this.groupBlockedOutlet.Location = new System.Drawing.Point(10, 560);
            this.groupBlockedOutlet.Name = "groupBlockedOutlet";
            this.groupBlockedOutlet.Size = new System.Drawing.Size(350, 150);
            this.groupBlockedOutlet.TabIndex = 29;
            this.groupBlockedOutlet.TabStop = false;
            this.groupBlockedOutlet.Tag = "ScenarioDetail";
            this.groupBlockedOutlet.Text = "Blocked Outlet";
            this.groupBlockedOutlet.Visible = false;
            //
            // lblEquipmentType
            //
            this.lblEquipmentType.AutoSize = true;
            this.lblEquipmentType.Location = new System.Drawing.Point(30, 43);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(124, 20);
            this.lblEquipmentType.TabIndex = 1;
            this.lblEquipmentType.Text = "Equipment Type";
            //
            // cmbEquipmentType
            //
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Items.AddRange(new object[] {
            "Pump",
            "Compressor",
            "Heat Exchanger"});
            this.cmbEquipmentType.Location = new System.Drawing.Point(180, 40);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(150, 28);
            this.cmbEquipmentType.TabIndex = 0;
            //
            // lblPumpType
            //
            this.lblPumpType.AutoSize = true;
            this.lblPumpType.Location = new System.Drawing.Point(30, 83);
            this.lblPumpType.Name = "lblPumpType";
            this.lblPumpType.Size = new System.Drawing.Size(90, 20);
            this.lblPumpType.TabIndex = 4;
            this.lblPumpType.Text = "Pump Type";
            this.lblPumpType.Visible = false;
            //
            // cmbPumpType
            //
            this.cmbPumpType.FormattingEnabled = true;
            this.cmbPumpType.Items.AddRange(new object[] {
            "Centrifugal",
            "Positive Displacement"});
            this.cmbPumpType.Location = new System.Drawing.Point(180, 80);
            this.cmbPumpType.Name = "cmbPumpType";
            this.cmbPumpType.Size = new System.Drawing.Size(150, 28);
            this.cmbPumpType.TabIndex = 5;
            this.cmbPumpType.Visible = false;
            //
            // lblPumpCurve
            //
            this.lblPumpCurve.AutoSize = true;
            this.lblPumpCurve.Location = new System.Drawing.Point(30, 83);
            this.lblPumpCurve.Name = "lblPumpCurve";
            this.lblPumpCurve.Size = new System.Drawing.Size(95, 20);
            this.lblPumpCurve.TabIndex = 3;
            this.lblPumpCurve.Text = "Pump Curve";
            this.lblPumpCurve.Visible = false;
            //
            // txtPumpCurve
            //
            this.txtPumpCurve.Location = new System.Drawing.Point(180, 80);
            this.txtPumpCurve.Name = "txtPumpCurve";
            this.txtPumpCurve.Size = new System.Drawing.Size(150, 26);
            this.txtPumpCurve.TabIndex = 2;
            this.txtPumpCurve.Visible = false;
            //
            // chkControlValveFailure
            //
            this.chkControlValveFailure.AutoSize = true;
            this.chkControlValveFailure.Location = new System.Drawing.Point(20, 76);
            this.chkControlValveFailure.Name = "chkControlValveFailure";
            this.chkControlValveFailure.Size = new System.Drawing.Size(181, 24);
            this.chkControlValveFailure.TabIndex = 0;
            this.chkControlValveFailure.Text = "Control Valve Failure";
            this.chkControlValveFailure.UseVisualStyleBackColor = true;
            //
            // PSVSizing
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PSVSizing";
            this.Text = "PSV Sizing Tool";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupSteamFluidProperties.ResumeLayout(false);
            this.groupSteamFluidProperties.PerformLayout();
            this.groupSteamTemperatures.ResumeLayout(false);
            this.groupSteamTemperatures.PerformLayout();
            this.groupSteamPSVConfig.ResumeLayout(false);
            this.groupSteamPSVConfig.PerformLayout();
            this.groupSteamSizingScenarios.ResumeLayout(false);
            this.groupSteamSizingScenarios.PerformLayout();
            this.groupSteamPressures.ResumeLayout(false);
            this.groupSteamPressures.PerformLayout();
            this.groupSteamBackPressure.ResumeLayout(false);
            this.groupSteamBackPressure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewSteam)).EndInit();
            this.groupFireCaseSteam.ResumeLayout(false);
            this.groupFireCaseSteam.PerformLayout();
            this.groupControlValveFailure.ResumeLayout(false);
            this.groupControlValveFailure.PerformLayout();
            this.groupPowerFailure.ResumeLayout(false);
            this.groupPowerFailure.PerformLayout();
            this.groupHydraulicHammer.ResumeLayout(false);
            this.groupHydraulicHammer.PerformLayout();
            this.groupRefluxFailure.ResumeLayout(false);
            this.groupRefluxFailure.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupLiquidFluidProperties.ResumeLayout(false);
            this.groupLiquidFluidProperties.PerformLayout();
            this.groupLiquidTemperatures.ResumeLayout(false);
            this.groupLiquidTemperatures.PerformLayout();
            this.groupLiquidPSVConfig.ResumeLayout(false);
            this.groupLiquidPSVConfig.PerformLayout();
            this.groupLiquidSizingScenarios.ResumeLayout(false);
            this.groupLiquidSizingScenarios.PerformLayout();
            this.groupLiquidPressures.ResumeLayout(false);
            this.groupLiquidPressures.PerformLayout();
            this.groupLiquidBackPressure.ResumeLayout(false);
            this.groupLiquidBackPressure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewLiquid)).EndInit();
            this.groupFireCaseLiquid.ResumeLayout(false);
            this.groupFireCaseLiquid.PerformLayout();
            this.tabGas.ResumeLayout(false);
            this.tabGas.PerformLayout();
            this.groupPSVConfiguration.ResumeLayout(false);
            this.groupPSVConfiguration.PerformLayout();
            this.groupSizingScenarios.ResumeLayout(false);
            this.groupSizingScenarios.PerformLayout();
            this.groupPressures.ResumeLayout(false);
            this.groupPressures.PerformLayout();
            this.groupBackPressure.ResumeLayout(false);
            this.groupBackPressure.PerformLayout();
            this.groupTemperatures.ResumeLayout(false);
            this.groupTemperatures.PerformLayout();
            this.groupFluidProperties.ResumeLayout(false);
            this.groupFluidProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridViewGas)).EndInit();
            this.groupFireCaseGas.ResumeLayout(false);
            this.groupFireCaseGas.PerformLayout();
            this.groupCompressorExpanderFailure.ResumeLayout(false);
            this.groupCompressorExpanderFailure.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.scenarioDetailsPanel.ResumeLayout(false);
            this.groupTubeRupture.ResumeLayout(false);
            this.groupTubeRupture.PerformLayout();
            this.groupBlockedOutlet.ResumeLayout(false);
            this.groupBlockedOutlet.PerformLayout();
            this.groupThermalRelief.ResumeLayout(false);
            this.groupThermalRelief.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbTwoPhaseFluid;
        private System.Windows.Forms.TextBox txtTwoPhaseReqFlowCapacity;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Button btnCalculateTwoPhase;
        private System.Windows.Forms.Label lblTwoPhaseResult;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupSteamFluidProperties;
        private System.Windows.Forms.TextBox txtSteamMolecularWeight;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtSteamCompressibility;
        private System.Windows.Forms.TextBox txtSteamSpecificHeatRatio;
        private System.Windows.Forms.ComboBox cmbSteamFluid;
        private System.Windows.Forms.GroupBox groupSteamTemperatures;
        private System.Windows.Forms.TextBox txtSteamNormalInletTemp;
        private System.Windows.Forms.TextBox txtSteamOperatingTemp;
        private System.Windows.Forms.TextBox txtSteamRelievingTemp;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.GroupBox groupSteamPSVConfig;
        private System.Windows.Forms.CheckBox chkSteamFireCase;
        private System.Windows.Forms.RadioButton radioSteamMultiplePSVs;
        private System.Windows.Forms.RadioButton radioSteamSinglePSV;
        private System.Windows.Forms.GroupBox groupSteamSizingScenarios;
        private System.Windows.Forms.CheckBox chkSteamTubeRupture;
        private System.Windows.Forms.CheckBox chkSteamThermalRelief;
        private System.Windows.Forms.CheckBox chkSteamRunawayReaction;
        private System.Windows.Forms.CheckBox chkSteamControlValveFailure;
        private System.Windows.Forms.CheckBox chkSteamBlockedOutlet;
        private System.Windows.Forms.CheckBox chkSteamRuptureDisc;
        private System.Windows.Forms.TextBox txtSteamReqFlowCapacity;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label lblSteamResult;
        private System.Windows.Forms.GroupBox groupSteamPressures;
        private System.Windows.Forms.GroupBox groupSteamBackPressure;
        private System.Windows.Forms.TextBox txtSteamInletLoss;
        private System.Windows.Forms.TextBox txtSteamInletLossPercent;
        private System.Windows.Forms.TextBox txtSteamTotalBackPressure;
        private System.Windows.Forms.TextBox txtSteamVariableSuperimposedBP;
        private System.Windows.Forms.TextBox txtSteamConstantSuperimposedBP;
        private System.Windows.Forms.TextBox txtSteamBuiltUpBP;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label lblSteamInletLossPsig;
        private System.Windows.Forms.TextBox txtSteamOperatingPressure;
        private System.Windows.Forms.TextBox txtSteamSystemMAWP;
        private System.Windows.Forms.TextBox txtSteamAtmPressure;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnCalculateSteam;
        private System.Windows.Forms.DataGridView resultsDataGridViewSteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSteamSizingScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSteamTotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSteamAreaPerValve;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSteamSelectedOrifice;
        private System.Windows.Forms.GroupBox groupFireCaseSteam;
        private System.Windows.Forms.RadioButton radioWettedSteam;
        private System.Windows.Forms.RadioButton radioUnwettedSteam;
        private System.Windows.Forms.Label lblEnvFactorWettedSteam;
        private System.Windows.Forms.TextBox txtEnvFactorWettedSteam;
        private System.Windows.Forms.Label lblLatentHeatSteam;
        private System.Windows.Forms.TextBox txtLatentHeatSteam;
        private System.Windows.Forms.Label lblWettedAreaSteam;
        private System.Windows.Forms.TextBox txtWettedAreaSteam;
        private System.Windows.Forms.Label lblEnvFactorUnwettedSteam;
        private System.Windows.Forms.TextBox txtEnvFactorUnwettedSteam;
        private System.Windows.Forms.Label lblFireSizingFactorSteam;
        private System.Windows.Forms.TextBox txtFireSizingFactorSteam;
        private System.Windows.Forms.Label lblSurfaceAreaUnwettedSteam;
        private System.Windows.Forms.TextBox txtSurfaceAreaUnwettedSteam;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupLiquidFluidProperties;
        private System.Windows.Forms.TextBox txtLiquidViscosity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLiquidSpecificGravity;
        private System.Windows.Forms.ComboBox cmbLiquidFluid;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtLiquidVesselVolume;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txtLiquidTempChange;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox txtLiquidPumpCurve;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.GroupBox groupControlValveFailure;
        private System.Windows.Forms.TextBox txtCv;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label lblUpstreamPressure;
        private System.Windows.Forms.TextBox txtUpstreamPressure;
        private System.Windows.Forms.Label lblDownstreamPressure;
        private System.Windows.Forms.TextBox txtDownstreamPressure;
        private System.Windows.Forms.GroupBox groupPowerFailure;
        private System.Windows.Forms.TextBox txtPumpHead;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.GroupBox groupHydraulicHammer;
        private System.Windows.Forms.TextBox txtValveCloseTime;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.GroupBox groupRefluxFailure;
        private System.Windows.Forms.TextBox txtRefluxRatio;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label lblBoilupRate;
        private System.Windows.Forms.TextBox txtBoilupRate;
        private System.Windows.Forms.GroupBox groupCompressorExpanderFailure;
        private System.Windows.Forms.TextBox txtCompressorCapacity;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.GroupBox groupBlockedOutlet;
        private System.Windows.Forms.Label lblEquipmentType;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.Label lblPumpType;
        private System.Windows.Forms.ComboBox cmbPumpType;
        private System.Windows.Forms.Label lblPumpCurve;
        private System.Windows.Forms.TextBox txtPumpCurve;
        private System.Windows.Forms.GroupBox groupLiquidTemperatures;
        private System.Windows.Forms.TextBox txtLiquidNormalInletTemp;
        private System.Windows.Forms.TextBox txtLiquidOperatingTemp;
        private System.Windows.Forms.TextBox txtLiquidRelievingTemp;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupLiquidPSVConfig;
        private System.Windows.Forms.CheckBox chkLiquidFireCase;
        private System.Windows.Forms.RadioButton radioLiquidMultiplePSVs;
        private System.Windows.Forms.RadioButton radioLiquidSinglePSV;
        private System.Windows.Forms.GroupBox groupLiquidSizingScenarios;
        private System.Windows.Forms.CheckBox chkLiquidTubeRupture;
        private System.Windows.Forms.CheckBox chkLiquidThermalRelief;
        private System.Windows.Forms.CheckBox chkLiquidRunawayReaction;
        private System.Windows.Forms.CheckBox chkLiquidControlValveFailure;
        private System.Windows.Forms.CheckBox chkLiquidBlockedOutlet;
        private System.Windows.Forms.CheckBox chkLiquidPowerFailure;
        private System.Windows.Forms.CheckBox chkLiquidRefluxFailure;
        private System.Windows.Forms.CheckBox chkGasControlValveFailure;
        private System.Windows.Forms.CheckBox chkGasPowerFailure;
        private System.Windows.Forms.CheckBox chkGasRefluxFailure;
        private System.Windows.Forms.CheckBox chkSteamPowerFailure;
        private System.Windows.Forms.CheckBox chkSteamRefluxFailure;
        private System.Windows.Forms.CheckBox chkGasCompressorExpanderFailure;
        private System.Windows.Forms.CheckBox chkTubeRupture;
        private System.Windows.Forms.CheckBox chkThermalRelief;
        private System.Windows.Forms.CheckBox chkRunawayReaction;
        private System.Windows.Forms.CheckBox chkBlockedOutlet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkLiquidRuptureDisc;
        private System.Windows.Forms.TextBox txtLiquidReqFlowCapacity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupLiquidPressures;
        private System.Windows.Forms.GroupBox groupLiquidBackPressure;
        private System.Windows.Forms.TextBox txtLiquidInletLoss;
        private System.Windows.Forms.TextBox txtLiquidInletLossPercent;
        private System.Windows.Forms.TextBox txtLiquidTotalBackPressure;
        private System.Windows.Forms.TextBox txtLiquidVariableSuperimposedBP;
        private System.Windows.Forms.TextBox txtLiquidConstantSuperimposedBP;
        private System.Windows.Forms.TextBox txtLiquidBuiltUpBP;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblLiquidInletLossPsig;
        private System.Windows.Forms.TextBox txtLiquidOperatingPressure;
        private System.Windows.Forms.TextBox txtLiquidSystemMAWP;
        private System.Windows.Forms.TextBox txtLiquidAtmPressure;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button btnCalculateLiquid;
        private System.Windows.Forms.Label lblLiquidResult;
        private System.Windows.Forms.DataGridView resultsDataGridViewLiquid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiquidSizingScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiquidTotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiquidAreaPerValve;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLiquidSelectedOrifice;
        private System.Windows.Forms.GroupBox groupFireCaseLiquid;
        private System.Windows.Forms.RadioButton radioWettedLiquid;
        private System.Windows.Forms.RadioButton radioUnwettedLiquid;
        private System.Windows.Forms.Label lblEnvFactorWettedLiquid;
        private System.Windows.Forms.TextBox txtEnvFactorWettedLiquid;
        private System.Windows.Forms.Label lblLatentHeatLiquid;
        private System.Windows.Forms.TextBox txtLatentHeatLiquid;
        private System.Windows.Forms.Label lblWettedAreaLiquid;
        private System.Windows.Forms.TextBox txtWettedAreaLiquid;
        private System.Windows.Forms.Label lblEnvFactorUnwettedLiquid;
        private System.Windows.Forms.TextBox txtEnvFactorUnwettedLiquid;
        private System.Windows.Forms.Label lblFireSizingFactorLiquid;
        private System.Windows.Forms.TextBox txtFireSizingFactorLiquid;
        private System.Windows.Forms.Label lblSurfaceAreaUnwettedLiquid;
        private System.Windows.Forms.TextBox txtSurfaceAreaUnwettedLiquid;
        private System.Windows.Forms.TabPage tabGas;
        private System.Windows.Forms.GroupBox groupPSVConfiguration;
        private System.Windows.Forms.CheckBox chkFireCase;
        private System.Windows.Forms.RadioButton radioMultiplePSVs;
        private System.Windows.Forms.RadioButton radioSinglePSV;
        private System.Windows.Forms.GroupBox groupSizingScenarios;
        private System.Windows.Forms.TextBox txtReqFlowCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupPressures;
        private System.Windows.Forms.GroupBox groupBackPressure;
        private System.Windows.Forms.TextBox txtInletLoss;
        private System.Windows.Forms.TextBox txtInletLossPercent;
        private System.Windows.Forms.TextBox txtTotalBackPressure;
        private System.Windows.Forms.TextBox txtVariableSuperimposedBP;
        private System.Windows.Forms.TextBox txtConstantSuperimposedBP;
        private System.Windows.Forms.TextBox txtBuiltUpBP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblInletLossPsig;
        private System.Windows.Forms.TextBox txtOperatingPressure;
        private System.Windows.Forms.TextBox txtSystemMAWP;
        private System.Windows.Forms.TextBox txtAtmPressure;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupTemperatures;
        private System.Windows.Forms.TextBox txtNormalInletTemp;
        private System.Windows.Forms.TextBox txtOperatingTemp;
        private System.Windows.Forms.TextBox txtRelievingTemp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupFluidProperties;
        private System.Windows.Forms.TextBox txtSpecificGravity;
        private System.Windows.Forms.TextBox txtMolecularWeight;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCompressibility;
        private System.Windows.Forms.TextBox txtSpecificHeatRatio;
        private System.Windows.Forms.ComboBox cmbGasFluid;
        private System.Windows.Forms.Label lblGasResult;
        private System.Windows.Forms.Button btnCalculateGas;
        private System.Windows.Forms.DataGridView resultsDataGridViewGas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGasSizingScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGasTotalArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGasAreaPerValve;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGasSelectedOrifice;
        private System.Windows.Forms.GroupBox groupFireCaseGas;
        private System.Windows.Forms.RadioButton radioWettedGas;
        private System.Windows.Forms.RadioButton radioUnwettedGas;
        private System.Windows.Forms.Label lblEnvFactorWettedGas;
        private System.Windows.Forms.TextBox txtEnvFactorWettedGas;
        private System.Windows.Forms.Label lblLatentHeatGas;
        private System.Windows.Forms.TextBox txtLatentHeatGas;
        private System.Windows.Forms.Label lblWettedAreaGas;
        private System.Windows.Forms.TextBox txtWettedAreaGas;
        private System.Windows.Forms.Label lblEnvFactorUnwettedGas;
        private System.Windows.Forms.TextBox txtEnvFactorUnwettedGas;
        private System.Windows.Forms.Label lblFireSizingFactorGas;
        private System.Windows.Forms.TextBox txtFireSizingFactorGas;
        private System.Windows.Forms.Label lblSurfaceAreaUnwettedGas;
        private System.Windows.Forms.TextBox txtSurfaceAreaUnwettedGas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel scenarioDetailsPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.CheckBox chkControlValveFailure;
        private System.Windows.Forms.CheckBox chkLiquidHydraulicHammer;
        private System.Windows.Forms.CheckBox chkSteamHydraulicHammer;
        private System.Windows.Forms.GroupBox groupThermalRelief;
        private System.Windows.Forms.Label lblVesselVolume;
        private System.Windows.Forms.TextBox txtVesselVolume;
        private System.Windows.Forms.Label lblTemperatureChange;
        private System.Windows.Forms.TextBox txtTemperatureChange;
        private System.Windows.Forms.Label lblInitialPressure;
        private System.Windows.Forms.TextBox txtInitialPressure;
        private System.Windows.Forms.Label lblReliefPressure;
        private System.Windows.Forms.TextBox txtReliefPressure;
        private System.Windows.Forms.GroupBox groupTubeRupture;
        private System.Windows.Forms.Label lblUpstreamPressureTubeRupture;
        private System.Windows.Forms.TextBox txtUpstreamPressureTubeRupture;
        private System.Windows.Forms.Label lblDownstreamPressureTubeRupture;
        private System.Windows.Forms.TextBox txtDownstreamPressureTubeRupture;
        private System.Windows.Forms.Label lblTubeInnerDiameter;
        private System.Windows.Forms.TextBox txtTubeInnerDiameter;
        private System.Windows.Forms.Label lblDischargeCoefficient;
        private System.Windows.Forms.TextBox txtDischargeCoefficient;
    }
}
