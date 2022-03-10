using ScoopBoxManager.Forms;

namespace ScoopBoxManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            // prepare application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // set scaling
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

            // go
            Variables.MainForm = new Main();
            Application.Run(Variables.MainForm);
        }
    }
}