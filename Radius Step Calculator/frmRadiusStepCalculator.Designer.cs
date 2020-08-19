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
            this.pnlConcaveConvex.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(118, 116);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 0;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(60, 119);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(52, 17);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius";
            // 
            // txtToolRadius
            // 
            this.txtToolRadius.Location = new System.Drawing.Point(118, 144);
            this.txtToolRadius.Name = "txtToolRadius";
            this.txtToolRadius.Size = new System.Drawing.Size(100, 22);
            this.txtToolRadius.TabIndex = 2;
            this.txtToolRadius.Text = "0.0";
            // 
            // lblToolRadius
            // 
            this.lblToolRadius.AutoSize = true;
            this.lblToolRadius.Location = new System.Drawing.Point(28, 147);
            this.lblToolRadius.Name = "lblToolRadius";
            this.lblToolRadius.Size = new System.Drawing.Size(84, 17);
            this.lblToolRadius.TabIndex = 3;
            this.lblToolRadius.Text = "Tool Radius";
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(118, 201);
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(100, 22);
            this.txtXOffset.TabIndex = 4;
            this.txtXOffset.Text = "0.0";
            // 
            // lblXOffset
            // 
            this.lblXOffset.AutoSize = true;
            this.lblXOffset.Location = new System.Drawing.Point(7, 204);
            this.lblXOffset.Name = "lblXOffset";
            this.lblXOffset.Size = new System.Drawing.Size(105, 17);
            this.lblXOffset.TabIndex = 5;
            this.lblXOffset.Text = "Center X Offset";
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(118, 229);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(100, 22);
            this.txtYOffset.TabIndex = 6;
            this.txtYOffset.Text = "0.0";
            // 
            // lblYOffset
            // 
            this.lblYOffset.AutoSize = true;
            this.lblYOffset.Location = new System.Drawing.Point(7, 232);
            this.lblYOffset.Name = "lblYOffset";
            this.lblYOffset.Size = new System.Drawing.Size(105, 17);
            this.lblYOffset.TabIndex = 7;
            this.lblYOffset.Text = "Center Y Offset";
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(118, 282);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(100, 22);
            this.txtStartAngle.TabIndex = 8;
            this.txtStartAngle.Text = "0.0";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(34, 285);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(78, 17);
            this.lblStartAngle.TabIndex = 9;
            this.lblStartAngle.Text = "Start Angle";
            // 
            // txtEndAngle
            // 
            this.txtEndAngle.Location = new System.Drawing.Point(118, 310);
            this.txtEndAngle.Name = "txtEndAngle";
            this.txtEndAngle.Size = new System.Drawing.Size(100, 22);
            this.txtEndAngle.TabIndex = 10;
            this.txtEndAngle.Text = "360.0";
            // 
            // lblEndAngle
            // 
            this.lblEndAngle.AutoSize = true;
            this.lblEndAngle.Location = new System.Drawing.Point(39, 313);
            this.lblEndAngle.Name = "lblEndAngle";
            this.lblEndAngle.Size = new System.Drawing.Size(73, 17);
            this.lblEndAngle.TabIndex = 11;
            this.lblEndAngle.Text = "End Angle";
            // 
            // txtAngleInc
            // 
            this.txtAngleInc.Location = new System.Drawing.Point(118, 363);
            this.txtAngleInc.Name = "txtAngleInc";
            this.txtAngleInc.Size = new System.Drawing.Size(100, 22);
            this.txtAngleInc.TabIndex = 12;
            // 
            // lblAngleInc
            // 
            this.lblAngleInc.AutoSize = true;
            this.lblAngleInc.Location = new System.Drawing.Point(2, 366);
            this.lblAngleInc.Name = "lblAngleInc";
            this.lblAngleInc.Size = new System.Drawing.Size(110, 17);
            this.lblAngleInc.TabIndex = 13;
            this.lblAngleInc.Text = "Angle Increment";
            // 
            // txtArcLength
            // 
            this.txtArcLength.Location = new System.Drawing.Point(118, 426);
            this.txtArcLength.Name = "txtArcLength";
            this.txtArcLength.Size = new System.Drawing.Size(100, 22);
            this.txtArcLength.TabIndex = 14;
            // 
            // lblArcLength
            // 
            this.lblArcLength.AutoSize = true;
            this.lblArcLength.Location = new System.Drawing.Point(34, 429);
            this.lblArcLength.Name = "lblArcLength";
            this.lblArcLength.Size = new System.Drawing.Size(77, 17);
            this.lblArcLength.TabIndex = 15;
            this.lblArcLength.Text = "Arc Length";
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(148, 397);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(39, 17);
            this.lblOR.TabIndex = 16;
            this.lblOR.Text = "-OR-";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(397, 414);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 46);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbConvex
            // 
            this.rbConvex.AutoSize = true;
            this.rbConvex.Location = new System.Drawing.Point(22, 3);
            this.rbConvex.Name = "rbConvex";
            this.rbConvex.Size = new System.Drawing.Size(75, 21);
            this.rbConvex.TabIndex = 0;
            this.rbConvex.TabStop = true;
            this.rbConvex.Text = "Convex";
            this.rbConvex.UseVisualStyleBackColor = true;
            // 
            // rbConcave
            // 
            this.rbConcave.AutoSize = true;
            this.rbConcave.Location = new System.Drawing.Point(22, 30);
            this.rbConcave.Name = "rbConcave";
            this.rbConcave.Size = new System.Drawing.Size(84, 21);
            this.rbConcave.TabIndex = 1;
            this.rbConcave.TabStop = true;
            this.rbConcave.Text = "Concave";
            this.rbConcave.UseVisualStyleBackColor = true;
            // 
            // pnlConcaveConvex
            // 
            this.pnlConcaveConvex.Controls.Add(this.rbConvex);
            this.pnlConcaveConvex.Controls.Add(this.rbConcave);
            this.pnlConcaveConvex.Location = new System.Drawing.Point(92, 12);
            this.pnlConcaveConvex.Name = "pnlConcaveConvex";
            this.pnlConcaveConvex.Size = new System.Drawing.Size(126, 56);
            this.pnlConcaveConvex.TabIndex = 20;
            // 
            // chkInc
            // 
            this.chkInc.AutoSize = true;
            this.chkInc.Location = new System.Drawing.Point(120, 74);
            this.chkInc.Name = "chkInc";
            this.chkInc.Size = new System.Drawing.Size(103, 21);
            this.chkInc.TabIndex = 21;
            this.chkInc.Text = "Incremental";
            this.chkInc.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(250, 29);
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
            this.lblBold.Size = new System.Drawing.Size(168, 17);
            this.lblBold.TabIndex = 23;
            this.lblBold.Text = "Move BOLD Axis First!";
            // 
            // frmRadiusStepCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRadiusStepCalculator";
            this.Text = "Radius Step Calculator v1.11";
            this.pnlConcaveConvex.ResumeLayout(false);
            this.pnlConcaveConvex.PerformLayout();
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
    }
}

