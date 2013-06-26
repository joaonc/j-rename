using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    public class CommandAgent
    {
        private IList<ICommand> commandQueue = new List<ICommand>();

        public IList<ICommand> Commands
        {
            get { return commandQueue; }
            set { commandQueue = value; }
        }
    }
}
