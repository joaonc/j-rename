using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;

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

    public enum FileName
    {
        Current,
        New
    };

    public class FilesOperator
    {
        private string currentDirectory;
        private List<string> mask;
        private bool showMaskedFiles;
        private DataTable dtFiles;
        private CommandAgent commandAgent;

        public FilesOperator()
        {
            Initialize(null, null);
        }

        public FilesOperator(string directory)
        {
            Initialize(directory, null);
        }

        public FilesOperator(string directory, params string[] mask)
        {
            Initialize(directory, mask);
        }

        private void Initialize(string directory, params string[] mask)
        {
            if (string.IsNullOrEmpty(directory))
                currentDirectory = Directory.GetCurrentDirectory();
            else
                currentDirectory = directory;

            if (mask == null || mask.Length == 0)
            {
                this.mask = new List<string>();
                this.mask.Add("*.*");
            }
            else
                this.mask = mask.ToList<string>();

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

            commandAgent = new CommandAgent();
            commandAgent.PropertyChanged += new PropertyChangedEventHandler(this.Commands_ListChanged);

            RefreshFiles();
        }

        public DataTable FilesData
        {
            get { return dtFiles; }
            set { dtFiles = value; }
        }

        public CommandAgent CommandAgent
        {
            get { return commandAgent; }
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

        /// <summary>
        /// File mask. It's a list that can hold multiple masks.
        /// </summary>
        public List<string> Mask
        {
            get { return mask; }
            set
            {
                mask = value;
                RefreshFiles();
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
            foreach (string fileMask in Mask)
            {
                foreach (FileInfo fi in di.GetFiles(fileMask))
                {
                    FilesData.Rows.Add(true, true, fi.Name, null, CurrentDirectory, null);
                }
            }
        }

        public DirectoryFileName GetDirectoryFileName(int pos, FileName fileNameType)
        {
            if (pos < 0 || pos >= FilesData.Rows.Count)
                throw new Exception(string.Format("Position not in range: {0}", pos));

            return GetDirectoryFileName(FilesData.Rows[pos], fileNameType);
        }

        private DirectoryFileName GetDirectoryFileName(DataRow row, FileName fileNameType)
        {
            int colIndexFileName = (fileNameType == FileName.Current) ? (int)FilesColumns.CurrentFileName : (int)FilesColumns.NewFileName;
            int colIndexDirectory = (fileNameType == FileName.Current) ? (int)FilesColumns.CurrentDirectory : (int)FilesColumns.NewDirectory;

            return new DirectoryFileName((string)row[colIndexDirectory], (string)row[colIndexFileName]);
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

        private void Commands_ListChanged(object sender, PropertyChangedEventArgs e)
        {
            foreach(DataRow row in FilesData.Rows)
            {
                try
                {
                    DirectoryFileName newDirectoryFileName = CommandAgent.Execute(GetDirectoryFileName(row, FileName.Current));
                    row[(int)FilesColumns.NewFileName] = newDirectoryFileName.FileName;
                    row[(int)FilesColumns.NewDirectory] = newDirectoryFileName.DirectoryName;
                }
                catch
                {
                    row[(int)FilesColumns.NewFileName] = null;
                    row[(int)FilesColumns.NewDirectory] = null;
                }
            }
        }
    }
}
