namespace ScoopBoxManager.Forms
{
    partial class AddApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddApplication));
            this.BtnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TbApplication = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbPackageManager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSave.Image = global::ScoopBoxManager.Properties.Resources.save_32;
            this.BtnSave.Location = new System.Drawing.Point(0, 147);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(312, 45);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "package manager";
            // 
            // TbApplication
            // 
            this.TbApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.TbApplication.ForeColor = System.Drawing.Color.Black;
            this.TbApplication.Location = new System.Drawing.Point(23, 40);
            this.TbApplication.Name = "TbApplication";
            this.TbApplication.Size = new System.Drawing.Size(266, 23);
            this.TbApplication.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "application";
            // 
            // CbPackageManager
            // 
            this.CbPackageManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.CbPackageManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbPackageManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbPackageManager.ForeColor = System.Drawing.Color.Black;
            this.CbPackageManager.FormattingEnabled = true;
            this.CbPackageManager.Location = new System.Drawing.Point(23, 95);
            this.CbPackageManager.Name = "CbPackageManager";
            this.CbPackageManager.Size = new System.Drawing.Size(158, 23);
            this.CbPackageManager.TabIndex = 1;
            // 
            // AddApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(312, 192);
            this.Controls.Add(this.CbPackageManager);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbApplication);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.Load += new System.EventHandler(this.Application_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Button BtnSave;
        private Label label2;
        internal TextBox TbApplication;
        private Label label1;
        internal ComboBox CbPackageManager;
    }
}