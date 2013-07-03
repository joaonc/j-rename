using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRenamer
{
    /// <summary>
    /// Helper class to manipulate Directory and File names separately.
    /// </summary>
    public class DirectoryFileName
    {
        public static string[] GetDirectoryAndFileName(string fileFullName)
        {
            return new string[] 
            {
                Path.GetFullPath(fileFullName),
                Path.GetFileName(fileFullName)
            };
        }

        private string fileName;
        private string directoryName;

        public DirectoryFileName(string directoryName, string fileName)
        {
            DirectoryName = directoryName;
            FileName = fileName;
        }

        public DirectoryFileName(string fileFullName)
        {
            string[] directoryAndFileName = GetDirectoryAndFileName(fileFullName);
            DirectoryName = directoryAndFileName[0];
            FileName = directoryAndFileName[1];
        }

        public string FileName
        {
            get { return fileName; }
            set
            {
                FileInfo fi = new FileInfo(value);  // making sure the filename is valid
                fileName = value;
            }
        }

        public string DirectoryName
        {
            get { return directoryName; }
            set { directoryName = value.TrimEnd('\\', ' '); }
        }

        public string FullName
        {
            get
            {
                return DirectoryName + '\\' + FileName;
            }
            set
            {
                string[] fileFullName = GetDirectoryAndFileName(value);
                DirectoryName = fileFullName[0];
                FileName = fileFullName[1];
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return ((DirectoryFileName)obj).DirectoryName.Equals(this.DirectoryName) &&
                ((DirectoryFileName)obj).FileName.Equals(this.FileName);
        }

        public override int GetHashCode()
        {
            return FileName.GetHashCode() ^ DirectoryName.GetHashCode();
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
