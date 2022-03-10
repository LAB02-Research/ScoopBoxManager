using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoopBox;
using ScoopBoxManager.Enums;

namespace ScoopBoxManager.Models
{
    public static class AppSettingsExtensions
    {
        /// <summary>
        /// Converts the AppSettings to a ScoopBox Options object
        /// </summary>
        /// <param name="appSettings"></param>
        /// <returns></returns>
        public static IOptions ConvertToScoopBoxOptions(this AppSettings appSettings)
        {
            // set basic options
            var options = new Options
            {
                AudioInput = appSettings.AudioInput,
                VideoInput = appSettings.VideoInput,
                ProtectedClient = appSettings.ProtectedClient,
                PrinterRedirection = appSettings.PrinterRedirection,
                ClipboardRedirection = appSettings.ClipboardRedirection,
                MemoryInMB = appSettings.MemoryMb,
                Networking = appSettings.Networking,
                VGpu = appSettings.VGpu,
            };

            // set optional paths
            if (!string.IsNullOrEmpty(appSettings.SandboxConfigurationFile)) options.SandboxConfigurationFileName = appSettings.SandboxConfigurationFile;
            if (!string.IsNullOrEmpty(appSettings.RootfilesDirectoryLocation)) options.RootFilesDirectoryLocation = appSettings.RootfilesDirectoryLocation;
            if (!string.IsNullOrEmpty(appSettings.RootSandboxFilesDirectoryLocation)) options.RootSandboxFilesDirectoryLocation = appSettings.RootSandboxFilesDirectoryLocation;

            // set mapped folders
            if (appSettings.MappedFolders.Any()) options.UserMappedDirectories = appSettings.MappedFolders;

            // done
            return options;
        }

        /// <summary>
        /// Converts the AppSettings to a ChocolateyPackageManagerScript
        /// </summary>
        /// <param name="appSettings"></param>
        /// <returns></returns>
        public static ChocolateyPackageManagerScript ConvertToChocolateyPackageManagerScript(this AppSettings appSettings)
        {
            var appList = appSettings.Applications.Where(x => x.PackageManager == PackageManagerType.Chocolatey).Select(app => app.Package).ToList();
            return !appList.Any() ? null : new ChocolateyPackageManagerScript(appList);
        }

        /// <summary>
        /// Converts the AppSettings to a ScoopPackageManagerScript
        /// </summary>
        /// <param name="appSettings"></param>
        /// <returns></returns>
        public static ScoopPackageManagerScript ConvertToScoopPackageManagerScript(this AppSettings appSettings)
        {
            var appList = appSettings.Applications.Where(x => x.PackageManager == PackageManagerType.Scoop).Select(app => app.Package).ToList();
            return !appList.Any() ? null : new ScoopPackageManagerScript(appList);
        }
    }

    public class AppSettings
    {
        public AppSettings()
        {
            //
        }

        public string SandboxConfigurationFile { get; set; } = null;
        public string RootfilesDirectoryLocation { get; set; } = null;
        public string RootSandboxFilesDirectoryLocation { get; set; } = null;
        public AudioInputOptions AudioInput { get; set; } = AudioInputOptions.Default;
        public VideoInputOptions VideoInput { get; set; } = VideoInputOptions.Default;
        public ProtectedClientOptions ProtectedClient { get; set; } = ProtectedClientOptions.Default;
        public PrinterRedirectionOptions PrinterRedirection { get; set; } = PrinterRedirectionOptions.Default;
        public VGpuOptions VGpu { get; set; } = VGpuOptions.Enabled;
        public int MemoryMb { get; set; } = 0;
        public NetworkingOptions Networking { get; set; } = NetworkingOptions.Default;
        public ClipboardRedirectionOptions ClipboardRedirection { get; set; } = ClipboardRedirectionOptions.Default;

        public List<MappedFolder> MappedFolders { get; set; } = new();
        public List<PackageManagerApplication> Applications { get; set; } = new();
    }
}
