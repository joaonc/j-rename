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
            this.SuspendLayout();
            // 
            // radioButtonByPosition
            // 
            this.radioButtonByPosition.AutoSize = true;
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
            this.radioButtonByText.Location = new System.Drawing.Point(88, 4);
            this.radioButtonByText.Name = "radioButtonByText";
            this.radioButtonByText.Size = new System.Drawing.Size(61, 17);
            this.radioButtonByText.TabIndex = 1;
            this.radioButtonByText.TabStop = true;
            this.radioButtonByText.Text = "By Text";
            this.radioButtonByText.UseVisualStyleBackColor = true;
            // 
            // UserControlCommandInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonByText);
            this.Controls.Add(this.radioButtonByPosition);
            this.Name = "UserControlCommandInsert";
            this.Size = new System.Drawing.Size(360, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonByPosition;
        private System.Windows.Forms.RadioButton radioButtonByText;
    }
}
