namespace FERExcelAddIn
{
    partial class B31_3PipeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B31_3PipeCalculator));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbQualityFactor = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.labelWeldJointFactor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxDimensions = new System.Windows.Forms.GroupBox();
            this.txtOuterDiameter = new System.Windows.Forms.TextBox();
            this.cmbNPS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.txtBarlowThicknessResult = new System.Windows.Forms.TextBox();
            this.lblBarlowThickness = new System.Windows.Forms.Label();
            this.txtMinThicknessResult = new System.Windows.Forms.TextBox();
            this.labelMinThickness = new System.Windows.Forms.Label();
            this.txtStressValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxFactors = new System.Windows.Forms.GroupBox();
            this.txtWeldJointFactor = new System.Windows.Forms.TextBox();
            this.txtYCoefficient = new System.Windows.Forms.TextBox();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.groupBoxDisclaimer = new System.Windows.Forms.GroupBox();
            this.txtDisclaimer = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelResults = new System.Windows.Forms.Panel();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colNPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarlowThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxResultFormulas = new System.Windows.Forms.GroupBox();
            this.lblBarlowFormula = new System.Windows.Forms.Label();
            this.lblB313Formula = new System.Windows.Forms.Label();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxDimensions.SuspendLayout();
            this.groupBoxConditions.SuspendLayout();
            this.groupBoxFactors.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.groupBoxDisclaimer.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBoxResultFormulas.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBoxMaterial
            //
            this.groupBoxMaterial.Controls.Add(this.cmbMaterial);
            this.groupBoxMaterial.Controls.Add(this.label1);
            this.groupBoxMaterial.Controls.Add(this.cmbSpec);
            this.groupBoxMaterial.Controls.Add(this.label2);
            this.groupBoxMaterial.Controls.Add(this.cmbGrade);
            this.groupBoxMaterial.Controls.Add(this.label3);
            this.groupBoxMaterial.Location = new System.Drawing.Point(10, 10);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxMaterial.Size = new System.Drawing.Size(545, 130);
            this.groupBoxMaterial.TabIndex = 0;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material Specifications";
            //
            // cmbMaterial
            //
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(120, 25);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(412, 28);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.CmbMaterial_SelectedIndexChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.MinimumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cmbSpec
            //
            this.cmbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(120, 55);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(412, 28);
            this.cmbSpec.TabIndex = 1;
            this.cmbSpec.SelectedIndexChanged += new System.EventHandler(this.CmbSpec_SelectedIndexChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.MinimumSize = new System.Drawing.Size(90, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spec:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cmbGrade
            //
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(120, 85);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(412, 28);
            this.cmbGrade.TabIndex = 2;
            this.cmbGrade.SelectedIndexChanged += new System.EventHandler(this.CmbGrade_SelectedIndexChanged);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.MinimumSize = new System.Drawing.Size(90, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cmbQualityFactor
            //
            this.cmbQualityFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualityFactor.FormattingEnabled = true;
            this.cmbQualityFactor.Location = new System.Drawing.Point(188, 25);
            this.cmbQualityFactor.Name = "cmbQualityFactor";
            this.cmbQualityFactor.Size = new System.Drawing.Size(344, 28);
            this.cmbQualityFactor.TabIndex = 0;
            this.cmbQualityFactor.SelectedIndexChanged += new System.EventHandler(this.CmbMaterial_SelectedIndexChanged);
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.MinimumSize = new System.Drawing.Size(90, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "(E) Quality Factor:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label7, "ASME B31.3 Table A-2/3");
            //
            // labelWeldJointFactor
            //
            this.labelWeldJointFactor.AutoSize = true;
            this.labelWeldJointFactor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeldJointFactor.Location = new System.Drawing.Point(15, 58);
            this.labelWeldJointFactor.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelWeldJointFactor.Name = "labelWeldJointFactor";
            this.labelWeldJointFactor.Size = new System.Drawing.Size(146, 21);
            this.labelWeldJointFactor.TabIndex = 16;
            this.labelWeldJointFactor.Text = "(W) Weld Factor:";
            this.labelWeldJointFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelWeldJointFactor, "ASME B31.3 Table 302.3.5-1");
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 88);
            this.label9.MinimumSize = new System.Drawing.Size(90, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "(Y) Coefficient:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label9, "ASME B31.3 Table 304.1.1");
            //
            // groupBoxDimensions
            //
            this.groupBoxDimensions.Controls.Add(this.txtOuterDiameter);
            this.groupBoxDimensions.Controls.Add(this.cmbNPS);
            this.groupBoxDimensions.Controls.Add(this.label4);
            this.groupBoxDimensions.Controls.Add(this.lblOD);
            this.groupBoxDimensions.Location = new System.Drawing.Point(10, 150);
            this.groupBoxDimensions.Name = "groupBoxDimensions";
            this.groupBoxDimensions.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxDimensions.Size = new System.Drawing.Size(545, 90);
            this.groupBoxDimensions.TabIndex = 1;
            this.groupBoxDimensions.TabStop = false;
            this.groupBoxDimensions.Text = "Pipe Dimensions";
            //
            // txtOuterDiameter
            //
            this.txtOuterDiameter.Location = new System.Drawing.Point(234, 51);
            this.txtOuterDiameter.Name = "txtOuterDiameter";
            this.txtOuterDiameter.ReadOnly = true;
            this.txtOuterDiameter.Size = new System.Drawing.Size(166, 26);
            this.txtOuterDiameter.TabIndex = 9;
            //
            // cmbNPS
            //
            this.cmbNPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPS.FormattingEnabled = true;
            this.cmbNPS.Location = new System.Drawing.Point(234, 21);
            this.cmbNPS.Name = "cmbNPS";
            this.cmbNPS.Size = new System.Drawing.Size(166, 28);
            this.cmbNPS.TabIndex = 3;
            this.cmbNPS.SelectedIndexChanged += new System.EventHandler(this.CmbNPS_SelectedIndexChanged);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.MinimumSize = new System.Drawing.Size(90, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "NPS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblOD
            //
            this.lblOD.AutoSize = true;
            this.lblOD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOD.Location = new System.Drawing.Point(15, 58);
            this.lblOD.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(167, 21);
            this.lblOD.TabIndex = 8;
            this.lblOD.Text = "Outer Diameter (D):";
            this.lblOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // groupBoxConditions
            //
            this.groupBoxConditions.Controls.Add(this.txtBarlowThicknessResult);
            this.groupBoxConditions.Controls.Add(this.lblBarlowThickness);
            this.groupBoxConditions.Controls.Add(this.txtMinThicknessResult);
            this.groupBoxConditions.Controls.Add(this.labelMinThickness);
            this.groupBoxConditions.Controls.Add(this.txtStressValue);
            this.groupBoxConditions.Controls.Add(this.label10);
            this.groupBoxConditions.Controls.Add(this.txtPressure);
            this.groupBoxConditions.Controls.Add(this.label5);
            this.groupBoxConditions.Controls.Add(this.txtTemperature);
            this.groupBoxConditions.Controls.Add(this.label6);
            this.groupBoxConditions.Location = new System.Drawing.Point(10, 250);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxConditions.Size = new System.Drawing.Size(545, 190);
            this.groupBoxConditions.TabIndex = 2;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Text = "Design Conditions";
            //
            // txtBarlowThicknessResult
            //
            this.txtBarlowThicknessResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBarlowThicknessResult.Location = new System.Drawing.Point(234, 153);
            this.txtBarlowThicknessResult.Name = "txtBarlowThicknessResult";
            this.txtBarlowThicknessResult.ReadOnly = true;
            this.txtBarlowThicknessResult.Size = new System.Drawing.Size(166, 26);
            this.txtBarlowThicknessResult.TabIndex = 16;
            //
            // lblBarlowThickness
            //
            this.lblBarlowThickness.AutoSize = true;
            this.lblBarlowThickness.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarlowThickness.Location = new System.Drawing.Point(15, 158);
            this.lblBarlowThickness.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblBarlowThickness.Name = "lblBarlowThickness";
            this.lblBarlowThickness.Size = new System.Drawing.Size(145, 21);
            this.lblBarlowThickness.TabIndex = 15;
            this.lblBarlowThickness.Text = "Barlow t-min (in):";
            this.lblBarlowThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtMinThicknessResult
            //
            this.txtMinThicknessResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMinThicknessResult.Location = new System.Drawing.Point(234, 123);
            this.txtMinThicknessResult.Name = "txtMinThicknessResult";
            this.txtMinThicknessResult.ReadOnly = true;
            this.txtMinThicknessResult.Size = new System.Drawing.Size(166, 26);
            this.txtMinThicknessResult.TabIndex = 14;
            //
            // labelMinThickness
            //
            this.labelMinThickness.AutoSize = true;
            this.labelMinThickness.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinThickness.Location = new System.Drawing.Point(15, 128);
            this.labelMinThickness.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelMinThickness.Name = "labelMinThickness";
            this.labelMinThickness.Size = new System.Drawing.Size(137, 21);
            this.labelMinThickness.TabIndex = 13;
            this.labelMinThickness.Text = "B31.3 t-min (in):";
            this.labelMinThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtStressValue
            //
            this.txtStressValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStressValue.Location = new System.Drawing.Point(234, 93);
            this.txtStressValue.Name = "txtStressValue";
            this.txtStressValue.ReadOnly = true;
            this.txtStressValue.Size = new System.Drawing.Size(166, 26);
            this.txtStressValue.TabIndex = 6;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 98);
            this.label10.MinimumSize = new System.Drawing.Size(90, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 21);
            this.label10.TabIndex = 12;
            this.label10.Text = "(S) Stress (psi):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtPressure
            //
            this.txtPressure.Location = new System.Drawing.Point(234, 63);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(166, 26);
            this.txtPressure.TabIndex = 5;
            this.txtPressure.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumericInput);
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.MinimumSize = new System.Drawing.Size(90, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "(P) Pressure (psi):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // txtTemperature
            //
            this.txtTemperature.Location = new System.Drawing.Point(234, 33);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(166, 26);
            this.txtTemperature.TabIndex = 4;
            this.txtTemperature.TextChanged += new System.EventHandler(this.TxtTemperature_TextChanged);
            this.txtTemperature.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumericInput);
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.MinimumSize = new System.Drawing.Size(90, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temperature (°F):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // groupBoxFactors
            //
            this.groupBoxFactors.Controls.Add(this.txtWeldJointFactor);
            this.groupBoxFactors.Controls.Add(this.cmbQualityFactor);
            this.groupBoxFactors.Controls.Add(this.label7);
            this.groupBoxFactors.Controls.Add(this.labelWeldJointFactor);
            this.groupBoxFactors.Controls.Add(this.txtYCoefficient);
            this.groupBoxFactors.Controls.Add(this.label9);
            this.groupBoxFactors.Location = new System.Drawing.Point(10, 450);
            this.groupBoxFactors.Name = "groupBoxFactors";
            this.groupBoxFactors.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxFactors.Size = new System.Drawing.Size(545, 150);
            this.groupBoxFactors.TabIndex = 3;
            this.groupBoxFactors.TabStop = false;
            this.groupBoxFactors.Text = "Calculation Factors";
            //
            // txtWeldJointFactor
            //
            this.txtWeldJointFactor.Location = new System.Drawing.Point(188, 56);
            this.txtWeldJointFactor.Name = "txtWeldJointFactor";
            this.txtWeldJointFactor.Size = new System.Drawing.Size(76, 26);
            this.txtWeldJointFactor.TabIndex = 20;
            this.txtWeldJointFactor.Visible = true;
            //
            // txtYCoefficient
            //
            this.txtYCoefficient.Location = new System.Drawing.Point(188, 86);
            this.txtYCoefficient.Name = "txtYCoefficient";
            this.txtYCoefficient.Size = new System.Drawing.Size(76, 26);
            this.txtYCoefficient.TabIndex = 9;
            this.txtYCoefficient.Text = "0.4";
            this.txtYCoefficient.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateNumericInput);
            //
            // panelInputs
            //
            this.panelInputs.Controls.Add(this.groupBoxMaterial);
            this.panelInputs.Controls.Add(this.groupBoxDimensions);
            this.panelInputs.Controls.Add(this.groupBoxConditions);
            this.panelInputs.Controls.Add(this.groupBoxFactors);
            this.panelInputs.Controls.Add(this.groupBoxDisclaimer);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputs.Location = new System.Drawing.Point(0, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(575, 823);
            this.panelInputs.TabIndex = 0;
            //
            // groupBoxDisclaimer
            //
            this.groupBoxDisclaimer.Controls.Add(this.txtDisclaimer);
            this.groupBoxDisclaimer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDisclaimer.Location = new System.Drawing.Point(10, 610);
            this.groupBoxDisclaimer.Name = "groupBoxDisclaimer";
            this.groupBoxDisclaimer.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxDisclaimer.Size = new System.Drawing.Size(545, 206);
            this.groupBoxDisclaimer.TabIndex = 4;
            this.groupBoxDisclaimer.TabStop = false;
            this.groupBoxDisclaimer.Text = "Disclaimer";
            //
            // txtDisclaimer
            //
            this.txtDisclaimer.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisclaimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDisclaimer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisclaimer.Location = new System.Drawing.Point(10, 31);
            this.txtDisclaimer.Margin = new System.Windows.Forms.Padding(10);
            this.txtDisclaimer.Multiline = true;
            this.txtDisclaimer.Name = "txtDisclaimer";
            this.txtDisclaimer.ReadOnly = true;
            this.txtDisclaimer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisclaimer.Size = new System.Drawing.Size(525, 165);
            this.txtDisclaimer.TabIndex = 0;
            this.txtDisclaimer.Text = resources.GetString("txtDisclaimer.Text");
            //
            // panelButtons
            //
            this.panelButtons.Controls.Add(this.btnReset);
            this.panelButtons.Controls.Add(this.btnCalculate);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(575, 669);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(615, 154);
            this.panelButtons.TabIndex = 1;
            //
            // btnReset
            //
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(70, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 69);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            //
            // btnCalculate
            //
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(193, 58);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(246, 69);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            //
            // btnCancel
            //
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(445, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 69);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            //
            // panelResults
            //
            this.panelResults.Controls.Add(this.dgvResults);
            this.panelResults.Controls.Add(this.groupBoxResultFormulas);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.Location = new System.Drawing.Point(575, 0);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(615, 669);
            this.panelResults.TabIndex = 2;
            //
            // dgvResults
            //
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNPS,
            this.colOD,
            this.colThickness,
            this.colBarlowThickness});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 120);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(615, 549);
            this.dgvResults.TabIndex = 0;
            //
            // colNPS
            //
            this.colNPS.HeaderText = "NPS";
            this.colNPS.MinimumWidth = 8;
            this.colNPS.Name = "colNPS";
            //
            // colOD
            //
            this.colOD.HeaderText = "OD (in)";
            this.colOD.MinimumWidth = 8;
            this.colOD.Name = "colOD";
            //
            // colThickness
            //
            this.colThickness.HeaderText = "B31.3 t-min (in)";
            this.colThickness.MinimumWidth = 8;
            this.colThickness.Name = "colThickness";
            //
            // colBarlowThickness
            //
            this.colBarlowThickness.HeaderText = "Barlow t-min (in)";
            this.colBarlowThickness.MinimumWidth = 8;
            this.colBarlowThickness.Name = "colBarlowThickness";
            //
            // groupBoxResultFormulas
            //
            this.groupBoxResultFormulas.Controls.Add(this.lblBarlowFormula);
            this.groupBoxResultFormulas.Controls.Add(this.lblB313Formula);
            this.groupBoxResultFormulas.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxResultFormulas.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResultFormulas.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResultFormulas.Name = "groupBoxResultFormulas";
            this.groupBoxResultFormulas.Size = new System.Drawing.Size(615, 120);
            this.groupBoxResultFormulas.TabIndex = 1;
            this.groupBoxResultFormulas.TabStop = false;
            this.groupBoxResultFormulas.Text = "Calculation Formulas";
            //
            // lblBarlowFormula
            //
            this.lblBarlowFormula.AutoSize = true;
            this.lblBarlowFormula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarlowFormula.Location = new System.Drawing.Point(15, 70);
            this.lblBarlowFormula.Name = "lblBarlowFormula";
            this.lblBarlowFormula.Size = new System.Drawing.Size(235, 27);
            this.lblBarlowFormula.TabIndex = 1;
            this.lblBarlowFormula.Text = "Barlow: t = ​​PD/(2SE)";
            //
            // lblB313Formula
            //
            this.lblB313Formula.AutoSize = true;
            this.lblB313Formula.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB313Formula.Location = new System.Drawing.Point(15, 30);
            this.lblB313Formula.Name = "lblB313Formula";
            this.lblB313Formula.Size = new System.Drawing.Size(396, 27);
            this.lblB313Formula.TabIndex = 0;
            this.lblB313Formula.Text = "ASME B31.3: t = ​​PD/(2(SEW + PY))";
            //
            // B31_3PipeCalculator
            //
            this.AcceptButton = this.btnCalculate;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1190, 823);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInputs);
            this.MinimumSize = new System.Drawing.Size(916, 659);
            this.Name = "B31_3PipeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASME B31.3 Pipe Thickness Calculator";
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxDimensions.ResumeLayout(false);
            this.groupBoxDimensions.PerformLayout();
            this.groupBoxConditions.ResumeLayout(false);
            this.groupBoxConditions.PerformLayout();
            this.groupBoxFactors.ResumeLayout(false);
            this.groupBoxFactors.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.groupBoxDisclaimer.ResumeLayout(false);
            this.groupBoxDisclaimer.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBoxResultFormulas.ResumeLayout(false);
            this.groupBoxResultFormulas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.ComboBox cmbQualityFactor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWeldJointFactor;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWeldJointFactor;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDimensions;
        private System.Windows.Forms.TextBox txtOuterDiameter;
        private System.Windows.Forms.ComboBox cmbNPS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.GroupBox groupBoxConditions;
        private System.Windows.Forms.TextBox txtBarlowThicknessResult;
        private System.Windows.Forms.Label lblBarlowThickness;
        private System.Windows.Forms.TextBox txtMinThicknessResult;
        private System.Windows.Forms.Label labelMinThickness;
        private System.Windows.Forms.TextBox txtStressValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxFactors;
        private System.Windows.Forms.TextBox txtYCoefficient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.GroupBox groupBoxResultFormulas;
        private System.Windows.Forms.Label lblB313Formula;
        private System.Windows.Forms.Label lblBarlowFormula;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarlowThickness;
        private System.Windows.Forms.GroupBox groupBoxDisclaimer;
        private System.Windows.Forms.TextBox txtDisclaimer;
    }
}
