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
    public partial class UserControlCommandRemove : UserControl, ICommandFactory
    {
        public UserControlCommandRemove()
        {
            InitializeComponent();
        }

        public ICommand GetCommand()
        {
            return null;
        }
    }
}
