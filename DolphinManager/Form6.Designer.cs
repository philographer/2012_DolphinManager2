namespace DolphinManager
{
    partial class Form6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.lstMemory = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabDataStorage = new System.Windows.Forms.TabPage();
            this.lstStorage = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.lstCPU = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabMemory.SuspendLayout();
            this.tabDataStorage.SuspendLayout();
            this.tabCPU.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tabMemory
            // 
            this.tabMemory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabMemory.Controls.Add(this.lstMemory);
            this.tabMemory.Location = new System.Drawing.Point(4, 28);
            this.tabMemory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMemory.Size = new System.Drawing.Size(1081, 607);
            this.tabMemory.TabIndex = 7;
            this.tabMemory.Text = "램";
            // 
            // lstMemory
            // 
            this.lstMemory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstMemory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.lstMemory.Location = new System.Drawing.Point(27, 57);
            this.lstMemory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMemory.Name = "lstMemory";
            this.lstMemory.Size = new System.Drawing.Size(1013, 523);
            this.lstMemory.TabIndex = 7;
            this.lstMemory.UseCompatibleStateImageBehavior = false;
            this.lstMemory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "이름";
            this.columnHeader17.Width = 110;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "값";
            this.columnHeader18.Width = 600;
            // 
            // tabDataStorage
            // 
            this.tabDataStorage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabDataStorage.Controls.Add(this.lstStorage);
            this.tabDataStorage.Location = new System.Drawing.Point(4, 28);
            this.tabDataStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDataStorage.Name = "tabDataStorage";
            this.tabDataStorage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDataStorage.Size = new System.Drawing.Size(1081, 607);
            this.tabDataStorage.TabIndex = 4;
            this.tabDataStorage.Text = "하드디스크";
            // 
            // lstStorage
            // 
            this.lstStorage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstStorage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.lstStorage.Location = new System.Drawing.Point(27, 57);
            this.lstStorage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstStorage.Name = "lstStorage";
            this.lstStorage.Size = new System.Drawing.Size(1013, 523);
            this.lstStorage.TabIndex = 3;
            this.lstStorage.UseCompatibleStateImageBehavior = false;
            this.lstStorage.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "이름";
            this.columnHeader11.Width = 110;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "값";
            this.columnHeader12.Width = 600;
            // 
            // tabCPU
            // 
            this.tabCPU.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tabCPU.Controls.Add(this.lstCPU);
            this.tabCPU.Location = new System.Drawing.Point(4, 28);
            this.tabCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCPU.Size = new System.Drawing.Size(1081, 607);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "Cpu";
            // 
            // lstCPU
            // 
            this.lstCPU.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstCPU.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstCPU.Location = new System.Drawing.Point(27, 57);
            this.lstCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCPU.Name = "lstCPU";
            this.lstCPU.Size = new System.Drawing.Size(1013, 523);
            this.lstCPU.TabIndex = 0;
            this.lstCPU.UseCompatibleStateImageBehavior = false;
            this.lstCPU.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "값";
            this.columnHeader2.Width = 600;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tabCPU);
            this.MainTabControl.Controls.Add(this.tabDataStorage);
            this.MainTabControl.Controls.Add(this.tabMemory);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1089, 639);
            this.MainTabControl.TabIndex = 1;
            // 
            // Form6
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1089, 639);
            this.Controls.Add(this.MainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form6";
            this.Text = "CheckCom";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tabMemory.ResumeLayout(false);
            this.tabDataStorage.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabMemory;
        private System.Windows.Forms.ListView lstMemory;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.TabPage tabDataStorage;
        private System.Windows.Forms.ListView lstStorage;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.ListView lstCPU;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl MainTabControl;

    }
}