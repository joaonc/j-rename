using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    /// <summary>
    /// Command interface for the Command Pattern.
    /// Work with full paths to avoid problems.
    /// </summary>
    public interface ICommand
    {
        string Description { get; }
        DirectoryFileName Execute(DirectoryFileName directoryFileName);
    }
}
