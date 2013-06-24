using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace JRenamer
{
    /// <summary>
    /// Columns for the table that contains information about the files.
    /// The value of the enum corresponds to the column position.
    /// </summary>
    public enum FilesColumns
    {
        Selected = 0,
        Masked,
        CurrentFileName,
        NewFileName,
        CurrentDirectory,
        NewDirectory
    };

    public class FilesOperator
    {
        private string currentDirectory;
        private string mask;
        private bool showMaskedFiles;
        private DataTable dtFiles;

        public EventHandler DataChanged;
        
        public FilesOperator()
        {
            Initiate(null, null);
        }

        public FilesOperator(string directory)
        {
            Initiate(directory, null);
        }

        public FilesOperator(string directory, string mask)
        {
            Initiate(directory, mask);
        }

        private void Initiate(string directory, string mask)
        {
            if (string.IsNullOrEmpty(directory))
                currentDirectory = Directory.GetCurrentDirectory();
            else
                currentDirectory = directory;

            if (string.IsNullOrEmpty(Mask))
                this.mask = "*.*";
            else
                this.mask = mask;

            FilesData = new DataTable();
            FilesData.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Selected", typeof(bool)),
                new DataColumn("Masked", typeof(bool)),
                new DataColumn("Current Filename", typeof(string)),
                new DataColumn("New filename", typeof(string)),
                new DataColumn("Current Directory", typeof(string)),
                new DataColumn("New Directory", typeof(string))
            });

            RefreshFiles();
        }

        public DataTable FilesData
        {
            get { return dtFiles; }
            set { dtFiles = value; }
        }

        public string CurrentDirectory
        {
            get { return currentDirectory; }
            set
            {
                if (!currentDirectory.Equals(value))
                {
                    currentDirectory = value;
                    RefreshFiles();
                }
            }
        }

        public string Mask
        {
            get { return mask; }
            set
            {
                if (!mask.Equals(value))
                {
                    mask = value;
                    RefreshFiles();
                }
            }
        }

        /// <summary>
        /// Gets or sets whether masked files are shown in the DataTable.
        /// A row can be masked out, but still selected. In the end, the processed rows are the selected ones.
        /// </summary>
        public bool ShowMaskedFiles
        {
            get { return showMaskedFiles; }
            set
            {
                if (!showMaskedFiles.Equals(value))
                {
                    showMaskedFiles = value;
                    RefreshFiles();
                }
            }
        }

        private void RefreshFiles()
        {
            FilesData.Rows.Clear();

            DirectoryInfo di = new DirectoryInfo(CurrentDirectory);
            foreach (FileInfo fi in di.GetFiles(Mask))
            {
                FilesData.Rows.Add(true, true, fi.Name, fi.Name, CurrentDirectory, CurrentDirectory);
            }
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

        /// <summary>
        /// Gets the directories under the CurrentDirectory.
        /// </summary>
        /// <param name="fullPath">Whether to return the full directory path (true) or just the directory name (false).</param>
        /// <returns></returns>
        public string[] GetSubDirectories(bool fullPath)
        {
            string[] directories;

            if (fullPath)
                directories = Directory.GetDirectories(currentDirectory);
            else
            {
                List<string> dirs = new List<string>();
                DirectoryInfo di = new DirectoryInfo(CurrentDirectory);
                foreach (DirectoryInfo di2 in di.GetDirectories()   )
                    dirs.Add(di2.Name);

                directories = dirs.ToArray<string>();
            }

            return directories;
        }

        public string[] GetFiles(bool selectedOnly, bool fullPath)
        {
            List<string> files = new List<string>();

            string expression = selectedOnly ? "Selected = " + selectedOnly.ToString() : null;
            foreach(DataRow row in FilesData.Select(expression))
            {
                string fileName = fullPath ? ((string)row[(int)FilesColumns.CurrentDirectory]).TrimEnd('\\') : "";
                fileName += (string)row[(int)FilesColumns.CurrentFileName];

                files.Add(fileName);
            }

            return files.ToArray<string>();
        }

        public void SelectFilesAll(bool value)
        {
            foreach (DataRow row in FilesData.Rows)
                row[(int)FilesColumns.Selected] = value;
        }

        public void SelectFilesInvert()
        {
            foreach (DataRow row in FilesData.Rows)
                row[(int)FilesColumns.Selected] = !(bool)row[0];
        }
    }
}
