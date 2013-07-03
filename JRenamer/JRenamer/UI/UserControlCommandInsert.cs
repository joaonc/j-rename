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
        }

        public ICommand GetCommand()
        {
            ICommand command;

            if (radioButtonByPosition.Checked)
            {
                // Insert by position
                command = new CommandInsertByPosition(0, "TXT");
            }
            else
            {
                // Insert by text
                command = new CommandInsertByText("bla", true, "TTT");
            }

            return command;
        }
    }
}
