using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files
{
    public partial class JRenamerForm : Form
    {
        FilesOperator files;
        DataTable dtFiles;

        public JRenamerForm()
        {
            InitializeComponent();
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            files = new FilesOperator();

            dtFiles = new DataTable();
            dtFiles.Columns.AddRange(new DataColumn[]
            {
                new DataColumn(" ", typeof(bool)),
                new DataColumn("Filename", typeof(string)),
                new DataColumn("New filename", typeof(string))
            });

            dataGridViewFiles.DataSource = dtFiles;
            dataGridViewFiles.Columns[0].ReadOnly = false;
            dataGridViewFiles.Columns[0].Width = 25;
            dataGridViewFiles.Columns[0].Resizable = DataGridViewTriState.False;
            dataGridViewFiles.Columns[0].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewFiles.Columns[1].ReadOnly = true;
            dataGridViewFiles.Columns[2].ReadOnly = false;
            dataGridViewFiles.AllowUserToAddRows = false;
            dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewFiles.RowHeadersVisible = false;

#if DEBUG
            files.CurrentDirectory = @"C:\Users\Public\Shared\Documents\Posts";
#else
            files.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
#endif
            RefreshDirectory();
        }

        /// <summary>
        /// Refreshes the list of directories.
        /// </summary>
        private void RefreshDirectory()
        {
            textBoxCurrentDirectory.Text = files.CurrentDirectory;

            listBoxDirectory.Items.Clear();
            listBoxDirectory.Items.Add("..");
            listBoxDirectory.Items.AddRange(files.GetDirectories(false));

            RefreshFiles();
        }

        private void RefreshFiles()
        {
            files.Mask = comboBoxMask.Text;
            checkedListBoxFiles.Items.Clear();
            checkedListBoxFiles.Items.AddRange(files.GetFiles(false));

            dtFiles.Rows.Clear();

            foreach (string fileName in files.GetFiles(false))
            {
                dtFiles.Rows.Add(false, fileName, fileName);
            }
        }

        private void SelectFilesAll(bool value)
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                checkedListBoxFiles.SetItemCheckState(i, value ? CheckState.Checked : CheckState.Unchecked);
            }

            foreach (DataRow row in dtFiles.Rows)
                row[0] = value;
        }

        private void SelectFilesInvert()
        {
            for (int i = 0; i < checkedListBoxFiles.Items.Count; i++)
            {
                switch(checkedListBoxFiles.GetItemCheckState(i)) {
                    case CheckState.Checked:
                        checkedListBoxFiles.SetItemCheckState(i, CheckState.Unchecked);
                        break;
                    case CheckState.Unchecked:
                        checkedListBoxFiles.SetItemCheckState(i, CheckState.Checked);
                        break;
                    default:
                        break;  // Leave CheckState.Indeterminate
                }
            }

            foreach (DataRow row in dtFiles.Rows)
            {
                row[0] = !(bool)row[0];
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            contextMenuStripCreate.Show(buttonCreate, 0, buttonCreate.Height);
        }

        private void comboBoxMask_TextChanged(object sender, EventArgs e)
        {
            RefreshFiles();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            SelectFilesAll(true);
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            SelectFilesAll(false);
        }

        private void buttonSelectInvert_Click(object sender, EventArgs e)
        {
            SelectFilesInvert();
        }

        private void listBoxDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            files.CurrentDirectory = textBoxCurrentDirectory.Text.TrimEnd('\\') + "\\" + listBoxDirectory.SelectedItem.ToString();
            RefreshFiles();
        }

        private void listBoxDirectory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDirectory.SelectedIndex == 0)
            {
                files.CurrentDirectory = textBoxCurrentDirectory.Text;
                files.DirectoryGoUp();
            }
            else
                files.CurrentDirectory = textBoxCurrentDirectory.Text.TrimEnd('\\') + "\\" + listBoxDirectory.SelectedItem.ToString();

            textBoxCurrentDirectory.Text = files.CurrentDirectory;
            RefreshDirectory();
            RefreshFiles();
        }
    }
}
