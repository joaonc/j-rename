namespace JRenamer
{
    partial class UserControlCommandRemove
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
            this.radioButtonByPosition.CheckedChanged += new System.EventHandler(this.radioButtonByPosition_CheckedChanged);
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
            // UserControlCommandRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonByText);
            this.Controls.Add(this.radioButtonByPosition);
            this.Name = "UserControlCommandRemove";
            this.Size = new System.Drawing.Size(388, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonByPosition;
        private System.Windows.Forms.RadioButton radioButtonByText;
    }
}
