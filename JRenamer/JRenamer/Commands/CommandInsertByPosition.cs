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
        private BeginningEnd beginningEnd;

        public CommandInsertByPosition(int startIndex, BeginningEnd beginningEnd, string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new CommandInvalidException("Need text to insert.");
            if (startIndex < 0)
                throw new CommandInvalidException("Start index needs to be 0 or greater.");

            description = string.Format("Insert \"{0}\" at pos {1} from {2}", value, startIndex, beginningEnd == BeginningEnd.Beginning ? "beginning" : "end");
            this.startIndex = startIndex;
            this.beginningEnd = beginningEnd;
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
            int start = startIndex;
            if (beginningEnd == BeginningEnd.End)
                start = directoryFileName.FileName.Length - startIndex;

            return new DirectoryFileName(
                directoryFileName.DirectoryName,
                directoryFileName.FileName.Insert(start, valueInsert));
        }
    }
}
