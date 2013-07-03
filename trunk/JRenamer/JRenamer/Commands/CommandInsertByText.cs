using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    class CommandInsertByText : ICommand
    {
        private string description;
        private string atText;
        private bool before;
        private string valueInsert;

        public CommandInsertByText(string atText, bool before, string value)
        {
            description = string.Format("Insert \"{0}\" {1} text {2}", value, before ? "before" : "after", atText);
            this.atText = atText;
            this.before = before;
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
            int startIndex = directoryFileName.FileName.IndexOf(atText);

            if (!before)
                startIndex++;

            return new DirectoryFileName(
                directoryFileName.DirectoryName,
                directoryFileName.FileName.Insert(startIndex, valueInsert));
        }
    }
}
