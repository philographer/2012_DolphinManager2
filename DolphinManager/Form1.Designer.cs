namespace DolphinManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_Oneclick = new System.Windows.Forms.Button();
            this.Btn_SizeAdjust = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_AddFuction = new System.Windows.Forms.Button();
            this.Btn_AllProcessKill = new System.Windows.Forms.Button();
            this.Btn_SelcetProcessKill = new System.Windows.Forms.Button();
            this.Btn_DeleteCookie = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Btn_Exception = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.기능ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모든프로세스종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선택프로세스종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.예외설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.쿠키삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리툴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Config = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Oneclick
            // 
            this.Btn_Oneclick.Font = new System.Drawing.Font("휴먼편지체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Oneclick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Oneclick.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Oneclick.Image")));
            this.Btn_Oneclick.Location = new System.Drawing.Point(4, 4);
            this.Btn_Oneclick.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Oneclick.Name = "Btn_Oneclick";
            this.Btn_Oneclick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btn_Oneclick.Size = new System.Drawing.Size(166, 126);
            this.Btn_Oneclick.TabIndex = 0;
            this.Btn_Oneclick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Oneclick.UseVisualStyleBackColor = true;
            this.Btn_Oneclick.Click += new System.EventHandler(this.Btn_Oneclick_Click);
            // 
            // Btn_SizeAdjust
            // 
            this.Btn_SizeAdjust.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_SizeAdjust.Location = new System.Drawing.Point(4, 140);
            this.Btn_SizeAdjust.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SizeAdjust.Name = "Btn_SizeAdjust";
            this.Btn_SizeAdjust.Size = new System.Drawing.Size(166, 40);
            this.Btn_SizeAdjust.TabIndex = 1;
            this.Btn_SizeAdjust.Text = "SizeAdjust";
            this.Btn_SizeAdjust.UseVisualStyleBackColor = false;
            this.Btn_SizeAdjust.Click += new System.EventHandler(this.Btn_SizeAdjust_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Exit.Location = new System.Drawing.Point(430, 154);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(220, 66);
            this.Btn_Exit.TabIndex = 14;
            this.Btn_Exit.Text = "Hide";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_AddFuction
            // 
            this.Btn_AddFuction.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_AddFuction.Location = new System.Drawing.Point(201, 154);
            this.Btn_AddFuction.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AddFuction.Name = "Btn_AddFuction";
            this.Btn_AddFuction.Size = new System.Drawing.Size(220, 66);
            this.Btn_AddFuction.TabIndex = 13;
            this.Btn_AddFuction.Text = "ManagementTool";
            this.Btn_AddFuction.UseVisualStyleBackColor = false;
            this.Btn_AddFuction.Click += new System.EventHandler(this.Btn_CheckComputer_Click);
            // 
            // Btn_AllProcessKill
            // 
            this.Btn_AllProcessKill.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_AllProcessKill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_AllProcessKill.ImageKey = "(없음)";
            this.Btn_AllProcessKill.Location = new System.Drawing.Point(201, 4);
            this.Btn_AllProcessKill.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_AllProcessKill.Name = "Btn_AllProcessKill";
            this.Btn_AllProcessKill.Size = new System.Drawing.Size(220, 66);
            this.Btn_AllProcessKill.TabIndex = 10;
            this.Btn_AllProcessKill.Text = "AllProcessClean";
            this.Btn_AllProcessKill.UseVisualStyleBackColor = false;
            this.Btn_AllProcessKill.Click += new System.EventHandler(this.Btn_AllProcessKill_Click);
            // 
            // Btn_SelcetProcessKill
            // 
            this.Btn_SelcetProcessKill.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_SelcetProcessKill.Location = new System.Drawing.Point(430, 4);
            this.Btn_SelcetProcessKill.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_SelcetProcessKill.Name = "Btn_SelcetProcessKill";
            this.Btn_SelcetProcessKill.Size = new System.Drawing.Size(220, 66);
            this.Btn_SelcetProcessKill.TabIndex = 9;
            this.Btn_SelcetProcessKill.Text = "SelectProcessClean";
            this.Btn_SelcetProcessKill.UseVisualStyleBackColor = false;
            this.Btn_SelcetProcessKill.Click += new System.EventHandler(this.Btn_SelcetProcessKill_Click);
            // 
            // Btn_DeleteCookie
            // 
            this.Btn_DeleteCookie.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_DeleteCookie.Location = new System.Drawing.Point(201, 76);
            this.Btn_DeleteCookie.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_DeleteCookie.Name = "Btn_DeleteCookie";
            this.Btn_DeleteCookie.Size = new System.Drawing.Size(220, 66);
            this.Btn_DeleteCookie.TabIndex = 8;
            this.Btn_DeleteCookie.Text = "CookieDelete";
            this.Btn_DeleteCookie.UseVisualStyleBackColor = false;
            this.Btn_DeleteCookie.Click += new System.EventHandler(this.Btn_DeleteCookie_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Btn_Exception
            // 
            this.Btn_Exception.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Exception.Location = new System.Drawing.Point(430, 80);
            this.Btn_Exception.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Exception.Name = "Btn_Exception";
            this.Btn_Exception.Size = new System.Drawing.Size(220, 66);
            this.Btn_Exception.TabIndex = 19;
            this.Btn_Exception.Text = "Exception";
            this.Btn_Exception.UseVisualStyleBackColor = false;
            this.Btn_Exception.Click += new System.EventHandler(this.button3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DolphinM";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.contextMenuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contextMenuStrip1.BackgroundImage")));
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.기능ToolStripMenuItem,
            this.환경설정ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 124);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 기능ToolStripMenuItem
            // 
            this.기능ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모든프로세스종료ToolStripMenuItem,
            this.선택프로세스종료ToolStripMenuItem,
            this.예외설정ToolStripMenuItem,
            this.쿠키삭제ToolStripMenuItem,
            this.관리툴ToolStripMenuItem});
            this.기능ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.기능ToolStripMenuItem.Name = "기능ToolStripMenuItem";
            this.기능ToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.기능ToolStripMenuItem.Text = "기능";
            // 
            // 모든프로세스종료ToolStripMenuItem
            // 
            this.모든프로세스종료ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("모든프로세스종료ToolStripMenuItem.BackgroundImage")));
            this.모든프로세스종료ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.모든프로세스종료ToolStripMenuItem.Name = "모든프로세스종료ToolStripMenuItem";
            this.모든프로세스종료ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.모든프로세스종료ToolStripMenuItem.Text = "모든프로세스종료";
            this.모든프로세스종료ToolStripMenuItem.Click += new System.EventHandler(this.모든프로세스종료ToolStripMenuItem_Click);
            // 
            // 선택프로세스종료ToolStripMenuItem
            // 
            this.선택프로세스종료ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("선택프로세스종료ToolStripMenuItem.BackgroundImage")));
            this.선택프로세스종료ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.선택프로세스종료ToolStripMenuItem.Name = "선택프로세스종료ToolStripMenuItem";
            this.선택프로세스종료ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.선택프로세스종료ToolStripMenuItem.Text = "선택프로세스종료";
            this.선택프로세스종료ToolStripMenuItem.Click += new System.EventHandler(this.선택프로세스종료ToolStripMenuItem_Click);
            // 
            // 예외설정ToolStripMenuItem
            // 
            this.예외설정ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("예외설정ToolStripMenuItem.BackgroundImage")));
            this.예외설정ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.예외설정ToolStripMenuItem.Name = "예외설정ToolStripMenuItem";
            this.예외설정ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.예외설정ToolStripMenuItem.Text = "예외설정";
            this.예외설정ToolStripMenuItem.Click += new System.EventHandler(this.예외설정ToolStripMenuItem_Click);
            // 
            // 쿠키삭제ToolStripMenuItem
            // 
            this.쿠키삭제ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("쿠키삭제ToolStripMenuItem.BackgroundImage")));
            this.쿠키삭제ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.쿠키삭제ToolStripMenuItem.Name = "쿠키삭제ToolStripMenuItem";
            this.쿠키삭제ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.쿠키삭제ToolStripMenuItem.Text = "쿠키삭제";
            this.쿠키삭제ToolStripMenuItem.Click += new System.EventHandler(this.쿠키삭제ToolStripMenuItem_Click);
            // 
            // 관리툴ToolStripMenuItem
            // 
            this.관리툴ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("관리툴ToolStripMenuItem.BackgroundImage")));
            this.관리툴ToolStripMenuItem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.관리툴ToolStripMenuItem.Name = "관리툴ToolStripMenuItem";
            this.관리툴ToolStripMenuItem.Size = new System.Drawing.Size(228, 30);
            this.관리툴ToolStripMenuItem.Text = "관리툴";
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.ForeColor = System.Drawing.Color.DeepPink;
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.환경설정ToolStripMenuItem.Text = "환경설정";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(131, 30);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Btn_Config
            // 
            this.Btn_Config.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Config.Location = new System.Drawing.Point(4, 186);
            this.Btn_Config.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Config.Name = "Btn_Config";
            this.Btn_Config.Size = new System.Drawing.Size(166, 34);
            this.Btn_Config.TabIndex = 21;
            this.Btn_Config.Text = "Config";
            this.Btn_Config.UseVisualStyleBackColor = false;
            this.Btn_Config.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(663, 231);
            this.Controls.Add(this.Btn_Config);
            this.Controls.Add(this.Btn_Exception);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_AllProcessKill);
            this.Controls.Add(this.Btn_SelcetProcessKill);
            this.Controls.Add(this.Btn_SizeAdjust);
            this.Controls.Add(this.Btn_Oneclick);
            this.Controls.Add(this.Btn_AddFuction);
            this.Controls.Add(this.Btn_DeleteCookie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DolphinManager";
            this.Activated += new System.EventHandler(this.Form1_Activated1);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Oneclick;
        private System.Windows.Forms.Button Btn_SizeAdjust;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_AddFuction;
        public System.Windows.Forms.Button Btn_AllProcessKill;
        private System.Windows.Forms.Button Btn_SelcetProcessKill;
        public System.Windows.Forms.Button Btn_DeleteCookie;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Btn_Exception;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 기능ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모든프로세스종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선택프로세스종료ToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Config;
        private System.Windows.Forms.ToolStripMenuItem 예외설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 쿠키삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리툴ToolStripMenuItem;
    }
}

