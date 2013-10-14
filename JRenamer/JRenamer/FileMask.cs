using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JRenamer
{
    /// <summary>
    /// Helps with masking files
    /// </summary>
    public class FileMaskList : List<string>
    {
        public bool FitsMask(string fileName, bool ignoreCase)
        {
            string fileMask = "TEMP to compile";
            string pattern =
                    '^' +
                    Regex.Escape(fileMask.Replace(".", "__DOT__")
                                    .Replace("*", "__STAR__")
                                    .Replace("?", "__QM__"))
                        .Replace("__DOT__", "[.]")
                        .Replace("__STAR__", ".*")
                        .Replace("__QM__", ".")
                    + '$';
            return new Regex(pattern, ignoreCase ? RegexOptions.IgnoreCase : RegexOptions.None).IsMatch(fileName);
        }
    }
}
