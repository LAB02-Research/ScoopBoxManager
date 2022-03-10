using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoopBoxManager.Enums;
using ScoopBoxManager.Models;

namespace ScoopBoxManager.Forms
{
    public partial class AddApplication : Form
    {
        public PackageManagerApplication Application { get; set; } = null;
        public int ListviewIndex { get; set; } = -1;

        public AddApplication(PackageManagerApplication application, int listviewIndex)
        {
            Application = application;
            ListviewIndex = listviewIndex;

            InitializeComponent();
        }

        public AddApplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Optionally loads the provided application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Load(object sender, EventArgs e)
        {
            // load enum
            CbPackageManager.DataSource = Enum.GetValues(typeof(PackageManagerType));

            if (Application == null) return;

            // load linked application
            CbPackageManager.Text = Application.PackageManager.ToString();
            TbApplication.Text = Application.Package;
        }

        /// <summary>
        /// Converts the settings to a PackageManagerApplication object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // get values
            var app = TbApplication.Text.Trim();
            var manager = Enum.Parse<PackageManagerType>(CbPackageManager.SelectedValue.ToString() ?? "Scoop");

            // basic checks
            if (string.IsNullOrEmpty(app))
            {
                MessageBox.Show("Enter an application.", "ScoopBoxManager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ActiveControl = TbApplication;
                return;
            }

            // optionally create new obj
            Application ??= new PackageManagerApplication();

            // map values
            Application.Package = app;
            Application.PackageManager = manager;

            // done!
            DialogResult = DialogResult.OK;
        }
    }
}
