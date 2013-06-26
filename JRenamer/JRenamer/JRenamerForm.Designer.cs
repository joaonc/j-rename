﻿namespace JRenamer
{
    partial class JRenamerForm
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
            this.labelDirectory = new System.Windows.Forms.Label();
            this.listBoxDirectory = new System.Windows.Forms.ListBox();
            this.buttonChangeDir = new System.Windows.Forms.Button();
            this.textBoxCurrentDirectory = new System.Windows.Forms.TextBox();
            this.splitContainerFiles = new System.Windows.Forms.SplitContainer();
            this.panelDirectories = new System.Windows.Forms.Panel();
            this.checkBoxShowMasked = new System.Windows.Forms.CheckBox();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.buttonSelectInvert = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.labelSelect = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxMask = new System.Windows.Forms.ComboBox();
            this.labelMask = new System.Windows.Forms.Label();
            this.labelFiles = new System.Windows.Forms.Label();
            this.contextMenuStripCreate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerActions = new System.Windows.Forms.SplitContainer();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).BeginInit();
            this.splitContainerFiles.Panel1.SuspendLayout();
            this.splitContainerFiles.Panel2.SuspendLayout();
            this.splitContainerFiles.SuspendLayout();
            this.panelDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.contextMenuStripCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerActions)).BeginInit();
            this.splitContainerActions.Panel1.SuspendLayout();
            this.splitContainerActions.Panel2.SuspendLayout();
            this.splitContainerActions.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(3, 10);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(49, 13);
            this.labelDirectory.TabIndex = 0;
            this.labelDirectory.Text = "Directory";
            // 
            // listBoxDirectory
            // 
            this.listBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDirectory.FormattingEnabled = true;
            this.listBoxDirectory.Location = new System.Drawing.Point(3, 52);
            this.listBoxDirectory.Name = "listBoxDirectory";
            this.listBoxDirectory.Size = new System.Drawing.Size(262, 238);
            this.listBoxDirectory.TabIndex = 1;
            this.listBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectory_SelectedIndexChanged);
            this.listBoxDirectory.DoubleClick += new System.EventHandler(this.listBoxDirectory_DoubleClick);
            // 
            // buttonChangeDir
            // 
            this.buttonChangeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeDir.Location = new System.Drawing.Point(6, 317);
            this.buttonChangeDir.Name = "buttonChangeDir";
            this.buttonChangeDir.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeDir.TabIndex = 2;
            this.buttonChangeDir.Text = "Change dir";
            this.buttonChangeDir.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrentDirectory
            // 
            this.textBoxCurrentDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCurrentDirectory.Location = new System.Drawing.Point(3, 26);
            this.textBoxCurrentDirectory.Name = "textBoxCurrentDirectory";
            this.textBoxCurrentDirectory.ReadOnly = true;
            this.textBoxCurrentDirectory.Size = new System.Drawing.Size(262, 20);
            this.textBoxCurrentDirectory.TabIndex = 3;
            // 
            // splitContainerFiles
            // 
            this.splitContainerFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFiles.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerFiles.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFiles.Name = "splitContainerFiles";
            // 
            // splitContainerFiles.Panel1
            // 
            this.splitContainerFiles.Panel1.Controls.Add(this.panelDirectories);
            this.splitContainerFiles.Panel1MinSize = 200;
            // 
            // splitContainerFiles.Panel2
            // 
            this.splitContainerFiles.Panel2.Controls.Add(this.panelFiles);
            this.splitContainerFiles.Panel2MinSize = 0;
            this.splitContainerFiles.Size = new System.Drawing.Size(1024, 345);
            this.splitContainerFiles.SplitterDistance = 270;
            this.splitContainerFiles.TabIndex = 4;
            // 
            // panelDirectories
            // 
            this.panelDirectories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDirectories.Controls.Add(this.buttonChangeDir);
            this.panelDirectories.Controls.Add(this.labelDirectory);
            this.panelDirectories.Controls.Add(this.listBoxDirectory);
            this.panelDirectories.Controls.Add(this.textBoxCurrentDirectory);
            this.panelDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDirectories.Location = new System.Drawing.Point(0, 0);
            this.panelDirectories.Name = "panelDirectories";
            this.panelDirectories.Size = new System.Drawing.Size(270, 345);
            this.panelDirectories.TabIndex = 4;
            // 
            // checkBoxShowMasked
            // 
            this.checkBoxShowMasked.AutoSize = true;
            this.checkBoxShowMasked.Location = new System.Drawing.Point(172, 33);
            this.checkBoxShowMasked.Name = "checkBoxShowMasked";
            this.checkBoxShowMasked.Size = new System.Drawing.Size(93, 17);
            this.checkBoxShowMasked.TabIndex = 10;
            this.checkBoxShowMasked.Text = "Show masked";
            this.checkBoxShowMasked.UseVisualStyleBackColor = true;
            this.checkBoxShowMasked.CheckedChanged += new System.EventHandler(this.checkBoxShowMasked_CheckedChanged);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Location = new System.Drawing.Point(6, 88);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewFiles.Size = new System.Drawing.Size(741, 253);
            this.dataGridViewFiles.TabIndex = 9;
            // 
            // buttonSelectInvert
            // 
            this.buttonSelectInvert.Location = new System.Drawing.Point(211, 59);
            this.buttonSelectInvert.Name = "buttonSelectInvert";
            this.buttonSelectInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectInvert.TabIndex = 8;
            this.buttonSelectInvert.Text = "Invert";
            this.buttonSelectInvert.UseVisualStyleBackColor = true;
            this.buttonSelectInvert.Click += new System.EventHandler(this.buttonSelectInvert_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.Location = new System.Drawing.Point(130, 59);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectNone.TabIndex = 7;
            this.buttonSelectNone.Text = "None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(49, 59);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAll.TabIndex = 6;
            this.buttonSelectAll.Text = "All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(6, 64);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(37, 13);
            this.labelSelect.TabIndex = 5;
            this.labelSelect.Text = "Select";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Location = new System.Drawing.Point(946, 91);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // comboBoxMask
            // 
            this.comboBoxMask.FormattingEnabled = true;
            this.comboBoxMask.Location = new System.Drawing.Point(45, 31);
            this.comboBoxMask.Name = "comboBoxMask";
            this.comboBoxMask.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMask.TabIndex = 2;
            this.comboBoxMask.Text = "*.*";
            this.comboBoxMask.TextChanged += new System.EventHandler(this.comboBoxMask_TextChanged);
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Location = new System.Drawing.Point(6, 34);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(33, 13);
            this.labelMask.TabIndex = 1;
            this.labelMask.Text = "Mask";
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(3, 11);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(28, 13);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "Files";
            // 
            // contextMenuStripCreate
            // 
            this.contextMenuStripCreate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemTSV,
            this.toolStripMenuItemSpace,
            this.toolStripMenuItemCSV});
            this.contextMenuStripCreate.Name = "contextMenuStripCreate";
            this.contextMenuStripCreate.ShowImageMargin = false;
            this.contextMenuStripCreate.Size = new System.Drawing.Size(217, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem1.Text = "One Per Line (TXT)";
            // 
            // toolStripMenuItemTSV
            // 
            this.toolStripMenuItemTSV.Name = "toolStripMenuItemTSV";
            this.toolStripMenuItemTSV.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemTSV.Text = "Tab Separated Values (TXT)";
            // 
            // toolStripMenuItemSpace
            // 
            this.toolStripMenuItemSpace.Name = "toolStripMenuItemSpace";
            this.toolStripMenuItemSpace.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemSpace.Text = "Space Separated Values (TXT)";
            // 
            // toolStripMenuItemCSV
            // 
            this.toolStripMenuItemCSV.Name = "toolStripMenuItemCSV";
            this.toolStripMenuItemCSV.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemCSV.Text = "Comma Separated Values (CSV)";
            // 
            // splitContainerActions
            // 
            this.splitContainerActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerActions.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerActions.Location = new System.Drawing.Point(12, 12);
            this.splitContainerActions.Name = "splitContainerActions";
            this.splitContainerActions.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerActions.Panel1
            // 
            this.splitContainerActions.Panel1.Controls.Add(this.splitContainerFiles);
            // 
            // splitContainerActions.Panel2
            // 
            this.splitContainerActions.Panel2.Controls.Add(this.panelActions);
            this.splitContainerActions.Size = new System.Drawing.Size(1024, 466);
            this.splitContainerActions.SplitterDistance = 345;
            this.splitContainerActions.TabIndex = 5;
            // 
            // panelFiles
            // 
            this.panelFiles.Controls.Add(this.checkBoxShowMasked);
            this.panelFiles.Controls.Add(this.dataGridViewFiles);
            this.panelFiles.Controls.Add(this.buttonSelectInvert);
            this.panelFiles.Controls.Add(this.labelFiles);
            this.panelFiles.Controls.Add(this.buttonSelectNone);
            this.panelFiles.Controls.Add(this.labelMask);
            this.panelFiles.Controls.Add(this.buttonSelectAll);
            this.panelFiles.Controls.Add(this.comboBoxMask);
            this.panelFiles.Controls.Add(this.labelSelect);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFiles.Location = new System.Drawing.Point(0, 0);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(750, 345);
            this.panelFiles.TabIndex = 11;
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.listBoxCommands);
            this.panelActions.Controls.Add(this.buttonCreate);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1024, 117);
            this.panelActions.TabIndex = 5;
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(732, 3);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(208, 108);
            this.listBoxCommands.TabIndex = 5;
            // 
            // JRenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 490);
            this.Controls.Add(this.splitContainerActions);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "JRenamerForm";
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.splitContainerFiles.Panel1.ResumeLayout(false);
            this.splitContainerFiles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).EndInit();
            this.splitContainerFiles.ResumeLayout(false);
            this.panelDirectories.ResumeLayout(false);
            this.panelDirectories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.contextMenuStripCreate.ResumeLayout(false);
            this.splitContainerActions.Panel1.ResumeLayout(false);
            this.splitContainerActions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerActions)).EndInit();
            this.splitContainerActions.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.ListBox listBoxDirectory;
        private System.Windows.Forms.Button buttonChangeDir;
        private System.Windows.Forms.TextBox textBoxCurrentDirectory;
        private System.Windows.Forms.SplitContainer splitContainerFiles;
        private System.Windows.Forms.ComboBox comboBoxMask;
        private System.Windows.Forms.Label labelMask;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSelectInvert;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCreate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCSV;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Panel panelDirectories;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTSV;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBoxShowMasked;
        private System.Windows.Forms.SplitContainer splitContainerActions;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.ListBox listBoxCommands;
    }
}

