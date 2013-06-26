using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    public class CommandInsert : ICommand
    {
        private string description;
        private int startIndex;
        private string valueInsert;

        public CommandInsert(int startIndex, string value)
        {
            description = string.Format("Insert \"{0}\" at pos {1}", value, startIndex);
            this.startIndex = startIndex;
            valueInsert = value;
        }

        public string Description
        {
            get { return description; }
        }

        public override string ToString()
        {
            return Description;
        }

        public string Execute(string currentName)
        {
            return currentName.Insert(startIndex, valueInsert);
        }
    }
}
