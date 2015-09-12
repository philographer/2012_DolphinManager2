namespace DolphinManager
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Btn_exceptionSave = new System.Windows.Forms.Button();
            this.ListBox_Process = new System.Windows.Forms.ListBox();
            this.Btn_addExceptionProcess = new System.Windows.Forms.Button();
            this.Btn_deleteExceptionProcess = new System.Windows.Forms.Button();
            this.TxtBox_Send = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Btn_addProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_exceptionSave
            // 
            this.Btn_exceptionSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_exceptionSave.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_exceptionSave.Location = new System.Drawing.Point(13, 389);
            this.Btn_exceptionSave.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_exceptionSave.Name = "Btn_exceptionSave";
            this.Btn_exceptionSave.Size = new System.Drawing.Size(681, 55);
            this.Btn_exceptionSave.TabIndex = 16;
            this.Btn_exceptionSave.Text = "Save";
            this.Btn_exceptionSave.UseVisualStyleBackColor = false;
            this.Btn_exceptionSave.Click += new System.EventHandler(this.Btn_execptionSave_Click);
            // 
            // ListBox_Process
            // 
            this.ListBox_Process.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListBox_Process.FormattingEnabled = true;
            this.ListBox_Process.ItemHeight = 18;
            this.ListBox_Process.Location = new System.Drawing.Point(363, 63);
            this.ListBox_Process.Margin = new System.Windows.Forms.Padding(4);
            this.ListBox_Process.Name = "ListBox_Process";
            this.ListBox_Process.Size = new System.Drawing.Size(348, 274);
            this.ListBox_Process.TabIndex = 17;
            // 
            // Btn_addExceptionProcess
            // 
            this.Btn_addExceptionProcess.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_addExceptionProcess.Location = new System.Drawing.Point(534, 345);
            this.Btn_addExceptionProcess.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_addExceptionProcess.Name = "Btn_addExceptionProcess";
            this.Btn_addExceptionProcess.Size = new System.Drawing.Size(76, 42);
            this.Btn_addExceptionProcess.TabIndex = 18;
            this.Btn_addExceptionProcess.Text = "Add";
            this.Btn_addExceptionProcess.UseVisualStyleBackColor = false;
            this.Btn_addExceptionProcess.Click += new System.EventHandler(this.Btn_addExceptionProcess_Click);
            // 
            // Btn_deleteExceptionProcess
            // 
            this.Btn_deleteExceptionProcess.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_deleteExceptionProcess.Location = new System.Drawing.Point(618, 345);
            this.Btn_deleteExceptionProcess.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_deleteExceptionProcess.Name = "Btn_deleteExceptionProcess";
            this.Btn_deleteExceptionProcess.Size = new System.Drawing.Size(76, 42);
            this.Btn_deleteExceptionProcess.TabIndex = 19;
            this.Btn_deleteExceptionProcess.Text = "Delete";
            this.Btn_deleteExceptionProcess.UseVisualStyleBackColor = false;
            this.Btn_deleteExceptionProcess.Click += new System.EventHandler(this.Btn_deleteExceptionProcess_Click);
            // 
            // TxtBox_Send
            // 
            this.TxtBox_Send.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TxtBox_Send.Location = new System.Drawing.Point(363, 345);
            this.TxtBox_Send.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox_Send.Name = "TxtBox_Send";
            this.TxtBox_Send.Size = new System.Drawing.Size(163, 28);
            this.TxtBox_Send.TabIndex = 20;
            this.TxtBox_Send.Text = "InputProcessName";
            this.TxtBox_Send.Click += new System.EventHandler(this.TxtBox_Send_Click);
            this.TxtBox_Send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_Send_KeyDown);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(13, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(310, 280);
            this.checkedListBox1.TabIndex = 21;
            // 
            // Btn_addProcess
            // 
            this.Btn_addProcess.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_addProcess.Location = new System.Drawing.Point(13, 345);
            this.Btn_addProcess.Name = "Btn_addProcess";
            this.Btn_addProcess.Size = new System.Drawing.Size(310, 37);
            this.Btn_addProcess.TabIndex = 22;
            this.Btn_addProcess.Text = "AddToException";
            this.Btn_addProcess.UseVisualStyleBackColor = false;
            this.Btn_addProcess.Click += new System.EventHandler(this.Btn_addProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "현재프로세스";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "예외프로세스";
            // 
            // Form4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(711, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_addProcess);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.TxtBox_Send);
            this.Controls.Add(this.Btn_deleteExceptionProcess);
            this.Controls.Add(this.Btn_addExceptionProcess);
            this.Controls.Add(this.ListBox_Process);
            this.Controls.Add(this.Btn_exceptionSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Except";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_exceptionSave;
        private System.Windows.Forms.Button Btn_addExceptionProcess;
        public System.Windows.Forms.ListBox ListBox_Process;
        private System.Windows.Forms.Button Btn_deleteExceptionProcess;
        private System.Windows.Forms.TextBox TxtBox_Send;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Btn_addProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}