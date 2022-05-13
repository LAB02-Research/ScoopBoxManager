using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;

namespace ScoopBoxManager.Functions
{
    internal static class HelperFunctions
    {
        /// <summary>
        /// Launches the url with the system's default browser
        /// </summary>
        /// <param name="url"></param>
        internal static void LaunchUrl(string url)
        {
            using (_ = Process.Start(new ProcessStartInfo(url) { UseShellExecute = true })) { }
        }
    }
}
