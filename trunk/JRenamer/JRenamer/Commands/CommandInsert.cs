﻿using System;
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
        public CommandInsertType CommandInsertType { get; set; }

        public CommandInsert(int startIndex, string value)
        {
            CommandInsertType = CommandInsertType.ByPosition;
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