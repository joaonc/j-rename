namespace JRenamer
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelDirectories = new System.Windows.Forms.Panel();
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
            this.checkBoxShowMasked = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelDirectories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.contextMenuStripCreate.SuspendLayout();
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
            this.listBoxDirectory.Size = new System.Drawing.Size(262, 407);
            this.listBoxDirectory.TabIndex = 1;
            this.listBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectory_SelectedIndexChanged);
            this.listBoxDirectory.DoubleClick += new System.EventHandler(this.listBoxDirectory_DoubleClick);
            // 
            // buttonChangeDir
            // 
            this.buttonChangeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeDir.Location = new System.Drawing.Point(6, 468);
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
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(12, 12);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelDirectories);
            this.splitContainer.Panel1MinSize = 200;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.checkBoxShowMasked);
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewFiles);
            this.splitContainer.Panel2.Controls.Add(this.buttonSelectInvert);
            this.splitContainer.Panel2.Controls.Add(this.buttonSelectNone);
            this.splitContainer.Panel2.Controls.Add(this.buttonSelectAll);
            this.splitContainer.Panel2.Controls.Add(this.labelSelect);
            this.splitContainer.Panel2.Controls.Add(this.buttonCreate);
            this.splitContainer.Panel2.Controls.Add(this.comboBoxMask);
            this.splitContainer.Panel2.Controls.Add(this.labelMask);
            this.splitContainer.Panel2.Controls.Add(this.labelFiles);
            this.splitContainer.Panel2MinSize = 0;
            this.splitContainer.Size = new System.Drawing.Size(800, 496);
            this.splitContainer.SplitterDistance = 270;
            this.splitContainer.TabIndex = 4;
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
            this.panelDirectories.Size = new System.Drawing.Size(270, 496);
            this.panelDirectories.TabIndex = 4;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Location = new System.Drawing.Point(3, 87);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewFiles.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewFiles.Size = new System.Drawing.Size(520, 367);
            this.dataGridViewFiles.TabIndex = 9;
            // 
            // buttonSelectInvert
            // 
            this.buttonSelectInvert.Location = new System.Drawing.Point(212, 58);
            this.buttonSelectInvert.Name = "buttonSelectInvert";
            this.buttonSelectInvert.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectInvert.TabIndex = 8;
            this.buttonSelectInvert.Text = "Invert";
            this.buttonSelectInvert.UseVisualStyleBackColor = true;
            this.buttonSelectInvert.Click += new System.EventHandler(this.buttonSelectInvert_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.Location = new System.Drawing.Point(131, 58);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectNone.TabIndex = 7;
            this.buttonSelectNone.Text = "None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.buttonSelectNone_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Location = new System.Drawing.Point(50, 58);
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
            this.labelSelect.Location = new System.Drawing.Point(7, 63);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(37, 13);
            this.labelSelect.TabIndex = 5;
            this.labelSelect.Text = "Select";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Location = new System.Drawing.Point(448, 470);
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
            this.comboBoxMask.Location = new System.Drawing.Point(46, 30);
            this.comboBoxMask.Name = "comboBoxMask";
            this.comboBoxMask.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMask.TabIndex = 2;
            this.comboBoxMask.Text = "*.*";
            this.comboBoxMask.TextChanged += new System.EventHandler(this.comboBoxMask_TextChanged);
            // 
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Location = new System.Drawing.Point(7, 33);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(33, 13);
            this.labelMask.TabIndex = 1;
            this.labelMask.Text = "Mask";
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(4, 10);
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
            // checkBoxShowMasked
            // 
            this.checkBoxShowMasked.AutoSize = true;
            this.checkBoxShowMasked.Location = new System.Drawing.Point(173, 32);
            this.checkBoxShowMasked.Name = "checkBoxShowMasked";
            this.checkBoxShowMasked.Size = new System.Drawing.Size(93, 17);
            this.checkBoxShowMasked.TabIndex = 10;
            this.checkBoxShowMasked.Text = "Show masked";
            this.checkBoxShowMasked.UseVisualStyleBackColor = true;
            this.checkBoxShowMasked.CheckedChanged += new System.EventHandler(this.checkBoxShowMasked_CheckedChanged);
            // 
            // JRenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 520);
            this.Controls.Add(this.splitContainer);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "JRenamerForm";
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelDirectories.ResumeLayout(false);
            this.panelDirectories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.contextMenuStripCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.ListBox listBoxDirectory;
        private System.Windows.Forms.Button buttonChangeDir;
        private System.Windows.Forms.TextBox textBoxCurrentDirectory;
        private System.Windows.Forms.SplitContainer splitContainer;
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
    }
}

