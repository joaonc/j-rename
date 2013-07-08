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
            if (string.IsNullOrEmpty(value))
                throw new CommandInvalidException("Need text to insert.");
            if (startIndex < 0)
                throw new CommandInvalidException("Start index needs to be 0 or greater.");

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
