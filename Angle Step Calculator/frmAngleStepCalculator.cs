using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angle_Step_Calculator
    {
    public partial class frmAngleStepCalculator : Form
    {
        public frmAngleStepCalculator()
        {
            InitializeComponent();
            rbConventional.Checked = true;
            txtOutput.SelectionTabs = new int[] { 100 };
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double angle;
            double tangle;
            double tradians;
            double toolradius;
            double centerxoffset;
            double centeryoffset;
            double increment;
            double distance;
            int steps;
            int step;
            int selectxy = 0;
            double leftover;
            double qangle;
            double radians;
            double x;
            double y;
            double lastx=0.0;
            double lasty=0.0;
            string nfmt = "{0:0.000}";

            StringBuilder text = new StringBuilder();
            txtOutput.Rtf = String.Empty;
            text.Append(@"{\rtf1\ansi ");

            try
            {
                qangle = Convert.ToDouble(txtAngle.Text) % 360;
                if (qangle < 0) qangle = 360.0 + qangle;
                angle = (-qangle + 90.0) % 360.0;
               
                toolradius = Convert.ToDouble(txtToolRadius.Text);
                if (toolradius < 0.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Tool Radius must be >= 0!}";
                    return;
                }

                distance = Convert.ToDouble(txtDistance.Text);
                if (distance < 0.0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Distance must be >= 0!}";
                    return;
                }

                centerxoffset = Convert.ToDouble(txtXOffset.Text);
                centeryoffset = Convert.ToDouble(txtYOffset.Text);

                increment = Convert.ToDouble(txtIncrement.Text);

                if (increment < 0)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Distance Increment must be >= 0!}";
                    return;
                }

                if (increment >= distance)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Increment must be less than Distance!}";
                    return;
                }

                string tmp = txtFormat.Text;
                bool fmtGood = true;
                for (int i = 0;i < tmp.Length; i++)
                {
                    if (tmp[i] != '0' && tmp[i] != '.' ) fmtGood = false;
                }
                if (!fmtGood)
                {
                    txtOutput.Rtf = "{\\rtf1\\ansi Decimal Place format error!}";
                    return;
                }
                nfmt = "{0:" + txtFormat.Text + "}";
            }
            catch { return; }

            txtOutput.Text = String.Empty;

            steps = System.Convert.ToInt32(Math.Floor(distance / increment));
            leftover = ((distance/increment) - Math.Truncate(distance/increment)) * increment;

            x = 0;
            y = 0;

            radians = Math.PI / 180.0 * angle;

            if (chkReverse.Checked == false)
            {
                x = centerxoffset;
                y = centeryoffset;
                lastx = x;
                lasty = y;
            } 
            else
            {
                x += centerxoffset + distance * Math.Cos(radians);
                y += centeryoffset + distance * Math.Sin(radians);
                lastx = x;
                lasty = y;


                angle = (angle + 180.0) % 360.0;
                radians = Math.PI / 180.0 * angle;
            }

            if (rbConventional.Checked == true) 
            {
                tangle = (angle - 90.0) % 360.0;
                tradians = Math.PI / 180.0 * tangle;

                x += toolradius * Math.Cos(tradians);
                y += toolradius * Math.Sin(tradians);
                lastx = x;
                lasty = y;
            }

            if (rbClimb.Checked == true)
            {
                tangle = (angle + 90.0) % 360.0;
                tradians = Math.PI / 180.0 * tangle;

                x += toolradius * Math.Cos(tradians);
                y += toolradius * Math.Sin(tradians);
                lastx = x;
                lasty = y;
            }

            text.Append(@"\b Start X = " + String.Format(nfmt, x) + @"\tab Start Y = " + String.Format(nfmt, y) + @"\b0 ");
            text.Append(@"\line \line ");

            if (qangle > 0 && qangle <= 90) selectxy = 0;
            if (qangle > 90 && qangle <= 180) selectxy = 1;
            if (qangle > 180 && qangle <= 270) selectxy = 0;
            if (qangle > 270 && qangle <= 360) selectxy = 1;

            if (rbClimb.Checked == true) selectxy = 1 - selectxy;


            for (step=0; step < steps; step++)
            {
                x += increment * Math.Cos(radians);
                y += increment * Math.Sin(radians);

                if (selectxy == 0)
                    if (chkInc.Checked == false)
                        text.Append("#" + System.Convert.ToString(step + 1) + @"\tab\b X = " + String.Format(nfmt, x) + @"\b0\tab Y = " + String.Format(nfmt, y));
                    else
                        text.Append("#" + System.Convert.ToString(step + 1) + @"\tab\b X = " + String.Format(nfmt, x - lastx) + @"\b0\tab Y = " + String.Format(nfmt, y - lasty));
                else
                    if (chkInc.Checked == false)
                        text.Append("# " + System.Convert.ToString(step + 1) + @"\tab X = " + String.Format(nfmt, x) + @"\tab\b Y = " + String.Format(nfmt, y) + @"\b0");
                    else
                        text.Append("# " + System.Convert.ToString(step + 1) + @"\tab X = " + String.Format(nfmt, x - lastx) + @"\tab\b Y = " + String.Format(nfmt, y - lasty) + @"\b0");

                text.Append(@"\line\line");

                lastx = x;
                lasty = y;
            }

            if (leftover > 0.0)
            {
                x += leftover * Math.Cos(radians);
                y += leftover * Math.Sin(radians);

                if (selectxy == 0)
                    if (chkInc.Checked == false)
                        text.Append("#" + System.Convert.ToString(step + 1) + @"\tab\b X = " + String.Format(nfmt, x) + @"\b0\tab Y = " + String.Format(nfmt, y));
                    else
                        text.Append("#" + System.Convert.ToString(step + 1) + @"\tab\b X = " + String.Format(nfmt, x - lastx) + @"\b0\tab Y = " + String.Format(nfmt, y - lasty));
                else
                    if (chkInc.Checked == false)
                        text.Append("# " + System.Convert.ToString(step + 1) + @"\tab X = " + String.Format(nfmt, x) + @"\tab\b Y = " + String.Format(nfmt, y) + @"\b0");
                    else
                        text.Append("# " + System.Convert.ToString(step + 1) + @"\tab X = " + String.Format(nfmt, x - lastx) + @"\tab\b Y = " + String.Format(nfmt, y - lasty) + @"\b0");


                text.Append(@"\line\line");
            }


            text.Append(@"}");
            txtOutput.Rtf = text.ToString();
        }
    }
}
