using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JRenamer
{
    public partial class JRenamerForm : Form
    {
        FilesOperator filesOperator;

        public JRenamerForm()
        {
            InitializeComponent();
        }

        private void FilesForm_Load(object sender, EventArgs e)
        {
            // Files
            filesOperator = new FilesOperator();

            dataGridViewFiles.DataSource = filesOperator.FilesData;
            dataGridViewFiles.AllowUserToAddRows = false;
            dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewFiles.RowHeadersVisible = false;
            dataGridViewFiles.Columns[(int)FilesColumns.Selected].HeaderText = "";
            dataGridViewFiles.Columns[(int)FilesColumns.Selected].ReadOnly = false;
            dataGridViewFiles.Columns[(int)FilesColumns.Selected].Width = 25;
            dataGridViewFiles.Columns[(int)FilesColumns.Selected].Resizable = DataGridViewTriState.False;
            dataGridViewFiles.Columns[(int)FilesColumns.Selected].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewFiles.Columns[(int)FilesColumns.CurrentFileName].ReadOnly = true;
            dataGridViewFiles.Columns[(int)FilesColumns.CurrentFileName].Width = 200;
            dataGridViewFiles.Columns[(int)FilesColumns.NewFileName].ReadOnly = false;
            dataGridViewFiles.Columns[(int)FilesColumns.NewFileName].Width = 200;
            dataGridViewFiles.Columns[(int)FilesColumns.Masked].Visible = false;
            dataGridViewFiles.Columns[(int)FilesColumns.CurrentDirectory].Visible = false;
            dataGridViewFiles.Columns[(int)FilesColumns.NewDirectory].Visible = false;

#if DEBUG
            filesOperator.CurrentDirectory = @"C:\Users\Public\Shared\Documents\Posts";
            filesOperator.CommandAgent.Commands.Add(new CommandInsert(0, "test"));
            filesOperator.CommandAgent.Commands.Add(new CommandInsert(3, "X"));
#else
            files.CurrentDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
#endif
            RefreshDirectory();

            // Commands
            listBoxCommands.DataSource = filesOperator.CommandAgent.Commands;
            listBoxCommands.ClearSelected();
            filesOperator.CommandAgent.PropertyChanged += new PropertyChangedEventHandler(this.Commands_ListChanged);
        }

        private void Commands_ListChanged(object sender, PropertyChangedEventArgs e)
        {
            listBoxCommands.DataSource = null;
            listBoxCommands.DataSource = filesOperator.CommandAgent.Commands;
        }

        /// <summary>
        /// Refreshes the list of directories.
        /// </summary>
        private void RefreshDirectory()
        {
            textBoxCurrentDirectory.Text = filesOperator.CurrentDirectory;

            listBoxDirectory.Items.Clear();
            listBoxDirectory.Items.Add("..");
            listBoxDirectory.Items.AddRange(filesOperator.GetSubDirectories(false));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            contextMenuStripCreate.Show(buttonCreate, 0, buttonCreate.Height);
        }

        private void comboBoxMask_TextChanged(object sender, EventArgs e)
        {
            filesOperator.Mask = comboBoxMask.Text;
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            filesOperator.SelectFilesAll(true);
        }

        private void buttonSelectNone_Click(object sender, EventArgs e)
        {
            filesOperator.SelectFilesAll(false);
        }

        private void buttonSelectInvert_Click(object sender, EventArgs e)
        {
            filesOperator.SelectFilesInvert();
        }

        private void listBoxDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            filesOperator.CurrentDirectory = textBoxCurrentDirectory.Text.TrimEnd('\\') + "\\" + listBoxDirectory.SelectedItem.ToString();
        }

        private void listBoxDirectory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxDirectory.SelectedIndex == 0)
            {
                filesOperator.CurrentDirectory = textBoxCurrentDirectory.Text;
                filesOperator.DirectoryGoUp();
            }
            else
                filesOperator.CurrentDirectory = textBoxCurrentDirectory.Text.TrimEnd('\\') + "\\" + listBoxDirectory.SelectedItem.ToString();

            textBoxCurrentDirectory.Text = filesOperator.CurrentDirectory;
            RefreshDirectory();
        }

        private void checkBoxShowMasked_CheckedChanged(object sender, EventArgs e)
        {
            filesOperator.ShowMaskedFiles = checkBoxShowMasked.Checked;
        }

        private void buttonCommandMoveUp_Click(object sender, EventArgs e)
        {
            if (listBoxCommands.SelectedIndex > 0)
            {
                filesOperator.CommandAgent.MoveUp(listBoxCommands.SelectedIndex);
                listBoxCommands.SelectedIndex = listBoxCommands.SelectedIndex - 1;
            }
        }

        private void buttonCommandMoveDown_Click(object sender, EventArgs e)
        {
            if (listBoxCommands.SelectedIndex >= 0 && listBoxCommands.SelectedIndex < (listBoxCommands.Items.Count - 1))
            {
                filesOperator.CommandAgent.MoveDown(listBoxCommands.SelectedIndex);
                listBoxCommands.SelectedIndex = listBoxCommands.SelectedIndex + 1;
            }
        }

        private void buttonCommandDelete_Click(object sender, EventArgs e)
        {
            filesOperator.CommandAgent.RemoveAt(listBoxCommands.SelectedIndex);
        }

        private void buttonCommandAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandReplace_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandGet_Click(object sender, EventArgs e)
        {

        }

        private void buttonCommandClear_Click(object sender, EventArgs e)
        {
            filesOperator.CommandAgent.Clear();
        }
    }
}
