namespace ScoopBoxManager.Forms
{
    partial class AddMappedFolder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMappedFolder));
            this.TbSandboxFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbHostFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbReadOnly = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbSandboxFolder
            // 
            this.TbSandboxFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbSandboxFolder.ForeColor = System.Drawing.Color.Black;
            this.TbSandboxFolder.Location = new System.Drawing.Point(13, 96);
            this.TbSandboxFolder.Name = "TbSandboxFolder";
            this.TbSandboxFolder.Size = new System.Drawing.Size(378, 23);
            this.TbSandboxFolder.TabIndex = 1;
            this.TbSandboxFolder.Text = "C:\\Users\\WDAGUtilityAccount\\Desktop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "sandbox folder";
            // 
            // TbHostFolder
            // 
            this.TbHostFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbHostFolder.ForeColor = System.Drawing.Color.Black;
            this.TbHostFolder.Location = new System.Drawing.Point(12, 35);
            this.TbHostFolder.Name = "TbHostFolder";
            this.TbHostFolder.Size = new System.Drawing.Size(378, 23);
            this.TbHostFolder.TabIndex = 0;
            this.TbHostFolder.TextChanged += new System.EventHandler(this.TbHostFolder_TextChanged);
            this.TbHostFolder.DoubleClick += new System.EventHandler(this.TbHostFolder_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "host folder";
            // 
            // CbReadOnly
            // 
            this.CbReadOnly.AutoSize = true;
            this.CbReadOnly.Checked = true;
            this.CbReadOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbReadOnly.Location = new System.Drawing.Point(13, 137);
            this.CbReadOnly.Name = "CbReadOnly";
            this.CbReadOnly.Size = new System.Drawing.Size(72, 19);
            this.CbReadOnly.TabIndex = 8;
            this.CbReadOnly.Text = "readonly";
            this.CbReadOnly.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Image = global::ScoopBoxManager.Properties.Resources.save_32;
            this.BtnSave.Location = new System.Drawing.Point(0, 185);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(403, 45);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(201, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "tip: double-click to open a file dialog";
            // 
            // AddMappedFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(403, 230);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbReadOnly);
            this.Controls.Add(this.TbSandboxFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbHostFolder);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMappedFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapped Folder";
            this.Load += new System.EventHandler(this.MappedFolder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal TextBox TbSandboxFolder;
        private Label label2;
        internal TextBox TbHostFolder;
        private Label label1;
        private CheckBox CbReadOnly;
        internal Button BtnSave;
        private Label label15;
    }
}