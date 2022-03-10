namespace ScoopBoxManager.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnLaunch = new System.Windows.Forms.Button();
            this.GpGeneralConfig = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NumMemory = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.CbVgpu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbClipboardRedirection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbPrinterRedirection = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbProtectedClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CbNetworking = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbVideoInput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbAudioInput = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbRootSandboxFilesDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbRootfilesDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSandboxConfigurationFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GpMappedFolders = new System.Windows.Forms.GroupBox();
            this.BtnRemoveMappedFolder = new System.Windows.Forms.Button();
            this.BtnAddMappedFolder = new System.Windows.Forms.Button();
            this.LvMappedFolders = new System.Windows.Forms.ListView();
            this.ClmHostFolder = new System.Windows.Forms.ColumnHeader();
            this.ClmSandboxFolder = new System.Windows.Forms.ColumnHeader();
            this.ClmReadonly = new System.Windows.Forms.ColumnHeader();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoveApplication = new System.Windows.Forms.Button();
            this.BtnAddApplication = new System.Windows.Forms.Button();
            this.LvApplications = new System.Windows.Forms.ListView();
            this.ClmApplication = new System.Windows.Forms.ColumnHeader();
            this.ClmPackageManager = new System.Windows.Forms.ColumnHeader();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnSaveSettings = new System.Windows.Forms.Button();
            this.BtnLoadSettings = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LblScoopBox = new System.Windows.Forms.Label();
            this.LblSettingsStored = new System.Windows.Forms.Label();
            this.LblSettingsLoaded = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.GpGeneralConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemory)).BeginInit();
            this.GpMappedFolders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLaunch
            // 
            this.BtnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLaunch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLaunch.Location = new System.Drawing.Point(713, 534);
            this.BtnLaunch.Name = "BtnLaunch";
            this.BtnLaunch.Size = new System.Drawing.Size(330, 55);
            this.BtnLaunch.TabIndex = 8;
            this.BtnLaunch.Text = "LAUNCH SANDBOX";
            this.BtnLaunch.UseVisualStyleBackColor = true;
            this.BtnLaunch.Click += new System.EventHandler(this.BtnLaunch_Click);
            // 
            // GpGeneralConfig
            // 
            this.GpGeneralConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.GpGeneralConfig.Controls.Add(this.label12);
            this.GpGeneralConfig.Controls.Add(this.NumMemory);
            this.GpGeneralConfig.Controls.Add(this.label11);
            this.GpGeneralConfig.Controls.Add(this.CbVgpu);
            this.GpGeneralConfig.Controls.Add(this.label10);
            this.GpGeneralConfig.Controls.Add(this.CbClipboardRedirection);
            this.GpGeneralConfig.Controls.Add(this.label9);
            this.GpGeneralConfig.Controls.Add(this.CbPrinterRedirection);
            this.GpGeneralConfig.Controls.Add(this.label8);
            this.GpGeneralConfig.Controls.Add(this.CbProtectedClient);
            this.GpGeneralConfig.Controls.Add(this.label7);
            this.GpGeneralConfig.Controls.Add(this.CbNetworking);
            this.GpGeneralConfig.Controls.Add(this.label6);
            this.GpGeneralConfig.Controls.Add(this.CbVideoInput);
            this.GpGeneralConfig.Controls.Add(this.label5);
            this.GpGeneralConfig.Controls.Add(this.CbAudioInput);
            this.GpGeneralConfig.Controls.Add(this.label4);
            this.GpGeneralConfig.Location = new System.Drawing.Point(12, 12);
            this.GpGeneralConfig.Name = "GpGeneralConfig";
            this.GpGeneralConfig.Size = new System.Drawing.Size(433, 261);
            this.GpGeneralConfig.TabIndex = 1;
            this.GpGeneralConfig.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "general configuration";
            // 
            // NumMemory
            // 
            this.NumMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.NumMemory.ForeColor = System.Drawing.Color.Black;
            this.NumMemory.Location = new System.Drawing.Point(247, 157);
            this.NumMemory.Maximum = new decimal(new int[] {
            262144,
            0,
            0,
            0});
            this.NumMemory.Name = "NumMemory";
            this.NumMemory.Size = new System.Drawing.Size(158, 23);
            this.NumMemory.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "memory (mb)";
            // 
            // CbVgpu
            // 
            this.CbVgpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbVgpu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVgpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbVgpu.ForeColor = System.Drawing.Color.Black;
            this.CbVgpu.FormattingEnabled = true;
            this.CbVgpu.Location = new System.Drawing.Point(27, 157);
            this.CbVgpu.Name = "CbVgpu";
            this.CbVgpu.Size = new System.Drawing.Size(158, 23);
            this.CbVgpu.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "vgpu";
            // 
            // CbClipboardRedirection
            // 
            this.CbClipboardRedirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbClipboardRedirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbClipboardRedirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbClipboardRedirection.ForeColor = System.Drawing.Color.Black;
            this.CbClipboardRedirection.FormattingEnabled = true;
            this.CbClipboardRedirection.Location = new System.Drawing.Point(247, 212);
            this.CbClipboardRedirection.Name = "CbClipboardRedirection";
            this.CbClipboardRedirection.Size = new System.Drawing.Size(158, 23);
            this.CbClipboardRedirection.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "clipboard redirection";
            // 
            // CbPrinterRedirection
            // 
            this.CbPrinterRedirection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbPrinterRedirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPrinterRedirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbPrinterRedirection.ForeColor = System.Drawing.Color.Black;
            this.CbPrinterRedirection.FormattingEnabled = true;
            this.CbPrinterRedirection.Location = new System.Drawing.Point(247, 102);
            this.CbPrinterRedirection.Name = "CbPrinterRedirection";
            this.CbPrinterRedirection.Size = new System.Drawing.Size(158, 23);
            this.CbPrinterRedirection.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(247, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "printer redirection";
            // 
            // CbProtectedClient
            // 
            this.CbProtectedClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbProtectedClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProtectedClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbProtectedClient.ForeColor = System.Drawing.Color.Black;
            this.CbProtectedClient.FormattingEnabled = true;
            this.CbProtectedClient.Location = new System.Drawing.Point(27, 102);
            this.CbProtectedClient.Name = "CbProtectedClient";
            this.CbProtectedClient.Size = new System.Drawing.Size(158, 23);
            this.CbProtectedClient.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "protected client";
            // 
            // CbNetworking
            // 
            this.CbNetworking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbNetworking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNetworking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbNetworking.ForeColor = System.Drawing.Color.Black;
            this.CbNetworking.FormattingEnabled = true;
            this.CbNetworking.Location = new System.Drawing.Point(27, 212);
            this.CbNetworking.Name = "CbNetworking";
            this.CbNetworking.Size = new System.Drawing.Size(158, 23);
            this.CbNetworking.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "networking";
            // 
            // CbVideoInput
            // 
            this.CbVideoInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbVideoInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbVideoInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbVideoInput.ForeColor = System.Drawing.Color.Black;
            this.CbVideoInput.FormattingEnabled = true;
            this.CbVideoInput.Location = new System.Drawing.Point(247, 47);
            this.CbVideoInput.Name = "CbVideoInput";
            this.CbVideoInput.Size = new System.Drawing.Size(158, 23);
            this.CbVideoInput.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "video input";
            // 
            // CbAudioInput
            // 
            this.CbAudioInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbAudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAudioInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAudioInput.ForeColor = System.Drawing.Color.Black;
            this.CbAudioInput.FormattingEnabled = true;
            this.CbAudioInput.Location = new System.Drawing.Point(27, 47);
            this.CbAudioInput.Name = "CbAudioInput";
            this.CbAudioInput.Size = new System.Drawing.Size(158, 23);
            this.CbAudioInput.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "audio input";
            // 
            // TbRootSandboxFilesDirectory
            // 
            this.TbRootSandboxFilesDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbRootSandboxFilesDirectory.ForeColor = System.Drawing.Color.Black;
            this.TbRootSandboxFilesDirectory.Location = new System.Drawing.Point(27, 168);
            this.TbRootSandboxFilesDirectory.Name = "TbRootSandboxFilesDirectory";
            this.TbRootSandboxFilesDirectory.Size = new System.Drawing.Size(378, 23);
            this.TbRootSandboxFilesDirectory.TabIndex = 5;
            this.TbRootSandboxFilesDirectory.DoubleClick += new System.EventHandler(this.TbRootSandboxFilesDirectory_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "root sandboxfiles directory location";
            // 
            // TbRootfilesDirectory
            // 
            this.TbRootfilesDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbRootfilesDirectory.ForeColor = System.Drawing.Color.Black;
            this.TbRootfilesDirectory.Location = new System.Drawing.Point(27, 113);
            this.TbRootfilesDirectory.Name = "TbRootfilesDirectory";
            this.TbRootfilesDirectory.Size = new System.Drawing.Size(378, 23);
            this.TbRootfilesDirectory.TabIndex = 3;
            this.TbRootfilesDirectory.DoubleClick += new System.EventHandler(this.TbRootfilesDirectory_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "rootfiles directory location";
            // 
            // TbSandboxConfigurationFile
            // 
            this.TbSandboxConfigurationFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbSandboxConfigurationFile.ForeColor = System.Drawing.Color.Black;
            this.TbSandboxConfigurationFile.Location = new System.Drawing.Point(27, 58);
            this.TbSandboxConfigurationFile.Name = "TbSandboxConfigurationFile";
            this.TbSandboxConfigurationFile.Size = new System.Drawing.Size(378, 23);
            this.TbSandboxConfigurationFile.TabIndex = 1;
            this.TbSandboxConfigurationFile.DoubleClick += new System.EventHandler(this.TbSandboxConfigurationFile_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "sandbox configuration file";
            // 
            // GpMappedFolders
            // 
            this.GpMappedFolders.Controls.Add(this.BtnRemoveMappedFolder);
            this.GpMappedFolders.Controls.Add(this.BtnAddMappedFolder);
            this.GpMappedFolders.Controls.Add(this.LvMappedFolders);
            this.GpMappedFolders.Controls.Add(this.label13);
            this.GpMappedFolders.Location = new System.Drawing.Point(466, 12);
            this.GpMappedFolders.Name = "GpMappedFolders";
            this.GpMappedFolders.Size = new System.Drawing.Size(577, 240);
            this.GpMappedFolders.TabIndex = 2;
            this.GpMappedFolders.TabStop = false;
            // 
            // BtnRemoveMappedFolder
            // 
            this.BtnRemoveMappedFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveMappedFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveMappedFolder.Image = global::ScoopBoxManager.Properties.Resources.remove_24;
            this.BtnRemoveMappedFolder.Location = new System.Drawing.Point(6, 202);
            this.BtnRemoveMappedFolder.Name = "BtnRemoveMappedFolder";
            this.BtnRemoveMappedFolder.Size = new System.Drawing.Size(69, 32);
            this.BtnRemoveMappedFolder.TabIndex = 26;
            this.BtnRemoveMappedFolder.UseVisualStyleBackColor = true;
            this.BtnRemoveMappedFolder.Click += new System.EventHandler(this.BtnRemoveMappedFolder_Click);
            // 
            // BtnAddMappedFolder
            // 
            this.BtnAddMappedFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddMappedFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddMappedFolder.Image = global::ScoopBoxManager.Properties.Resources.add_24;
            this.BtnAddMappedFolder.Location = new System.Drawing.Point(502, 202);
            this.BtnAddMappedFolder.Name = "BtnAddMappedFolder";
            this.BtnAddMappedFolder.Size = new System.Drawing.Size(69, 32);
            this.BtnAddMappedFolder.TabIndex = 25;
            this.BtnAddMappedFolder.UseVisualStyleBackColor = true;
            this.BtnAddMappedFolder.Click += new System.EventHandler(this.BtnAddMappedFolder_Click);
            // 
            // LvMappedFolders
            // 
            this.LvMappedFolders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.LvMappedFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmHostFolder,
            this.ClmSandboxFolder,
            this.ClmReadonly});
            this.LvMappedFolders.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvMappedFolders.ForeColor = System.Drawing.Color.Black;
            this.LvMappedFolders.FullRowSelect = true;
            this.LvMappedFolders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvMappedFolders.Location = new System.Drawing.Point(3, 19);
            this.LvMappedFolders.MultiSelect = false;
            this.LvMappedFolders.Name = "LvMappedFolders";
            this.LvMappedFolders.Size = new System.Drawing.Size(571, 177);
            this.LvMappedFolders.TabIndex = 24;
            this.LvMappedFolders.UseCompatibleStateImageBehavior = false;
            this.LvMappedFolders.View = System.Windows.Forms.View.Details;
            this.LvMappedFolders.DoubleClick += new System.EventHandler(this.LvMappedFolders_DoubleClick);
            // 
            // ClmHostFolder
            // 
            this.ClmHostFolder.Text = "host folder";
            this.ClmHostFolder.Width = 240;
            // 
            // ClmSandboxFolder
            // 
            this.ClmSandboxFolder.Text = "sandbox folder";
            this.ClmSandboxFolder.Width = 240;
            // 
            // ClmReadonly
            // 
            this.ClmReadonly.Text = "readonly";
            this.ClmReadonly.Width = 70;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "mapped folders";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRemoveApplication);
            this.groupBox1.Controls.Add(this.BtnAddApplication);
            this.groupBox1.Controls.Add(this.LvApplications);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(466, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 240);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // BtnRemoveApplication
            // 
            this.BtnRemoveApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoveApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveApplication.Image = global::ScoopBoxManager.Properties.Resources.remove_24;
            this.BtnRemoveApplication.Location = new System.Drawing.Point(6, 202);
            this.BtnRemoveApplication.Name = "BtnRemoveApplication";
            this.BtnRemoveApplication.Size = new System.Drawing.Size(69, 32);
            this.BtnRemoveApplication.TabIndex = 26;
            this.BtnRemoveApplication.UseVisualStyleBackColor = true;
            this.BtnRemoveApplication.Click += new System.EventHandler(this.BtnRemoveApplication_Click);
            // 
            // BtnAddApplication
            // 
            this.BtnAddApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddApplication.Image = global::ScoopBoxManager.Properties.Resources.add_24;
            this.BtnAddApplication.Location = new System.Drawing.Point(502, 202);
            this.BtnAddApplication.Name = "BtnAddApplication";
            this.BtnAddApplication.Size = new System.Drawing.Size(69, 32);
            this.BtnAddApplication.TabIndex = 25;
            this.BtnAddApplication.UseVisualStyleBackColor = true;
            this.BtnAddApplication.Click += new System.EventHandler(this.BtnAddApplication_Click);
            // 
            // LvApplications
            // 
            this.LvApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.LvApplications.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClmApplication,
            this.ClmPackageManager});
            this.LvApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.LvApplications.ForeColor = System.Drawing.Color.Black;
            this.LvApplications.FullRowSelect = true;
            this.LvApplications.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvApplications.Location = new System.Drawing.Point(3, 19);
            this.LvApplications.MultiSelect = false;
            this.LvApplications.Name = "LvApplications";
            this.LvApplications.Size = new System.Drawing.Size(571, 177);
            this.LvApplications.TabIndex = 24;
            this.LvApplications.UseCompatibleStateImageBehavior = false;
            this.LvApplications.View = System.Windows.Forms.View.Details;
            this.LvApplications.DoubleClick += new System.EventHandler(this.LvApplications_DoubleClick);
            // 
            // ClmApplication
            // 
            this.ClmApplication.Text = "application";
            this.ClmApplication.Width = 430;
            // 
            // ClmPackageManager
            // 
            this.ClmPackageManager.Text = "package manager";
            this.ClmPackageManager.Width = 120;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "applications";
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSaveSettings.Image = global::ScoopBoxManager.Properties.Resources.save_32;
            this.BtnSaveSettings.Location = new System.Drawing.Point(12, 534);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(127, 55);
            this.BtnSaveSettings.TabIndex = 4;
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // BtnLoadSettings
            // 
            this.BtnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLoadSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnLoadSettings.Image = global::ScoopBoxManager.Properties.Resources.open_32;
            this.BtnLoadSettings.Location = new System.Drawing.Point(145, 534);
            this.BtnLoadSettings.Name = "BtnLoadSettings";
            this.BtnLoadSettings.Size = new System.Drawing.Size(127, 55);
            this.BtnLoadSettings.TabIndex = 5;
            this.BtnLoadSettings.UseVisualStyleBackColor = true;
            this.BtnLoadSettings.Click += new System.EventHandler(this.BtnLoadSettings_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(278, 534);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(316, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "tip: double-click on a location textbox to open a file dialog";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(278, 559);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(367, 30);
            this.label16.TabIndex = 10;
            this.label16.Text = "tip: your last launched settings are stored (and loaded) as the default\r\n       u" +
    "se the save/load buttons to use other settings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(713, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "powered by @hasan-hasanov\'s";
            // 
            // LblScoopBox
            // 
            this.LblScoopBox.AutoSize = true;
            this.LblScoopBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblScoopBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.LblScoopBox.Location = new System.Drawing.Point(885, 516);
            this.LblScoopBox.Name = "LblScoopBox";
            this.LblScoopBox.Size = new System.Drawing.Size(60, 15);
            this.LblScoopBox.TabIndex = 12;
            this.LblScoopBox.Text = "ScoopBox";
            this.LblScoopBox.Click += new System.EventHandler(this.LblScoopBox_Click);
            // 
            // LblSettingsStored
            // 
            this.LblSettingsStored.AutoSize = true;
            this.LblSettingsStored.ForeColor = System.Drawing.Color.GreenYellow;
            this.LblSettingsStored.Location = new System.Drawing.Point(12, 516);
            this.LblSettingsStored.Name = "LblSettingsStored";
            this.LblSettingsStored.Size = new System.Drawing.Size(87, 15);
            this.LblSettingsStored.TabIndex = 13;
            this.LblSettingsStored.Text = "settings stored!";
            this.LblSettingsStored.Visible = false;
            // 
            // LblSettingsLoaded
            // 
            this.LblSettingsLoaded.AutoSize = true;
            this.LblSettingsLoaded.ForeColor = System.Drawing.Color.GreenYellow;
            this.LblSettingsLoaded.Location = new System.Drawing.Point(145, 516);
            this.LblSettingsLoaded.Name = "LblSettingsLoaded";
            this.LblSettingsLoaded.Size = new System.Drawing.Size(90, 15);
            this.LblSettingsLoaded.TabIndex = 14;
            this.LblSettingsLoaded.Text = "settings loaded!";
            this.LblSettingsLoaded.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.TbSandboxConfigurationFile);
            this.groupBox2.Controls.Add(this.TbRootSandboxFilesDirectory);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TbRootfilesDirectory);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 218);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 15);
            this.label18.TabIndex = 22;
            this.label18.Text = "optional configuration";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1052, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblSettingsLoaded);
            this.Controls.Add(this.LblSettingsStored);
            this.Controls.Add(this.LblScoopBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnLoadSettings);
            this.Controls.Add(this.BtnSaveSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GpMappedFolders);
            this.Controls.Add(this.GpGeneralConfig);
            this.Controls.Add(this.BtnLaunch);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScoopBox Manager   |   LAB02 Research";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GpGeneralConfig.ResumeLayout(false);
            this.GpGeneralConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumMemory)).EndInit();
            this.GpMappedFolders.ResumeLayout(false);
            this.GpMappedFolders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox GpGeneralConfig;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox GpMappedFolders;
        private Label label13;
        private ColumnHeader ClmHostFolder;
        private ColumnHeader ClmSandboxFolder;
        private ColumnHeader ClmReadonly;
        private GroupBox groupBox1;
        private ColumnHeader ClmApplication;
        private ColumnHeader ClmPackageManager;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label LblScoopBox;
        internal Button BtnLaunch;
        internal TextBox TbRootSandboxFilesDirectory;
        internal TextBox TbRootfilesDirectory;
        internal TextBox TbSandboxConfigurationFile;
        internal ComboBox CbAudioInput;
        internal ComboBox CbNetworking;
        internal ComboBox CbVideoInput;
        internal ComboBox CbPrinterRedirection;
        internal ComboBox CbProtectedClient;
        internal ComboBox CbClipboardRedirection;
        internal ComboBox CbVgpu;
        internal NumericUpDown NumMemory;
        internal ListView LvMappedFolders;
        internal Button BtnAddMappedFolder;
        internal Button BtnRemoveMappedFolder;
        internal Button BtnRemoveApplication;
        internal Button BtnAddApplication;
        internal ListView LvApplications;
        internal Button BtnSaveSettings;
        internal Button BtnLoadSettings;
        internal Label LblSettingsStored;
        internal Label LblSettingsLoaded;
        private GroupBox groupBox2;
        private Label label18;
    }
}