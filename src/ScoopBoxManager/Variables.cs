using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoopBoxManager.Forms;

namespace ScoopBoxManager
{
    internal static class Variables
    {
        /// <summary>
        /// Internal references
        /// </summary>
        internal static Main MainForm { get; set; }

        /// <summary>
        /// Internal variables
        /// </summary>
        internal static string SandboxRoot { get; } = "C:\\Users\\WDAGUtilityAccount\\Desktop";

        /// <summary>
        /// Local IO
        /// </summary>
        internal static string StartupPath { get; } = Path.GetDirectoryName(Application.ExecutablePath);
        internal static string ConfigPath { get; } = Path.Combine(StartupPath, "config");
        internal static string AppSettingsFile { get; } = Path.Combine(ConfigPath, "default_appsettings.json");
    }
}
