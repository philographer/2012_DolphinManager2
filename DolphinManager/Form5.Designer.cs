namespace DolphinManager
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.Btn_DiskArrangement = new System.Windows.Forms.Button();
            this.Btn_DiskDefrag = new System.Windows.Forms.Button();
            this.Btn_diskCheck = new System.Windows.Forms.Button();
            this.Btn_comSatatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_DiskArrangement
            // 
            this.Btn_DiskArrangement.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_DiskArrangement.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_DiskArrangement.Location = new System.Drawing.Point(17, 18);
            this.Btn_DiskArrangement.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DiskArrangement.Name = "Btn_DiskArrangement";
            this.Btn_DiskArrangement.Size = new System.Drawing.Size(220, 66);
            this.Btn_DiskArrangement.TabIndex = 12;
            this.Btn_DiskArrangement.Text = "디스크정리";
            this.Btn_DiskArrangement.UseVisualStyleBackColor = false;
            this.Btn_DiskArrangement.Click += new System.EventHandler(this.Btn_DiskArrangement_Click);
            // 
            // Btn_DiskDefrag
            // 
            this.Btn_DiskDefrag.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_DiskDefrag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_DiskDefrag.Location = new System.Drawing.Point(246, 18);
            this.Btn_DiskDefrag.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DiskDefrag.Name = "Btn_DiskDefrag";
            this.Btn_DiskDefrag.Size = new System.Drawing.Size(220, 66);
            this.Btn_DiskDefrag.TabIndex = 13;
            this.Btn_DiskDefrag.Text = "디스크 조각 모음";
            this.Btn_DiskDefrag.UseVisualStyleBackColor = false;
            this.Btn_DiskDefrag.Click += new System.EventHandler(this.Btn_DiskDefrag_Click);
            // 
            // Btn_diskCheck
            // 
            this.Btn_diskCheck.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_diskCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_diskCheck.Location = new System.Drawing.Point(17, 108);
            this.Btn_diskCheck.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_diskCheck.Name = "Btn_diskCheck";
            this.Btn_diskCheck.Size = new System.Drawing.Size(220, 66);
            this.Btn_diskCheck.TabIndex = 14;
            this.Btn_diskCheck.Text = "디스크체크";
            this.Btn_diskCheck.UseVisualStyleBackColor = false;
            this.Btn_diskCheck.Click += new System.EventHandler(this.Btn_diskCheck_Click);
            // 
            // Btn_comSatatus
            // 
            this.Btn_comSatatus.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_comSatatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_comSatatus.Location = new System.Drawing.Point(246, 108);
            this.Btn_comSatatus.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_comSatatus.Name = "Btn_comSatatus";
            this.Btn_comSatatus.Size = new System.Drawing.Size(220, 66);
            this.Btn_comSatatus.TabIndex = 15;
            this.Btn_comSatatus.Text = "컴퓨터상태확인";
            this.Btn_comSatatus.UseVisualStyleBackColor = false;
            this.Btn_comSatatus.Click += new System.EventHandler(this.Btn_comSatatus_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(496, 196);
            this.Controls.Add(this.Btn_comSatatus);
            this.Controls.Add(this.Btn_diskCheck);
            this.Controls.Add(this.Btn_DiskDefrag);
            this.Controls.Add(this.Btn_DiskArrangement);
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Tool";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_DiskArrangement;
        private System.Windows.Forms.Button Btn_DiskDefrag;
        private System.Windows.Forms.Button Btn_diskCheck;
        private System.Windows.Forms.Button Btn_comSatatus;

    }
}