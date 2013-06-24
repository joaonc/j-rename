using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Files
{
    public enum FilesColumns
    {
        Selected = 0,
        CurrentFileName,
        NewFileName
    };

    public class FilesOperator
    {
        private string currentDirectory;
        private string mask;
        private DataTable dtFiles;
        
        public FilesOperator()
        {
            Initiate();
        }

        public FilesOperator(string directory)
        {
            CurrentDirectory = directory;
            Initiate();
        }

        public FilesOperator(string directory, string mask)
        {
            CurrentDirectory = directory;
            Mask = mask;
            Initiate();
        }

        private void Initiate()
        {
            if (string.IsNullOrEmpty(CurrentDirectory))
                CurrentDirectory = Directory.GetCurrentDirectory();

            if (string.IsNullOrEmpty(Mask))
                Mask = "*.*";

            FilesData = new DataTable();
            FilesData.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(" ", typeof(bool)),
                new DataColumn("Filename", typeof(string)),
                new DataColumn("New filename", typeof(string))
            });
        }

        public DataTable FilesData
        {
            get { return dtFiles; }
            set { dtFiles = value; }
        }

        public string CurrentDirectory
        {
            get { return currentDirectory; }
            set { currentDirectory = value; }
        }

        public string Mask
        {
            get { return mask; }
            set { mask = value; }
        }

        /// <summary>
        /// Goes up one directory level.
        /// </summary>
        /// <returns>The new directory path.</returns>
        public string DirectoryGoUp()
        {
            CurrentDirectory = new DirectoryInfo(CurrentDirectory).Parent.FullName;

            return CurrentDirectory;
        }

        public string DirectoryGoDown(string directoryName)
        {
            DirectoryInfo di = new DirectoryInfo(CurrentDirectory.TrimEnd('\\') + '\\' + directoryName);
            
            if (!di.Exists)
                throw new DirectoryNotFoundException(di.FullName);
            
            CurrentDirectory = di.FullName;

            return CurrentDirectory;
        }

        public string[] GetDirectories(bool fullPath)
        {
            string[] directories;

            if (fullPath)
                directories = Directory.GetDirectories(currentDirectory);
            else
            {
                List<string> dirs = new List<string>();
                DirectoryInfo di = new DirectoryInfo(CurrentDirectory);
                foreach (DirectoryInfo di2 in di.GetDirectories()   )
                {
                    dirs.Add(di2.Name);
                }

                directories = dirs.ToArray<string>();
            }

            return directories;
        }

        public string[] GetFiles(bool fullPath)
        {
            List<string> files = new List<string>();
            DirectoryInfo di = new DirectoryInfo(CurrentDirectory);
            foreach (FileInfo fi in di.GetFiles(Mask))
            {
                files.Add(fullPath ? fi.FullName : fi.Name);
            }

            return files.ToArray<string>();
        }
    }
}
