using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ScoopBox;
using ScoopBoxManager.Enums;
using ScoopBoxManager.Models;

namespace ScoopBoxManager.Functions
{
    internal static class SettingsManager
    {
        /// <summary>
        /// Stores the current UI-defined settings as the default or as the provided file
        /// </summary>
        [SuppressMessage("ReSharper", "UseObjectOrCollectionInitializer")]
        [SuppressMessage("ReSharper", "AssignNullToNotNullAttribute")]
        internal static AppSettings StoreCurrentSettings(string settingsFile = "")
        {
            return Variables.MainForm.Invoke(delegate
            {
                // prepare new settings object
                var appSettings = new AppSettings();

                // get IO locations
                appSettings.SandboxConfigurationFile = Variables.MainForm.TbSandboxConfigurationFile.Text;
                appSettings.RootfilesDirectoryLocation = Variables.MainForm.TbRootfilesDirectory.Text;
                appSettings.RootfilesDirectoryLocation = Variables.MainForm.TbRootSandboxFilesDirectory.Text;

                // get comboboxes
                appSettings.AudioInput = Enum.Parse<AudioInputOptions>(Variables.MainForm.CbAudioInput.SelectedValue.ToString() ?? "Default");
                appSettings.VideoInput = Enum.Parse<VideoInputOptions>(Variables.MainForm.CbVideoInput.SelectedValue.ToString() ?? "Default");
                appSettings.ProtectedClient = Enum.Parse<ProtectedClientOptions>(Variables.MainForm.CbProtectedClient.SelectedValue.ToString() ?? "Default");
                appSettings.PrinterRedirection = Enum.Parse<PrinterRedirectionOptions>(Variables.MainForm.CbPrinterRedirection.SelectedValue.ToString() ?? "Default");
                appSettings.VGpu = Enum.Parse<VGpuOptions>(Variables.MainForm.CbVgpu.SelectedValue.ToString() ?? "Enabled");
                appSettings.Networking = Enum.Parse<NetworkingOptions>(Variables.MainForm.CbNetworking.SelectedValue.ToString() ?? "Default");
                appSettings.ClipboardRedirection = Enum.Parse<ClipboardRedirectionOptions>(Variables.MainForm.CbClipboardRedirection.SelectedValue.ToString() ?? "Default");

                // get memory
                appSettings.MemoryMb = (int)Variables.MainForm.NumMemory.Value;

                // get mapped folders
                foreach (ListViewItem mappedFolderItem in Variables.MainForm.LvMappedFolders.Items)
                {
                    var mappedFolder = new MappedFolder
                    {
                        HostFolder = mappedFolderItem.Text,
                        SandboxFolder = mappedFolderItem.SubItems[1].Text,
                        ReadOnly = mappedFolderItem.SubItems[2].Text
                    };

                    appSettings.MappedFolders.Add(mappedFolder);
                }

                // get apps
                foreach (ListViewItem appItem in Variables.MainForm.LvApplications.Items)
                {
                    var app = new PackageManagerApplication
                    {
                        Package = appItem.Text,
                        PackageManager = Enum.Parse<PackageManagerType>(appItem.SubItems[1].Text)
                    };

                    appSettings.Applications.Add(app);
                }

                // prepare filename
                if (string.IsNullOrEmpty(settingsFile)) settingsFile = Variables.AppSettingsFile;

                // check directory
                var fileDir = Path.GetDirectoryName(settingsFile);
                if (!Directory.Exists(fileDir)) Directory.CreateDirectory(fileDir);

                // serialize obj
                var appSettingsStr = JsonConvert.SerializeObject(appSettings, Formatting.Indented);

                // store
                File.WriteAllText(settingsFile, appSettingsStr);

                // done
                return appSettings;
            });
        }

        /// <summary>
        /// Loads the last known configuration from disk
        /// </summary>
        internal static void LoadSettings() => LoadSettings("");

        /// <summary>
        /// Loads the provided configuration from disk
        /// </summary>
        internal static void LoadSettings(string settingsFile)
        {
            if (string.IsNullOrEmpty(settingsFile)) settingsFile = Variables.AppSettingsFile;
            
            // check file exists
            if (!File.Exists(settingsFile)) return;

            // file found, load em up
            var appSettingsStr = File.ReadAllText(settingsFile);
            if (string.IsNullOrEmpty(appSettingsStr)) return;

            // try to parse
            var appSettings = JsonConvert.DeserializeObject<AppSettings>(appSettingsStr);
            if (appSettings == null)
            {
                if (settingsFile == Variables.AppSettingsFile) Variables.MainForm.Invoke(delegate { MessageBox.Show("The last stored appsettings can't be deserialized!", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                else Variables.MainForm.Invoke(delegate { MessageBox.Show("The stored appsettings can't be deserialized!", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Error); });
                return;
            }

            // all good, print to gui
            InterfaceManager.ShowAppSettings(appSettings);
        }
    }
}
