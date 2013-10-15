using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRenamer
{
    public partial class UserControlCommandInsert : UserControl, ICommandFactory
    {
        public UserControlCommandInsert()
        {
            InitializeComponent();

            panelByText.Location = panelByPosition.Location;

            SetPanelTextState();
        }

        public ICommand GetCommand()
        {
            ICommand command;

            if (radioButtonByPosition.Checked)
            {
                // Insert by position
                command = new CommandInsertByPosition((int)numericUpDownInsert.Value, BeginningEnd.Beginning, textBoxInsert.Text);
            }
            else
            {
                // Insert by text
                command = new CommandInsertByText(textBoxSearch.Text, radioButtonTextBefore.Checked, textBoxInsert.Text);
            }

            return command;
        }

        private void radioButtonByText_CheckedChanged(object sender, EventArgs e)
        {
            SetPanelTextState();
        }

        private void SetPanelTextState()
        {
            bool byPosition = radioButtonByPosition.Checked;

            panelByPosition.Visible = byPosition;
            panelByText.Visible = !byPosition;
        }
    }
}
