﻿namespace VGMToolbox.forms
{
    partial class Xsf_Psf2SqExtractorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPsf2Source = new System.Windows.Forms.TextBox();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabels
            // 
            this.pnlLabels.Location = new System.Drawing.Point(0, 447);
            this.pnlLabels.Size = new System.Drawing.Size(979, 19);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(979, 20);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(0, 370);
            this.tbOutput.Size = new System.Drawing.Size(979, 77);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(0, 350);
            this.pnlButtons.Size = new System.Drawing.Size(979, 20);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(919, 0);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(859, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPsf2Source);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 59);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Files/Folders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drag PSF2s to Extract From Here";
            // 
            // tbPsf2Source
            // 
            this.tbPsf2Source.AllowDrop = true;
            this.tbPsf2Source.Location = new System.Drawing.Point(6, 19);
            this.tbPsf2Source.Name = "tbPsf2Source";
            this.tbPsf2Source.Size = new System.Drawing.Size(282, 20);
            this.tbPsf2Source.TabIndex = 0;
            this.tbPsf2Source.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbPsf2Source_DragDrop);
            this.tbPsf2Source.DragEnter += new System.Windows.Forms.DragEventHandler(this.doDragEnter);
            // 
            // Xsf_Psf2SqExtractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 488);
            this.Controls.Add(this.groupBox1);
            this.Name = "Xsf_Psf2SqExtractorForm";
            this.Text = "Xsf_Psf2SqExtractorForm";
            this.Controls.SetChildIndex(this.pnlLabels, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPsf2Source;

    }
}