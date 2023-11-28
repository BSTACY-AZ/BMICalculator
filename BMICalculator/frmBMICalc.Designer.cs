namespace BMICalcualtor
{
    partial class frmBMICalc
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
            this.rbImperial = new System.Windows.Forms.RadioButton();
            this.rbMetric = new System.Windows.Forms.RadioButton();
            this.gbMeasurementType = new System.Windows.Forms.GroupBox();
            this.txtMajorUnit = new System.Windows.Forms.TextBox();
            this.txtMinorUnit = new System.Windows.Forms.TextBox();
            this.lblMajorUnit = new System.Windows.Forms.Label();
            this.lblMinorUnit = new System.Windows.Forms.Label();
            this.lblEnterHeight = new System.Windows.Forms.Label();
            this.lblEnterWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.gbMeasurementType.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbImperial
            // 
            this.rbImperial.AutoSize = true;
            this.rbImperial.Checked = true;
            this.rbImperial.Location = new System.Drawing.Point(31, 39);
            this.rbImperial.Name = "rbImperial";
            this.rbImperial.Size = new System.Drawing.Size(61, 17);
            this.rbImperial.TabIndex = 0;
            this.rbImperial.TabStop = true;
            this.rbImperial.Text = "Imperial";
            this.rbImperial.UseVisualStyleBackColor = true;
            this.rbImperial.CheckedChanged += new System.EventHandler(this.rbImperial_CheckedChanged);
            // 
            // rbMetric
            // 
            this.rbMetric.AutoSize = true;
            this.rbMetric.Location = new System.Drawing.Point(145, 39);
            this.rbMetric.Name = "rbMetric";
            this.rbMetric.Size = new System.Drawing.Size(54, 17);
            this.rbMetric.TabIndex = 1;
            this.rbMetric.Text = "Metric";
            this.rbMetric.UseVisualStyleBackColor = true;
            this.rbMetric.CheckedChanged += new System.EventHandler(this.rbMetric_CheckedChanged);
            // 
            // gbMeasurementType
            // 
            this.gbMeasurementType.Controls.Add(this.rbImperial);
            this.gbMeasurementType.Controls.Add(this.rbMetric);
            this.gbMeasurementType.Location = new System.Drawing.Point(56, 33);
            this.gbMeasurementType.Name = "gbMeasurementType";
            this.gbMeasurementType.Size = new System.Drawing.Size(240, 92);
            this.gbMeasurementType.TabIndex = 2;
            this.gbMeasurementType.TabStop = false;
            this.gbMeasurementType.Text = "1. Choose a measurement type:";
            // 
            // txtMajorUnit
            // 
            this.txtMajorUnit.Location = new System.Drawing.Point(74, 175);
            this.txtMajorUnit.Name = "txtMajorUnit";
            this.txtMajorUnit.Size = new System.Drawing.Size(40, 20);
            this.txtMajorUnit.TabIndex = 3;
            // 
            // txtMinorUnit
            // 
            this.txtMinorUnit.Location = new System.Drawing.Point(181, 175);
            this.txtMinorUnit.Name = "txtMinorUnit";
            this.txtMinorUnit.Size = new System.Drawing.Size(36, 20);
            this.txtMinorUnit.TabIndex = 4;
            // 
            // lblMajorUnit
            // 
            this.lblMajorUnit.AutoSize = true;
            this.lblMajorUnit.Location = new System.Drawing.Point(120, 178);
            this.lblMajorUnit.Name = "lblMajorUnit";
            this.lblMajorUnit.Size = new System.Drawing.Size(28, 13);
            this.lblMajorUnit.TabIndex = 5;
            this.lblMajorUnit.Text = "Feet";
            // 
            // lblMinorUnit
            // 
            this.lblMinorUnit.AutoSize = true;
            this.lblMinorUnit.Location = new System.Drawing.Point(226, 178);
            this.lblMinorUnit.Name = "lblMinorUnit";
            this.lblMinorUnit.Size = new System.Drawing.Size(39, 13);
            this.lblMinorUnit.TabIndex = 6;
            this.lblMinorUnit.Text = "Inches";
            // 
            // lblEnterHeight
            // 
            this.lblEnterHeight.AutoSize = true;
            this.lblEnterHeight.Location = new System.Drawing.Point(67, 145);
            this.lblEnterHeight.Name = "lblEnterHeight";
            this.lblEnterHeight.Size = new System.Drawing.Size(136, 13);
            this.lblEnterHeight.TabIndex = 7;
            this.lblEnterHeight.Text = "2. Please enter your height:";
            // 
            // lblEnterWeight
            // 
            this.lblEnterWeight.AutoSize = true;
            this.lblEnterWeight.Location = new System.Drawing.Point(67, 224);
            this.lblEnterWeight.Name = "lblEnterWeight";
            this.lblEnterWeight.Size = new System.Drawing.Size(138, 13);
            this.lblEnterWeight.TabIndex = 8;
            this.lblEnterWeight.Text = "3. Please enter your weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(74, 259);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(50, 20);
            this.txtWeight.TabIndex = 9;
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Location = new System.Drawing.Point(130, 262);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(43, 13);
            this.lblWeightUnit.TabIndex = 10;
            this.lblWeightUnit.Text = "Pounds";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(133, 307);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(99, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "4. Calculate BMI";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(67, 357);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(229, 84);
            this.lblResults.TabIndex = 12;
            // 
            // frmBMICalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblEnterWeight);
            this.Controls.Add(this.lblEnterHeight);
            this.Controls.Add(this.lblMinorUnit);
            this.Controls.Add(this.lblMajorUnit);
            this.Controls.Add(this.txtMinorUnit);
            this.Controls.Add(this.txtMajorUnit);
            this.Controls.Add(this.gbMeasurementType);
            this.Name = "frmBMICalc";
            this.Text = "BMI Calculator";
            this.gbMeasurementType.ResumeLayout(false);
            this.gbMeasurementType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbImperial;
        private System.Windows.Forms.RadioButton rbMetric;
        private System.Windows.Forms.GroupBox gbMeasurementType;
        private System.Windows.Forms.TextBox txtMajorUnit;
        private System.Windows.Forms.TextBox txtMinorUnit;
        private System.Windows.Forms.Label lblMajorUnit;
        private System.Windows.Forms.Label lblMinorUnit;
        private System.Windows.Forms.Label lblEnterHeight;
        private System.Windows.Forms.Label lblEnterWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResults;
    }
}

