using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class HTHACheckerForm : Form
    {
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblH2Pressure;
        private System.Windows.Forms.TextBox txtH2Pressure;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDisclaimer;

        private void InitializeComponent()
        {
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblH2Pressure = new System.Windows.Forms.Label();
            this.txtH2Pressure = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblMaterial
            //
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(20, 20);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material:";
            //
            // cboMaterial
            //
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(120, 17);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(200, 28);
            this.cboMaterial.TabIndex = 1;
            //
            // lblDisclaimer
            //
            this.lblDisclaimer.Location = new System.Drawing.Point(0, 0);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(100, 23);
            this.lblDisclaimer.TabIndex = 0;
            //
            // lblTemperature
            //
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(20, 50);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(104, 20);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Temperature:";
            //
            // txtTemperature
            //
            this.txtTemperature.Location = new System.Drawing.Point(167, 47);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtTemperature.TabIndex = 3;
            //
            // lblH2Pressure
            //
            this.lblH2Pressure.AutoSize = true;
            this.lblH2Pressure.Location = new System.Drawing.Point(20, 80);
            this.lblH2Pressure.Name = "lblH2Pressure";
            this.lblH2Pressure.Size = new System.Drawing.Size(140, 20);
            this.lblH2Pressure.TabIndex = 4;
            this.lblH2Pressure.Text = "H₂ Pressure (psia):";
            //
            // txtH2Pressure
            //
            this.txtH2Pressure.Location = new System.Drawing.Point(167, 74);
            this.txtH2Pressure.Name = "txtH2Pressure";
            this.txtH2Pressure.Size = new System.Drawing.Size(100, 26);
            this.txtH2Pressure.TabIndex = 5;
            //
            // btnCheck
            //
            this.btnCheck.Location = new System.Drawing.Point(120, 110);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 30);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check HTHA Risk";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            //
            // lblResult
            //
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(20, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(300, 232);
            this.lblResult.TabIndex = 7;
            //
            // HTHACheckerForm
            //
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtH2Pressure);
            this.Controls.Add(this.lblH2Pressure);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Name = "HTHACheckerForm";
            this.Text = "HTHA Checker (API 941)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
