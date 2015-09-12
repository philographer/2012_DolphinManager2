namespace DolphinManager
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Btn_AllSelect = new System.Windows.Forms.Button();
            this.Btn_ReverseSelect = new System.Windows.Forms.Button();
            this.Btn_SelectKill = new System.Windows.Forms.Button();
            this.Btn_UnCheckAll = new System.Windows.Forms.Button();
            this.Btn_listboxReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.checkedListBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(17, 18);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(262, 326);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseClick);
            // 
            // Btn_AllSelect
            // 
            this.Btn_AllSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.Btn_AllSelect.Location = new System.Drawing.Point(287, 88);
            this.Btn_AllSelect.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AllSelect.Name = "Btn_AllSelect";
            this.Btn_AllSelect.Size = new System.Drawing.Size(130, 45);
            this.Btn_AllSelect.TabIndex = 2;
            this.Btn_AllSelect.Text = "전체선택";
            this.Btn_AllSelect.UseVisualStyleBackColor = false;
            this.Btn_AllSelect.Click += new System.EventHandler(this.Btn_AllSelect_Click);
            // 
            // Btn_ReverseSelect
            // 
            this.Btn_ReverseSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.Btn_ReverseSelect.Location = new System.Drawing.Point(287, 194);
            this.Btn_ReverseSelect.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ReverseSelect.Name = "Btn_ReverseSelect";
            this.Btn_ReverseSelect.Size = new System.Drawing.Size(130, 45);
            this.Btn_ReverseSelect.TabIndex = 3;
            this.Btn_ReverseSelect.Text = "반전선택";
            this.Btn_ReverseSelect.UseVisualStyleBackColor = false;
            this.Btn_ReverseSelect.Click += new System.EventHandler(this.Btn_ReverseSelect_Click);
            // 
            // Btn_SelectKill
            // 
            this.Btn_SelectKill.BackColor = System.Drawing.Color.PowderBlue;
            this.Btn_SelectKill.Location = new System.Drawing.Point(287, 247);
            this.Btn_SelectKill.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SelectKill.Name = "Btn_SelectKill";
            this.Btn_SelectKill.Size = new System.Drawing.Size(130, 72);
            this.Btn_SelectKill.TabIndex = 4;
            this.Btn_SelectKill.Text = "프로세스종료";
            this.Btn_SelectKill.UseVisualStyleBackColor = false;
            this.Btn_SelectKill.Click += new System.EventHandler(this.Btn_SelectKill_Click);
            // 
            // Btn_UnCheckAll
            // 
            this.Btn_UnCheckAll.BackColor = System.Drawing.Color.PowderBlue;
            this.Btn_UnCheckAll.Location = new System.Drawing.Point(287, 141);
            this.Btn_UnCheckAll.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_UnCheckAll.Name = "Btn_UnCheckAll";
            this.Btn_UnCheckAll.Size = new System.Drawing.Size(130, 45);
            this.Btn_UnCheckAll.TabIndex = 5;
            this.Btn_UnCheckAll.Text = "전체선택해제";
            this.Btn_UnCheckAll.UseVisualStyleBackColor = false;
            this.Btn_UnCheckAll.Click += new System.EventHandler(this.Btn_UnCheckAll_Click);
            // 
            // Btn_listboxReset
            // 
            this.Btn_listboxReset.BackColor = System.Drawing.Color.PowderBlue;
            this.Btn_listboxReset.Location = new System.Drawing.Point(287, 18);
            this.Btn_listboxReset.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_listboxReset.Name = "Btn_listboxReset";
            this.Btn_listboxReset.Size = new System.Drawing.Size(130, 62);
            this.Btn_listboxReset.TabIndex = 6;
            this.Btn_listboxReset.Text = "새로고침";
            this.Btn_listboxReset.UseVisualStyleBackColor = false;
            this.Btn_listboxReset.Click += new System.EventHandler(this.Btn_listboxReset_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.Btn_listboxReset);
            this.Controls.Add(this.Btn_UnCheckAll);
            this.Controls.Add(this.Btn_SelectKill);
            this.Controls.Add(this.Btn_ReverseSelect);
            this.Controls.Add(this.Btn_AllSelect);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "SelectKill";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Btn_AllSelect;
        private System.Windows.Forms.Button Btn_ReverseSelect;
        private System.Windows.Forms.Button Btn_SelectKill;
        private System.Windows.Forms.Button Btn_UnCheckAll;
        private System.Windows.Forms.Button Btn_listboxReset;


    }
}