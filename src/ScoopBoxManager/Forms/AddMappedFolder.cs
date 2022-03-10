using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoopBox;

namespace ScoopBoxManager.Forms
{
    public partial class AddMappedFolder : Form
    {
        public MappedFolder MappedFolder { get; set; } = null;
        public int ListviewIndex { get; set; } = -1;

        public AddMappedFolder(MappedFolder mappedFolder, int listviewIndex)
        {
            MappedFolder = mappedFolder;
            ListviewIndex = listviewIndex;

            InitializeComponent();
        }

        public AddMappedFolder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Optionally loads the provided mapped folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MappedFolder_Load(object sender, EventArgs e)
        {
            TbSandboxFolder.Text = Variables.SandboxRoot;

            if (MappedFolder == null) return;

            // load linked mapped folder
            TbHostFolder.Text = MappedFolder.HostFolder;
            TbSandboxFolder.Text = MappedFolder.SandboxFolder;
            CbReadOnly.Checked = MappedFolder.ReadOnly == "true";
        }

        /// <summary>
        /// Converts the settings to a MappedFolder object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // get values
            var hostFolder = TbHostFolder.Text.Trim();
            var sandboxFolder = TbSandboxFolder.Text.Trim();
            var ro = CbReadOnly.Checked ? "true" : "false";
            
            // basic checks
            if (string.IsNullOrEmpty(hostFolder))
            {
                MessageBox.Show("Enter a host folder (or doubleclick to select one).", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = TbHostFolder;
                return;
            }

            if (string.IsNullOrEmpty(sandboxFolder))
            {
                MessageBox.Show("Enter a sandbox folder (or doubleclick to select one).", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = TbSandboxFolder;
                return;
            }

            // optionally create new obj
            MappedFolder ??= new MappedFolder();

            // map values
            MappedFolder.HostFolder = hostFolder;
            MappedFolder.SandboxFolder = sandboxFolder;
            MappedFolder.ReadOnly = ro;

            // done!
            DialogResult = DialogResult.OK;
        }

        private void TbHostFolder_DoubleClick(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            dialog.ShowNewFolderButton = true;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            TbHostFolder.Text = dialog.SelectedPath;

            // if sandbox folder starts with root, modify accordinly
            if (!TbSandboxFolder.Text.StartsWith(Variables.SandboxRoot)) return;
            var lastPart = Path.GetFileName(dialog.SelectedPath);
            TbSandboxFolder.Text = $"{Variables.SandboxRoot}\\{lastPart}";
        }

        private void TbHostFolder_TextChanged(object sender, EventArgs e)
        {
            // if sandbox folder starts with root, modify accordinly
            if (!TbSandboxFolder.Text.StartsWith(Variables.SandboxRoot)) return;

            // get the host folder, check for empty
            var hostfolder = TbHostFolder.Text.Trim();
            if (string.IsNullOrEmpty(hostfolder))
            {
                TbSandboxFolder.Text = $"{Variables.SandboxRoot}\\";
                return;
            }

            // set corresponding value
            var lastPart = hostfolder.Split('\\').Last();
            TbSandboxFolder.Text = $"{Variables.SandboxRoot}\\{lastPart}\\";
        }
    }
}
