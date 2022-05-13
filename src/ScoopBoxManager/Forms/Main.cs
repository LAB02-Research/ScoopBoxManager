using Newtonsoft.Json;
using ScoopBox;
using ScoopBoxManager.Enums;
using ScoopBoxManager.Functions;
using ScoopBoxManager.Models;

namespace ScoopBoxManager.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starting point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            // load enums
            CbAudioInput.DataSource = Enum.GetValues(typeof(AudioInputOptions));
            CbVideoInput.DataSource = Enum.GetValues(typeof(VideoInputOptions));
            CbProtectedClient.DataSource = Enum.GetValues(typeof(ProtectedClientOptions));
            CbPrinterRedirection.DataSource = Enum.GetValues(typeof(PrinterRedirectionOptions));
            CbVgpu.DataSource = Enum.GetValues(typeof(VGpuOptions));
            CbNetworking.DataSource = Enum.GetValues(typeof(NetworkingOptions));
            CbClipboardRedirection.DataSource = Enum.GetValues(typeof(ClipboardRedirectionOptions));

            // set defaults
            CbAudioInput.Text = "Default";
            CbVideoInput.Text = "Default";
            CbProtectedClient.Text = "Default";
            CbPrinterRedirection.Text = "Default";
            CbVgpu.Text = "Enabled";
            CbNetworking.Text = "Default";
            CbClipboardRedirection.Text = "Default";

            // load last-stored settings (if any)
            Task.Run(SettingsManager.LoadSettings);
        }
        
        /// <summary>
        /// Opens the ScoopBox URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblScoopBox_Click(object sender, EventArgs e) => HelperFunctions.LaunchUrl("https://github.com/hasan-hasanov/ScoopBox");

        /// <summary>
        /// Saves the current settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Do you want to save it as the default settings?\r\n\r\nClick 'no' to provide a custom filename.", "ScoopBoxManager", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (q != DialogResult.Yes && q != DialogResult.No) return;

            if (q == DialogResult.Yes)
            {
                // store as default
                SettingsManager.StoreCurrentSettings();
                InterfaceManager.ShowSettingsStored();
                return;
            }

            // let the user pick a filename
            if (!Directory.Exists(Variables.ConfigPath)) Directory.CreateDirectory(Variables.ConfigPath);

            using var dialog = new OpenFileDialog();

            dialog.CheckFileExists = false;
            dialog.Multiselect = false;
            dialog.InitialDirectory = Variables.ConfigPath;
            dialog.DefaultExt = "json";
            dialog.Filter = "JSON files (*.json)|*.json";

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            // force .json
            var filename = dialog.FileName;
            if (!filename.ToLower().EndsWith("json")) filename = $"{filename}.json";

            // store settings
            SettingsManager.StoreCurrentSettings(dialog.FileName);

            // done
            InterfaceManager.ShowSettingsStored();
        }

        /// <summary>
        /// Loads the selected settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoadSettings_Click(object sender, EventArgs e)
        {
            // let the user pick a filename
            if (!Directory.Exists(Variables.ConfigPath)) Directory.CreateDirectory(Variables.ConfigPath);

            using var dialog = new OpenFileDialog();

            dialog.CheckFileExists = true;
            dialog.Multiselect = false;
            dialog.InitialDirectory = Variables.ConfigPath;
            dialog.DefaultExt = "json";
            dialog.Filter = "JSON files (*.json)|*.json";

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            // force .json
            var filename = dialog.FileName;
            if (!filename.ToLower().EndsWith("json"))
            {
                MessageBox.Show("Only .json files are supported.", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // load settings
            SettingsManager.LoadSettings(filename);

            // done
            InterfaceManager.ShowSettingsLoaded();
        }

        /// <summary>
        /// Stores the current configuration, and launches a new sandbox with them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnLaunch_Click(object sender, EventArgs e)
        {
            BtnLaunch.Text = "LAUNCHING ..";

            // lock ui
            InterfaceManager.LockUi();

            try
            {
                // store current settings and get the appSettings object
                var appSettings = SettingsManager.StoreCurrentSettings();

                // prepare options
                var options = appSettings.ConvertToScoopBoxOptions();
                
                // prepare chocolatey packages
                var choco = appSettings.ConvertToChocolateyPackageManagerScript();

                // prepare scoop packages
                var scoop = appSettings.ConvertToScoopPackageManagerScript();

                // check for conflicting settings
                if (choco != null && scoop != null && options.Networking == NetworkingOptions.Disable && (choco.Applications.Any() || scoop.Applications.Any()))
                {
                    // without networking, no packages will get downloaded ..
                    var q = MessageBox.Show("You've disabled networking, but added packages. They won't be able to download.\r\n\r\nAre you sure you want to continue?", "ScoopBoxManager", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (q != DialogResult.Yes) return;
                }

                // prepare sandbox
                ISandboxConfigurationBuilder configurationBuilder = new SandboxConfigurationBuilder(options);
                var sandbox = new Sandbox(options, configurationBuilder);

                // launch according to packages
                if (choco == null && scoop == null)
                {
                    // scoopbox will get pissed if we don't provide at lease one script :(
                    await sandbox.Run(new ScoopPackageManagerScript(new List<string> { "curl" }));
                }

                // both choco & scoop
                else if (choco != null && scoop != null)
                {
                    await sandbox.Run(new List<IScript> { choco, scoop });
                }

                // only choco
                else if (choco != null) await sandbox.Run(new List<IScript> { choco });

                // only scoop
                else await sandbox.Run(new List<IScript> { scoop });

                // it's launching
                BtnLaunch.Text = "LAUNCHED!";
                BtnLaunch.ForeColor = Color.GreenYellow;

                // wait 3 sec so user won't spam
                await Task.Delay(TimeSpan.FromSeconds(3));
            }
            catch (Exception ex)
            {
                // show error
                MessageBox.Show($"Something went wrong while trying to launch your sandbox:\r\n\r\n{ex.Message}", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // unlock ui
                InterfaceManager.UnlockUi();

                // done
                BtnLaunch.ForeColor = Color.White;
                BtnLaunch.Text = "LAUNCH SANDBOX";
            }
        }

        /// <summary>
        /// Lets the user select a root files directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbRootfilesDirectory_DoubleClick(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            dialog.ShowNewFolderButton = true;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            TbRootfilesDirectory.Text = dialog.SelectedPath;
        }

        /// <summary>
        /// Lets the user select a rootdirectory for the sandbox files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbRootSandboxFilesDirectory_DoubleClick(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();

            dialog.ShowNewFolderButton = true;
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            TbRootSandboxFilesDirectory.Text = dialog.SelectedPath;
        }

        /// <summary>
        /// Lets the user select a sandbox configuration file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbSandboxConfigurationFile_DoubleClick(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog();

            dialog.CheckFileExists = true;
            dialog.Multiselect = false;

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            TbSandboxConfigurationFile.Text = dialog.FileName;
        }

        /// <summary>
        /// Opens a 'add mapped folder' window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddMappedFolder_Click(object sender, EventArgs e) => ProcessAddMappedFolder();

        /// <summary>
        /// Removes the selected mapped folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveMappedFolder_Click(object sender, EventArgs e)
        {
            if (LvMappedFolders.SelectedItems.Count == 0) return;
            LvMappedFolders.Items[LvMappedFolders.SelectedItems[0].Index].Remove();
        }

        /// <summary>
        /// Opens a 'add application' window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddApplication_Click(object sender, EventArgs e) => ProcessAddApplication();

        /// <summary>
        /// Removes the selected application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRemoveApplication_Click(object sender, EventArgs e)
        {
            if (LvApplications.SelectedItems.Count == 0) return;
            LvApplications.Items[LvApplications.SelectedItems[0].Index].Remove();
        }

        /// <summary>
        /// Opens the selected mapped folder for updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LvMappedFolders_DoubleClick(object sender, EventArgs e)
        {
            if (LvMappedFolders.SelectedItems.Count == 0) return;
            var index = LvMappedFolders.SelectedItems[0].Index;

            // prepare the mapped folder
            var mappedFolder = new MappedFolder
            {
                HostFolder = LvMappedFolders.SelectedItems[0].Text,
                SandboxFolder = LvMappedFolders.SelectedItems[0].SubItems[1].Text,
                ReadOnly = LvMappedFolders.SelectedItems[0].SubItems[2].Text
            };

            // open for update
            ProcessAddMappedFolder(mappedFolder, index);
        }

        /// <summary>
        /// Opens the selected application for updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LvApplications_DoubleClick(object sender, EventArgs e)
        {
            if (LvApplications.SelectedItems.Count == 0) return;
            var index = LvApplications.SelectedItems[0].Index;

            // prepare the application
            var app = new PackageManagerApplication
            {
                Package = LvApplications.SelectedItems[0].Text,
                PackageManager = Enum.Parse<PackageManagerType>(LvApplications.SelectedItems[0].SubItems[1].Text ?? "Scoop")
            };

            // open for update
            ProcessAddApplication(app, index);
        }

        /// <summary>
        /// Lets the user add or update a mapped folder
        /// </summary>
        /// <param name="currentMappedFolder"></param>
        /// <param name="listviewIndex"></param>
        private void ProcessAddMappedFolder(MappedFolder currentMappedFolder = null, int listviewIndex = -1)
        {
            // show the add mapped folder dialog
            using var addMapped = new AddMappedFolder(currentMappedFolder, listviewIndex);
            var result = addMapped.ShowDialog();
            if (result != DialogResult.OK) return;

            var mappedFolder = addMapped.MappedFolder;

            // are we updating?
            if (currentMappedFolder != null)
            {
                // jep, set new values
                LvMappedFolders.Items[listviewIndex].Text = mappedFolder.HostFolder;
                LvMappedFolders.Items[listviewIndex].SubItems[1].Text = mappedFolder.SandboxFolder;
                LvMappedFolders.Items[listviewIndex].SubItems[2].Text = mappedFolder.ReadOnly;
                LvMappedFolders.Refresh();
                return;
            }

            // prepare new listview item
            var mappedItem = new ListViewItem(mappedFolder.HostFolder);
            mappedItem.SubItems.Add(mappedFolder.SandboxFolder);
            mappedItem.SubItems.Add(mappedFolder.ReadOnly);

            // add to the list
            LvMappedFolders.Items.Add(mappedItem);
        }

        /// <summary>
        /// Lets the user add or update an application
        /// </summary>
        /// <param name="currentApplication"></param>
        /// <param name="listviewIndex"></param>
        private void ProcessAddApplication(PackageManagerApplication currentApplication = null, int listviewIndex = -1)
        {
            // show the add application folder dialog
            using var addApplication = new AddApplication(currentApplication, listviewIndex);
            var result = addApplication.ShowDialog();
            if (result != DialogResult.OK) return;

            var app = addApplication.Application;

            // are we updating?
            if (currentApplication != null)
            {
                // jep, set new values
                LvApplications.Items[listviewIndex].Text = app.Package;
                LvApplications.Items[listviewIndex].SubItems[1].Text = app.PackageManager.ToString();
                LvApplications.Refresh();
                return;
            }

            // nope, prepare new listview item
            var appItem = new ListViewItem(app.Package);
            appItem.SubItems.Add(app.PackageManager.ToString());

            // add to the list
            LvApplications.Items.Add(appItem);

        }
    }
}