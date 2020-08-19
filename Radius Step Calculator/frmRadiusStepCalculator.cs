using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radius_Step_Calculator
{
    public partial class frmRadiusStepCalculator : Form
    {
        public frmRadiusStepCalculator()
        {
            InitializeComponent();
            rbConcave.Checked = true;
            txtOutput.SelectionTabs = new int[] { 150 };
            chkInc.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double radius;
            double toolradius;
            double centerxoffset;
            double centeryoffset;
            double startangle;
            double endangle;
            double angleinc=0.0;
            double arclength;
            double a;
            double radians;
            double x;
            double y;
            double lastx=0.0;
            double lasty=0.0;
            int d;

            StringBuilder text = new StringBuilder();
            text.Append(@"{\rtf1\ansi ");

            try
            {
                radius = Convert.ToDouble(txtRadius.Text);
                toolradius = Convert.ToDouble(txtToolRadius.Text);
                if (radius == 0.0) return;

                centerxoffset = Convert.ToDouble(txtXOffset.Text);
                centeryoffset = Convert.ToDouble(txtYOffset.Text);

                startangle = Convert.ToDouble(txtStartAngle.Text);
                endangle = Convert.ToDouble(txtEndAngle.Text);
                if (txtAngleInc.Text != String.Empty) angleinc = Convert.ToDouble(txtAngleInc.Text);
                if (txtArcLength.Text != String.Empty)
                {
                    arclength = Convert.ToDouble(txtArcLength.Text);
                    angleinc = (180.0 * arclength) / (Math.PI * radius);
                    txtAngleInc.Text = angleinc.ToString();
                }

                if (rbConcave.Checked == true)
                    radius -= toolradius;
                else
                    radius += toolradius;
            }
            catch { return; }

            txtOutput.Text = String.Empty;

            startangle = (-startangle + 90.0) % 360.0;
            endangle = (-endangle + 90.0) % 360.0;

            for (a = startangle; a >= endangle; a -= angleinc)
            {
                radians = Math.PI / 180.0 * a;

                x = radius * Math.Cos(radians);
                y = radius * Math.Sin(radians);

                d = CheckXYDirection(a, rbConcave.Checked);

                if (chkInc.Checked == true)
                {
                    if (lastx == 0.0 && lasty == 0.0)
                        text.Append(@"\b Start X = " + String.Format("{0:0.0000}", x + centerxoffset) + @"\tab Start Y = " + String.Format("{0:0.0000}", y + centeryoffset) + @"\b0");
                    else
                    {
                        if (d == 0)
                            text.Append(@"\b X = " + String.Format("{0:0.0000}", x - lastx) + @"\b0\tab Y = " + String.Format("{0:0.0000}", y - lasty));
                        else
                            text.Append(@" X = " + String.Format("{0:0.0000}", x - lastx) + @"\tab\b Y = " + String.Format("{0:0.0000}", y - lasty) + @"\b0");
                    }
                }
                else
                {
                    if (d==0)
                        text.Append(@"\b X = " + String.Format("{0:0.0000}", x + centerxoffset) + @"\b0\tab Y = " + String.Format("{0:0.0000}", y + centeryoffset));
                    else
                        text.Append(@"X = " + String.Format("{0:0.0000}", x + centerxoffset) + @"\tab\b Y = " + String.Format("{0:0.0000}", y + centeryoffset) + @"\b0");
                }

                text.Append(@"\line \line ");

                lastx = x;
                lasty = y;
            }

            text.Append(@"}");
            txtOutput.Rtf = text.ToString();
        }

        private int CheckXYDirection(double angle, bool cc)
        {
            int d = 0;

            angle = Math.Abs(angle - 90.0);

            if (angle > 0 && angle <= 90) d = 1;
            if (angle > 90 && angle <= 180) d = 0;
            if (angle > 180 && angle <= 270) d = 1;
            if (angle > 270 && angle <= 360) d = 0;

            if (!cc) d = 1 - d;

            return d;
        }
    }
}
