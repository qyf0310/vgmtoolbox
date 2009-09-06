﻿namespace VGMToolbox.forms
{
    partial class Genh_CreatorForm
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
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.grpSourceFiles = new System.Windows.Forms.GroupBox();
            this.lblFilenameFilter = new System.Windows.Forms.Label();
            this.tbFilenameFilter = new System.Windows.Forms.TextBox();
            this.tbSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowseDirectory = new System.Windows.Forms.Button();
            this.grpFormat = new System.Windows.Forms.GroupBox();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.cbFindLoop = new System.Windows.Forms.RadioButton();
            this.cbLoopFileEnd = new System.Windows.Forms.RadioButton();
            this.cbNoLoops = new System.Windows.Forms.RadioButton();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.cbChannels = new System.Windows.Forms.ComboBox();
            this.cbInterleave = new System.Windows.Forms.ComboBox();
            this.cbHeaderSkip = new System.Windows.Forms.ComboBox();
            this.cbCapcomHack = new System.Windows.Forms.CheckBox();
            this.lblLeftCoef = new System.Windows.Forms.Label();
            this.tbLeftCoef = new System.Windows.Forms.TextBox();
            this.lblRightCoef = new System.Windows.Forms.Label();
            this.tbRightCoef = new System.Windows.Forms.TextBox();
            this.lblLoopEnd = new System.Windows.Forms.Label();
            this.tbLoopEnd = new System.Windows.Forms.TextBox();
            this.lblLoopStart = new System.Windows.Forms.Label();
            this.tbLoopStart = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblChannels = new System.Windows.Forms.Label();
            this.lblInterleave = new System.Windows.Forms.Label();
            this.lblHeaderSkip = new System.Windows.Forms.Label();
            this.cbHeaderOnly = new System.Windows.Forms.CheckBox();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.rbExtract = new System.Windows.Forms.RadioButton();
            this.contextMenuRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshFileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbManualEntry = new System.Windows.Forms.RadioButton();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpSourceFiles.SuspendLayout();
            this.grpFormat.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.contextMenuRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabels
            // 
            this.pnlLabels.Location = new System.Drawing.Point(0, 503);
            this.pnlLabels.Size = new System.Drawing.Size(638, 19);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(638, 20);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(0, 426);
            this.tbOutput.Size = new System.Drawing.Size(638, 77);
            this.toolTip1.SetToolTip(this.tbOutput, "Double-Click to view in your default text editor.");
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(0, 406);
            this.pnlButtons.Size = new System.Drawing.Size(638, 20);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(578, 0);
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(518, 0);
            this.btnDoTask.Click += new System.EventHandler(this.btnDoTask_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.HorizontalScrollbar = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 69);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFiles.Size = new System.Drawing.Size(254, 251);
            this.lbFiles.TabIndex = 5;
            this.lbFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbFiles_MouseUp);
            this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
            // 
            // grpSourceFiles
            // 
            this.grpSourceFiles.Controls.Add(this.lblFilenameFilter);
            this.grpSourceFiles.Controls.Add(this.tbFilenameFilter);
            this.grpSourceFiles.Controls.Add(this.tbSourceDirectory);
            this.grpSourceFiles.Controls.Add(this.lbFiles);
            this.grpSourceFiles.Controls.Add(this.btnBrowseDirectory);
            this.grpSourceFiles.Location = new System.Drawing.Point(3, 29);
            this.grpSourceFiles.Name = "grpSourceFiles";
            this.grpSourceFiles.Size = new System.Drawing.Size(266, 332);
            this.grpSourceFiles.TabIndex = 6;
            this.grpSourceFiles.TabStop = false;
            this.grpSourceFiles.Text = "Source Files";
            // 
            // lblFilenameFilter
            // 
            this.lblFilenameFilter.AutoSize = true;
            this.lblFilenameFilter.Location = new System.Drawing.Point(186, 45);
            this.lblFilenameFilter.Name = "lblFilenameFilter";
            this.lblFilenameFilter.Size = new System.Drawing.Size(76, 13);
            this.lblFilenameFilter.TabIndex = 11;
            this.lblFilenameFilter.Text = "FileName Filter";
            this.lblFilenameFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFilenameFilter
            // 
            this.tbFilenameFilter.Location = new System.Drawing.Point(6, 42);
            this.tbFilenameFilter.Name = "tbFilenameFilter";
            this.tbFilenameFilter.Size = new System.Drawing.Size(174, 20);
            this.tbFilenameFilter.TabIndex = 10;
            this.tbFilenameFilter.TextChanged += new System.EventHandler(this.tbFilenameFilter_TextChanged);
            // 
            // tbSourceDirectory
            // 
            this.tbSourceDirectory.Location = new System.Drawing.Point(6, 16);
            this.tbSourceDirectory.Name = "tbSourceDirectory";
            this.tbSourceDirectory.Size = new System.Drawing.Size(216, 20);
            this.tbSourceDirectory.TabIndex = 6;
            this.tbSourceDirectory.TextChanged += new System.EventHandler(this.tbSourceDirectory_TextChanged);
            this.tbSourceDirectory.Click += new System.EventHandler(this.tbSourceDirectory_Click);
            // 
            // btnBrowseDirectory
            // 
            this.btnBrowseDirectory.Location = new System.Drawing.Point(228, 16);
            this.btnBrowseDirectory.Name = "btnBrowseDirectory";
            this.btnBrowseDirectory.Size = new System.Drawing.Size(32, 20);
            this.btnBrowseDirectory.TabIndex = 9;
            this.btnBrowseDirectory.Text = "...";
            this.btnBrowseDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseDirectory.Click += new System.EventHandler(this.btnBrowseDirectory_Click);
            // 
            // grpFormat
            // 
            this.grpFormat.Controls.Add(this.comboFormat);
            this.grpFormat.Location = new System.Drawing.Point(275, 29);
            this.grpFormat.Name = "grpFormat";
            this.grpFormat.Size = new System.Drawing.Size(258, 41);
            this.grpFormat.TabIndex = 7;
            this.grpFormat.TabStop = false;
            this.grpFormat.Text = "Format";
            // 
            // comboFormat
            // 
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Location = new System.Drawing.Point(6, 15);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(246, 21);
            this.comboFormat.TabIndex = 0;
            this.comboFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboFormat_KeyPress);
            this.comboFormat.SelectedValueChanged += new System.EventHandler(this.comboFormat_SelectedValueChanged);
            this.comboFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboFormat_KeyDown);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.cbFindLoop);
            this.grpOptions.Controls.Add(this.cbLoopFileEnd);
            this.grpOptions.Controls.Add(this.cbNoLoops);
            this.grpOptions.Controls.Add(this.cbFrequency);
            this.grpOptions.Controls.Add(this.cbManualEntry);
            this.grpOptions.Controls.Add(this.cbChannels);
            this.grpOptions.Controls.Add(this.cbInterleave);
            this.grpOptions.Controls.Add(this.cbHeaderSkip);
            this.grpOptions.Controls.Add(this.cbCapcomHack);
            this.grpOptions.Controls.Add(this.lblLeftCoef);
            this.grpOptions.Controls.Add(this.tbLeftCoef);
            this.grpOptions.Controls.Add(this.lblRightCoef);
            this.grpOptions.Controls.Add(this.tbRightCoef);
            this.grpOptions.Controls.Add(this.lblLoopEnd);
            this.grpOptions.Controls.Add(this.tbLoopEnd);
            this.grpOptions.Controls.Add(this.lblLoopStart);
            this.grpOptions.Controls.Add(this.tbLoopStart);
            this.grpOptions.Controls.Add(this.lblFrequency);
            this.grpOptions.Controls.Add(this.lblChannels);
            this.grpOptions.Controls.Add(this.lblInterleave);
            this.grpOptions.Controls.Add(this.lblHeaderSkip);
            this.grpOptions.Location = new System.Drawing.Point(275, 74);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(258, 287);
            this.grpOptions.TabIndex = 8;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // cbFindLoop
            // 
            this.cbFindLoop.AutoSize = true;
            this.cbFindLoop.Location = new System.Drawing.Point(180, 195);
            this.cbFindLoop.Name = "cbFindLoop";
            this.cbFindLoop.Size = new System.Drawing.Size(72, 17);
            this.cbFindLoop.TabIndex = 27;
            this.cbFindLoop.Text = "Find Loop";
            this.cbFindLoop.UseVisualStyleBackColor = true;
            this.cbFindLoop.CheckedChanged += new System.EventHandler(this.cbFindLoop_CheckedChanged);
            // 
            // cbLoopFileEnd
            // 
            this.cbLoopFileEnd.AutoSize = true;
            this.cbLoopFileEnd.Location = new System.Drawing.Point(89, 195);
            this.cbLoopFileEnd.Name = "cbLoopFileEnd";
            this.cbLoopFileEnd.Size = new System.Drawing.Size(85, 17);
            this.cbLoopFileEnd.TabIndex = 26;
            this.cbLoopFileEnd.Text = "Use File End";
            this.cbLoopFileEnd.UseVisualStyleBackColor = true;
            this.cbLoopFileEnd.CheckedChanged += new System.EventHandler(this.cbLoopFileEnd_CheckedChanged);
            // 
            // cbNoLoops
            // 
            this.cbNoLoops.AutoSize = true;
            this.cbNoLoops.Location = new System.Drawing.Point(9, 195);
            this.cbNoLoops.Name = "cbNoLoops";
            this.cbNoLoops.Size = new System.Drawing.Size(71, 17);
            this.cbNoLoops.TabIndex = 25;
            this.cbNoLoops.Text = "No Loops";
            this.cbNoLoops.UseVisualStyleBackColor = true;
            this.cbNoLoops.CheckedChanged += new System.EventHandler(this.cbNoLoops_CheckedChanged);
            // 
            // cbFrequency
            // 
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Location = new System.Drawing.Point(152, 97);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(100, 21);
            this.cbFrequency.TabIndex = 24;
            // 
            // cbChannels
            // 
            this.cbChannels.FormattingEnabled = true;
            this.cbChannels.Location = new System.Drawing.Point(152, 71);
            this.cbChannels.Name = "cbChannels";
            this.cbChannels.Size = new System.Drawing.Size(100, 21);
            this.cbChannels.TabIndex = 23;
            // 
            // cbInterleave
            // 
            this.cbInterleave.FormattingEnabled = true;
            this.cbInterleave.Location = new System.Drawing.Point(152, 45);
            this.cbInterleave.Name = "cbInterleave";
            this.cbInterleave.Size = new System.Drawing.Size(100, 21);
            this.cbInterleave.TabIndex = 22;
            this.cbInterleave.Text = "0";
            // 
            // cbHeaderSkip
            // 
            this.cbHeaderSkip.FormattingEnabled = true;
            this.cbHeaderSkip.Location = new System.Drawing.Point(152, 19);
            this.cbHeaderSkip.Name = "cbHeaderSkip";
            this.cbHeaderSkip.Size = new System.Drawing.Size(100, 21);
            this.cbHeaderSkip.TabIndex = 21;
            this.cbHeaderSkip.Text = "0";
            // 
            // cbCapcomHack
            // 
            this.cbCapcomHack.AutoSize = true;
            this.cbCapcomHack.Location = new System.Drawing.Point(152, 266);
            this.cbCapcomHack.Name = "cbCapcomHack";
            this.cbCapcomHack.Size = new System.Drawing.Size(94, 17);
            this.cbCapcomHack.TabIndex = 18;
            this.cbCapcomHack.Text = "Capcom Hack";
            this.cbCapcomHack.UseVisualStyleBackColor = true;
            // 
            // lblLeftCoef
            // 
            this.lblLeftCoef.AutoSize = true;
            this.lblLeftCoef.Location = new System.Drawing.Point(6, 247);
            this.lblLeftCoef.Name = "lblLeftCoef";
            this.lblLeftCoef.Size = new System.Drawing.Size(95, 13);
            this.lblLeftCoef.TabIndex = 17;
            this.lblLeftCoef.Text = "Coef: Left Channel";
            // 
            // tbLeftCoef
            // 
            this.tbLeftCoef.Location = new System.Drawing.Point(152, 244);
            this.tbLeftCoef.Name = "tbLeftCoef";
            this.tbLeftCoef.Size = new System.Drawing.Size(100, 20);
            this.tbLeftCoef.TabIndex = 16;
            // 
            // lblRightCoef
            // 
            this.lblRightCoef.AutoSize = true;
            this.lblRightCoef.Location = new System.Drawing.Point(6, 221);
            this.lblRightCoef.Name = "lblRightCoef";
            this.lblRightCoef.Size = new System.Drawing.Size(102, 13);
            this.lblRightCoef.TabIndex = 15;
            this.lblRightCoef.Text = "Coef: Right Channel";
            // 
            // tbRightCoef
            // 
            this.tbRightCoef.Location = new System.Drawing.Point(152, 218);
            this.tbRightCoef.Name = "tbRightCoef";
            this.tbRightCoef.Size = new System.Drawing.Size(100, 20);
            this.tbRightCoef.TabIndex = 14;
            // 
            // lblLoopEnd
            // 
            this.lblLoopEnd.AutoSize = true;
            this.lblLoopEnd.Location = new System.Drawing.Point(6, 160);
            this.lblLoopEnd.Name = "lblLoopEnd";
            this.lblLoopEnd.Size = new System.Drawing.Size(102, 13);
            this.lblLoopEnd.TabIndex = 11;
            this.lblLoopEnd.Text = "Loop End (Samples)";
            // 
            // tbLoopEnd
            // 
            this.tbLoopEnd.Location = new System.Drawing.Point(152, 157);
            this.tbLoopEnd.Name = "tbLoopEnd";
            this.tbLoopEnd.Size = new System.Drawing.Size(100, 20);
            this.tbLoopEnd.TabIndex = 10;
            // 
            // lblLoopStart
            // 
            this.lblLoopStart.AutoSize = true;
            this.lblLoopStart.Location = new System.Drawing.Point(6, 134);
            this.lblLoopStart.Name = "lblLoopStart";
            this.lblLoopStart.Size = new System.Drawing.Size(105, 13);
            this.lblLoopStart.TabIndex = 9;
            this.lblLoopStart.Text = "Loop Start (Samples)";
            // 
            // tbLoopStart
            // 
            this.tbLoopStart.Location = new System.Drawing.Point(152, 131);
            this.tbLoopStart.Name = "tbLoopStart";
            this.tbLoopStart.Size = new System.Drawing.Size(100, 20);
            this.tbLoopStart.TabIndex = 8;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(6, 100);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 7;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblChannels
            // 
            this.lblChannels.AutoSize = true;
            this.lblChannels.Location = new System.Drawing.Point(6, 74);
            this.lblChannels.Name = "lblChannels";
            this.lblChannels.Size = new System.Drawing.Size(51, 13);
            this.lblChannels.TabIndex = 5;
            this.lblChannels.Text = "Channels";
            // 
            // lblInterleave
            // 
            this.lblInterleave.AutoSize = true;
            this.lblInterleave.Location = new System.Drawing.Point(6, 48);
            this.lblInterleave.Name = "lblInterleave";
            this.lblInterleave.Size = new System.Drawing.Size(54, 13);
            this.lblInterleave.TabIndex = 3;
            this.lblInterleave.Text = "Interleave";
            // 
            // lblHeaderSkip
            // 
            this.lblHeaderSkip.AutoSize = true;
            this.lblHeaderSkip.Location = new System.Drawing.Point(6, 22);
            this.lblHeaderSkip.Name = "lblHeaderSkip";
            this.lblHeaderSkip.Size = new System.Drawing.Size(66, 13);
            this.lblHeaderSkip.TabIndex = 1;
            this.lblHeaderSkip.Text = "Header Skip";
            // 
            // cbHeaderOnly
            // 
            this.cbHeaderOnly.AutoSize = true;
            this.cbHeaderOnly.Location = new System.Drawing.Point(275, 367);
            this.cbHeaderOnly.Name = "cbHeaderOnly";
            this.cbHeaderOnly.Size = new System.Drawing.Size(117, 17);
            this.cbHeaderOnly.TabIndex = 0;
            this.cbHeaderOnly.Text = "Ouput Header Only";
            this.cbHeaderOnly.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(3, 367);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(56, 17);
            this.rbCreate.TabIndex = 9;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            this.rbCreate.CheckedChanged += new System.EventHandler(this.rbCreate_CheckedChanged);
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Location = new System.Drawing.Point(65, 367);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(43, 17);
            this.rbEdit.TabIndex = 10;
            this.rbEdit.TabStop = true;
            this.rbEdit.Text = "Edit";
            this.rbEdit.UseVisualStyleBackColor = true;
            this.rbEdit.CheckedChanged += new System.EventHandler(this.rbEdit_CheckedChanged);
            // 
            // rbExtract
            // 
            this.rbExtract.AutoSize = true;
            this.rbExtract.Location = new System.Drawing.Point(114, 367);
            this.rbExtract.Name = "rbExtract";
            this.rbExtract.Size = new System.Drawing.Size(58, 17);
            this.rbExtract.TabIndex = 11;
            this.rbExtract.TabStop = true;
            this.rbExtract.Text = "Extract";
            this.rbExtract.UseVisualStyleBackColor = true;
            this.rbExtract.CheckedChanged += new System.EventHandler(this.rbExtract_CheckedChanged);
            // 
            // contextMenuRefresh
            // 
            this.contextMenuRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshFileListToolStripMenuItem});
            this.contextMenuRefresh.Name = "contextMenuRefresh";
            this.contextMenuRefresh.Size = new System.Drawing.Size(151, 26);
            // 
            // refreshFileListToolStripMenuItem
            // 
            this.refreshFileListToolStripMenuItem.Name = "refreshFileListToolStripMenuItem";
            this.refreshFileListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.refreshFileListToolStripMenuItem.Text = "Refresh File List";
            this.refreshFileListToolStripMenuItem.Click += new System.EventHandler(this.refreshFileListToolStripMenuItem_Click);
            // 
            // cbManualEntry
            // 
            this.cbManualEntry.AutoSize = true;
            this.cbManualEntry.Checked = true;
            this.cbManualEntry.Location = new System.Drawing.Point(9, 176);
            this.cbManualEntry.Name = "cbManualEntry";
            this.cbManualEntry.Size = new System.Drawing.Size(87, 17);
            this.cbManualEntry.TabIndex = 28;
            this.cbManualEntry.TabStop = true;
            this.cbManualEntry.Text = "Manual Entry";
            this.cbManualEntry.UseVisualStyleBackColor = true;
            this.cbManualEntry.CheckedChanged += new System.EventHandler(this.cbManualEntry_CheckedChanged);
            // 
            // Genh_CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 544);
            this.Controls.Add(this.grpFormat);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.cbHeaderOnly);
            this.Controls.Add(this.grpSourceFiles);
            this.Controls.Add(this.rbExtract);
            this.Controls.Add(this.rbEdit);
            this.Controls.Add(this.rbCreate);
            this.Name = "Genh_CreatorForm";
            this.Text = "Genh_CreatorForm";
            this.Controls.SetChildIndex(this.rbCreate, 0);
            this.Controls.SetChildIndex(this.rbEdit, 0);
            this.Controls.SetChildIndex(this.rbExtract, 0);
            this.Controls.SetChildIndex(this.grpSourceFiles, 0);
            this.Controls.SetChildIndex(this.cbHeaderOnly, 0);
            this.Controls.SetChildIndex(this.grpOptions, 0);
            this.Controls.SetChildIndex(this.grpFormat, 0);
            this.Controls.SetChildIndex(this.pnlLabels, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.grpSourceFiles.ResumeLayout(false);
            this.grpSourceFiles.PerformLayout();
            this.grpFormat.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.contextMenuRefresh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.GroupBox grpSourceFiles;
        private System.Windows.Forms.GroupBox grpFormat;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox tbSourceDirectory;
        private System.Windows.Forms.Button btnBrowseDirectory;
        private System.Windows.Forms.CheckBox cbHeaderOnly;
        private System.Windows.Forms.Label lblHeaderSkip;
        private System.Windows.Forms.Label lblInterleave;
        private System.Windows.Forms.Label lblChannels;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblLoopStart;
        private System.Windows.Forms.TextBox tbLoopStart;
        private System.Windows.Forms.TextBox tbLoopEnd;
        private System.Windows.Forms.Label lblLoopEnd;
        private System.Windows.Forms.Label lblLeftCoef;
        private System.Windows.Forms.TextBox tbLeftCoef;
        private System.Windows.Forms.Label lblRightCoef;
        private System.Windows.Forms.TextBox tbRightCoef;
        private System.Windows.Forms.CheckBox cbCapcomHack;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.RadioButton rbEdit;
        private System.Windows.Forms.RadioButton rbExtract;
        private System.Windows.Forms.ContextMenuStrip contextMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem refreshFileListToolStripMenuItem;
        private System.Windows.Forms.Label lblFilenameFilter;
        private System.Windows.Forms.TextBox tbFilenameFilter;
        private System.Windows.Forms.ComboBox cbHeaderSkip;
        private System.Windows.Forms.ComboBox cbInterleave;
        private System.Windows.Forms.ComboBox cbChannels;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.RadioButton cbLoopFileEnd;
        private System.Windows.Forms.RadioButton cbNoLoops;
        private System.Windows.Forms.RadioButton cbFindLoop;
        private System.Windows.Forms.RadioButton cbManualEntry;
    }
}