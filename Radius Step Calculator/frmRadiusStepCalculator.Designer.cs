namespace Radius_Step_Calculator
{
    partial class frmRadiusStepCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRadiusStepCalculator));
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtToolRadius = new System.Windows.Forms.TextBox();
            this.lblToolRadius = new System.Windows.Forms.Label();
            this.txtXOffset = new System.Windows.Forms.TextBox();
            this.lblXOffset = new System.Windows.Forms.Label();
            this.txtYOffset = new System.Windows.Forms.TextBox();
            this.lblYOffset = new System.Windows.Forms.Label();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.txtEndAngle = new System.Windows.Forms.TextBox();
            this.lblEndAngle = new System.Windows.Forms.Label();
            this.txtAngleInc = new System.Windows.Forms.TextBox();
            this.lblAngleInc = new System.Windows.Forms.Label();
            this.txtArcLength = new System.Windows.Forms.TextBox();
            this.lblArcLength = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbConvex = new System.Windows.Forms.RadioButton();
            this.rbConcave = new System.Windows.Forms.RadioButton();
            this.pnlConcaveConvex = new System.Windows.Forms.Panel();
            this.chkInc = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblBold = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbConventional = new System.Windows.Forms.RadioButton();
            this.rbClimb = new System.Windows.Forms.RadioButton();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.pnlConcaveConvex.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(117, 144);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 0;
            this.txtRadius.Text = "0.0";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(60, 146);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(50, 16);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius";
            // 
            // txtToolRadius
            // 
            this.txtToolRadius.Location = new System.Drawing.Point(117, 172);
            this.txtToolRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToolRadius.Name = "txtToolRadius";
            this.txtToolRadius.Size = new System.Drawing.Size(100, 22);
            this.txtToolRadius.TabIndex = 2;
            this.txtToolRadius.Text = "0.0";
            // 
            // lblToolRadius
            // 
            this.lblToolRadius.AutoSize = true;
            this.lblToolRadius.Location = new System.Drawing.Point(28, 175);
            this.lblToolRadius.Name = "lblToolRadius";
            this.lblToolRadius.Size = new System.Drawing.Size(81, 16);
            this.lblToolRadius.TabIndex = 3;
            this.lblToolRadius.Text = "Tool Radius";
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(117, 229);
            this.txtXOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(100, 22);
            this.txtXOffset.TabIndex = 4;
            this.txtXOffset.Text = "0.0";
            // 
            // lblXOffset
            // 
            this.lblXOffset.AutoSize = true;
            this.lblXOffset.Location = new System.Drawing.Point(7, 231);
            this.lblXOffset.Name = "lblXOffset";
            this.lblXOffset.Size = new System.Drawing.Size(94, 16);
            this.lblXOffset.TabIndex = 5;
            this.lblXOffset.Text = "Center X Offset";
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(117, 257);
            this.txtYOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(100, 22);
            this.txtYOffset.TabIndex = 6;
            this.txtYOffset.Text = "0.0";
            // 
            // lblYOffset
            // 
            this.lblYOffset.AutoSize = true;
            this.lblYOffset.Location = new System.Drawing.Point(7, 260);
            this.lblYOffset.Name = "lblYOffset";
            this.lblYOffset.Size = new System.Drawing.Size(95, 16);
            this.lblYOffset.TabIndex = 7;
            this.lblYOffset.Text = "Center Y Offset";
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(117, 310);
            this.txtStartAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(100, 22);
            this.txtStartAngle.TabIndex = 8;
            this.txtStartAngle.Text = "0.0";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(35, 313);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(72, 16);
            this.lblStartAngle.TabIndex = 9;
            this.lblStartAngle.Text = "Start Angle";
            // 
            // txtEndAngle
            // 
            this.txtEndAngle.Location = new System.Drawing.Point(117, 338);
            this.txtEndAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndAngle.Name = "txtEndAngle";
            this.txtEndAngle.Size = new System.Drawing.Size(100, 22);
            this.txtEndAngle.TabIndex = 10;
            this.txtEndAngle.Text = "360.0";
            // 
            // lblEndAngle
            // 
            this.lblEndAngle.AutoSize = true;
            this.lblEndAngle.Location = new System.Drawing.Point(39, 341);
            this.lblEndAngle.Name = "lblEndAngle";
            this.lblEndAngle.Size = new System.Drawing.Size(69, 16);
            this.lblEndAngle.TabIndex = 11;
            this.lblEndAngle.Text = "End Angle";
            // 
            // txtAngleInc
            // 
            this.txtAngleInc.Location = new System.Drawing.Point(117, 391);
            this.txtAngleInc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngleInc.Name = "txtAngleInc";
            this.txtAngleInc.Size = new System.Drawing.Size(100, 22);
            this.txtAngleInc.TabIndex = 12;
            // 
            // lblAngleInc
            // 
            this.lblAngleInc.AutoSize = true;
            this.lblAngleInc.Location = new System.Drawing.Point(3, 394);
            this.lblAngleInc.Name = "lblAngleInc";
            this.lblAngleInc.Size = new System.Drawing.Size(103, 16);
            this.lblAngleInc.TabIndex = 13;
            this.lblAngleInc.Text = "Angle Increment";
            // 
            // txtArcLength
            // 
            this.txtArcLength.Location = new System.Drawing.Point(117, 454);
            this.txtArcLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArcLength.Name = "txtArcLength";
            this.txtArcLength.Size = new System.Drawing.Size(100, 22);
            this.txtArcLength.TabIndex = 14;
            // 
            // lblArcLength
            // 
            this.lblArcLength.AutoSize = true;
            this.lblArcLength.Location = new System.Drawing.Point(35, 457);
            this.lblArcLength.Name = "lblArcLength";
            this.lblArcLength.Size = new System.Drawing.Size(70, 16);
            this.lblArcLength.TabIndex = 15;
            this.lblArcLength.Text = "Arc Length";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(148, 425);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(35, 16);
            this.lblOR.TabIndex = 16;
            this.lblOR.Text = "-OR-";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(515, 414);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 46);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbConvex
            // 
            this.rbConvex.AutoSize = true;
            this.rbConvex.Location = new System.Drawing.Point(7, 2);
            this.rbConvex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbConvex.Name = "rbConvex";
            this.rbConvex.Size = new System.Drawing.Size(73, 20);
            this.rbConvex.TabIndex = 0;
            this.rbConvex.TabStop = true;
            this.rbConvex.Text = "Convex";
            this.rbConvex.UseVisualStyleBackColor = true;
            // 
            // rbConcave
            // 
            this.rbConcave.AutoSize = true;
            this.rbConcave.Location = new System.Drawing.Point(7, 30);
            this.rbConcave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbConcave.Name = "rbConcave";
            this.rbConcave.Size = new System.Drawing.Size(82, 20);
            this.rbConcave.TabIndex = 1;
            this.rbConcave.TabStop = true;
            this.rbConcave.Text = "Concave";
            this.rbConcave.UseVisualStyleBackColor = true;
            // 
            // pnlConcaveConvex
            // 
            this.pnlConcaveConvex.Controls.Add(this.rbConvex);
            this.pnlConcaveConvex.Controls.Add(this.rbConcave);
            this.pnlConcaveConvex.Location = new System.Drawing.Point(57, 7);
            this.pnlConcaveConvex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlConcaveConvex.Name = "pnlConcaveConvex";
            this.pnlConcaveConvex.Size = new System.Drawing.Size(161, 57);
            this.pnlConcaveConvex.TabIndex = 20;
            // 
            // chkInc
            // 
            this.chkInc.AutoSize = true;
            this.chkInc.Location = new System.Drawing.Point(251, 402);
            this.chkInc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInc.Name = "chkInc";
            this.chkInc.Size = new System.Drawing.Size(98, 20);
            this.chkInc.TabIndex = 21;
            this.chkInc.Text = "Incremental";
            this.chkInc.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(251, 30);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtOutput.Size = new System.Drawing.Size(453, 367);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.Text = "";
            // 
            // lblBold
            // 
            this.lblBold.AutoSize = true;
            this.lblBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBold.Location = new System.Drawing.Point(403, 9);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(160, 16);
            this.lblBold.TabIndex = 23;
            this.lblBold.Text = "Move BOLD Axis First!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbConventional);
            this.panel1.Controls.Add(this.rbClimb);
            this.panel1.Location = new System.Drawing.Point(57, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 57);
            this.panel1.TabIndex = 24;
            // 
            // rbConventional
            // 
            this.rbConventional.AutoSize = true;
            this.rbConventional.Location = new System.Drawing.Point(7, 32);
            this.rbConventional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbConventional.Name = "rbConventional";
            this.rbConventional.Size = new System.Drawing.Size(129, 20);
            this.rbConventional.TabIndex = 1;
            this.rbConventional.TabStop = true;
            this.rbConventional.Text = "Conventional Mill";
            this.rbConventional.UseVisualStyleBackColor = true;
            // 
            // rbClimb
            // 
            this.rbClimb.AutoSize = true;
            this.rbClimb.Location = new System.Drawing.Point(7, 6);
            this.rbClimb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbClimb.Name = "rbClimb";
            this.rbClimb.Size = new System.Drawing.Size(85, 20);
            this.rbClimb.TabIndex = 0;
            this.rbClimb.TabStop = true;
            this.rbClimb.Text = "Climb Mill";
            this.rbClimb.UseVisualStyleBackColor = true;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(355, 437);
            this.txtFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormat.MaxLength = 7;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(77, 22);
            this.txtFormat.TabIndex = 25;
            this.txtFormat.Text = "0.000";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(247, 441);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(102, 16);
            this.lblFormat.TabIndex = 26;
            this.lblFormat.Text = "Decimal Format";
            // 
            // frmRadiusStepCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBold);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.chkInc);
            this.Controls.Add(this.pnlConcaveConvex);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.lblArcLength);
            this.Controls.Add(this.txtArcLength);
            this.Controls.Add(this.lblAngleInc);
            this.Controls.Add(this.txtAngleInc);
            this.Controls.Add(this.lblEndAngle);
            this.Controls.Add(this.txtEndAngle);
            this.Controls.Add(this.lblStartAngle);
            this.Controls.Add(this.txtStartAngle);
            this.Controls.Add(this.lblYOffset);
            this.Controls.Add(this.txtYOffset);
            this.Controls.Add(this.lblXOffset);
            this.Controls.Add(this.txtXOffset);
            this.Controls.Add(this.lblToolRadius);
            this.Controls.Add(this.txtToolRadius);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRadiusStepCalculator";
            this.Text = "Radius Step Calculator v1.27";
            this.pnlConcaveConvex.ResumeLayout(false);
            this.pnlConcaveConvex.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtToolRadius;
        private System.Windows.Forms.Label lblToolRadius;
        private System.Windows.Forms.TextBox txtXOffset;
        private System.Windows.Forms.Label lblXOffset;
        private System.Windows.Forms.TextBox txtYOffset;
        private System.Windows.Forms.Label lblYOffset;
        private System.Windows.Forms.TextBox txtStartAngle;
        private System.Windows.Forms.Label lblStartAngle;
        private System.Windows.Forms.TextBox txtEndAngle;
        private System.Windows.Forms.Label lblEndAngle;
        private System.Windows.Forms.TextBox txtAngleInc;
        private System.Windows.Forms.Label lblAngleInc;
        private System.Windows.Forms.TextBox txtArcLength;
        private System.Windows.Forms.Label lblArcLength;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbConvex;
        private System.Windows.Forms.RadioButton rbConcave;
        private System.Windows.Forms.Panel pnlConcaveConvex;
        private System.Windows.Forms.CheckBox chkInc;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbConventional;
        private System.Windows.Forms.RadioButton rbClimb;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFormat;
    }
}

