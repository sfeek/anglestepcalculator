﻿namespace Angle_Step_Calculator
{
    partial class frmAngleStepCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAngleStepCalculator));
            this.txtToolRadius = new System.Windows.Forms.TextBox();
            this.lblToolRadius = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblBold = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCentered = new System.Windows.Forms.RadioButton();
            this.rbConventional = new System.Windows.Forms.RadioButton();
            this.rbClimb = new System.Windows.Forms.RadioButton();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.txtXOffset = new System.Windows.Forms.TextBox();
            this.lblXOffset = new System.Windows.Forms.Label();
            this.txtYOffset = new System.Windows.Forms.TextBox();
            this.lblYOffset = new System.Windows.Forms.Label();
            this.txtIncrement = new System.Windows.Forms.TextBox();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.chkInc = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lblToolRadius.Location = new System.Drawing.Point(32, 176);
            this.lblToolRadius.Name = "lblToolRadius";
            this.lblToolRadius.Size = new System.Drawing.Size(81, 16);
            this.lblToolRadius.TabIndex = 3;
            this.lblToolRadius.Text = "Tool Radius";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(487, 414);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 46);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(251, 30);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtOutput.Size = new System.Drawing.Size(453, 367);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.TabStop = false;
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
            this.panel1.Controls.Add(this.rbCentered);
            this.panel1.Controls.Add(this.rbConventional);
            this.panel1.Controls.Add(this.rbClimb);
            this.panel1.Location = new System.Drawing.Point(57, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 82);
            this.panel1.TabIndex = 24;
            // 
            // rbCentered
            // 
            this.rbCentered.AutoSize = true;
            this.rbCentered.Location = new System.Drawing.Point(7, 57);
            this.rbCentered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCentered.Name = "rbCentered";
            this.rbCentered.Size = new System.Drawing.Size(83, 20);
            this.rbCentered.TabIndex = 2;
            this.rbCentered.Text = "Centered";
            this.rbCentered.UseVisualStyleBackColor = true;
            // 
            // rbConventional
            // 
            this.rbConventional.AutoSize = true;
            this.rbConventional.Location = new System.Drawing.Point(7, 32);
            this.rbConventional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbConventional.Name = "rbConventional";
            this.rbConventional.Size = new System.Drawing.Size(129, 20);
            this.rbConventional.TabIndex = 1;
            this.rbConventional.Text = "Conventional Mill";
            this.rbConventional.UseVisualStyleBackColor = true;
            // 
            // rbClimb
            // 
            this.rbClimb.AutoSize = true;
            this.rbClimb.Location = new System.Drawing.Point(7, 7);
            this.rbClimb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbClimb.Name = "rbClimb";
            this.rbClimb.Size = new System.Drawing.Size(85, 20);
            this.rbClimb.TabIndex = 0;
            this.rbClimb.Text = "Climb Mill";
            this.rbClimb.UseVisualStyleBackColor = true;
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(361, 439);
            this.txtFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFormat.MaxLength = 7;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(65, 22);
            this.txtFormat.TabIndex = 8;
            this.txtFormat.Text = "0.000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 443);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Decimal Places";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(117, 145);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 22);
            this.txtDistance.TabIndex = 1;
            this.txtDistance.Text = "0.0";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(52, 148);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(60, 16);
            this.lblDistance.TabIndex = 28;
            this.lblDistance.Text = "Distance";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(117, 117);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 22);
            this.txtAngle.TabIndex = 0;
            this.txtAngle.Text = "0.0";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(69, 121);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(42, 16);
            this.lblAngle.TabIndex = 30;
            this.lblAngle.Text = "Angle";
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(73, 377);
            this.chkReverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(134, 20);
            this.chkReverse.TabIndex = 6;
            this.chkReverse.Text = "Reverse Cut Side";
            this.chkReverse.UseVisualStyleBackColor = true;
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(117, 265);
            this.txtXOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(99, 22);
            this.txtXOffset.TabIndex = 4;
            this.txtXOffset.Text = "0.0";
            // 
            // lblXOffset
            // 
            this.lblXOffset.AutoSize = true;
            this.lblXOffset.Location = new System.Drawing.Point(21, 268);
            this.lblXOffset.Name = "lblXOffset";
            this.lblXOffset.Size = new System.Drawing.Size(82, 16);
            this.lblXOffset.TabIndex = 33;
            this.lblXOffset.Text = "Start X Offset";
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(117, 293);
            this.txtYOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(100, 22);
            this.txtYOffset.TabIndex = 5;
            this.txtYOffset.Text = "0.0";
            // 
            // lblYOffset
            // 
            this.lblYOffset.AutoSize = true;
            this.lblYOffset.Location = new System.Drawing.Point(21, 297);
            this.lblYOffset.Name = "lblYOffset";
            this.lblYOffset.Size = new System.Drawing.Size(83, 16);
            this.lblYOffset.TabIndex = 35;
            this.lblYOffset.Text = "Start Y Offset";
            // 
            // txtIncrement
            // 
            this.txtIncrement.Location = new System.Drawing.Point(117, 203);
            this.txtIncrement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncrement.Name = "txtIncrement";
            this.txtIncrement.Size = new System.Drawing.Size(100, 22);
            this.txtIncrement.TabIndex = 3;
            this.txtIncrement.Text = "0.0";
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Location = new System.Drawing.Point(12, 207);
            this.lblIncrement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(96, 16);
            this.lblIncrement.TabIndex = 37;
            this.lblIncrement.Text = "Step Increment";
            // 
            // chkInc
            // 
            this.chkInc.AutoSize = true;
            this.chkInc.Checked = true;
            this.chkInc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInc.Location = new System.Drawing.Point(251, 414);
            this.chkInc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInc.Name = "chkInc";
            this.chkInc.Size = new System.Drawing.Size(98, 20);
            this.chkInc.TabIndex = 7;
            this.chkInc.Text = "Incremental";
            this.chkInc.UseVisualStyleBackColor = true;
            // 
            // frmAngleStepCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.chkInc);
            this.Controls.Add(this.lblIncrement);
            this.Controls.Add(this.txtIncrement);
            this.Controls.Add(this.lblYOffset);
            this.Controls.Add(this.txtYOffset);
            this.Controls.Add(this.lblXOffset);
            this.Controls.Add(this.txtXOffset);
            this.Controls.Add(this.chkReverse);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBold);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblToolRadius);
            this.Controls.Add(this.txtToolRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAngleStepCalculator";
            this.Text = "Angle Step Calculator v1.2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtToolRadius;
        private System.Windows.Forms.Label lblToolRadius;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbConventional;
        private System.Windows.Forms.RadioButton rbClimb;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCentered;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.TextBox txtXOffset;
        private System.Windows.Forms.Label lblXOffset;
        private System.Windows.Forms.TextBox txtYOffset;
        private System.Windows.Forms.Label lblYOffset;
        private System.Windows.Forms.TextBox txtIncrement;
        private System.Windows.Forms.Label lblIncrement;
        private System.Windows.Forms.CheckBox chkInc;
    }
}

