namespace DolphinManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CkBox_Always = new System.Windows.Forms.CheckBox();
            this.CkBox_OneClick = new System.Windows.Forms.CheckBox();
            this.Btn_configSave = new System.Windows.Forms.Button();
            this.CkBox_Keyboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CkBox_Always
            // 
            this.CkBox_Always.AutoSize = true;
            this.CkBox_Always.Location = new System.Drawing.Point(17, 67);
            this.CkBox_Always.Margin = new System.Windows.Forms.Padding(4);
            this.CkBox_Always.Name = "CkBox_Always";
            this.CkBox_Always.Size = new System.Drawing.Size(256, 22);
            this.CkBox_Always.TabIndex = 21;
            this.CkBox_Always.Text = "메인창 최상위(최소화 가능)";
            this.CkBox_Always.UseVisualStyleBackColor = true;
            // 
            // CkBox_OneClick
            // 
            this.CkBox_OneClick.AutoSize = true;
            this.CkBox_OneClick.Location = new System.Drawing.Point(17, 18);
            this.CkBox_OneClick.Margin = new System.Windows.Forms.Padding(4);
            this.CkBox_OneClick.Name = "CkBox_OneClick";
            this.CkBox_OneClick.Size = new System.Drawing.Size(280, 22);
            this.CkBox_OneClick.TabIndex = 22;
            this.CkBox_OneClick.Text = "모든프로세스 종료시 쿠키삭제";
            this.CkBox_OneClick.UseVisualStyleBackColor = true;
            // 
            // Btn_configSave
            // 
            this.Btn_configSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_configSave.Location = new System.Drawing.Point(365, 146);
            this.Btn_configSave.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_configSave.Name = "Btn_configSave";
            this.Btn_configSave.Size = new System.Drawing.Size(116, 45);
            this.Btn_configSave.TabIndex = 23;
            this.Btn_configSave.Text = "Save";
            this.Btn_configSave.UseVisualStyleBackColor = false;
            this.Btn_configSave.Click += new System.EventHandler(this.Btn_saveConfig_Click);
            // 
            // CkBox_Keyboard
            // 
            this.CkBox_Keyboard.AutoSize = true;
            this.CkBox_Keyboard.Location = new System.Drawing.Point(17, 116);
            this.CkBox_Keyboard.Name = "CkBox_Keyboard";
            this.CkBox_Keyboard.Size = new System.Drawing.Size(311, 40);
            this.CkBox_Keyboard.TabIndex = 24;
            this.CkBox_Keyboard.Text = "키보드 단축키(F2)로 프로세스정리\r\n(프로그램 재시작시 적용)";
            this.CkBox_Keyboard.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(503, 204);
            this.Controls.Add(this.CkBox_Keyboard);
            this.Controls.Add(this.Btn_configSave);
            this.Controls.Add(this.CkBox_OneClick);
            this.Controls.Add(this.CkBox_Always);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox CkBox_Always;
        private System.Windows.Forms.Button Btn_configSave;
        public System.Windows.Forms.CheckBox CkBox_OneClick;
        public System.Windows.Forms.CheckBox CkBox_Keyboard;

    }
}