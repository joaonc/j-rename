namespace JRenamer
{
    partial class UserControlCommandInsert
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonByPosition = new System.Windows.Forms.RadioButton();
            this.radioButtonByText = new System.Windows.Forms.RadioButton();
            this.radioButtonTextBefore = new System.Windows.Forms.RadioButton();
            this.radioButtonTextAfter = new System.Windows.Forms.RadioButton();
            this.panelByText = new System.Windows.Forms.Panel();
            this.labelTextToSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelTextToInsert = new System.Windows.Forms.Label();
            this.textBoxInsert = new System.Windows.Forms.TextBox();
            this.panelByPosition = new System.Windows.Forms.Panel();
            this.labelPositionToInsert = new System.Windows.Forms.Label();
            this.numericUpDownInsert = new System.Windows.Forms.NumericUpDown();
            this.panelByText.SuspendLayout();
            this.panelByPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonByPosition
            // 
            this.radioButtonByPosition.AutoSize = true;
            this.radioButtonByPosition.Checked = true;
            this.radioButtonByPosition.Location = new System.Drawing.Point(4, 4);
            this.radioButtonByPosition.Name = "radioButtonByPosition";
            this.radioButtonByPosition.Size = new System.Drawing.Size(77, 17);
            this.radioButtonByPosition.TabIndex = 0;
            this.radioButtonByPosition.TabStop = true;
            this.radioButtonByPosition.Text = "By Position";
            this.radioButtonByPosition.UseVisualStyleBackColor = true;
            // 
            // radioButtonByText
            // 
            this.radioButtonByText.AutoSize = true;
            this.radioButtonByText.Location = new System.Drawing.Point(4, 27);
            this.radioButtonByText.Name = "radioButtonByText";
            this.radioButtonByText.Size = new System.Drawing.Size(61, 17);
            this.radioButtonByText.TabIndex = 1;
            this.radioButtonByText.Text = "By Text";
            this.radioButtonByText.UseVisualStyleBackColor = true;
            this.radioButtonByText.CheckedChanged += new System.EventHandler(this.radioButtonByText_CheckedChanged);
            // 
            // radioButtonTextBefore
            // 
            this.radioButtonTextBefore.AutoSize = true;
            this.radioButtonTextBefore.Checked = true;
            this.radioButtonTextBefore.Location = new System.Drawing.Point(3, 3);
            this.radioButtonTextBefore.Name = "radioButtonTextBefore";
            this.radioButtonTextBefore.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTextBefore.TabIndex = 2;
            this.radioButtonTextBefore.TabStop = true;
            this.radioButtonTextBefore.Text = "Before";
            this.radioButtonTextBefore.UseVisualStyleBackColor = true;
            // 
            // radioButtonTextAfter
            // 
            this.radioButtonTextAfter.AutoSize = true;
            this.radioButtonTextAfter.Location = new System.Drawing.Point(3, 27);
            this.radioButtonTextAfter.Name = "radioButtonTextAfter";
            this.radioButtonTextAfter.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTextAfter.TabIndex = 3;
            this.radioButtonTextAfter.Text = "After";
            this.radioButtonTextAfter.UseVisualStyleBackColor = true;
            // 
            // panelByText
            // 
            this.panelByText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelByText.Controls.Add(this.labelTextToSearch);
            this.panelByText.Controls.Add(this.textBoxSearch);
            this.panelByText.Controls.Add(this.radioButtonTextBefore);
            this.panelByText.Controls.Add(this.radioButtonTextAfter);
            this.panelByText.Location = new System.Drawing.Point(155, 4);
            this.panelByText.Name = "panelByText";
            this.panelByText.Size = new System.Drawing.Size(202, 91);
            this.panelByText.TabIndex = 4;
            // 
            // labelTextToSearch
            // 
            this.labelTextToSearch.AutoSize = true;
            this.labelTextToSearch.Location = new System.Drawing.Point(3, 47);
            this.labelTextToSearch.Name = "labelTextToSearch";
            this.labelTextToSearch.Size = new System.Drawing.Size(75, 13);
            this.labelTextToSearch.TabIndex = 5;
            this.labelTextToSearch.Text = "Text to search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(3, 63);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(196, 20);
            this.textBoxSearch.TabIndex = 4;
            // 
            // labelTextToInsert
            // 
            this.labelTextToInsert.AutoSize = true;
            this.labelTextToInsert.Location = new System.Drawing.Point(0, 85);
            this.labelTextToInsert.Name = "labelTextToInsert";
            this.labelTextToInsert.Size = new System.Drawing.Size(68, 13);
            this.labelTextToInsert.TabIndex = 5;
            this.labelTextToInsert.Text = "Text to insert";
            // 
            // textBoxInsert
            // 
            this.textBoxInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInsert.Location = new System.Drawing.Point(3, 101);
            this.textBoxInsert.Name = "textBoxInsert";
            this.textBoxInsert.Size = new System.Drawing.Size(347, 20);
            this.textBoxInsert.TabIndex = 6;
            // 
            // panelByPosition
            // 
            this.panelByPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelByPosition.Controls.Add(this.labelPositionToInsert);
            this.panelByPosition.Controls.Add(this.numericUpDownInsert);
            this.panelByPosition.Location = new System.Drawing.Point(87, 4);
            this.panelByPosition.Name = "panelByPosition";
            this.panelByPosition.Size = new System.Drawing.Size(65, 91);
            this.panelByPosition.TabIndex = 7;
            // 
            // labelPositionToInsert
            // 
            this.labelPositionToInsert.AutoSize = true;
            this.labelPositionToInsert.Location = new System.Drawing.Point(3, 5);
            this.labelPositionToInsert.Name = "labelPositionToInsert";
            this.labelPositionToInsert.Size = new System.Drawing.Size(44, 13);
            this.labelPositionToInsert.TabIndex = 1;
            this.labelPositionToInsert.Text = "Position";
            // 
            // numericUpDownInsert
            // 
            this.numericUpDownInsert.Location = new System.Drawing.Point(3, 24);
            this.numericUpDownInsert.Name = "numericUpDownInsert";
            this.numericUpDownInsert.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownInsert.TabIndex = 0;
            // 
            // UserControlCommandInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelByPosition);
            this.Controls.Add(this.textBoxInsert);
            this.Controls.Add(this.labelTextToInsert);
            this.Controls.Add(this.panelByText);
            this.Controls.Add(this.radioButtonByText);
            this.Controls.Add(this.radioButtonByPosition);
            this.Name = "UserControlCommandInsert";
            this.Size = new System.Drawing.Size(360, 140);
            this.panelByText.ResumeLayout(false);
            this.panelByText.PerformLayout();
            this.panelByPosition.ResumeLayout(false);
            this.panelByPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInsert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonByPosition;
        private System.Windows.Forms.RadioButton radioButtonByText;
        private System.Windows.Forms.RadioButton radioButtonTextBefore;
        private System.Windows.Forms.RadioButton radioButtonTextAfter;
        private System.Windows.Forms.Panel panelByText;
        private System.Windows.Forms.Label labelTextToSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelTextToInsert;
        private System.Windows.Forms.TextBox textBoxInsert;
        private System.Windows.Forms.Panel panelByPosition;
        private System.Windows.Forms.Label labelPositionToInsert;
        private System.Windows.Forms.NumericUpDown numericUpDownInsert;
    }
}
