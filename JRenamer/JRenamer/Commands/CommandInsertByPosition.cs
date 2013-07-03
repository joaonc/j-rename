using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    public class CommandInsertByPosition : ICommand
    {
        private string description;
        private int startIndex;
        private string valueInsert;

        public CommandInsertByPosition(int startIndex, string value)
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

        public DirectoryFileName Execute(DirectoryFileName directoryFileName)
        {
            return new DirectoryFileName(
                directoryFileName.DirectoryName,
                directoryFileName.FileName.Insert(startIndex, valueInsert));
        }
    }
}
