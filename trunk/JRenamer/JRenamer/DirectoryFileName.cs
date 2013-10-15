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
        private string fileName;
        private string directoryName;

        public DirectoryFileName(string directoryName, string fileName)
        {
            DirectoryName = directoryName;
            FileName = fileName;
        }

        public DirectoryFileName(string fileFullName)
        {
            FullName = fileFullName;
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

        public string FileNameWithoutExtension
        {
            get { return Path.GetFileNameWithoutExtension(FileName); }
        }

        public string Extension
        {
            get { return Path.GetExtension(FileName); }
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
                DirectoryName = Path.GetDirectoryName(value);
                FileName = Path.GetFileName(value);
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
