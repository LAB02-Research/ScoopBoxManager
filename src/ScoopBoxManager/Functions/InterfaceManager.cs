using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoopBoxManager.Models;

namespace ScoopBoxManager.Functions
{
    internal static class InterfaceManager
    {
        /// <summary>
        /// Shows the provided AppSettings in the GUI
        /// </summary>
        /// <param name="appSettings"></param>
        internal static void ShowAppSettings(AppSettings appSettings)
        {
            Variables.MainForm.Invoke(delegate
            {
                // set IO locations
                Variables.MainForm.TbSandboxConfigurationFile.Text = appSettings.SandboxConfigurationFile;
                Variables.MainForm.TbRootfilesDirectory.Text = appSettings.RootfilesDirectoryLocation;
                Variables.MainForm.TbRootSandboxFilesDirectory.Text = appSettings.RootfilesDirectoryLocation;

                // set comboboxes
                Variables.MainForm.CbAudioInput.Text = appSettings.AudioInput.ToString();
                Variables.MainForm.CbVideoInput.Text = appSettings.VideoInput.ToString();
                Variables.MainForm.CbProtectedClient.Text = appSettings.ProtectedClient.ToString();
                Variables.MainForm.CbPrinterRedirection.Text = appSettings.PrinterRedirection.ToString();
                Variables.MainForm.CbVgpu.Text = appSettings.VGpu.ToString();
                Variables.MainForm.CbNetworking.Text = appSettings.Networking.ToString();
                Variables.MainForm.CbClipboardRedirection.Text = appSettings.ClipboardRedirection.ToString();

                // set memory
                Variables.MainForm.NumMemory.Value = appSettings.MemoryMb;

                // set mapped folders
                Variables.MainForm.LvMappedFolders.BeginUpdate();
                foreach (var mappedFolder in appSettings.MappedFolders)
                {
                    var mappedFolderItem = new ListViewItem(mappedFolder.HostFolder);
                    mappedFolderItem.SubItems.Add(mappedFolder.SandboxFolder);
                    mappedFolderItem.SubItems.Add(mappedFolder.ReadOnly);

                    Variables.MainForm.LvMappedFolders.Items.Add(mappedFolderItem);
                }
                Variables.MainForm.LvMappedFolders.EndUpdate();

                // set apps
                Variables.MainForm.LvApplications.BeginUpdate();
                foreach (var app in appSettings.Applications)
                {
                    var appItem = new ListViewItem(app.Package);
                    appItem.SubItems.Add(app.PackageManager.ToString());

                    Variables.MainForm.LvApplications.Items.Add(appItem);
                }
                Variables.MainForm.LvApplications.EndUpdate();

                // done
            });
        }

        /// <summary>
        /// Sets all interface elements enabled to false
        /// </summary>
        internal static void LockUi()
        {
            Variables.MainForm.Invoke(delegate
            {
                foreach (var textBox in Variables.MainForm.Controls.OfType<TextBox>()) textBox.Enabled = false;
                foreach (var button in Variables.MainForm.Controls.OfType<Button>()) button.Enabled = false;
                foreach (var comboBox in Variables.MainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = false;
                foreach (var numericUpDown in Variables.MainForm.Controls.OfType<NumericUpDown>()) numericUpDown.Enabled = false;
                foreach (var listView in Variables.MainForm.Controls.OfType<ListView>()) listView.Enabled = false;
            });
        }

        /// <summary>
        /// Sets all interface elements enabled to true
        /// </summary>
        internal static void UnlockUi()
        {
            Variables.MainForm.Invoke(delegate
            {
                foreach (var textBox in Variables.MainForm.Controls.OfType<TextBox>()) textBox.Enabled = true;
                foreach (var button in Variables.MainForm.Controls.OfType<Button>()) button.Enabled = true;
                foreach (var comboBox in Variables.MainForm.Controls.OfType<ComboBox>()) comboBox.Enabled = true;
                foreach (var numericUpDown in Variables.MainForm.Controls.OfType<NumericUpDown>()) numericUpDown.Enabled = true;
                foreach (var listView in Variables.MainForm.Controls.OfType<ListView>()) listView.Enabled = true;
            });
        }

        /// <summary>
        /// Shows 'settings stored' for three seconds
        /// </summary>
        internal static void ShowSettingsStored()
        {
            Variables.MainForm.Invoke(async delegate
            {
                Variables.MainForm.LblSettingsStored.Visible = true;
                await Task.Delay(TimeSpan.FromSeconds(3));
                Variables.MainForm.LblSettingsStored.Visible = false;
            });
        }

        /// <summary>
        /// Shows 'settings loaded' for three seconds
        /// </summary>
        internal static void ShowSettingsLoaded()
        {
            Variables.MainForm.Invoke(async delegate
            {
                Variables.MainForm.LblSettingsLoaded.Visible = true;
                await Task.Delay(TimeSpan.FromSeconds(3));
                Variables.MainForm.LblSettingsLoaded.Visible = false;
            });
        }
    }
}
