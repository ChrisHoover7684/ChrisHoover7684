namespace FERExcelAddIn
{
    partial class API_653_Tank_Calcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabShellEval = new System.Windows.Forms.TabPage();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblNumCourses = new System.Windows.Forms.Label();
            this.numCourses = new System.Windows.Forms.NumericUpDown();
            this.btnGenerateHeightInputs = new System.Windows.Forms.Button();
            this.panelHeightInputs = new System.Windows.Forms.Panel();
            this.lblYieldStrength = new System.Windows.Forms.Label();
            this.txtYieldStrength = new System.Windows.Forms.TextBox();
            this.lblTensileStrength = new System.Windows.Forms.Label();
            this.txtTensileStrength = new System.Windows.Forms.TextBox();
            this.lblSpecificGravity = new System.Windows.Forms.Label();
            this.txtSpecificGravity = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.CourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowableStress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StressBasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TminVerification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbStandard = new System.Windows.Forms.ComboBox();
            this.cmbEdition = new System.Windows.Forms.ComboBox();
            this.cmbJointType = new System.Windows.Forms.ComboBox();
            this.cmbApplicability = new System.Windows.Forms.ComboBox();
            this.lblEfficiencyValue = new System.Windows.Forms.Label();
            this.lblEfficiencyDescription = new System.Windows.Forms.Label();
            this.lblStandard = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblJointType = new System.Windows.Forms.Label();
            this.lblLimits = new System.Windows.Forms.Label();
            this.lblNumRivets = new System.Windows.Forms.Label();
            this.cmbNumRivets = new System.Windows.Forms.ComboBox();
            this.btnCalculateHydro = new System.Windows.Forms.Button();
            this.lblCorrosionAllowance = new System.Windows.Forms.Label();
            this.txtCorrosionAllowance = new System.Windows.Forms.TextBox();
            this.hydroResultGrid = new System.Windows.Forms.DataGridView();
            this.HydroCourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowableHt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAllowableH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HydrotestVerification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxAllowableHVerification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKFactor = new System.Windows.Forms.Label();
            this.txtKFactor = new System.Windows.Forms.TextBox();
            this.rtbFormulaDisplay = new System.Windows.Forms.RichTextBox();
            this.tabSettlementEval = new System.Windows.Forms.TabPage();
            this.grpSettlementBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblSettlementDiameter = new System.Windows.Forms.Label();
            this.txtSettlementDiameter = new System.Windows.Forms.TextBox();
            this.lblSettlementShellHeight = new System.Windows.Forms.Label();
            this.txtSettlementShellHeight = new System.Windows.Forms.TextBox();
            this.lblBottomThickness = new System.Windows.Forms.Label();
            this.txtBottomThickness = new System.Windows.Forms.TextBox();
            this.lblSettlementTshell = new System.Windows.Forms.Label();
            this.txtSettlementTshell = new System.Windows.Forms.TextBox();
            this.grpSettlementInputs = new System.Windows.Forms.GroupBox();
            this.lblReferenceElevation = new System.Windows.Forms.Label();
            this.txtReferenceElevation = new System.Windows.Forms.TextBox();
            this.lblCenterElevation = new System.Windows.Forms.Label();
            this.txtCenterElevation = new System.Windows.Forms.TextBox();
            this.dgvSettlementPoints = new System.Windows.Forms.DataGridView();
            this.btnAddSettlementPoint = new System.Windows.Forms.Button();
            this.btnClearSettlementPoints = new System.Windows.Forms.Button();
            this.lblRecommendedPoints = new System.Windows.Forms.Label();
            this.grpSettlementResults = new System.Windows.Forms.GroupBox();
            this.lblMaxDifferentialSettlement = new System.Windows.Forms.Label();
            this.lblAllowableDifferential = new System.Windows.Forms.Label();
            this.lblTiltAngle = new System.Windows.Forms.Label();
            this.lblEdgeSettlement = new System.Windows.Forms.Label();
            this.lblAllowableEdge = new System.Windows.Forms.Label();
            this.lblCenterSettlement = new System.Windows.Forms.Label();
            this.lblAllowableCenter = new System.Windows.Forms.Label();
            this.grpSettlementSummary = new System.Windows.Forms.GroupBox();
            this.rtbSettlementSummary = new System.Windows.Forms.RichTextBox();
            this.lblTiltNote = new System.Windows.Forms.Label();
            this.btnCalculateSettlement = new System.Windows.Forms.Button();
            this.tabBottomEval = new System.Windows.Forms.TabPage();
            this.grpAnnularPlate = new System.Windows.Forms.GroupBox();
            this.lblAnnularPlateResult = new System.Windows.Forms.Label();
            this.btnCalculateAnnularPlate = new System.Windows.Forms.Button();
            this.txtAnnularCorrosionAllowance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAsBuiltFirstCourse = new System.Windows.Forms.TextBox();
            this.lblApiRefAnnular = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpCriticalZone = new System.Windows.Forms.GroupBox();
            this.lblCriticalZoneResult = new System.Windows.Forms.Label();
            this.btnCalculateCriticalZone = new System.Windows.Forms.Button();
            this.txtOriginalBottomThickness = new System.Windows.Forms.TextBox();
            this.lblApiRefCriticalZone = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTminShellCourse1 = new System.Windows.Forms.TextBox();
            this.lblTminShellCourse1 = new System.Windows.Forms.Label();
            this.grpMrt = new System.Windows.Forms.GroupBox();
            this.lblMrtResult = new System.Windows.Forms.Label();
            this.lblCoatingLife = new System.Windows.Forms.Label();
            this.txtCoatingLife = new System.Windows.Forms.TextBox();
            this.chkBottomCoated = new System.Windows.Forms.CheckBox();
            this.btnCalculateMrt = new System.Windows.Forms.Button();
            this.cmbTable4_4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUPr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStPr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRTip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRTbc = new System.Windows.Forms.TextBox();
            this.lblUnitRTbc = new System.Windows.Forms.Label();
            this.lblUnitRTip = new System.Windows.Forms.Label();
            this.lblUnitOr = new System.Windows.Forms.Label();
            this.lblUnitStPr = new System.Windows.Forms.Label();
            this.lblUnitUPr = new System.Windows.Forms.Label();
            this.lblApiRefMrt = new System.Windows.Forms.Label();
            this.label_RTbc = new System.Windows.Forms.Label();
            this.tabLocalizedCorrosion = new System.Windows.Forms.TabPage();
            this.grpLocalizedCorrosion = new System.Windows.Forms.GroupBox();
            this.rtbLocalizedResult = new System.Windows.Forms.RichTextBox();
            this.txtLactualLocalized = new System.Windows.Forms.TextBox();
            this.lblLactualLocalized = new System.Windows.Forms.Label();
            this.btnCalculateLocalized = new System.Windows.Forms.Button();
            this.txtTminLocalized = new System.Windows.Forms.TextBox();
            this.lblTminLocalized = new System.Windows.Forms.Label();
            this.txtT2Localized = new System.Windows.Forms.TextBox();
            this.lblApiRefLocalized = new System.Windows.Forms.Label();
            this.lblT2Localized = new System.Windows.Forms.Label();
            this.txtDiameterLocalized = new System.Windows.Forms.TextBox();
            this.lblDiameterLocalized = new System.Windows.Forms.Label();
            this.lblValidationIconLocalized = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabShellEval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydroResultGrid)).BeginInit();
            this.tabSettlementEval.SuspendLayout();
            this.grpSettlementBasicInfo.SuspendLayout();
            this.grpSettlementInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettlementPoints)).BeginInit();
            this.grpSettlementResults.SuspendLayout();
            this.grpSettlementSummary.SuspendLayout();
            this.tabBottomEval.SuspendLayout();
            this.grpAnnularPlate.SuspendLayout();
            this.grpCriticalZone.SuspendLayout();
            this.grpMrt.SuspendLayout();
            this.tabLocalizedCorrosion.SuspendLayout();
            this.grpLocalizedCorrosion.SuspendLayout();
            this.SuspendLayout();
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabShellEval);
            this.tabControl1.Controls.Add(this.tabSettlementEval);
            this.tabControl1.Controls.Add(this.tabBottomEval);
            this.tabControl1.Controls.Add(this.tabLocalizedCorrosion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 1266);
            this.tabControl1.TabIndex = 0;
            //
            // tabShellEval
            //
            this.tabShellEval.Controls.Add(this.btnCalculate);
            this.tabShellEval.Controls.Add(this.lblDiameter);
            this.tabShellEval.Controls.Add(this.txtDiameter);
            this.tabShellEval.Controls.Add(this.lblNumCourses);
            this.tabShellEval.Controls.Add(this.numCourses);
            this.tabShellEval.Controls.Add(this.btnGenerateHeightInputs);
            this.tabShellEval.Controls.Add(this.panelHeightInputs);
            this.tabShellEval.Controls.Add(this.lblYieldStrength);
            this.tabShellEval.Controls.Add(this.txtYieldStrength);
            this.tabShellEval.Controls.Add(this.lblTensileStrength);
            this.tabShellEval.Controls.Add(this.txtTensileStrength);
            this.tabShellEval.Controls.Add(this.lblSpecificGravity);
            this.tabShellEval.Controls.Add(this.txtSpecificGravity);
            this.tabShellEval.Controls.Add(this.lblMaterial);
            this.tabShellEval.Controls.Add(this.cmbMaterial);
            this.tabShellEval.Controls.Add(this.resultGrid);
            this.tabShellEval.Controls.Add(this.cmbStandard);
            this.tabShellEval.Controls.Add(this.cmbEdition);
            this.tabShellEval.Controls.Add(this.cmbJointType);
            this.tabShellEval.Controls.Add(this.cmbApplicability);
            this.tabShellEval.Controls.Add(this.lblEfficiencyValue);
            this.tabShellEval.Controls.Add(this.lblEfficiencyDescription);
            this.tabShellEval.Controls.Add(this.lblStandard);
            this.tabShellEval.Controls.Add(this.lblEdition);
            this.tabShellEval.Controls.Add(this.lblJointType);
            this.tabShellEval.Controls.Add(this.lblLimits);
            this.tabShellEval.Controls.Add(this.lblNumRivets);
            this.tabShellEval.Controls.Add(this.cmbNumRivets);
            this.tabShellEval.Controls.Add(this.btnCalculateHydro);
            this.tabShellEval.Controls.Add(this.lblCorrosionAllowance);
            this.tabShellEval.Controls.Add(this.txtCorrosionAllowance);
            this.tabShellEval.Controls.Add(this.hydroResultGrid);
            this.tabShellEval.Controls.Add(this.lblKFactor);
            this.tabShellEval.Controls.Add(this.txtKFactor);
            this.tabShellEval.Controls.Add(this.rtbFormulaDisplay);
            this.tabShellEval.Location = new System.Drawing.Point(4, 29);
            this.tabShellEval.Name = "tabShellEval";
            this.tabShellEval.Padding = new System.Windows.Forms.Padding(3);
            this.tabShellEval.Size = new System.Drawing.Size(1192, 1233);
            this.tabShellEval.TabIndex = 0;
            this.tabShellEval.Text = "Shell Evaluation";
            this.tabShellEval.UseVisualStyleBackColor = true;
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(39, 438);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(450, 46);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate Minimum Thickness";
            this.btnCalculate.UseVisualStyleBackColor = true;
            //
            // lblDiameter
            //
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(35, 42);
            this.lblDiameter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(201, 20);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Nominal Diameter (D, feet):";
            //
            // txtDiameter
            //
            this.txtDiameter.Location = new System.Drawing.Point(261, 42);
            this.txtDiameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(148, 26);
            this.txtDiameter.TabIndex = 1;
            this.txtDiameter.Text = "38";
            //
            // lblNumCourses
            //
            this.lblNumCourses.AutoSize = true;
            this.lblNumCourses.Location = new System.Drawing.Point(570, 10);
            this.lblNumCourses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCourses.Name = "lblNumCourses";
            this.lblNumCourses.Size = new System.Drawing.Size(189, 20);
            this.lblNumCourses.TabIndex = 2;
            this.lblNumCourses.Text = "Number of Shell Courses:";
            //
            // numCourses
            //
            this.numCourses.Location = new System.Drawing.Point(767, 8);
            this.numCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numCourses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCourses.Name = "numCourses";
            this.numCourses.Size = new System.Drawing.Size(150, 26);
            this.numCourses.TabIndex = 3;
            this.numCourses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // btnGenerateHeightInputs
            //
            this.btnGenerateHeightInputs.Location = new System.Drawing.Point(574, 42);
            this.btnGenerateHeightInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateHeightInputs.Name = "btnGenerateHeightInputs";
            this.btnGenerateHeightInputs.Size = new System.Drawing.Size(343, 35);
            this.btnGenerateHeightInputs.TabIndex = 4;
            this.btnGenerateHeightInputs.Text = "Generate Height Inputs";
            this.btnGenerateHeightInputs.UseVisualStyleBackColor = true;
            //
            // panelHeightInputs
            //
            this.panelHeightInputs.Location = new System.Drawing.Point(574, 86);
            this.panelHeightInputs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeightInputs.Name = "panelHeightInputs";
            this.panelHeightInputs.Size = new System.Drawing.Size(450, 343);
            this.panelHeightInputs.TabIndex = 5;
            //
            // lblYieldStrength
            //
            this.lblYieldStrength.AutoSize = true;
            this.lblYieldStrength.Location = new System.Drawing.Point(35, 74);
            this.lblYieldStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYieldStrength.Name = "lblYieldStrength";
            this.lblYieldStrength.Size = new System.Drawing.Size(167, 20);
            this.lblYieldStrength.TabIndex = 6;
            this.lblYieldStrength.Text = "Yield Strength (Y, psi):";
            //
            // txtYieldStrength
            //
            this.txtYieldStrength.Location = new System.Drawing.Point(261, 78);
            this.txtYieldStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYieldStrength.Name = "txtYieldStrength";
            this.txtYieldStrength.Size = new System.Drawing.Size(148, 26);
            this.txtYieldStrength.TabIndex = 7;
            this.txtYieldStrength.Text = "13000";
            //
            // lblTensileStrength
            //
            this.lblTensileStrength.AutoSize = true;
            this.lblTensileStrength.Location = new System.Drawing.Point(35, 110);
            this.lblTensileStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTensileStrength.Name = "lblTensileStrength";
            this.lblTensileStrength.Size = new System.Drawing.Size(180, 20);
            this.lblTensileStrength.TabIndex = 8;
            this.lblTensileStrength.Text = "Tensile Strength (T, psi):";
            //
            // txtTensileStrength
            //
            this.txtTensileStrength.Location = new System.Drawing.Point(261, 114);
            this.txtTensileStrength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTensileStrength.Name = "txtTensileStrength";
            this.txtTensileStrength.Size = new System.Drawing.Size(148, 26);
            this.txtTensileStrength.TabIndex = 9;
            this.txtTensileStrength.Text = "21000";
            //
            // lblSpecificGravity
            //
            this.lblSpecificGravity.AutoSize = true;
            this.lblSpecificGravity.Location = new System.Drawing.Point(35, 142);
            this.lblSpecificGravity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecificGravity.Name = "lblSpecificGravity";
            this.lblSpecificGravity.Size = new System.Drawing.Size(149, 20);
            this.lblSpecificGravity.TabIndex = 10;
            this.lblSpecificGravity.Text = "Specific Gravity (G):";
            //
            // txtSpecificGravity
            //
            this.txtSpecificGravity.Location = new System.Drawing.Point(261, 150);
            this.txtSpecificGravity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecificGravity.Name = "txtSpecificGravity";
            this.txtSpecificGravity.Size = new System.Drawing.Size(148, 26);
            this.txtSpecificGravity.TabIndex = 11;
            this.txtSpecificGravity.Text = "1.0";
            //
            // lblMaterial
            //
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(35, 10);
            this.lblMaterial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(108, 20);
            this.lblMaterial.TabIndex = 17;
            this.lblMaterial.Text = "Shell Material:";
            //
            // cmbMaterial
            //
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(261, 6);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(300, 28);
            this.cmbMaterial.TabIndex = 18;
            //
            // resultGrid
            //
            this.resultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNumber,
            this.Height,
            this.MinThickness,
            this.AllowableStress,
            this.StressBasis,
            this.TminVerification});
            this.resultGrid.Location = new System.Drawing.Point(39, 505);
            this.resultGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.RowHeadersWidth = 62;
            this.resultGrid.Size = new System.Drawing.Size(1144, 200);
            this.resultGrid.TabIndex = 16;
            //
            // CourseNumber
            //
            this.CourseNumber.HeaderText = "Course #";
            this.CourseNumber.MinimumWidth = 8;
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.ReadOnly = true;
            this.CourseNumber.Width = 75;
            //
            // Height
            //
            this.Height.HeaderText = "Height (ft)";
            this.Height.MinimumWidth = 8;
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Width = 75;
            //
            // MinThickness
            //
            this.MinThickness.HeaderText = "T-min (in)";
            this.MinThickness.MinimumWidth = 8;
            this.MinThickness.Name = "MinThickness";
            this.MinThickness.ReadOnly = true;
            this.MinThickness.Width = 75;
            //
            // AllowableStress
            //
            this.AllowableStress.HeaderText = "Allowable Stress";
            this.AllowableStress.MinimumWidth = 8;
            this.AllowableStress.Name = "AllowableStress";
            this.AllowableStress.ReadOnly = true;
            this.AllowableStress.Width = 80;
            //
            // StressBasis
            //
            this.StressBasis.HeaderText = "Stress Basis";
            this.StressBasis.MinimumWidth = 8;
            this.StressBasis.Name = "StressBasis";
            this.StressBasis.ReadOnly = true;
            this.StressBasis.Width = 380;
            //
            // TminVerification
            //
            this.TminVerification.HeaderText = "T-min Verification";
            this.TminVerification.MinimumWidth = 8;
            this.TminVerification.Name = "TminVerification";
            this.TminVerification.Width = 330;
            //
            // cmbStandard
            //
            this.cmbStandard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStandard.FormattingEnabled = true;
            this.cmbStandard.Location = new System.Drawing.Point(261, 186);
            this.cmbStandard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbStandard.Name = "cmbStandard";
            this.cmbStandard.Size = new System.Drawing.Size(300, 28);
            this.cmbStandard.TabIndex = 19;
            //
            // cmbEdition
            //
            this.cmbEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdition.FormattingEnabled = true;
            this.cmbEdition.Location = new System.Drawing.Point(261, 220);
            this.cmbEdition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEdition.Name = "cmbEdition";
            this.cmbEdition.Size = new System.Drawing.Size(300, 28);
            this.cmbEdition.TabIndex = 20;
            //
            // cmbJointType
            //
            this.cmbJointType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJointType.FormattingEnabled = true;
            this.cmbJointType.Location = new System.Drawing.Point(261, 254);
            this.cmbJointType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJointType.Name = "cmbJointType";
            this.cmbJointType.Size = new System.Drawing.Size(97, 28);
            this.cmbJointType.TabIndex = 21;
            //
            // cmbApplicability
            //
            this.cmbApplicability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicability.FormattingEnabled = true;
            this.cmbApplicability.Location = new System.Drawing.Point(261, 288);
            this.cmbApplicability.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbApplicability.Name = "cmbApplicability";
            this.cmbApplicability.Size = new System.Drawing.Size(300, 28);
            this.cmbApplicability.TabIndex = 22;
            //
            // lblEfficiencyValue
            //
            this.lblEfficiencyValue.AutoSize = true;
            this.lblEfficiencyValue.Location = new System.Drawing.Point(35, 330);
            this.lblEfficiencyValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEfficiencyValue.Name = "lblEfficiencyValue";
            this.lblEfficiencyValue.Size = new System.Drawing.Size(152, 20);
            this.lblEfficiencyValue.TabIndex = 23;
            this.lblEfficiencyValue.Text = "Selected Efficiency: ";
            //
            // lblEfficiencyDescription
            //
            this.lblEfficiencyDescription.AutoSize = true;
            this.lblEfficiencyDescription.Location = new System.Drawing.Point(35, 360);
            this.lblEfficiencyDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEfficiencyDescription.Name = "lblEfficiencyDescription";
            this.lblEfficiencyDescription.Size = new System.Drawing.Size(59, 20);
            this.lblEfficiencyDescription.TabIndex = 24;
            this.lblEfficiencyDescription.Text = "Notes: ";
            //
            // lblStandard
            //
            this.lblStandard.AutoSize = true;
            this.lblStandard.Location = new System.Drawing.Point(35, 189);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(79, 20);
            this.lblStandard.TabIndex = 25;
            this.lblStandard.Text = "Standard:";
            //
            // lblEdition
            //
            this.lblEdition.AutoSize = true;
            this.lblEdition.Location = new System.Drawing.Point(35, 223);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(108, 20);
            this.lblEdition.TabIndex = 26;
            this.lblEdition.Text = "Edition / Year:";
            //
            // lblJointType
            //
            this.lblJointType.AutoSize = true;
            this.lblJointType.Location = new System.Drawing.Point(35, 257);
            this.lblJointType.Name = "lblJointType";
            this.lblJointType.Size = new System.Drawing.Size(85, 20);
            this.lblJointType.TabIndex = 27;
            this.lblJointType.Text = "Joint Type:";
            //
            // lblLimits
            //
            this.lblLimits.AutoSize = true;
            this.lblLimits.Location = new System.Drawing.Point(35, 291);
            this.lblLimits.Name = "lblLimits";
            this.lblLimits.Size = new System.Drawing.Size(148, 20);
            this.lblLimits.TabIndex = 28;
            this.lblLimits.Text = "Applicability / Limits:";
            //
            // lblNumRivets
            //
            this.lblNumRivets.AutoSize = true;
            this.lblNumRivets.Location = new System.Drawing.Point(35, 223);
            this.lblNumRivets.Name = "lblNumRivets";
            this.lblNumRivets.Size = new System.Drawing.Size(135, 20);
            this.lblNumRivets.TabIndex = 29;
            this.lblNumRivets.Text = "Number of Rivets:";
            this.lblNumRivets.Visible = false;
            //
            // cmbNumRivets
            //
            this.cmbNumRivets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumRivets.FormattingEnabled = true;
            this.cmbNumRivets.Location = new System.Drawing.Point(261, 220);
            this.cmbNumRivets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNumRivets.Name = "cmbNumRivets";
            this.cmbNumRivets.Size = new System.Drawing.Size(300, 28);
            this.cmbNumRivets.TabIndex = 30;
            this.cmbNumRivets.Visible = false;
            //
            // btnCalculateHydro
            //
            this.btnCalculateHydro.Location = new System.Drawing.Point(39, 698);
            this.btnCalculateHydro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculateHydro.Name = "btnCalculateHydro";
            this.btnCalculateHydro.Size = new System.Drawing.Size(250, 46);
            this.btnCalculateHydro.TabIndex = 31;
            this.btnCalculateHydro.Text = "Calculate Allowable Heights";
            this.btnCalculateHydro.UseVisualStyleBackColor = true;
            //
            // lblCorrosionAllowance
            //
            this.lblCorrosionAllowance.AutoSize = true;
            this.lblCorrosionAllowance.Location = new System.Drawing.Point(35, 390);
            this.lblCorrosionAllowance.Name = "lblCorrosionAllowance";
            this.lblCorrosionAllowance.Size = new System.Drawing.Size(183, 20);
            this.lblCorrosionAllowance.TabIndex = 34;
            this.lblCorrosionAllowance.Text = "Corrosion Allowance (in):";
            //
            // txtCorrosionAllowance
            //
            this.txtCorrosionAllowance.Location = new System.Drawing.Point(261, 390);
            this.txtCorrosionAllowance.Name = "txtCorrosionAllowance";
            this.txtCorrosionAllowance.Size = new System.Drawing.Size(148, 26);
            this.txtCorrosionAllowance.TabIndex = 35;
            this.txtCorrosionAllowance.Text = "0";
            //
            // hydroResultGrid
            //
            this.hydroResultGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hydroResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hydroResultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HydroCourseNumber,
            this.ActualThickness,
            this.AllowableHt,
            this.MaxAllowableH});
            this.hydroResultGrid.Location = new System.Drawing.Point(39, 749);
            this.hydroResultGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.hydroResultGrid.Name = "hydroResultGrid";
            this.hydroResultGrid.RowHeadersWidth = 62;
            this.hydroResultGrid.Size = new System.Drawing.Size(1144, 220);
            this.hydroResultGrid.TabIndex = 32;
            //
            // HydroCourseNumber
            //
            this.HydroCourseNumber.HeaderText = "Course #";
            this.HydroCourseNumber.MinimumWidth = 8;
            this.HydroCourseNumber.Name = "HydroCourseNumber";
            this.HydroCourseNumber.ReadOnly = true;
            this.HydroCourseNumber.Width = 75;
            //
            // ActualThickness
            //
            this.ActualThickness.HeaderText = "Actual Thickness (in)";
            this.ActualThickness.MinimumWidth = 8;
            this.ActualThickness.Name = "ActualThickness";
            this.ActualThickness.Width = 150;
            //
            // AllowableHt
            //
            this.AllowableHt.HeaderText = "Allowable Ht (ft)";
            this.AllowableHt.MinimumWidth = 8;
            this.AllowableHt.Name = "AllowableHt";
            this.AllowableHt.ReadOnly = true;
            this.AllowableHt.Width = 150;
            //
            // MaxAllowableH
            //
            this.MaxAllowableH.HeaderText = "Max Allowable H (ft)";
            this.MaxAllowableH.MinimumWidth = 8;
            this.MaxAllowableH.Name = "MaxAllowableH";
            this.MaxAllowableH.ReadOnly = true;
            this.MaxAllowableH.Width = 150;
            //
            // HydrotestVerification
            //
            this.HydrotestVerification.HeaderText = "Hydrotest Verification";
            this.HydrotestVerification.MinimumWidth = 8;
            this.HydrotestVerification.Name = "HydrotestVerification";
            this.HydrotestVerification.ReadOnly = true;
            this.HydrotestVerification.Width = 400;
            //
            // MaxAllowableHVerification
            //
            this.MaxAllowableHVerification.HeaderText = "Max H Verification";
            this.MaxAllowableHVerification.MinimumWidth = 8;
            this.MaxAllowableHVerification.Name = "MaxAllowableHVerification";
            this.MaxAllowableHVerification.ReadOnly = true;
            this.MaxAllowableHVerification.Width = 400;
            //
            // lblKFactor
            //
            this.lblKFactor.AutoSize = true;
            this.lblKFactor.Location = new System.Drawing.Point(369, 257);
            this.lblKFactor.Name = "lblKFactor";
            this.lblKFactor.Size = new System.Drawing.Size(135, 20);
            this.lblKFactor.TabIndex = 36;
            this.lblKFactor.Text = "k-factor (decimal):";
            this.lblKFactor.Visible = false;
            //
            // txtKFactor
            //
            this.txtKFactor.Location = new System.Drawing.Point(510, 254);
            this.txtKFactor.Name = "txtKFactor";
            this.txtKFactor.Size = new System.Drawing.Size(51, 26);
            this.txtKFactor.TabIndex = 37;
            this.txtKFactor.Text = "1.0";
            this.txtKFactor.Visible = false;
            //
            // rtbFormulaDisplay
            //
            this.rtbFormulaDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFormulaDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFormulaDisplay.Location = new System.Drawing.Point(39, 992);
            this.rtbFormulaDisplay.Name = "rtbFormulaDisplay";
            this.rtbFormulaDisplay.ReadOnly = true;
            this.rtbFormulaDisplay.Size = new System.Drawing.Size(1144, 215);
            this.rtbFormulaDisplay.TabIndex = 38;
            this.rtbFormulaDisplay.Text = "Click on a row in the grids above to see detailed calculation formulas...";
            //
            // tabSettlementEval
            //
            this.tabSettlementEval.Controls.Add(this.grpSettlementBasicInfo);
            this.tabSettlementEval.Controls.Add(this.grpSettlementInputs);
            this.tabSettlementEval.Controls.Add(this.grpSettlementResults);
            this.tabSettlementEval.Controls.Add(this.grpSettlementSummary);
            this.tabSettlementEval.Controls.Add(this.btnCalculateSettlement);
            this.tabSettlementEval.Location = new System.Drawing.Point(4, 29);
            this.tabSettlementEval.Name = "tabSettlementEval";
            this.tabSettlementEval.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettlementEval.Size = new System.Drawing.Size(1192, 1233);
            this.tabSettlementEval.TabIndex = 1;
            this.tabSettlementEval.Text = "Settlement Evaluation";
            this.tabSettlementEval.UseVisualStyleBackColor = true;
            //
            // grpSettlementBasicInfo
            //
            this.grpSettlementBasicInfo.Controls.Add(this.lblSettlementDiameter);
            this.grpSettlementBasicInfo.Controls.Add(this.txtSettlementDiameter);
            this.grpSettlementBasicInfo.Controls.Add(this.lblSettlementShellHeight);
            this.grpSettlementBasicInfo.Controls.Add(this.txtSettlementShellHeight);
            this.grpSettlementBasicInfo.Controls.Add(this.lblBottomThickness);
            this.grpSettlementBasicInfo.Controls.Add(this.txtBottomThickness);
            this.grpSettlementBasicInfo.Controls.Add(this.lblSettlementTshell);
            this.grpSettlementBasicInfo.Controls.Add(this.txtSettlementTshell);
            this.grpSettlementBasicInfo.Location = new System.Drawing.Point(8, 6);
            this.grpSettlementBasicInfo.Name = "grpSettlementBasicInfo";
            this.grpSettlementBasicInfo.Size = new System.Drawing.Size(400, 150);
            this.grpSettlementBasicInfo.TabIndex = 0;
            this.grpSettlementBasicInfo.TabStop = false;
            this.grpSettlementBasicInfo.Text = "Basic Tank Info";
            //
            // lblSettlementDiameter
            //
            this.lblSettlementDiameter.AutoSize = true;
            this.lblSettlementDiameter.Location = new System.Drawing.Point(6, 25);
            this.lblSettlementDiameter.Name = "lblSettlementDiameter";
            this.lblSettlementDiameter.Size = new System.Drawing.Size(165, 20);
            this.lblSettlementDiameter.TabIndex = 0;
            this.lblSettlementDiameter.Text = "Tank Diameter (D) [ft]:";
            //
            // txtSettlementDiameter
            //
            this.txtSettlementDiameter.Location = new System.Drawing.Point(278, 22);
            this.txtSettlementDiameter.Name = "txtSettlementDiameter";
            this.txtSettlementDiameter.Size = new System.Drawing.Size(102, 26);
            this.txtSettlementDiameter.TabIndex = 1;
            //
            // lblSettlementShellHeight
            //
            this.lblSettlementShellHeight.AutoSize = true;
            this.lblSettlementShellHeight.Location = new System.Drawing.Point(6, 55);
            this.lblSettlementShellHeight.Name = "lblSettlementShellHeight";
            this.lblSettlementShellHeight.Size = new System.Drawing.Size(147, 20);
            this.lblSettlementShellHeight.TabIndex = 2;
            this.lblSettlementShellHeight.Text = "Shell Height (H) [ft]:";
            //
            // txtSettlementShellHeight
            //
            this.txtSettlementShellHeight.Location = new System.Drawing.Point(278, 52);
            this.txtSettlementShellHeight.Name = "txtSettlementShellHeight";
            this.txtSettlementShellHeight.Size = new System.Drawing.Size(102, 26);
            this.txtSettlementShellHeight.TabIndex = 3;
            //
            // lblBottomThickness
            //
            this.lblBottomThickness.AutoSize = true;
            this.lblBottomThickness.Location = new System.Drawing.Point(6, 85);
            this.lblBottomThickness.Name = "lblBottomThickness";
            this.lblBottomThickness.Size = new System.Drawing.Size(232, 20);
            this.lblBottomThickness.TabIndex = 4;
            this.lblBottomThickness.Text = "Bottom Plate Thickness (tb) [in]:";
            //
            // txtBottomThickness
            //
            this.txtBottomThickness.Location = new System.Drawing.Point(278, 82);
            this.txtBottomThickness.Name = "txtBottomThickness";
            this.txtBottomThickness.Size = new System.Drawing.Size(102, 26);
            this.txtBottomThickness.TabIndex = 5;
            //
            // lblSettlementTshell
            //
            this.lblSettlementTshell.AutoSize = true;
            this.lblSettlementTshell.Location = new System.Drawing.Point(6, 115);
            this.lblSettlementTshell.Name = "lblSettlementTshell";
            this.lblSettlementTshell.Size = new System.Drawing.Size(269, 20);
            this.lblSettlementTshell.TabIndex = 6;
            this.lblSettlementTshell.Text = "Lowest Course Thickness (tshell) [in]:";
            //
            // txtSettlementTshell
            //
            this.txtSettlementTshell.Location = new System.Drawing.Point(278, 112);
            this.txtSettlementTshell.Name = "txtSettlementTshell";
            this.txtSettlementTshell.Size = new System.Drawing.Size(102, 26);
            this.txtSettlementTshell.TabIndex = 7;
            //
            // grpSettlementInputs
            //
            this.grpSettlementInputs.Controls.Add(this.lblReferenceElevation);
            this.grpSettlementInputs.Controls.Add(this.txtReferenceElevation);
            this.grpSettlementInputs.Controls.Add(this.lblCenterElevation);
            this.grpSettlementInputs.Controls.Add(this.txtCenterElevation);
            this.grpSettlementInputs.Controls.Add(this.dgvSettlementPoints);
            this.grpSettlementInputs.Controls.Add(this.btnAddSettlementPoint);
            this.grpSettlementInputs.Controls.Add(this.btnClearSettlementPoints);
            this.grpSettlementInputs.Controls.Add(this.lblRecommendedPoints);
            this.grpSettlementInputs.Location = new System.Drawing.Point(8, 162);
            this.grpSettlementInputs.Name = "grpSettlementInputs";
            this.grpSettlementInputs.Size = new System.Drawing.Size(550, 539);
            this.grpSettlementInputs.TabIndex = 1;
            this.grpSettlementInputs.TabStop = false;
            this.grpSettlementInputs.Text = "Settlement Measurement Inputs";
            //
            // lblReferenceElevation
            //
            this.lblReferenceElevation.AutoSize = true;
            this.lblReferenceElevation.Location = new System.Drawing.Point(6, 25);
            this.lblReferenceElevation.Name = "lblReferenceElevation";
            this.lblReferenceElevation.Size = new System.Drawing.Size(181, 20);
            this.lblReferenceElevation.TabIndex = 0;
            this.lblReferenceElevation.Text = "Reference Elevation [in]:";
            //
            // txtReferenceElevation
            //
            this.txtReferenceElevation.Location = new System.Drawing.Point(211, 22);
            this.txtReferenceElevation.Name = "txtReferenceElevation";
            this.txtReferenceElevation.Size = new System.Drawing.Size(79, 26);
            this.txtReferenceElevation.TabIndex = 1;
            //
            // lblCenterElevation
            //
            this.lblCenterElevation.AutoSize = true;
            this.lblCenterElevation.Location = new System.Drawing.Point(300, 25);
            this.lblCenterElevation.Name = "lblCenterElevation";
            this.lblCenterElevation.Size = new System.Drawing.Size(154, 20);
            this.lblCenterElevation.TabIndex = 2;
            this.lblCenterElevation.Text = "Center Elevation [in]:";
            //
            // txtCenterElevation
            //
            this.txtCenterElevation.Location = new System.Drawing.Point(470, 22);
            this.txtCenterElevation.Name = "txtCenterElevation";
            this.txtCenterElevation.Size = new System.Drawing.Size(70, 26);
            this.txtCenterElevation.TabIndex = 3;
            //
            // dgvSettlementPoints
            //
            this.dgvSettlementPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettlementPoints.Location = new System.Drawing.Point(6, 95);
            this.dgvSettlementPoints.Name = "dgvSettlementPoints";
            this.dgvSettlementPoints.RowHeadersWidth = 62;
            this.dgvSettlementPoints.Size = new System.Drawing.Size(538, 344);
            this.dgvSettlementPoints.TabIndex = 4;
            //
            // btnAddSettlementPoint
            //
            this.btnAddSettlementPoint.Location = new System.Drawing.Point(3, 445);
            this.btnAddSettlementPoint.Name = "btnAddSettlementPoint";
            this.btnAddSettlementPoint.Size = new System.Drawing.Size(120, 33);
            this.btnAddSettlementPoint.TabIndex = 5;
            this.btnAddSettlementPoint.Text = "Add Point";
            //
            // btnClearSettlementPoints
            //
            this.btnClearSettlementPoints.Location = new System.Drawing.Point(129, 445);
            this.btnClearSettlementPoints.Name = "btnClearSettlementPoints";
            this.btnClearSettlementPoints.Size = new System.Drawing.Size(120, 33);
            this.btnClearSettlementPoints.TabIndex = 6;
            this.btnClearSettlementPoints.Text = "Clear Points";
            //
            // lblRecommendedPoints
            //
            this.lblRecommendedPoints.AutoSize = true;
            this.lblRecommendedPoints.Location = new System.Drawing.Point(257, 451);
            this.lblRecommendedPoints.Name = "lblRecommendedPoints";
            this.lblRecommendedPoints.Size = new System.Drawing.Size(182, 20);
            this.lblRecommendedPoints.TabIndex = 7;
            this.lblRecommendedPoints.Text = "Recommended: 8 points";
            //
            // grpSettlementResults
            //
            this.grpSettlementResults.Controls.Add(this.lblMaxDifferentialSettlement);
            this.grpSettlementResults.Controls.Add(this.lblAllowableDifferential);
            this.grpSettlementResults.Controls.Add(this.lblTiltAngle);
            this.grpSettlementResults.Controls.Add(this.lblEdgeSettlement);
            this.grpSettlementResults.Controls.Add(this.lblAllowableEdge);
            this.grpSettlementResults.Controls.Add(this.lblCenterSettlement);
            this.grpSettlementResults.Controls.Add(this.lblAllowableCenter);
            this.grpSettlementResults.Location = new System.Drawing.Point(570, 6);
            this.grpSettlementResults.Name = "grpSettlementResults";
            this.grpSettlementResults.Size = new System.Drawing.Size(450, 200);
            this.grpSettlementResults.TabIndex = 2;
            this.grpSettlementResults.TabStop = false;
            this.grpSettlementResults.Text = "Calculated Settlement Results";
            //
            // lblMaxDifferentialSettlement
            //
            this.lblMaxDifferentialSettlement.AutoSize = true;
            this.lblMaxDifferentialSettlement.Location = new System.Drawing.Point(6, 25);
            this.lblMaxDifferentialSettlement.Name = "lblMaxDifferentialSettlement";
            this.lblMaxDifferentialSettlement.Size = new System.Drawing.Size(205, 20);
            this.lblMaxDifferentialSettlement.TabIndex = 0;
            this.lblMaxDifferentialSettlement.Text = "Max Differential Settlement:";
            //
            // lblAllowableDifferential
            //
            this.lblAllowableDifferential.AutoSize = true;
            this.lblAllowableDifferential.Location = new System.Drawing.Point(6, 50);
            this.lblAllowableDifferential.Name = "lblAllowableDifferential";
            this.lblAllowableDifferential.Size = new System.Drawing.Size(243, 20);
            this.lblAllowableDifferential.TabIndex = 1;
            this.lblAllowableDifferential.Text = "Allowable Differential Settlement:";
            //
            // lblTiltAngle
            //
            this.lblTiltAngle.AutoSize = true;
            this.lblTiltAngle.Location = new System.Drawing.Point(6, 75);
            this.lblTiltAngle.Name = "lblTiltAngle";
            this.lblTiltAngle.Size = new System.Drawing.Size(78, 20);
            this.lblTiltAngle.TabIndex = 2;
            this.lblTiltAngle.Text = "Tilt Angle:";
            //
            // lblEdgeSettlement
            //
            this.lblEdgeSettlement.AutoSize = true;
            this.lblEdgeSettlement.Location = new System.Drawing.Point(6, 100);
            this.lblEdgeSettlement.Name = "lblEdgeSettlement";
            this.lblEdgeSettlement.Size = new System.Drawing.Size(133, 20);
            this.lblEdgeSettlement.TabIndex = 3;
            this.lblEdgeSettlement.Text = "Edge Settlement:";
            //
            // lblAllowableEdge
            //
            this.lblAllowableEdge.AutoSize = true;
            this.lblAllowableEdge.Location = new System.Drawing.Point(6, 125);
            this.lblAllowableEdge.Name = "lblAllowableEdge";
            this.lblAllowableEdge.Size = new System.Drawing.Size(204, 20);
            this.lblAllowableEdge.TabIndex = 4;
            this.lblAllowableEdge.Text = "Allowable Edge Settlement:";
            //
            // lblCenterSettlement
            //
            this.lblCenterSettlement.AutoSize = true;
            this.lblCenterSettlement.Location = new System.Drawing.Point(6, 150);
            this.lblCenterSettlement.Name = "lblCenterSettlement";
            this.lblCenterSettlement.Size = new System.Drawing.Size(143, 20);
            this.lblCenterSettlement.TabIndex = 5;
            this.lblCenterSettlement.Text = "Center Settlement:";
            //
            // lblAllowableCenter
            //
            this.lblAllowableCenter.AutoSize = true;
            this.lblAllowableCenter.Location = new System.Drawing.Point(6, 175);
            this.lblAllowableCenter.Name = "lblAllowableCenter";
            this.lblAllowableCenter.Size = new System.Drawing.Size(214, 20);
            this.lblAllowableCenter.TabIndex = 6;
            this.lblAllowableCenter.Text = "Allowable Center Settlement:";
            //
            // grpSettlementSummary
            //
            this.grpSettlementSummary.Controls.Add(this.rtbSettlementSummary);
            this.grpSettlementSummary.Controls.Add(this.lblTiltNote);
            this.grpSettlementSummary.Location = new System.Drawing.Point(570, 212);
            this.grpSettlementSummary.Name = "grpSettlementSummary";
            this.grpSettlementSummary.Size = new System.Drawing.Size(450, 389);
            this.grpSettlementSummary.TabIndex = 3;
            this.grpSettlementSummary.TabStop = false;
            this.grpSettlementSummary.Text = "Compliance Summary";
            //
            // rtbSettlementSummary
            //
            this.rtbSettlementSummary.Location = new System.Drawing.Point(6, 25);
            this.rtbSettlementSummary.Name = "rtbSettlementSummary";
            this.rtbSettlementSummary.ReadOnly = true;
            this.rtbSettlementSummary.Size = new System.Drawing.Size(438, 284);
            this.rtbSettlementSummary.TabIndex = 0;
            this.rtbSettlementSummary.Text = "";
            //
            // lblTiltNote
            //
            this.lblTiltNote.AutoSize = true;
            this.lblTiltNote.Location = new System.Drawing.Point(2, 337);
            this.lblTiltNote.Name = "lblTiltNote";
            this.lblTiltNote.Size = new System.Drawing.Size(500, 20);
            this.lblTiltNote.TabIndex = 1;
            this.lblTiltNote.Text = "Note: Tilt calculated conservatively from extreme elevation differences.";
            //
            // btnCalculateSettlement
            //
            this.btnCalculateSettlement.Location = new System.Drawing.Point(8, 707);
            this.btnCalculateSettlement.Name = "btnCalculateSettlement";
            this.btnCalculateSettlement.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateSettlement.TabIndex = 4;
            this.btnCalculateSettlement.Text = "Calculate Settlement";
            this.btnCalculateSettlement.UseVisualStyleBackColor = true;
            //
            // tabBottomEval
            //
            this.tabBottomEval.Controls.Add(this.grpAnnularPlate);
            this.tabBottomEval.Controls.Add(this.grpCriticalZone);
            this.tabBottomEval.Controls.Add(this.grpMrt);
            this.tabBottomEval.Location = new System.Drawing.Point(4, 29);
            this.tabBottomEval.Name = "tabBottomEval";
            this.tabBottomEval.Size = new System.Drawing.Size(1192, 1233);
            this.tabBottomEval.TabIndex = 2;
            this.tabBottomEval.Text = "Bottom Evaluation";
            this.tabBottomEval.UseVisualStyleBackColor = true;
            //
            // grpAnnularPlate
            //
            this.grpAnnularPlate.Controls.Add(this.lblAnnularPlateResult);
            this.grpAnnularPlate.Controls.Add(this.btnCalculateAnnularPlate);
            this.grpAnnularPlate.Controls.Add(this.txtAnnularCorrosionAllowance);
            this.grpAnnularPlate.Controls.Add(this.label12);
            this.grpAnnularPlate.Controls.Add(this.txtAsBuiltFirstCourse);
            this.grpAnnularPlate.Controls.Add(this.lblApiRefAnnular);
            this.grpAnnularPlate.Controls.Add(this.label11);
            this.grpAnnularPlate.Location = new System.Drawing.Point(556, 232);
            this.grpAnnularPlate.Name = "grpAnnularPlate";
            this.grpAnnularPlate.Size = new System.Drawing.Size(458, 220);
            this.grpAnnularPlate.TabIndex = 2;
            this.grpAnnularPlate.TabStop = false;
            this.grpAnnularPlate.Text = "Annular Plate Thickness";
            //
            // lblAnnularPlateResult
            //
            this.lblAnnularPlateResult.AutoSize = true;
            this.lblAnnularPlateResult.Location = new System.Drawing.Point(20, 95);
            this.lblAnnularPlateResult.Name = "lblAnnularPlateResult";
            this.lblAnnularPlateResult.Size = new System.Drawing.Size(59, 20);
            this.lblAnnularPlateResult.TabIndex = 5;
            this.lblAnnularPlateResult.Text = "Result:";
            //
            // btnCalculateAnnularPlate
            //
            this.btnCalculateAnnularPlate.Location = new System.Drawing.Point(252, 165);
            this.btnCalculateAnnularPlate.Name = "btnCalculateAnnularPlate";
            this.btnCalculateAnnularPlate.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateAnnularPlate.TabIndex = 4;
            this.btnCalculateAnnularPlate.Text = "Calculate Annular Plate Thickness";
            this.btnCalculateAnnularPlate.UseVisualStyleBackColor = true;
            //
            // txtAnnularCorrosionAllowance
            //
            this.txtAnnularCorrosionAllowance.Location = new System.Drawing.Point(290, 58);
            this.txtAnnularCorrosionAllowance.Name = "txtAnnularCorrosionAllowance";
            this.txtAnnularCorrosionAllowance.Size = new System.Drawing.Size(144, 26);
            this.txtAnnularCorrosionAllowance.TabIndex = 3;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(256, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Annular Plate Corrosion Allowance:";
            //
            // txtAsBuiltFirstCourse
            //
            this.txtAsBuiltFirstCourse.Location = new System.Drawing.Point(290, 25);
            this.txtAsBuiltFirstCourse.Name = "txtAsBuiltFirstCourse";
            this.txtAsBuiltFirstCourse.Size = new System.Drawing.Size(144, 26);
            this.txtAsBuiltFirstCourse.TabIndex = 2;
            //
            // lblApiRefAnnular
            //
            this.lblApiRefAnnular.AutoSize = true;
            this.lblApiRefAnnular.Location = new System.Drawing.Point(20, 130);
            this.lblApiRefAnnular.Name = "lblApiRefAnnular";
            this.lblApiRefAnnular.Size = new System.Drawing.Size(139, 20);
            this.lblApiRefAnnular.TabIndex = 6;
            this.lblApiRefAnnular.Text = "Ref: API 653 4.4.5";
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(250, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "As-Built 1st Course Thickness (in):";
            //
            // grpCriticalZone
            //
            this.grpCriticalZone.Controls.Add(this.lblCriticalZoneResult);
            this.grpCriticalZone.Controls.Add(this.btnCalculateCriticalZone);
            this.grpCriticalZone.Controls.Add(this.txtOriginalBottomThickness);
            this.grpCriticalZone.Controls.Add(this.lblApiRefCriticalZone);
            this.grpCriticalZone.Controls.Add(this.label10);
            this.grpCriticalZone.Controls.Add(this.txtTminShellCourse1);
            this.grpCriticalZone.Controls.Add(this.lblTminShellCourse1);
            this.grpCriticalZone.Location = new System.Drawing.Point(556, 6);
            this.grpCriticalZone.Name = "grpCriticalZone";
            this.grpCriticalZone.Size = new System.Drawing.Size(458, 220);
            this.grpCriticalZone.TabIndex = 1;
            this.grpCriticalZone.TabStop = false;
            this.grpCriticalZone.Text = "Critical Zone Thickness";
            //
            // lblCriticalZoneResult
            //
            this.lblCriticalZoneResult.AutoSize = true;
            this.lblCriticalZoneResult.Location = new System.Drawing.Point(20, 100);
            this.lblCriticalZoneResult.Name = "lblCriticalZoneResult";
            this.lblCriticalZoneResult.Size = new System.Drawing.Size(59, 20);
            this.lblCriticalZoneResult.TabIndex = 3;
            this.lblCriticalZoneResult.Text = "Result:";
            //
            // btnCalculateCriticalZone
            //
            this.btnCalculateCriticalZone.Location = new System.Drawing.Point(234, 156);
            this.btnCalculateCriticalZone.Name = "btnCalculateCriticalZone";
            this.btnCalculateCriticalZone.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateCriticalZone.TabIndex = 2;
            this.btnCalculateCriticalZone.Text = "Calculate Critical Zone Thickness";
            this.btnCalculateCriticalZone.UseVisualStyleBackColor = true;
            //
            // txtOriginalBottomThickness
            //
            this.txtOriginalBottomThickness.Location = new System.Drawing.Point(290, 56);
            this.txtOriginalBottomThickness.Name = "txtOriginalBottomThickness";
            this.txtOriginalBottomThickness.Size = new System.Drawing.Size(144, 26);
            this.txtOriginalBottomThickness.TabIndex = 1;
            //
            // lblApiRefCriticalZone
            //
            this.lblApiRefCriticalZone.AutoSize = true;
            this.lblApiRefCriticalZone.Location = new System.Drawing.Point(20, 130);
            this.lblApiRefCriticalZone.Name = "lblApiRefCriticalZone";
            this.lblApiRefCriticalZone.Size = new System.Drawing.Size(139, 20);
            this.lblApiRefCriticalZone.TabIndex = 4;
            this.lblApiRefCriticalZone.Text = "Ref: API 653 4.3.3";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Original Bottom Thickness (in):";
            //
            // txtTminShellCourse1
            //
            this.txtTminShellCourse1.Location = new System.Drawing.Point(290, 22);
            this.txtTminShellCourse1.Name = "txtTminShellCourse1";
            this.txtTminShellCourse1.Size = new System.Drawing.Size(144, 26);
            this.txtTminShellCourse1.TabIndex = 0;
            //
            // lblTminShellCourse1
            //
            this.lblTminShellCourse1.AutoSize = true;
            this.lblTminShellCourse1.Location = new System.Drawing.Point(20, 25);
            this.lblTminShellCourse1.Name = "lblTminShellCourse1";
            this.lblTminShellCourse1.Size = new System.Drawing.Size(198, 20);
            this.lblTminShellCourse1.TabIndex = 6;
            this.lblTminShellCourse1.Text = "t_min 1st Shell Course (in):";
            //
            // grpMrt
            //
            this.grpMrt.Controls.Add(this.lblMrtResult);
            this.grpMrt.Controls.Add(this.lblCoatingLife);
            this.grpMrt.Controls.Add(this.txtCoatingLife);
            this.grpMrt.Controls.Add(this.chkBottomCoated);
            this.grpMrt.Controls.Add(this.btnCalculateMrt);
            this.grpMrt.Controls.Add(this.cmbTable4_4);
            this.grpMrt.Controls.Add(this.label8);
            this.grpMrt.Controls.Add(this.txtUPr);
            this.grpMrt.Controls.Add(this.label7);
            this.grpMrt.Controls.Add(this.txtStPr);
            this.grpMrt.Controls.Add(this.label6);
            this.grpMrt.Controls.Add(this.txtOr);
            this.grpMrt.Controls.Add(this.label5);
            this.grpMrt.Controls.Add(this.txtRTip);
            this.grpMrt.Controls.Add(this.label4);
            this.grpMrt.Controls.Add(this.txtRTbc);
            this.grpMrt.Controls.Add(this.lblUnitRTbc);
            this.grpMrt.Controls.Add(this.lblUnitRTip);
            this.grpMrt.Controls.Add(this.lblUnitOr);
            this.grpMrt.Controls.Add(this.lblUnitStPr);
            this.grpMrt.Controls.Add(this.lblUnitUPr);
            this.grpMrt.Controls.Add(this.lblApiRefMrt);
            this.grpMrt.Controls.Add(this.label_RTbc);
            this.grpMrt.Location = new System.Drawing.Point(8, 6);
            this.grpMrt.Name = "grpMrt";
            this.grpMrt.Size = new System.Drawing.Size(542, 716);
            this.grpMrt.TabIndex = 0;
            this.grpMrt.TabStop = false;
            this.grpMrt.Text = "Minimum Remaining Thickness (MRT) for Next Inspection";
            //
            // lblMrtResult
            //
            this.lblMrtResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMrtResult.Location = new System.Drawing.Point(20, 444);
            this.lblMrtResult.Name = "lblMrtResult";
            this.lblMrtResult.Size = new System.Drawing.Size(500, 100);
            this.lblMrtResult.TabIndex = 23;
            this.lblMrtResult.Text = "Awaiting calculation...";
            //
            // lblCoatingLife
            //
            this.lblCoatingLife.AutoSize = true;
            this.lblCoatingLife.Location = new System.Drawing.Point(230, 330);
            this.lblCoatingLife.Name = "lblCoatingLife";
            this.lblCoatingLife.Size = new System.Drawing.Size(150, 20);
            this.lblCoatingLife.TabIndex = 22;
            this.lblCoatingLife.Text = "Coating Life (years):";
            this.lblCoatingLife.Visible = false;
            //
            // txtCoatingLife
            //
            this.txtCoatingLife.Location = new System.Drawing.Point(380, 327);
            this.txtCoatingLife.Name = "txtCoatingLife";
            this.txtCoatingLife.Size = new System.Drawing.Size(110, 26);
            this.txtCoatingLife.TabIndex = 21;
            this.txtCoatingLife.Visible = false;
            //
            // chkBottomCoated
            //
            this.chkBottomCoated.AutoSize = true;
            this.chkBottomCoated.Location = new System.Drawing.Point(20, 329);
            this.chkBottomCoated.Name = "chkBottomCoated";
            this.chkBottomCoated.Size = new System.Drawing.Size(167, 24);
            this.chkBottomCoated.TabIndex = 20;
            this.chkBottomCoated.Text = "Bottom is Coated?";
            this.chkBottomCoated.UseVisualStyleBackColor = true;
            //
            // btnCalculateMrt
            //
            this.btnCalculateMrt.Location = new System.Drawing.Point(290, 383);
            this.btnCalculateMrt.Name = "btnCalculateMrt";
            this.btnCalculateMrt.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateMrt.TabIndex = 12;
            this.btnCalculateMrt.Text = "Calculate MRT";
            this.btnCalculateMrt.UseVisualStyleBackColor = true;
            //
            // cmbTable4_4
            //
            this.cmbTable4_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable4_4.FormattingEnabled = true;
            this.cmbTable4_4.Location = new System.Drawing.Point(20, 290);
            this.cmbTable4_4.Name = "cmbTable4_4";
            this.cmbTable4_4.Size = new System.Drawing.Size(470, 28);
            this.cmbTable4_4.TabIndex = 11;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Leak Detection / Containment System (Table 4.4):";
            //
            // txtUPr
            //
            this.txtUPr.Location = new System.Drawing.Point(360, 210);
            this.txtUPr.Name = "txtUPr";
            this.txtUPr.Size = new System.Drawing.Size(130, 26);
            this.txtUPr.TabIndex = 9;
            this.txtUPr.Text = "0.003";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(290, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max Corrosion Rate, Bottom Side (UPr):";
            //
            // txtStPr
            //
            this.txtStPr.Location = new System.Drawing.Point(360, 170);
            this.txtStPr.Name = "txtStPr";
            this.txtStPr.Size = new System.Drawing.Size(130, 26);
            this.txtStPr.TabIndex = 7;
            this.txtStPr.Text = "0.005";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Max Corrosion Rate, Top Side (StPr):";
            //
            // txtOr
            //
            this.txtOr.Location = new System.Drawing.Point(360, 130);
            this.txtOr.Name = "txtOr";
            this.txtOr.Size = new System.Drawing.Size(130, 26);
            this.txtOr.TabIndex = 5;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Next Inspection Interval (Or, years):";
            //
            // txtRTip
            //
            this.txtRTip.Location = new System.Drawing.Point(360, 90);
            this.txtRTip.Name = "txtRTip";
            this.txtRTip.Size = new System.Drawing.Size(130, 26);
            this.txtRTip.TabIndex = 3;
            this.txtRTip.Text = "0.20";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Min. Rem. Thickness, Top Side (RTip):";
            //
            // txtRTbc
            //
            this.txtRTbc.Location = new System.Drawing.Point(360, 50);
            this.txtRTbc.Name = "txtRTbc";
            this.txtRTbc.Size = new System.Drawing.Size(130, 26);
            this.txtRTbc.TabIndex = 1;
            this.txtRTbc.Text = "0.25";
            //
            // lblUnitRTbc
            //
            this.lblUnitRTbc.AutoSize = true;
            this.lblUnitRTbc.Location = new System.Drawing.Point(495, 53);
            this.lblUnitRTbc.Name = "lblUnitRTbc";
            this.lblUnitRTbc.Size = new System.Drawing.Size(21, 20);
            this.lblUnitRTbc.TabIndex = 15;
            this.lblUnitRTbc.Text = "in";
            //
            // lblUnitRTip
            //
            this.lblUnitRTip.AutoSize = true;
            this.lblUnitRTip.Location = new System.Drawing.Point(495, 93);
            this.lblUnitRTip.Name = "lblUnitRTip";
            this.lblUnitRTip.Size = new System.Drawing.Size(21, 20);
            this.lblUnitRTip.TabIndex = 16;
            this.lblUnitRTip.Text = "in";
            //
            // lblUnitOr
            //
            this.lblUnitOr.AutoSize = true;
            this.lblUnitOr.Location = new System.Drawing.Point(495, 133);
            this.lblUnitOr.Name = "lblUnitOr";
            this.lblUnitOr.Size = new System.Drawing.Size(47, 20);
            this.lblUnitOr.TabIndex = 17;
            this.lblUnitOr.Text = "years";
            //
            // lblUnitStPr
            //
            this.lblUnitStPr.AutoSize = true;
            this.lblUnitStPr.Location = new System.Drawing.Point(495, 173);
            this.lblUnitStPr.Name = "lblUnitStPr";
            this.lblUnitStPr.Size = new System.Drawing.Size(37, 20);
            this.lblUnitStPr.TabIndex = 18;
            this.lblUnitStPr.Text = "in/yr";
            //
            // lblUnitUPr
            //
            this.lblUnitUPr.AutoSize = true;
            this.lblUnitUPr.Location = new System.Drawing.Point(495, 213);
            this.lblUnitUPr.Name = "lblUnitUPr";
            this.lblUnitUPr.Size = new System.Drawing.Size(37, 20);
            this.lblUnitUPr.TabIndex = 19;
            this.lblUnitUPr.Text = "in/yr";
            //
            // lblApiRefMrt
            //
            this.lblApiRefMrt.AutoSize = true;
            this.lblApiRefMrt.Location = new System.Drawing.Point(20, 380);
            this.lblApiRefMrt.Name = "lblApiRefMrt";
            this.lblApiRefMrt.Size = new System.Drawing.Size(139, 20);
            this.lblApiRefMrt.TabIndex = 14;
            this.lblApiRefMrt.Text = "Ref: API 653 4.4.2";
            //
            // label_RTbc
            //
            this.label_RTbc.AutoSize = true;
            this.label_RTbc.Location = new System.Drawing.Point(20, 50);
            this.label_RTbc.Name = "label_RTbc";
            this.label_RTbc.Size = new System.Drawing.Size(307, 20);
            this.label_RTbc.TabIndex = 0;
            this.label_RTbc.Text = "Min. Rem. Thickness, Bottom Side (RTbc):";
            //
            // tabLocalizedCorrosion
            //
            this.tabLocalizedCorrosion.Controls.Add(this.grpLocalizedCorrosion);
            this.tabLocalizedCorrosion.Location = new System.Drawing.Point(4, 29);
            this.tabLocalizedCorrosion.Name = "tabLocalizedCorrosion";
            this.tabLocalizedCorrosion.Size = new System.Drawing.Size(1192, 1233);
            this.tabLocalizedCorrosion.TabIndex = 3;
            this.tabLocalizedCorrosion.Text = "Localized Corrosion";
            this.tabLocalizedCorrosion.UseVisualStyleBackColor = true;
            //
            // grpLocalizedCorrosion
            //
            this.grpLocalizedCorrosion.Controls.Add(this.rtbLocalizedResult);
            this.grpLocalizedCorrosion.Controls.Add(this.txtLactualLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblLactualLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.btnCalculateLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.txtTminLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblTminLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.txtT2Localized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblApiRefLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblT2Localized);
            this.grpLocalizedCorrosion.Controls.Add(this.txtDiameterLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblDiameterLocalized);
            this.grpLocalizedCorrosion.Controls.Add(this.lblValidationIconLocalized);
            this.grpLocalizedCorrosion.Location = new System.Drawing.Point(8, 6);
            this.grpLocalizedCorrosion.Name = "grpLocalizedCorrosion";
            this.grpLocalizedCorrosion.Size = new System.Drawing.Size(537, 486);
            this.grpLocalizedCorrosion.TabIndex = 0;
            this.grpLocalizedCorrosion.TabStop = false;
            this.grpLocalizedCorrosion.Text = "Localized Corrosion Evaluation";
            //
            // rtbLocalizedResult
            //
            this.rtbLocalizedResult.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbLocalizedResult.Location = new System.Drawing.Point(20, 160);
            this.rtbLocalizedResult.Name = "rtbLocalizedResult";
            this.rtbLocalizedResult.ReadOnly = true;
            this.rtbLocalizedResult.Size = new System.Drawing.Size(470, 255);
            this.rtbLocalizedResult.TabIndex = 5;
            this.rtbLocalizedResult.Text = "Awaiting calculation...";
            //
            // txtLactualLocalized
            //
            this.txtLactualLocalized.Location = new System.Drawing.Point(331, 120);
            this.txtLactualLocalized.Name = "txtLactualLocalized";
            this.txtLactualLocalized.Size = new System.Drawing.Size(159, 26);
            this.txtLactualLocalized.TabIndex = 3;
            //
            // lblLactualLocalized
            //
            this.lblLactualLocalized.AutoSize = true;
            this.lblLactualLocalized.Location = new System.Drawing.Point(20, 123);
            this.lblLactualLocalized.Name = "lblLactualLocalized";
            this.lblLactualLocalized.Size = new System.Drawing.Size(282, 20);
            this.lblLactualLocalized.TabIndex = 10;
            this.lblLactualLocalized.Text = "Actual Measured Length (L_actual, in):";
            //
            // btnCalculateLocalized
            //
            this.btnCalculateLocalized.Location = new System.Drawing.Point(290, 421);
            this.btnCalculateLocalized.Name = "btnCalculateLocalized";
            this.btnCalculateLocalized.Size = new System.Drawing.Size(200, 40);
            this.btnCalculateLocalized.TabIndex = 6;
            this.btnCalculateLocalized.Text = "Calculate";
            this.btnCalculateLocalized.UseVisualStyleBackColor = true;
            //
            // txtTminLocalized
            //
            this.txtTminLocalized.Location = new System.Drawing.Point(331, 87);
            this.txtTminLocalized.Name = "txtTminLocalized";
            this.txtTminLocalized.Size = new System.Drawing.Size(159, 26);
            this.txtTminLocalized.TabIndex = 2;
            //
            // lblTminLocalized
            //
            this.lblTminLocalized.AutoSize = true;
            this.lblTminLocalized.Location = new System.Drawing.Point(20, 90);
            this.lblTminLocalized.Name = "lblTminLocalized";
            this.lblTminLocalized.Size = new System.Drawing.Size(262, 20);
            this.lblTminLocalized.TabIndex = 2;
            this.lblTminLocalized.Text = "Minimum Req. Thickness (t_min, in):";
            //
            // txtT2Localized
            //
            this.txtT2Localized.Location = new System.Drawing.Point(331, 54);
            this.txtT2Localized.Name = "txtT2Localized";
            this.txtT2Localized.Size = new System.Drawing.Size(159, 26);
            this.txtT2Localized.TabIndex = 1;
            //
            // lblApiRefLocalized
            //
            this.lblApiRefLocalized.AutoSize = true;
            this.lblApiRefLocalized.Location = new System.Drawing.Point(20, 441);
            this.lblApiRefLocalized.Name = "lblApiRefLocalized";
            this.lblApiRefLocalized.Size = new System.Drawing.Size(139, 20);
            this.lblApiRefLocalized.TabIndex = 6;
            this.lblApiRefLocalized.Text = "Ref: API 653 4.3.2";
            //
            // lblT2Localized
            //
            this.lblT2Localized.AutoSize = true;
            this.lblT2Localized.Location = new System.Drawing.Point(20, 57);
            this.lblT2Localized.Name = "lblT2Localized";
            this.lblT2Localized.Size = new System.Drawing.Size(253, 20);
            this.lblT2Localized.TabIndex = 0;
            this.lblT2Localized.Text = "Minimum Thickness in Area (t2, in):";
            //
            // txtDiameterLocalized
            //
            this.txtDiameterLocalized.Location = new System.Drawing.Point(331, 21);
            this.txtDiameterLocalized.Name = "txtDiameterLocalized";
            this.txtDiameterLocalized.Size = new System.Drawing.Size(159, 26);
            this.txtDiameterLocalized.TabIndex = 0;
            //
            // lblDiameterLocalized
            //
            this.lblDiameterLocalized.AutoSize = true;
            this.lblDiameterLocalized.Location = new System.Drawing.Point(20, 24);
            this.lblDiameterLocalized.Name = "lblDiameterLocalized";
            this.lblDiameterLocalized.Size = new System.Drawing.Size(161, 20);
            this.lblDiameterLocalized.TabIndex = 0;
            this.lblDiameterLocalized.Text = "Tank Diameter (D, ft):";
            //
            // lblValidationIconLocalized
            //
            this.lblValidationIconLocalized.AutoSize = true;
            this.lblValidationIconLocalized.ForeColor = System.Drawing.Color.Green;
            this.lblValidationIconLocalized.Location = new System.Drawing.Point(187, 24);
            this.lblValidationIconLocalized.Name = "lblValidationIconLocalized";
            this.lblValidationIconLocalized.Size = new System.Drawing.Size(18, 20);
            this.lblValidationIconLocalized.TabIndex = 9;
            this.lblValidationIconLocalized.Text = "✓";
            //
            // API_653_Tank_Calcs
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 1266);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "API_653_Tank_Calcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API 653 Tank Shell Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabShellEval.ResumeLayout(false);
            this.tabShellEval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hydroResultGrid)).EndInit();
            this.tabSettlementEval.ResumeLayout(false);
            this.grpSettlementBasicInfo.ResumeLayout(false);
            this.grpSettlementBasicInfo.PerformLayout();
            this.grpSettlementInputs.ResumeLayout(false);
            this.grpSettlementInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettlementPoints)).EndInit();
            this.grpSettlementResults.ResumeLayout(false);
            this.grpSettlementResults.PerformLayout();
            this.grpSettlementSummary.ResumeLayout(false);
            this.grpSettlementSummary.PerformLayout();
            this.tabBottomEval.ResumeLayout(false);
            this.grpAnnularPlate.ResumeLayout(false);
            this.grpAnnularPlate.PerformLayout();
            this.grpCriticalZone.ResumeLayout(false);
            this.grpCriticalZone.PerformLayout();
            this.grpMrt.ResumeLayout(false);
            this.grpMrt.PerformLayout();
            this.tabLocalizedCorrosion.ResumeLayout(false);
            this.grpLocalizedCorrosion.ResumeLayout(false);
            this.grpLocalizedCorrosion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabShellEval;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblNumCourses;
        private System.Windows.Forms.NumericUpDown numCourses;
        private System.Windows.Forms.Button btnGenerateHeightInputs;
        private System.Windows.Forms.Panel panelHeightInputs;
        private System.Windows.Forms.Label lblYieldStrength;
        private System.Windows.Forms.TextBox txtYieldStrength;
        private System.Windows.Forms.Label lblTensileStrength;
        private System.Windows.Forms.TextBox txtTensileStrength;
        private System.Windows.Forms.Label lblSpecificGravity;
        private System.Windows.Forms.TextBox txtSpecificGravity;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbStandard;
        private System.Windows.Forms.ComboBox cmbEdition;
        private System.Windows.Forms.ComboBox cmbJointType;
        private System.Windows.Forms.ComboBox cmbApplicability;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowableStress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StressBasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn TminVerification;
        private System.Windows.Forms.Label lblEfficiencyValue;
        private System.Windows.Forms.Label lblEfficiencyDescription;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblJointType;
        private System.Windows.Forms.Label lblLimits;
        private System.Windows.Forms.Label lblNumRivets;
        private System.Windows.Forms.ComboBox cmbNumRivets;
        private System.Windows.Forms.Button btnCalculateHydro;
        private System.Windows.Forms.DataGridView hydroResultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn HydroCourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowableHt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxAllowableH;
        private System.Windows.Forms.TabPage tabSettlementEval;
        private System.Windows.Forms.TabPage tabBottomEval;
        private System.Windows.Forms.TabPage tabLocalizedCorrosion;
        private System.Windows.Forms.GroupBox grpMrt;
        private System.Windows.Forms.Button btnCalculateMrt;
        private System.Windows.Forms.Label lblMrtResult;
        private System.Windows.Forms.CheckBox chkBottomCoated;
        private System.Windows.Forms.TextBox txtCoatingLife;
        private System.Windows.Forms.Label lblCoatingLife;
        private System.Windows.Forms.ComboBox cmbTable4_4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUPr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRTbc;
        private System.Windows.Forms.Label label_RTbc;
        private System.Windows.Forms.GroupBox grpCriticalZone;
        private System.Windows.Forms.Label lblCriticalZoneResult;
        private System.Windows.Forms.Button btnCalculateCriticalZone;
        private System.Windows.Forms.TextBox txtOriginalBottomThickness;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpAnnularPlate;
        private System.Windows.Forms.Label lblAnnularPlateResult;
        private System.Windows.Forms.Button btnCalculateAnnularPlate;
        private System.Windows.Forms.TextBox txtAnnularCorrosionAllowance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAsBuiltFirstCourse;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpLocalizedCorrosion;
        private System.Windows.Forms.RichTextBox rtbLocalizedResult;
        private System.Windows.Forms.TextBox txtLactualLocalized;
        private System.Windows.Forms.Label lblLactualLocalized;
        private System.Windows.Forms.Button btnCalculateLocalized;
        private System.Windows.Forms.TextBox txtTminLocalized;
        private System.Windows.Forms.Label lblTminLocalized;
        private System.Windows.Forms.TextBox txtT2Localized;
        private System.Windows.Forms.Label lblT2Localized;
        private System.Windows.Forms.Label lblCorrosionAllowance;
        private System.Windows.Forms.TextBox txtCorrosionAllowance;
        private System.Windows.Forms.Label lblApiRefLocalized;
        private System.Windows.Forms.Label lblApiRefMrt;
        private System.Windows.Forms.Label lblApiRefCriticalZone;
        private System.Windows.Forms.Label lblApiRefAnnular;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDiameterLocalized;
        private System.Windows.Forms.Label lblDiameterLocalized;
        private System.Windows.Forms.Label lblValidationIconLocalized;
        private System.Windows.Forms.TextBox txtTminShellCourse1;
        private System.Windows.Forms.Label lblTminShellCourse1;
        // Settlement Evaluation Tab Controls
        private System.Windows.Forms.GroupBox grpSettlementBasicInfo;
        private System.Windows.Forms.Label lblSettlementDiameter;
        private System.Windows.Forms.TextBox txtSettlementDiameter;
        private System.Windows.Forms.Label lblSettlementShellHeight;
        private System.Windows.Forms.TextBox txtSettlementShellHeight;
        private System.Windows.Forms.Label lblBottomThickness;
        private System.Windows.Forms.TextBox txtBottomThickness;
        private System.Windows.Forms.Label lblSettlementTshell;
        private System.Windows.Forms.TextBox txtSettlementTshell;
        private System.Windows.Forms.GroupBox grpSettlementInputs;
        private System.Windows.Forms.Label lblReferenceElevation;
        private System.Windows.Forms.TextBox txtReferenceElevation;
        private System.Windows.Forms.Label lblCenterElevation;
        private System.Windows.Forms.TextBox txtCenterElevation;
        private System.Windows.Forms.DataGridView dgvSettlementPoints;
        private System.Windows.Forms.Button btnAddSettlementPoint;
        private System.Windows.Forms.Button btnClearSettlementPoints;
        private System.Windows.Forms.Label lblRecommendedPoints;
        private System.Windows.Forms.GroupBox grpSettlementResults;
        private System.Windows.Forms.Label lblMaxDifferentialSettlement;
        private System.Windows.Forms.Label lblAllowableDifferential;
        private System.Windows.Forms.Label lblTiltAngle;
        private System.Windows.Forms.Label lblEdgeSettlement;
        private System.Windows.Forms.Label lblAllowableEdge;
        private System.Windows.Forms.Label lblCenterSettlement;
        private System.Windows.Forms.Label lblAllowableCenter;
        private System.Windows.Forms.GroupBox grpSettlementSummary;
        private System.Windows.Forms.RichTextBox rtbSettlementSummary;
        private System.Windows.Forms.Label lblTiltNote;
        private System.Windows.Forms.Button btnCalculateSettlement;
        private System.Windows.Forms.Label lblUnitRTbc;
        private System.Windows.Forms.Label lblUnitRTip;
        private System.Windows.Forms.Label lblUnitOr;
        private System.Windows.Forms.Label lblUnitStPr;
        private System.Windows.Forms.Label lblUnitUPr;
        private System.Windows.Forms.Label lblKFactor;
        private System.Windows.Forms.TextBox txtKFactor;
        private System.Windows.Forms.RichTextBox rtbFormulaDisplay;
    }
}
