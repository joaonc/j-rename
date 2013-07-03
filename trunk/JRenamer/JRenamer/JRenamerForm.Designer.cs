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
            this.contextMenuStripCreate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTSV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerActions = new System.Windows.Forms.SplitContainer();
            this.splitContainerFiles = new System.Windows.Forms.SplitContainer();
            this.panelDirectories = new System.Windows.Forms.Panel();
            this.buttonChangeDir = new System.Windows.Forms.Button();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.listBoxDirectory = new System.Windows.Forms.ListBox();
            this.textBoxCurrentDirectory = new System.Windows.Forms.TextBox();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.checkBoxShowMasked = new System.Windows.Forms.CheckBox();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.buttonSelectInvert = new System.Windows.Forms.Button();
            this.labelFiles = new System.Windows.Forms.Label();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.labelMask = new System.Windows.Forms.Label();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.comboBoxMask = new System.Windows.Forms.ComboBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.buttonCommandClear = new System.Windows.Forms.Button();
            this.buttonCommandGet = new System.Windows.Forms.Button();
            this.buttonCommandReplace = new System.Windows.Forms.Button();
            this.buttonCommandAdd = new System.Windows.Forms.Button();
            this.tabControlCommands = new System.Windows.Forms.TabControl();
            this.tabPageMacro = new System.Windows.Forms.TabPage();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.panelCommandInsert = new JRenamer.UserControlCommandInsert();
            this.tabPageRemove = new System.Windows.Forms.TabPage();
            this.tabPageChangeCase = new System.Windows.Forms.TabPage();
            this.buttonCommandDelete = new System.Windows.Forms.Button();
            this.buttonCommandMoveDown = new System.Windows.Forms.Button();
            this.buttonCommandMoveUp = new System.Windows.Forms.Button();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.contextMenuStripCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerActions)).BeginInit();
            this.splitContainerActions.Panel1.SuspendLayout();
            this.splitContainerActions.Panel2.SuspendLayout();
            this.splitContainerActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).BeginInit();
            this.splitContainerFiles.Panel1.SuspendLayout();
            this.splitContainerFiles.Panel2.SuspendLayout();
            this.splitContainerFiles.SuspendLayout();
            this.panelDirectories.SuspendLayout();
            this.panelFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.panelActions.SuspendLayout();
            this.tabControlCommands.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerActions.Size = new System.Drawing.Size(1002, 564);
            this.splitContainerActions.SplitterDistance = 362;
            this.splitContainerActions.TabIndex = 5;
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
            this.splitContainerFiles.Size = new System.Drawing.Size(1002, 362);
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
            this.panelDirectories.Size = new System.Drawing.Size(270, 362);
            this.panelDirectories.TabIndex = 4;
            // 
            // buttonChangeDir
            // 
            this.buttonChangeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeDir.Location = new System.Drawing.Point(3, 333);
            this.buttonChangeDir.Name = "buttonChangeDir";
            this.buttonChangeDir.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeDir.TabIndex = 2;
            this.buttonChangeDir.Text = "Change dir";
            this.buttonChangeDir.UseVisualStyleBackColor = true;
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
            this.listBoxDirectory.Size = new System.Drawing.Size(262, 277);
            this.listBoxDirectory.TabIndex = 1;
            this.listBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectory_SelectedIndexChanged);
            this.listBoxDirectory.DoubleClick += new System.EventHandler(this.listBoxDirectory_DoubleClick);
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
            this.panelFiles.Size = new System.Drawing.Size(728, 362);
            this.panelFiles.TabIndex = 11;
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
            this.dataGridViewFiles.Size = new System.Drawing.Size(716, 269);
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
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Location = new System.Drawing.Point(3, 11);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(28, 13);
            this.labelFiles.TabIndex = 0;
            this.labelFiles.Text = "Files";
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
            // labelMask
            // 
            this.labelMask.AutoSize = true;
            this.labelMask.Location = new System.Drawing.Point(6, 34);
            this.labelMask.Name = "labelMask";
            this.labelMask.Size = new System.Drawing.Size(33, 13);
            this.labelMask.TabIndex = 1;
            this.labelMask.Text = "Mask";
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
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(6, 64);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(37, 13);
            this.labelSelect.TabIndex = 5;
            this.labelSelect.Text = "Select";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.buttonCommandClear);
            this.panelActions.Controls.Add(this.buttonCommandGet);
            this.panelActions.Controls.Add(this.buttonCommandReplace);
            this.panelActions.Controls.Add(this.buttonCommandAdd);
            this.panelActions.Controls.Add(this.tabControlCommands);
            this.panelActions.Controls.Add(this.buttonCommandDelete);
            this.panelActions.Controls.Add(this.buttonCommandMoveDown);
            this.panelActions.Controls.Add(this.buttonCommandMoveUp);
            this.panelActions.Controls.Add(this.listBoxCommands);
            this.panelActions.Controls.Add(this.buttonCreate);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelActions.Location = new System.Drawing.Point(0, 0);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(1002, 198);
            this.panelActions.TabIndex = 5;
            // 
            // buttonCommandClear
            // 
            this.buttonCommandClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandClear.Location = new System.Drawing.Point(627, 93);
            this.buttonCommandClear.Name = "buttonCommandClear";
            this.buttonCommandClear.Size = new System.Drawing.Size(75, 23);
            this.buttonCommandClear.TabIndex = 13;
            this.buttonCommandClear.Text = "Clear All";
            this.buttonCommandClear.UseVisualStyleBackColor = true;
            this.buttonCommandClear.Click += new System.EventHandler(this.buttonCommandClear_Click);
            // 
            // buttonCommandGet
            // 
            this.buttonCommandGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandGet.Location = new System.Drawing.Point(627, 63);
            this.buttonCommandGet.Name = "buttonCommandGet";
            this.buttonCommandGet.Size = new System.Drawing.Size(75, 23);
            this.buttonCommandGet.TabIndex = 12;
            this.buttonCommandGet.Text = "Get";
            this.buttonCommandGet.UseVisualStyleBackColor = true;
            this.buttonCommandGet.Click += new System.EventHandler(this.buttonCommandGet_Click);
            // 
            // buttonCommandReplace
            // 
            this.buttonCommandReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandReplace.Location = new System.Drawing.Point(627, 33);
            this.buttonCommandReplace.Name = "buttonCommandReplace";
            this.buttonCommandReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonCommandReplace.TabIndex = 11;
            this.buttonCommandReplace.Text = "Replace";
            this.buttonCommandReplace.UseVisualStyleBackColor = true;
            this.buttonCommandReplace.Click += new System.EventHandler(this.buttonCommandReplace_Click);
            // 
            // buttonCommandAdd
            // 
            this.buttonCommandAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandAdd.Location = new System.Drawing.Point(626, 3);
            this.buttonCommandAdd.Name = "buttonCommandAdd";
            this.buttonCommandAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCommandAdd.TabIndex = 10;
            this.buttonCommandAdd.Text = "Add";
            this.buttonCommandAdd.UseVisualStyleBackColor = true;
            this.buttonCommandAdd.Click += new System.EventHandler(this.buttonCommandAdd_Click);
            // 
            // tabControlCommands
            // 
            this.tabControlCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCommands.Controls.Add(this.tabPageMacro);
            this.tabControlCommands.Controls.Add(this.tabPageInsert);
            this.tabControlCommands.Controls.Add(this.tabPageRemove);
            this.tabControlCommands.Controls.Add(this.tabPageChangeCase);
            this.tabControlCommands.Location = new System.Drawing.Point(1, 4);
            this.tabControlCommands.Name = "tabControlCommands";
            this.tabControlCommands.SelectedIndex = 0;
            this.tabControlCommands.Size = new System.Drawing.Size(619, 185);
            this.tabControlCommands.TabIndex = 9;
            // 
            // tabPageMacro
            // 
            this.tabPageMacro.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacro.Name = "tabPageMacro";
            this.tabPageMacro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacro.Size = new System.Drawing.Size(611, 159);
            this.tabPageMacro.TabIndex = 1;
            this.tabPageMacro.Text = "Macro";
            this.tabPageMacro.UseVisualStyleBackColor = true;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.panelCommandInsert);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(611, 159);
            this.tabPageInsert.TabIndex = 0;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // panelCommandInsert
            // 
            this.panelCommandInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCommandInsert.Location = new System.Drawing.Point(0, 0);
            this.panelCommandInsert.Name = "panelCommandInsert";
            this.panelCommandInsert.Size = new System.Drawing.Size(611, 159);
            this.panelCommandInsert.TabIndex = 0;
            // 
            // tabPageRemove
            // 
            this.tabPageRemove.Location = new System.Drawing.Point(4, 22);
            this.tabPageRemove.Name = "tabPageRemove";
            this.tabPageRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRemove.Size = new System.Drawing.Size(611, 159);
            this.tabPageRemove.TabIndex = 2;
            this.tabPageRemove.Text = "Remove";
            this.tabPageRemove.UseVisualStyleBackColor = true;
            // 
            // tabPageChangeCase
            // 
            this.tabPageChangeCase.Location = new System.Drawing.Point(4, 22);
            this.tabPageChangeCase.Name = "tabPageChangeCase";
            this.tabPageChangeCase.Size = new System.Drawing.Size(611, 159);
            this.tabPageChangeCase.TabIndex = 3;
            this.tabPageChangeCase.Text = "Change Case";
            this.tabPageChangeCase.UseVisualStyleBackColor = true;
            // 
            // buttonCommandDelete
            // 
            this.buttonCommandDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandDelete.Location = new System.Drawing.Point(921, 53);
            this.buttonCommandDelete.Name = "buttonCommandDelete";
            this.buttonCommandDelete.Size = new System.Drawing.Size(50, 23);
            this.buttonCommandDelete.TabIndex = 8;
            this.buttonCommandDelete.Text = "Del";
            this.buttonCommandDelete.UseVisualStyleBackColor = true;
            this.buttonCommandDelete.Click += new System.EventHandler(this.buttonCommandDelete_Click);
            // 
            // buttonCommandMoveDown
            // 
            this.buttonCommandMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandMoveDown.Location = new System.Drawing.Point(921, 28);
            this.buttonCommandMoveDown.Name = "buttonCommandMoveDown";
            this.buttonCommandMoveDown.Size = new System.Drawing.Size(50, 23);
            this.buttonCommandMoveDown.TabIndex = 7;
            this.buttonCommandMoveDown.Text = "Down";
            this.buttonCommandMoveDown.UseVisualStyleBackColor = true;
            this.buttonCommandMoveDown.Click += new System.EventHandler(this.buttonCommandMoveDown_Click);
            // 
            // buttonCommandMoveUp
            // 
            this.buttonCommandMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCommandMoveUp.Location = new System.Drawing.Point(921, 3);
            this.buttonCommandMoveUp.Name = "buttonCommandMoveUp";
            this.buttonCommandMoveUp.Size = new System.Drawing.Size(50, 23);
            this.buttonCommandMoveUp.TabIndex = 6;
            this.buttonCommandMoveUp.Text = "Up";
            this.buttonCommandMoveUp.UseVisualStyleBackColor = true;
            this.buttonCommandMoveUp.Click += new System.EventHandler(this.buttonCommandMoveUp_Click);
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.Location = new System.Drawing.Point(707, 3);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.Size = new System.Drawing.Size(208, 186);
            this.listBoxCommands.TabIndex = 5;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Location = new System.Drawing.Point(921, 166);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // JRenamerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 588);
            this.Controls.Add(this.splitContainerActions);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "JRenamerForm";
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.contextMenuStripCreate.ResumeLayout(false);
            this.splitContainerActions.Panel1.ResumeLayout(false);
            this.splitContainerActions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerActions)).EndInit();
            this.splitContainerActions.ResumeLayout(false);
            this.splitContainerFiles.Panel1.ResumeLayout(false);
            this.splitContainerFiles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFiles)).EndInit();
            this.splitContainerFiles.ResumeLayout(false);
            this.panelDirectories.ResumeLayout(false);
            this.panelDirectories.PerformLayout();
            this.panelFiles.ResumeLayout(false);
            this.panelFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.tabControlCommands.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonCommandDelete;
        private System.Windows.Forms.Button buttonCommandMoveDown;
        private System.Windows.Forms.Button buttonCommandMoveUp;
        private System.Windows.Forms.TabControl tabControlCommands;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.TabPage tabPageMacro;
        private System.Windows.Forms.TabPage tabPageRemove;
        private System.Windows.Forms.TabPage tabPageChangeCase;
        private System.Windows.Forms.Button buttonCommandAdd;
        private System.Windows.Forms.Button buttonCommandClear;
        private System.Windows.Forms.Button buttonCommandGet;
        private System.Windows.Forms.Button buttonCommandReplace;
        private UserControlCommandInsert panelCommandInsert;
    }
}

