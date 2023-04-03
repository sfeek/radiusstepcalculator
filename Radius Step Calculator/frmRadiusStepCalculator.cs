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
            rbConventional.Checked = true;
            txtOutput.SelectionTabs = new int[] { 100 };
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
            double angleinc = 0.0;
            double arclength;
            double a;
            double radians;
            double x;
            double y;
            int linecount = 0;
            double lastx = 0.0;
            double lasty = 0.0;
            int d;
            bool cw = true;
            string nfmt = "{0:0.0000}";

            StringBuilder text = new StringBuilder();
            txtOutput.Rtf = String.Empty;
            text.Append(@"{\rtf1\ansi ");

            try
            {
                radius = Convert.ToDouble(txtRadius.Text);
                
                if (radius <= 0.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Radius must be > 0!}";
                    return;
                }

                toolradius = Convert.ToDouble(txtToolRadius.Text);
                if (toolradius < 0.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Tool Radius must be >= 0!}";
                    return;
                }

                if (rbConcave.Checked == true && toolradius >= radius) 
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Radius must be > Tool Radius for Concave Radii!}";
                    return;
                }

                centerxoffset = Convert.ToDouble(txtXOffset.Text);
                centeryoffset = Convert.ToDouble(txtYOffset.Text);

                startangle = Convert.ToDouble(txtStartAngle.Text);
                endangle = Convert.ToDouble(txtEndAngle.Text); 

                if (txtAngleInc.Text != String.Empty && txtArcLength.Text != String.Empty)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Can only specify Angle Increment OR Arc Length!}";
                    return;
                }

                if (txtAngleInc.Text != String.Empty)
                {
                    angleinc = Convert.ToDouble(txtAngleInc.Text);

                    if (angleinc < 0.0001)
                    {
                        txtOutput.Rtf = "{\\rtf1\\ansi Angle Increment must be > 0!}";
                        return;
                    }
                }

                if (txtArcLength.Text != String.Empty)
                {
                    arclength = Convert.ToDouble(txtArcLength.Text);
                    angleinc = (180.0 * arclength) / (Math.PI * radius);
                }

                if (rbConcave.Checked == true)
                    radius -= toolradius;
                else
                    radius += toolradius;

                string tmp = txtFormat.Text;
                bool fmtGood = true;
                for (int i = 0; i < tmp.Length; i++)
                {
                    if (tmp[i] != '0' && tmp[i] != '.') fmtGood = false;
                }
                if (!fmtGood)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Decimal Place Format Error!}";
                    return;
                }
                nfmt = "{0:" + txtFormat.Text + "}";
            }
            catch { return; }

            txtOutput.Text = String.Empty;

            startangle = (-startangle + 90.0) % 360.0;
            endangle = (-endangle + 90.0) % 360.0;

            if (rbConcave.Checked == true)
                cw = true;
            else
                cw = false;

            if (rbClimb.Checked == true)
                cw = !cw;

            linecount = 0;

            if (cw == true)
            {
                for (a = startangle; a >= endangle; a -= angleinc)
                {
                    radians = Math.PI / 180.0 * a;

                    d = CheckXYDirectionCW(a);

                    x = radius * Math.Cos(radians);
                    y = radius * Math.Sin(radians);

                    if (chkInc.Checked == true)
                    {
                        if (lastx == 0.0 && lasty == 0.0)
                            text.Append(@"\b Start X = " + String.Format(nfmt, x + centerxoffset) + @"\tab Start Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                        else
                        {
                            if (d == 0)
                                text.Append("#" + System.Convert.ToString(linecount) + @"\tab\b X = " + String.Format(nfmt, x - lastx) + @"\b0\tab Y = " + String.Format(nfmt, y - lasty));
                            else
                                text.Append("#" + System.Convert.ToString(linecount) + @"\tab X = " + String.Format(nfmt, x - lastx) + @"\tab\b Y = " + String.Format(nfmt, y - lasty) + @"\b0");
                        }
                    }
                    else
                    {
                        if (d == 0)
                            text.Append("#" + System.Convert.ToString(linecount) + @"\tab\b X = " + String.Format(nfmt, x + centerxoffset) + @"\b0\tab Y = " + String.Format(nfmt, y + centeryoffset));
                        else
                            text.Append("#" + System.Convert.ToString(linecount) + @"\tab X = " + String.Format(nfmt, x + centerxoffset) + @"\tab\b Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                    }

                    text.Append(@"\line\line");

                    lastx = x;
                    lasty = y;
                    linecount++;
                }
            }
            else
            {
                for (a = endangle; a <= startangle; a += angleinc)
                {
                    radians = Math.PI / 180.0 * a;

                    d = CheckXYDirectionCCW(a);

                    x = radius * Math.Cos(radians);
                    y = radius * Math.Sin(radians);

                    if (chkInc.Checked == true)
                    {
                        if (lastx == 0.0 && lasty == 0.0)
                            text.Append(@"\b Start X = " + String.Format(nfmt, x + centerxoffset) + @"\tab Start Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                        else
                        {
                            if (d == 0)
                                text.Append("#" + System.Convert.ToString(linecount) + @"\tab\b X = " + String.Format(nfmt, x - lastx) + @"\b0\tab Y = " + String.Format(nfmt, y - lasty));
                            else
                                text.Append("#" + System.Convert.ToString(linecount) + @"\tab X = " + String.Format(nfmt, x - lastx) + @"\tab\b Y = " + String.Format(nfmt, y - lasty) + @"\b0");
                        }
                    }
                    else
                    {
                        if (d == 0)
                            text.Append("#" + System.Convert.ToString(linecount) + @"\tab\b X = " + String.Format(nfmt, x + centerxoffset) + @"\b0\tab Y = " + String.Format(nfmt, y + centeryoffset));
                        else
                            text.Append("#" + System.Convert.ToString(linecount) + @"\tab X = " + String.Format(nfmt, x + centerxoffset) + @"\tab\b Y = " + String.Format(nfmt, y + centeryoffset) + @"\b0");
                    }

                    text.Append(@"\line\line");

                    lastx = x;
                    lasty = y;
                    linecount++;
                }
            }
            text.Append(@"}");
            txtOutput.Rtf = text.ToString();
        }

        private int CheckXYDirectionCW(double angle)
        {
            int d = 0;

            angle = Math.Abs(angle - 90.0);

            if (angle > 0 && angle <= 90) d = 1;
            if (angle > 90 && angle <= 180) d = 0;
            if (angle > 180 && angle <= 270) d = 1;
            if (angle > 270 && angle <= 360) d = 0;

            return d;
        }

        private int CheckXYDirectionCCW(double angle)
        {
            int d = 0;

            angle = Math.Abs(angle - 90.0);

            if (angle >= 0 && angle < 90) d = 1;
            if (angle >= 90 && angle < 180) d = 0;
            if (angle >= 180 && angle < 270) d = 1;
            if (angle >= 270 && angle < 360) d = 0;

            return d;
        }
    }
}

