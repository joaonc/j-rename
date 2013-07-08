using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    class CommandInvalidException : Exception
    {
        public CommandInvalidException(string message) : base(message) { }
    }
}
