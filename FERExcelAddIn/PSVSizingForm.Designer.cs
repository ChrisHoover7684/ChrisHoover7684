using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class PSVSizingForm
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkBlockedOutlet = new System.Windows.Forms.CheckBox();
            this.chkExternalFire = new System.Windows.Forms.CheckBox();
            this.chkCoolingFailure = new System.Windows.Forms.CheckBox();
            this.chkTubeRupture = new System.Windows.Forms.CheckBox();
            this.chkChemicalReaction = new System.Windows.Forms.CheckBox();
            this.chkThermalExpansion = new System.Windows.Forms.CheckBox();
            this.chkControlValveFailure = new System.Windows.Forms.CheckBox();
            this.chkPowerFailure = new System.Windows.Forms.CheckBox();
            this.chkHydraulicHammer = new System.Windows.Forms.CheckBox();
            this.chkRefluxFailure = new System.Windows.Forms.CheckBox();
            this.chkCompressorFailure = new System.Windows.Forms.CheckBox();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.autoCalculateCheckBox = new System.Windows.Forms.CheckBox();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInputs = new System.Windows.Forms.TabPage();
            this.inputsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.psvConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.radSinglePSV = new System.Windows.Forms.RadioButton();
            this.radMultiplePSV = new System.Windows.Forms.RadioButton();
            this.chkFireCase = new System.Windows.Forms.CheckBox();
            this.staggeredPsvsDataGridView = new System.Windows.Forms.DataGridView();
            this.fluidPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.lblFluidType = new System.Windows.Forms.Label();
            this.fluidTypeCombo = new System.Windows.Forms.ComboBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.pressureInput = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.temperatureInput = new System.Windows.Forms.TextBox();
            this.lblFlowRate = new System.Windows.Forms.Label();
            this.flowRateInput = new System.Windows.Forms.TextBox();
            this.lblMolecularWeight = new System.Windows.Forms.Label();
            this.molecularWeightInput = new System.Windows.Forms.TextBox();
            this.lblSpecificHeatRatio = new System.Windows.Forms.Label();
            this.specificHeatRatioInput = new System.Windows.Forms.TextBox();
            this.lblCompressibility = new System.Windows.Forms.Label();
            this.compressibilityInput = new System.Windows.Forms.TextBox();
            this.lblViscosity = new System.Windows.Forms.Label();
            this.viscosityInput = new System.Windows.Forms.TextBox();
            this.lblSpecificGravity = new System.Windows.Forms.Label();
            this.specificGravityInput = new System.Windows.Forms.TextBox();
            this.lblOperatingPressure = new System.Windows.Forms.Label();
            this.operatingPressureInput = new System.Windows.Forms.TextBox();
            this.vesselDesignGroupBox = new System.Windows.Forms.GroupBox();
            this.lblMAWP = new System.Windows.Forms.Label();
            this.txtMAWP = new System.Windows.Forms.TextBox();
            this.lblDesignTemp = new System.Windows.Forms.Label();
            this.txtDesignTemp = new System.Windows.Forms.TextBox();
            this.lblAccumulation = new System.Windows.Forms.Label();
            this.cmbAccumulation = new System.Windows.Forms.ComboBox();
            this.lblFillLevel = new System.Windows.Forms.Label();
            this.txtFillLevel = new System.Windows.Forms.TextBox();
            this.lblVesselDiameter = new System.Windows.Forms.Label();
            this.vesselDiameterInput = new System.Windows.Forms.TextBox();
            this.lblVesselLength = new System.Windows.Forms.Label();
            this.vesselLengthInput = new System.Windows.Forms.TextBox();
            this.chkHorizontalVessel = new System.Windows.Forms.CheckBox();
            this.chkInsulated = new System.Windows.Forms.CheckBox();
            this.chkWaterSpray = new System.Windows.Forms.CheckBox();
            this.chkUnderground = new System.Windows.Forms.CheckBox();
            this.lblVesselOrientation = new System.Windows.Forms.Label();
            this.tabScenarios = new System.Windows.Forms.TabPage();
            this.scenarioGroupBox = new System.Windows.Forms.GroupBox();
            this.tabResults = new System.Windows.Forms.TabPage();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.colScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrificeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSetPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.mainTableLayout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInputs.SuspendLayout();
            this.inputsTableLayout.SuspendLayout();
            this.psvConfigGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staggeredPsvsDataGridView)).BeginInit();
            this.fluidPropertiesGroupBox.SuspendLayout();
            this.vesselDesignGroupBox.SuspendLayout();
            this.tabScenarios.SuspendLayout();
            this.scenarioGroupBox.SuspendLayout();
            this.tabResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // chkBlockedOutlet
            //
            this.chkBlockedOutlet.AutoSize = true;
            this.chkBlockedOutlet.Checked = true;
            this.chkBlockedOutlet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlockedOutlet.Location = new System.Drawing.Point(20, 30);
            this.chkBlockedOutlet.Name = "chkBlockedOutlet";
            this.chkBlockedOutlet.Size = new System.Drawing.Size(139, 24);
            this.chkBlockedOutlet.TabIndex = 0;
            this.chkBlockedOutlet.Text = "Blocked Outlet";
            this.toolTip1.SetToolTip(this.chkBlockedOutlet, "Blocked Outlet (Single valve or full system blockage)");
            this.chkBlockedOutlet.UseVisualStyleBackColor = true;
            //
            // chkExternalFire
            //
            this.chkExternalFire.AutoSize = true;
            this.chkExternalFire.Location = new System.Drawing.Point(20, 70);
            this.chkExternalFire.Name = "chkExternalFire";
            this.chkExternalFire.Size = new System.Drawing.Size(124, 24);
            this.chkExternalFire.TabIndex = 1;
            this.chkExternalFire.Text = "External Fire";
            this.toolTip1.SetToolTip(this.chkExternalFire, "External fire exposure scenario");
            this.chkExternalFire.UseVisualStyleBackColor = true;
            //
            // chkCoolingFailure
            //
            this.chkCoolingFailure.AutoSize = true;
            this.chkCoolingFailure.Location = new System.Drawing.Point(20, 110);
            this.chkCoolingFailure.Name = "chkCoolingFailure";
            this.chkCoolingFailure.Size = new System.Drawing.Size(140, 24);
            this.chkCoolingFailure.TabIndex = 2;
            this.chkCoolingFailure.Text = "Cooling Failure";
            this.toolTip1.SetToolTip(this.chkCoolingFailure, "Failure of cooling system");
            this.chkCoolingFailure.UseVisualStyleBackColor = true;
            //
            // chkTubeRupture
            //
            this.chkTubeRupture.AutoSize = true;
            this.chkTubeRupture.Location = new System.Drawing.Point(20, 150);
            this.chkTubeRupture.Name = "chkTubeRupture";
            this.chkTubeRupture.Size = new System.Drawing.Size(133, 24);
            this.chkTubeRupture.TabIndex = 3;
            this.chkTubeRupture.Text = "Tube Rupture";
            this.toolTip1.SetToolTip(this.chkTubeRupture, "Heat exchanger tube rupture scenario");
            this.chkTubeRupture.UseVisualStyleBackColor = true;
            //
            // chkChemicalReaction
            //
            this.chkChemicalReaction.AutoSize = true;
            this.chkChemicalReaction.Location = new System.Drawing.Point(20, 190);
            this.chkChemicalReaction.Name = "chkChemicalReaction";
            this.chkChemicalReaction.Size = new System.Drawing.Size(168, 24);
            this.chkChemicalReaction.TabIndex = 4;
            this.chkChemicalReaction.Text = "Chemical Reaction";
            this.toolTip1.SetToolTip(this.chkChemicalReaction, "Runaway chemical reaction scenario");
            this.chkChemicalReaction.UseVisualStyleBackColor = true;
            //
            // chkThermalExpansion
            //
            this.chkThermalExpansion.AutoSize = true;
            this.chkThermalExpansion.Location = new System.Drawing.Point(20, 230);
            this.chkThermalExpansion.Name = "chkThermalExpansion";
            this.chkThermalExpansion.Size = new System.Drawing.Size(170, 24);
            this.chkThermalExpansion.TabIndex = 5;
            this.chkThermalExpansion.Text = "Thermal Expansion";
            this.toolTip1.SetToolTip(this.chkThermalExpansion, "Thermal expansion of trapped liquids");
            this.chkThermalExpansion.UseVisualStyleBackColor = true;
            //
            // chkControlValveFailure
            //
            this.chkControlValveFailure.AutoSize = true;
            this.chkControlValveFailure.Location = new System.Drawing.Point(20, 270);
            this.chkControlValveFailure.Name = "chkControlValveFailure";
            this.chkControlValveFailure.Size = new System.Drawing.Size(181, 24);
            this.chkControlValveFailure.TabIndex = 6;
            this.chkControlValveFailure.Text = "Control Valve Failure";
            this.toolTip1.SetToolTip(this.chkControlValveFailure, "Control valve failure in open position");
            this.chkControlValveFailure.UseVisualStyleBackColor = true;
            //
            // chkPowerFailure
            //
            this.chkPowerFailure.AutoSize = true;
            this.chkPowerFailure.Location = new System.Drawing.Point(20, 310);
            this.chkPowerFailure.Name = "chkPowerFailure";
            this.chkPowerFailure.Size = new System.Drawing.Size(131, 24);
            this.chkPowerFailure.TabIndex = 7;
            this.chkPowerFailure.Text = "Power Failure";
            this.toolTip1.SetToolTip(this.chkPowerFailure, "Total power failure scenario");
            this.chkPowerFailure.UseVisualStyleBackColor = true;
            //
            // chkHydraulicHammer
            //
            this.chkHydraulicHammer.AutoSize = true;
            this.chkHydraulicHammer.Location = new System.Drawing.Point(20, 350);
            this.chkHydraulicHammer.Name = "chkHydraulicHammer";
            this.chkHydraulicHammer.Size = new System.Drawing.Size(165, 24);
            this.chkHydraulicHammer.TabIndex = 8;
            this.chkHydraulicHammer.Text = "Hydraulic Hammer";
            this.toolTip1.SetToolTip(this.chkHydraulicHammer, "Hydraulic hammer scenario");
            this.chkHydraulicHammer.UseVisualStyleBackColor = true;
            //
            // chkRefluxFailure
            //
            this.chkRefluxFailure.AutoSize = true;
            this.chkRefluxFailure.Location = new System.Drawing.Point(20, 390);
            this.chkRefluxFailure.Name = "chkRefluxFailure";
            this.chkRefluxFailure.Size = new System.Drawing.Size(132, 24);
            this.chkRefluxFailure.TabIndex = 9;
            this.chkRefluxFailure.Text = "Reflux Failure";
            this.toolTip1.SetToolTip(this.chkRefluxFailure, "Reflux system failure");
            this.chkRefluxFailure.UseVisualStyleBackColor = true;
            //
            // chkCompressorFailure
            //
            this.chkCompressorFailure.AutoSize = true;
            this.chkCompressorFailure.Location = new System.Drawing.Point(20, 430);
            this.chkCompressorFailure.Name = "chkCompressorFailure";
            this.chkCompressorFailure.Size = new System.Drawing.Size(173, 24);
            this.chkCompressorFailure.TabIndex = 10;
            this.chkCompressorFailure.Text = "Compressor Failure";
            this.toolTip1.SetToolTip(this.chkCompressorFailure, "Compressor failure scenario");
            this.chkCompressorFailure.UseVisualStyleBackColor = true;
            //
            // btnExcelExport
            //
            this.btnExcelExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelExport.Location = new System.Drawing.Point(1076, 20);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(200, 50);
            this.btnExcelExport.TabIndex = 2;
            this.btnExcelExport.Text = "Export to Excel";
            this.toolTip1.SetToolTip(this.btnExcelExport, "Export results to Excel");
            this.btnExcelExport.UseVisualStyleBackColor = true;
            //
            // btnCalculate
            //
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(826, 20);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 50);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.toolTip1.SetToolTip(this.btnCalculate, "Perform PSV sizing calculations");
            this.btnCalculate.UseVisualStyleBackColor = true;
            //
            // autoCalculateCheckBox
            //
            this.autoCalculateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoCalculateCheckBox.AutoSize = true;
            this.autoCalculateCheckBox.Checked = true;
            this.autoCalculateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoCalculateCheckBox.Location = new System.Drawing.Point(832, 90);
            this.autoCalculateCheckBox.Name = "autoCalculateCheckBox";
            this.autoCalculateCheckBox.Size = new System.Drawing.Size(139, 24);
            this.autoCalculateCheckBox.TabIndex = 0;
            this.autoCalculateCheckBox.Text = "Auto Calculate";
            this.toolTip1.SetToolTip(this.autoCalculateCheckBox, "Recalculate automatically when inputs change");
            this.autoCalculateCheckBox.UseVisualStyleBackColor = true;
            //
            // mainTableLayout
            //
            this.mainTableLayout.ColumnCount = 1;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.tabControl, 0, 0);
            this.mainTableLayout.Controls.Add(this.buttonsPanel, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainTableLayout.Size = new System.Drawing.Size(1344, 1031);
            this.mainTableLayout.TabIndex = 0;
            //
            // tabControl
            //
            this.tabControl.Controls.Add(this.tabInputs);
            this.tabControl.Controls.Add(this.tabScenarios);
            this.tabControl.Controls.Add(this.tabResults);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1338, 870);
            this.tabControl.TabIndex = 0;
            //
            // tabInputs
            //
            this.tabInputs.Controls.Add(this.inputsTableLayout);
            this.tabInputs.Location = new System.Drawing.Point(4, 29);
            this.tabInputs.Name = "tabInputs";
            this.tabInputs.Padding = new System.Windows.Forms.Padding(3);
            this.tabInputs.Size = new System.Drawing.Size(1330, 837);
            this.tabInputs.TabIndex = 0;
            this.tabInputs.Text = "Input Parameters";
            this.tabInputs.UseVisualStyleBackColor = true;
            //
            // inputsTableLayout
            //
            this.inputsTableLayout.ColumnCount = 2;
            this.inputsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTableLayout.Controls.Add(this.psvConfigGroupBox, 0, 0);
            this.inputsTableLayout.Controls.Add(this.fluidPropertiesGroupBox, 0, 1);
            this.inputsTableLayout.Controls.Add(this.vesselDesignGroupBox, 1, 0);
            this.inputsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsTableLayout.Location = new System.Drawing.Point(3, 3);
            this.inputsTableLayout.Name = "inputsTableLayout";
            this.inputsTableLayout.RowCount = 2;
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.inputsTableLayout.Size = new System.Drawing.Size(1324, 831);
            this.inputsTableLayout.TabIndex = 0;
            //
            // psvConfigGroupBox
            //
            this.psvConfigGroupBox.Controls.Add(this.radSinglePSV);
            this.psvConfigGroupBox.Controls.Add(this.radMultiplePSV);
            this.psvConfigGroupBox.Controls.Add(this.chkFireCase);
            this.psvConfigGroupBox.Controls.Add(this.staggeredPsvsDataGridView);
            this.psvConfigGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psvConfigGroupBox.Location = new System.Drawing.Point(3, 3);
            this.psvConfigGroupBox.Name = "psvConfigGroupBox";
            this.psvConfigGroupBox.Size = new System.Drawing.Size(656, 409);
            this.psvConfigGroupBox.TabIndex = 0;
            this.psvConfigGroupBox.TabStop = false;
            this.psvConfigGroupBox.Text = "PSV Configuration";
            //
            // radSinglePSV
            //
            this.radSinglePSV.AutoSize = true;
            this.radSinglePSV.Checked = true;
            this.radSinglePSV.Location = new System.Drawing.Point(20, 30);
            this.radSinglePSV.Name = "radSinglePSV";
            this.radSinglePSV.Size = new System.Drawing.Size(114, 24);
            this.radSinglePSV.TabIndex = 0;
            this.radSinglePSV.TabStop = true;
            this.radSinglePSV.Text = "Single PSV";
            this.radSinglePSV.UseVisualStyleBackColor = true;
            //
            // radMultiplePSV
            //
            this.radMultiplePSV.AutoSize = true;
            this.radMultiplePSV.Location = new System.Drawing.Point(20, 60);
            this.radMultiplePSV.Name = "radMultiplePSV";
            this.radMultiplePSV.Size = new System.Drawing.Size(124, 24);
            this.radMultiplePSV.TabIndex = 1;
            this.radMultiplePSV.Text = "Multiple PSV";
            this.radMultiplePSV.UseVisualStyleBackColor = true;
            //
            // chkFireCase
            //
            this.chkFireCase.AutoSize = true;
            this.chkFireCase.Location = new System.Drawing.Point(20, 90);
            this.chkFireCase.Name = "chkFireCase";
            this.chkFireCase.Size = new System.Drawing.Size(103, 24);
            this.chkFireCase.TabIndex = 2;
            this.chkFireCase.Text = "Fire Case";
            this.chkFireCase.UseVisualStyleBackColor = true;
            //
            // staggeredPsvsDataGridView
            //
            this.staggeredPsvsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staggeredPsvsDataGridView.Location = new System.Drawing.Point(20, 120);
            this.staggeredPsvsDataGridView.Name = "staggeredPsvsDataGridView";
            this.staggeredPsvsDataGridView.RowHeadersWidth = 62;
            this.staggeredPsvsDataGridView.Size = new System.Drawing.Size(586, 180);
            this.staggeredPsvsDataGridView.TabIndex = 3;
            this.staggeredPsvsDataGridView.Visible = false;
            //
            // fluidPropertiesGroupBox
            //
            this.fluidPropertiesGroupBox.Controls.Add(this.lblFluidType);
            this.fluidPropertiesGroupBox.Controls.Add(this.fluidTypeCombo);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblPressure);
            this.fluidPropertiesGroupBox.Controls.Add(this.pressureInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblTemperature);
            this.fluidPropertiesGroupBox.Controls.Add(this.temperatureInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblFlowRate);
            this.fluidPropertiesGroupBox.Controls.Add(this.flowRateInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblMolecularWeight);
            this.fluidPropertiesGroupBox.Controls.Add(this.molecularWeightInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblSpecificHeatRatio);
            this.fluidPropertiesGroupBox.Controls.Add(this.specificHeatRatioInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblCompressibility);
            this.fluidPropertiesGroupBox.Controls.Add(this.compressibilityInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblViscosity);
            this.fluidPropertiesGroupBox.Controls.Add(this.viscosityInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblSpecificGravity);
            this.fluidPropertiesGroupBox.Controls.Add(this.specificGravityInput);
            this.fluidPropertiesGroupBox.Controls.Add(this.lblOperatingPressure);
            this.fluidPropertiesGroupBox.Controls.Add(this.operatingPressureInput);
            this.fluidPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluidPropertiesGroupBox.Location = new System.Drawing.Point(3, 418);
            this.fluidPropertiesGroupBox.Name = "fluidPropertiesGroupBox";
            this.fluidPropertiesGroupBox.Size = new System.Drawing.Size(656, 410);
            this.fluidPropertiesGroupBox.TabIndex = 1;
            this.fluidPropertiesGroupBox.TabStop = false;
            this.fluidPropertiesGroupBox.Text = "Fluid Properties";
            //
            // lblFluidType
            //
            this.lblFluidType.AutoSize = true;
            this.lblFluidType.Location = new System.Drawing.Point(20, 30);
            this.lblFluidType.Name = "lblFluidType";
            this.lblFluidType.Size = new System.Drawing.Size(85, 20);
            this.lblFluidType.TabIndex = 0;
            this.lblFluidType.Text = "Fluid Type:";
            //
            // fluidTypeCombo
            //
            this.fluidTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fluidTypeCombo.FormattingEnabled = true;
            this.fluidTypeCombo.Items.AddRange(new object[] {
            "Gas",
            "Liquid",
            "Steam",
            "Two-Phase"});
            this.fluidTypeCombo.Location = new System.Drawing.Point(250, 25);
            this.fluidTypeCombo.Name = "fluidTypeCombo";
            this.fluidTypeCombo.Size = new System.Drawing.Size(200, 28);
            this.fluidTypeCombo.TabIndex = 1;
            //
            // lblPressure
            //
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(20, 70);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(114, 20);
            this.lblPressure.TabIndex = 2;
            this.lblPressure.Text = "Pressure psig):";
            //
            // pressureInput
            //
            this.pressureInput.Location = new System.Drawing.Point(250, 65);
            this.pressureInput.Name = "pressureInput";
            this.pressureInput.Size = new System.Drawing.Size(100, 26);
            this.pressureInput.TabIndex = 3;
            this.pressureInput.Text = "100";
            //
            // lblTemperature
            //
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(20, 110);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(133, 20);
            this.lblTemperature.TabIndex = 4;
            this.lblTemperature.Text = "Temperature (°F):";
            //
            // temperatureInput
            //
            this.temperatureInput.Location = new System.Drawing.Point(250, 105);
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.Size = new System.Drawing.Size(100, 26);
            this.temperatureInput.TabIndex = 5;
            this.temperatureInput.Text = "60";
            //
            // lblFlowRate
            //
            this.lblFlowRate.AutoSize = true;
            this.lblFlowRate.Location = new System.Drawing.Point(20, 150);
            this.lblFlowRate.Name = "lblFlowRate";
            this.lblFlowRate.Size = new System.Drawing.Size(85, 20);
            this.lblFlowRate.TabIndex = 6;
            this.lblFlowRate.Text = "Flow Rate:";
            //
            // flowRateInput
            //
            this.flowRateInput.Location = new System.Drawing.Point(250, 145);
            this.flowRateInput.Name = "flowRateInput";
            this.flowRateInput.Size = new System.Drawing.Size(100, 26);
            this.flowRateInput.TabIndex = 7;
            this.flowRateInput.Text = "500";
            //
            // lblMolecularWeight
            //
            this.lblMolecularWeight.AutoSize = true;
            this.lblMolecularWeight.Location = new System.Drawing.Point(20, 190);
            this.lblMolecularWeight.Name = "lblMolecularWeight";
            this.lblMolecularWeight.Size = new System.Drawing.Size(187, 20);
            this.lblMolecularWeight.TabIndex = 8;
            this.lblMolecularWeight.Text = "Molecular Weight (g/mol):";
            //
            // molecularWeightInput
            //
            this.molecularWeightInput.Location = new System.Drawing.Point(250, 185);
            this.molecularWeightInput.Name = "molecularWeightInput";
            this.molecularWeightInput.Size = new System.Drawing.Size(100, 26);
            this.molecularWeightInput.TabIndex = 9;
            this.molecularWeightInput.Text = "28.97";
            //
            // lblSpecificHeatRatio
            //
            this.lblSpecificHeatRatio.AutoSize = true;
            this.lblSpecificHeatRatio.Location = new System.Drawing.Point(20, 230);
            this.lblSpecificHeatRatio.Name = "lblSpecificHeatRatio";
            this.lblSpecificHeatRatio.Size = new System.Drawing.Size(223, 20);
            this.lblSpecificHeatRatio.TabIndex = 10;
            this.lblSpecificHeatRatio.Text = "Specific Heat Ratio (k=Cp/Cv):";
            //
            // specificHeatRatioInput
            //
            this.specificHeatRatioInput.Location = new System.Drawing.Point(250, 225);
            this.specificHeatRatioInput.Name = "specificHeatRatioInput";
            this.specificHeatRatioInput.Size = new System.Drawing.Size(100, 26);
            this.specificHeatRatioInput.TabIndex = 11;
            this.specificHeatRatioInput.Text = "1.4";
            //
            // lblCompressibility
            //
            this.lblCompressibility.AutoSize = true;
            this.lblCompressibility.Location = new System.Drawing.Point(20, 270);
            this.lblCompressibility.Name = "lblCompressibility";
            this.lblCompressibility.Size = new System.Drawing.Size(192, 20);
            this.lblCompressibility.TabIndex = 12;
            this.lblCompressibility.Text = "Compressibility Factor (Z):";
            //
            // compressibilityInput
            //
            this.compressibilityInput.Location = new System.Drawing.Point(250, 265);
            this.compressibilityInput.Name = "compressibilityInput";
            this.compressibilityInput.Size = new System.Drawing.Size(100, 26);
            this.compressibilityInput.TabIndex = 13;
            this.compressibilityInput.Text = "1.0";
            //
            // lblViscosity
            //
            this.lblViscosity.AutoSize = true;
            this.lblViscosity.Location = new System.Drawing.Point(20, 310);
            this.lblViscosity.Name = "lblViscosity";
            this.lblViscosity.Size = new System.Drawing.Size(107, 20);
            this.lblViscosity.TabIndex = 14;
            this.lblViscosity.Text = "Viscosity (cP):";
            //
            // viscosityInput
            //
            this.viscosityInput.Location = new System.Drawing.Point(250, 305);
            this.viscosityInput.Name = "viscosityInput";
            this.viscosityInput.Size = new System.Drawing.Size(100, 26);
            this.viscosityInput.TabIndex = 15;
            this.viscosityInput.Text = "1.0";
            //
            // lblSpecificGravity
            //
            this.lblSpecificGravity.AutoSize = true;
            this.lblSpecificGravity.Location = new System.Drawing.Point(20, 350);
            this.lblSpecificGravity.Name = "lblSpecificGravity";
            this.lblSpecificGravity.Size = new System.Drawing.Size(160, 20);
            this.lblSpecificGravity.TabIndex = 16;
            this.lblSpecificGravity.Text = "Specific Gravity (SG):";
            //
            // specificGravityInput
            //
            this.specificGravityInput.Location = new System.Drawing.Point(250, 345);
            this.specificGravityInput.Name = "specificGravityInput";
            this.specificGravityInput.Size = new System.Drawing.Size(100, 26);
            this.specificGravityInput.TabIndex = 17;
            this.specificGravityInput.Text = "1.0";
            //
            // lblOperatingPressure
            //
            this.lblOperatingPressure.AutoSize = true;
            this.lblOperatingPressure.Location = new System.Drawing.Point(20, 390);
            this.lblOperatingPressure.Name = "lblOperatingPressure";
            this.lblOperatingPressure.Size = new System.Drawing.Size(193, 20);
            this.lblOperatingPressure.TabIndex = 18;
            this.lblOperatingPressure.Text = "Operating Pressure (psig):";
            //
            // operatingPressureInput
            //
            this.operatingPressureInput.Location = new System.Drawing.Point(250, 385);
            this.operatingPressureInput.Name = "operatingPressureInput";
            this.operatingPressureInput.Size = new System.Drawing.Size(100, 26);
            this.operatingPressureInput.TabIndex = 19;
            this.operatingPressureInput.Text = "80";
            //
            // vesselDesignGroupBox
            //
            this.vesselDesignGroupBox.Controls.Add(this.lblMAWP);
            this.vesselDesignGroupBox.Controls.Add(this.txtMAWP);
            this.vesselDesignGroupBox.Controls.Add(this.lblDesignTemp);
            this.vesselDesignGroupBox.Controls.Add(this.txtDesignTemp);
            this.vesselDesignGroupBox.Controls.Add(this.lblAccumulation);
            this.vesselDesignGroupBox.Controls.Add(this.cmbAccumulation);
            this.vesselDesignGroupBox.Controls.Add(this.lblFillLevel);
            this.vesselDesignGroupBox.Controls.Add(this.txtFillLevel);
            this.vesselDesignGroupBox.Controls.Add(this.lblVesselDiameter);
            this.vesselDesignGroupBox.Controls.Add(this.vesselDiameterInput);
            this.vesselDesignGroupBox.Controls.Add(this.lblVesselLength);
            this.vesselDesignGroupBox.Controls.Add(this.vesselLengthInput);
            this.vesselDesignGroupBox.Controls.Add(this.chkHorizontalVessel);
            this.vesselDesignGroupBox.Controls.Add(this.chkInsulated);
            this.vesselDesignGroupBox.Controls.Add(this.chkWaterSpray);
            this.vesselDesignGroupBox.Controls.Add(this.chkUnderground);
            this.vesselDesignGroupBox.Controls.Add(this.lblVesselOrientation);
            this.vesselDesignGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vesselDesignGroupBox.Location = new System.Drawing.Point(665, 3);
            this.vesselDesignGroupBox.Name = "vesselDesignGroupBox";
            this.vesselDesignGroupBox.Size = new System.Drawing.Size(656, 409);
            this.vesselDesignGroupBox.TabIndex = 2;
            this.vesselDesignGroupBox.TabStop = false;
            this.vesselDesignGroupBox.Text = "Vessel Design Parameters";
            //
            // lblMAWP
            //
            this.lblMAWP.AutoSize = true;
            this.lblMAWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAWP.Location = new System.Drawing.Point(20, 30);
            this.lblMAWP.Name = "lblMAWP";
            this.lblMAWP.Size = new System.Drawing.Size(117, 20);
            this.lblMAWP.TabIndex = 0;
            this.lblMAWP.Text = "MAWP (psig):";
            //
            // txtMAWP
            //
            this.txtMAWP.Location = new System.Drawing.Point(176, 26);
            this.txtMAWP.Name = "txtMAWP";
            this.txtMAWP.Size = new System.Drawing.Size(100, 26);
            this.txtMAWP.TabIndex = 1;
            this.txtMAWP.Text = "150";
            //
            // lblDesignTemp
            //
            this.lblDesignTemp.AutoSize = true;
            this.lblDesignTemp.Location = new System.Drawing.Point(20, 70);
            this.lblDesignTemp.Name = "lblDesignTemp";
            this.lblDesignTemp.Size = new System.Drawing.Size(136, 20);
            this.lblDesignTemp.TabIndex = 2;
            this.lblDesignTemp.Text = "Design Temp (°F):";
            //
            // txtDesignTemp
            //
            this.txtDesignTemp.Location = new System.Drawing.Point(176, 66);
            this.txtDesignTemp.Name = "txtDesignTemp";
            this.txtDesignTemp.Size = new System.Drawing.Size(100, 26);
            this.txtDesignTemp.TabIndex = 3;
            this.txtDesignTemp.Text = "300";
            //
            // lblAccumulation
            //
            this.lblAccumulation.AutoSize = true;
            this.lblAccumulation.Location = new System.Drawing.Point(20, 110);
            this.lblAccumulation.Name = "lblAccumulation";
            this.lblAccumulation.Size = new System.Drawing.Size(109, 20);
            this.lblAccumulation.TabIndex = 4;
            this.lblAccumulation.Text = "Accumulation:";
            //
            // cmbAccumulation
            //
            this.cmbAccumulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccumulation.FormattingEnabled = true;
            this.cmbAccumulation.Items.AddRange(new object[] {
            "10% (Single PSV)",
            "16% (Multiple PSV)",
            "21% (Fire Case)"});
            this.cmbAccumulation.Location = new System.Drawing.Point(176, 106);
            this.cmbAccumulation.Name = "cmbAccumulation";
            this.cmbAccumulation.Size = new System.Drawing.Size(215, 28);
            this.cmbAccumulation.TabIndex = 5;
            //
            // lblFillLevel
            //
            this.lblFillLevel.AutoSize = true;
            this.lblFillLevel.Location = new System.Drawing.Point(20, 150);
            this.lblFillLevel.Name = "lblFillLevel";
            this.lblFillLevel.Size = new System.Drawing.Size(101, 20);
            this.lblFillLevel.TabIndex = 6;
            this.lblFillLevel.Text = "Fill Level (%):";
            //
            // txtFillLevel
            //
            this.txtFillLevel.Location = new System.Drawing.Point(176, 146);
            this.txtFillLevel.Name = "txtFillLevel";
            this.txtFillLevel.Size = new System.Drawing.Size(100, 26);
            this.txtFillLevel.TabIndex = 7;
            this.txtFillLevel.Text = "100";
            //
            // lblVesselDiameter
            //
            this.lblVesselDiameter.AutoSize = true;
            this.lblVesselDiameter.Location = new System.Drawing.Point(20, 190);
            this.lblVesselDiameter.Name = "lblVesselDiameter";
            this.lblVesselDiameter.Size = new System.Drawing.Size(154, 20);
            this.lblVesselDiameter.TabIndex = 8;
            this.lblVesselDiameter.Text = "Vessel Diameter (ft):";
            //
            // vesselDiameterInput
            //
            this.vesselDiameterInput.Location = new System.Drawing.Point(180, 187);
            this.vesselDiameterInput.Name = "vesselDiameterInput";
            this.vesselDiameterInput.Size = new System.Drawing.Size(70, 26);
            this.vesselDiameterInput.TabIndex = 9;
            this.vesselDiameterInput.Text = "10";
            //
            // lblVesselLength
            //
            this.lblVesselLength.AutoSize = true;
            this.lblVesselLength.Location = new System.Drawing.Point(20, 230);
            this.lblVesselLength.Name = "lblVesselLength";
            this.lblVesselLength.Size = new System.Drawing.Size(139, 20);
            this.lblVesselLength.TabIndex = 10;
            this.lblVesselLength.Text = "Vessel Length (ft):";
            //
            // vesselLengthInput
            //
            this.vesselLengthInput.Location = new System.Drawing.Point(180, 227);
            this.vesselLengthInput.Name = "vesselLengthInput";
            this.vesselLengthInput.Size = new System.Drawing.Size(70, 26);
            this.vesselLengthInput.TabIndex = 11;
            this.vesselLengthInput.Text = "20";
            //
            // chkHorizontalVessel
            //
            this.chkHorizontalVessel.AutoSize = true;
            this.chkHorizontalVessel.Location = new System.Drawing.Point(430, 190);
            this.chkHorizontalVessel.Name = "chkHorizontalVessel";
            this.chkHorizontalVessel.Size = new System.Drawing.Size(159, 24);
            this.chkHorizontalVessel.TabIndex = 12;
            this.chkHorizontalVessel.Text = "Horizontal Vessel";
            this.chkHorizontalVessel.UseVisualStyleBackColor = true;
            //
            // chkInsulated
            //
            this.chkInsulated.AutoSize = true;
            this.chkInsulated.Location = new System.Drawing.Point(430, 70);
            this.chkInsulated.Name = "chkInsulated";
            this.chkInsulated.Size = new System.Drawing.Size(101, 24);
            this.chkInsulated.TabIndex = 13;
            this.chkInsulated.Text = "Insulated";
            this.chkInsulated.UseVisualStyleBackColor = true;
            //
            // chkWaterSpray
            //
            this.chkWaterSpray.AutoSize = true;
            this.chkWaterSpray.Location = new System.Drawing.Point(430, 110);
            this.chkWaterSpray.Name = "chkWaterSpray";
            this.chkWaterSpray.Size = new System.Drawing.Size(123, 24);
            this.chkWaterSpray.TabIndex = 14;
            this.chkWaterSpray.Text = "Water Spray";
            this.chkWaterSpray.UseVisualStyleBackColor = true;
            //
            // chkUnderground
            //
            this.chkUnderground.AutoSize = true;
            this.chkUnderground.Location = new System.Drawing.Point(430, 150);
            this.chkUnderground.Name = "chkUnderground";
            this.chkUnderground.Size = new System.Drawing.Size(129, 24);
            this.chkUnderground.TabIndex = 15;
            this.chkUnderground.Text = "Underground";
            this.chkUnderground.UseVisualStyleBackColor = true;
            //
            // lblVesselOrientation
            //
            this.lblVesselOrientation.AutoSize = true;
            this.lblVesselOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselOrientation.Location = new System.Drawing.Point(426, 30);
            this.lblVesselOrientation.Name = "lblVesselOrientation";
            this.lblVesselOrientation.Size = new System.Drawing.Size(103, 20);
            this.lblVesselOrientation.TabIndex = 16;
            this.lblVesselOrientation.Text = "Orientation:";
            //
            // tabScenarios
            //
            this.tabScenarios.Controls.Add(this.scenarioGroupBox);
            this.tabScenarios.Location = new System.Drawing.Point(4, 29);
            this.tabScenarios.Name = "tabScenarios";
            this.tabScenarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabScenarios.Size = new System.Drawing.Size(1330, 837);
            this.tabScenarios.TabIndex = 1;
            this.tabScenarios.Text = "Scenarios";
            this.tabScenarios.UseVisualStyleBackColor = true;
            //
            // scenarioGroupBox
            //
            this.scenarioGroupBox.Controls.Add(this.chkBlockedOutlet);
            this.scenarioGroupBox.Controls.Add(this.chkExternalFire);
            this.scenarioGroupBox.Controls.Add(this.chkCoolingFailure);
            this.scenarioGroupBox.Controls.Add(this.chkTubeRupture);
            this.scenarioGroupBox.Controls.Add(this.chkChemicalReaction);
            this.scenarioGroupBox.Controls.Add(this.chkThermalExpansion);
            this.scenarioGroupBox.Controls.Add(this.chkControlValveFailure);
            this.scenarioGroupBox.Controls.Add(this.chkPowerFailure);
            this.scenarioGroupBox.Controls.Add(this.chkHydraulicHammer);
            this.scenarioGroupBox.Controls.Add(this.chkRefluxFailure);
            this.scenarioGroupBox.Controls.Add(this.chkCompressorFailure);
            this.scenarioGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scenarioGroupBox.Location = new System.Drawing.Point(3, 3);
            this.scenarioGroupBox.Name = "scenarioGroupBox";
            this.scenarioGroupBox.Size = new System.Drawing.Size(1324, 831);
            this.scenarioGroupBox.TabIndex = 0;
            this.scenarioGroupBox.TabStop = false;
            this.scenarioGroupBox.Text = "Sizing Scenarios";
            //
            // tabResults
            //
            this.tabResults.Controls.Add(this.resultsDataGridView);
            this.tabResults.Location = new System.Drawing.Point(4, 29);
            this.tabResults.Name = "tabResults";
            this.tabResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabResults.Size = new System.Drawing.Size(1330, 837);
            this.tabResults.TabIndex = 2;
            this.tabResults.Text = "Results";
            this.tabResults.UseVisualStyleBackColor = true;
            //
            // resultsDataGridView
            //
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScenario,
            this.colFlowRate,
            this.colArea,
            this.colOrificeSize,
            this.colSetPressure});
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 62;
            this.resultsDataGridView.RowTemplate.Height = 28;
            this.resultsDataGridView.Size = new System.Drawing.Size(1324, 831);
            this.resultsDataGridView.TabIndex = 0;
            //
            // colScenario
            //
            this.colScenario.HeaderText = "Scenario";
            this.colScenario.MinimumWidth = 8;
            this.colScenario.Name = "colScenario";
            this.colScenario.Width = 200;
            //
            // colFlowRate
            //
            this.colFlowRate.HeaderText = "Flow Rate (lb/hr)";
            this.colFlowRate.MinimumWidth = 8;
            this.colFlowRate.Name = "colFlowRate";
            this.colFlowRate.Width = 150;
            //
            // colArea
            //
            this.colArea.HeaderText = "Req. Area (in²)";
            this.colArea.MinimumWidth = 8;
            this.colArea.Name = "colArea";
            this.colArea.Width = 150;
            //
            // colOrificeSize
            //
            this.colOrificeSize.HeaderText = "Orifice Size";
            this.colOrificeSize.MinimumWidth = 8;
            this.colOrificeSize.Name = "colOrificeSize";
            this.colOrificeSize.Width = 150;
            //
            // colSetPressure
            //
            this.colSetPressure.HeaderText = "Set Pressure (psig)";
            this.colSetPressure.MinimumWidth = 8;
            this.colSetPressure.Name = "colSetPressure";
            this.colSetPressure.Width = 150;
            //
            // buttonsPanel
            //
            this.buttonsPanel.Controls.Add(this.btnExcelExport);
            this.buttonsPanel.Controls.Add(this.btnCalculate);
            this.buttonsPanel.Controls.Add(this.autoCalculateCheckBox);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(3, 879);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(1338, 149);
            this.buttonsPanel.TabIndex = 1;
            //
            // PSVSizingForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 1031);
            this.Controls.Add(this.mainTableLayout);
            this.Name = "PSVSizingForm";
            this.Text = "Pressure Safety Valve Sizing Tool";
            this.mainTableLayout.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabInputs.ResumeLayout(false);
            this.inputsTableLayout.ResumeLayout(false);
            this.psvConfigGroupBox.ResumeLayout(false);
            this.psvConfigGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staggeredPsvsDataGridView)).EndInit();
            this.fluidPropertiesGroupBox.ResumeLayout(false);
            this.fluidPropertiesGroupBox.PerformLayout();
            this.vesselDesignGroupBox.ResumeLayout(false);
            this.vesselDesignGroupBox.PerformLayout();
            this.tabScenarios.ResumeLayout(false);
            this.scenarioGroupBox.ResumeLayout(false);
            this.scenarioGroupBox.PerformLayout();
            this.tabResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInputs;
        private System.Windows.Forms.TableLayoutPanel inputsTableLayout;
        private System.Windows.Forms.GroupBox psvConfigGroupBox;
        private System.Windows.Forms.RadioButton radSinglePSV;
        private System.Windows.Forms.RadioButton radMultiplePSV;
        private System.Windows.Forms.CheckBox chkFireCase;
        private System.Windows.Forms.DataGridView staggeredPsvsDataGridView;
        private System.Windows.Forms.GroupBox fluidPropertiesGroupBox;
        private System.Windows.Forms.Label lblFluidType;
        private System.Windows.Forms.ComboBox fluidTypeCombo;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox pressureInput;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox temperatureInput;
        private System.Windows.Forms.Label lblFlowRate;
        private System.Windows.Forms.TextBox flowRateInput;
        private System.Windows.Forms.Label lblMolecularWeight;
        private System.Windows.Forms.TextBox molecularWeightInput;
        private System.Windows.Forms.Label lblSpecificHeatRatio;
        private System.Windows.Forms.TextBox specificHeatRatioInput;
        private System.Windows.Forms.Label lblCompressibility;
        private System.Windows.Forms.TextBox compressibilityInput;
        private System.Windows.Forms.Label lblViscosity;
        private System.Windows.Forms.TextBox viscosityInput;
        private System.Windows.Forms.Label lblSpecificGravity;
        private System.Windows.Forms.TextBox specificGravityInput;
        private System.Windows.Forms.Label lblOperatingPressure;
        private System.Windows.Forms.TextBox operatingPressureInput;
        private System.Windows.Forms.GroupBox vesselDesignGroupBox;
        private System.Windows.Forms.Label lblMAWP;
        private System.Windows.Forms.TextBox txtMAWP;
        private System.Windows.Forms.Label lblDesignTemp;
        private System.Windows.Forms.TextBox txtDesignTemp;
        private System.Windows.Forms.Label lblAccumulation;
        private System.Windows.Forms.ComboBox cmbAccumulation;
        private System.Windows.Forms.Label lblFillLevel;
        private System.Windows.Forms.TextBox txtFillLevel;
        private System.Windows.Forms.Label lblVesselDiameter;
        private System.Windows.Forms.TextBox vesselDiameterInput;
        private System.Windows.Forms.Label lblVesselLength;
        private System.Windows.Forms.TextBox vesselLengthInput;
        private System.Windows.Forms.CheckBox chkHorizontalVessel;
        private System.Windows.Forms.CheckBox chkInsulated;
        private System.Windows.Forms.CheckBox chkWaterSpray;
        private System.Windows.Forms.CheckBox chkUnderground;
        private System.Windows.Forms.Label lblVesselOrientation;
        private System.Windows.Forms.TabPage tabScenarios;
        private System.Windows.Forms.GroupBox scenarioGroupBox;
        private System.Windows.Forms.CheckBox chkBlockedOutlet;
        private System.Windows.Forms.CheckBox chkExternalFire;
        private System.Windows.Forms.CheckBox chkCoolingFailure;
        private System.Windows.Forms.CheckBox chkTubeRupture;
        private System.Windows.Forms.CheckBox chkChemicalReaction;
        private System.Windows.Forms.CheckBox chkThermalExpansion;
        private System.Windows.Forms.CheckBox chkControlValveFailure;
        private System.Windows.Forms.CheckBox chkPowerFailure;
        private System.Windows.Forms.CheckBox chkHydraulicHammer;
        private System.Windows.Forms.CheckBox chkRefluxFailure;
        private System.Windows.Forms.CheckBox chkCompressorFailure;
        private System.Windows.Forms.TabPage tabResults;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrificeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetPressure;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox autoCalculateCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
