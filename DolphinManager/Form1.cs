using System;
using System.Collections;//연결리스트
using System.Diagnostics;//프로세스확인
using System.IO;//파일입출력
using System.Runtime.InteropServices;
using System.Security.Principal;//사용자이름얻기
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using Gma.UserActivityMonitor;



/* 부족한코드 하나하나 살펴봐 주셔서 감사합니다. 부족한 실력이지만 꼭 Software Maestro에 들어가고 싶습니다. 잘 부탁드립니다!
 * 배움을 갈망하며.
 * 150507 17:00 FinalVer.
 * Copyright 2012-2015 by Yoohogyun. All Rights Reserved.
 */

namespace DolphinManager
{

    public partial class Form1 : Form
    {
        //GlobalKeyListener gkh = new GlobalKeyListener();
       
     

        Form2 child1; //폼1 설정 child config
        Form3 child2; //폼2 설정 child select process kill
        Form4 child3; //폼3 설정 child exception process
        Form5 child4; //폼4 설정 child toolBox
        
        string[] files;
        ArrayList aFilePathList = new ArrayList();//파일의경로를 저장하는 연결리스트 
        ArrayList aFileNameList = new ArrayList();//파일의경로를 저장하는 연결리스트 
        ArrayList aFileExceptFile = new ArrayList();//예외파일이름 
        ArrayList ExceptFileName = new ArrayList();//예외파일경로 연결리스트
        ArrayList ConfigAlways = new ArrayList();//환경설정 연결리스트
        ArrayList Config = new ArrayList(); //환경설정
        ArrayList ChromeData = new ArrayList();//크롬쿠키삭제를 위한 연결리스트

      
           
        
        bool find = false;//프로세스찾음  
        bool findchrome = false;//크롬찾음
        [DllImport("user32")]
        public static extern UInt32 SendMessage(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);//방패아이콘
        internal const int BCM_FIRST = 0x1600;//방패
        internal const int BCM_SETSHIELD = (BCM_FIRST + 0x000C);//방패
        
  
        public Form1()
        {
          child1 = new Form2(); //자식폼1 생성(환경설정)
          child2 = new Form3(); //자식폼2 생성(선택종료)
          child3 = new Form4(); //자식폼3 생성(예외처리)
          child4 = new Form5(); //자식폼4 생성(부가기능)
          InitializeComponent();
           
          

          if (IsUserAdmin() == true) //관리자 계정이 확인되면 제목창 바꿈, 방패모양 제거
          {

              this.Text += " (Admin authorization Ok )";

          }
          else //관리자계정이 아닐경우 관리필요한 버튼에 방패모양 부여
          {
              this.Text += " (Admin authorization required)";
              AddShieldToButton(Btn_AllProcessKill);
              AddShieldToButton(Btn_SelcetProcessKill);
              AddShieldToButton(Btn_DeleteCookie);
          }
          

          
            
        }  
        
       public bool IsUserAdmin() // 돌핀매니져를 실행할 권한이 있는지 체크
        {
            bool isAdmin; //isAdmin == true => 관리자, false => 관리자X
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal pp = new WindowsPrincipal(user);
                isAdmin = pp.IsInRole(WindowsBuiltInRole.Administrator);
            }
           catch(UnauthorizedAccessException ex)
            {
               isAdmin = false;
           }
           return isAdmin;
        }

        public void checkAdmin() //관리자인지 아닌지 확인하는 함수
       {
            if(IsUserAdmin() == true) //관리자권한
            {
                MessageBox.Show("현재 관리자 권한으로 실행 중입니다. 프로그램이 동작합니다.");
            }

            else//관리자권한 x
            {
                if (MessageBox.Show("현재 관리자 권한이 아닙니다. 프로그램이 동작하지 않을 수 있습니다. 프로그램을 종료하고 관리자 권한으로 실행하시겠습니까?", "AdminAccess?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.UseShellExecute = true;
                    startInfo.WorkingDirectory = Environment.CurrentDirectory;
                    startInfo.FileName = Application.ExecutablePath;
                    startInfo.Verb = "runas";
                    
                    try
                    {
                        Process p = Process.Start(startInfo);
                    }
                    catch (System.ComponentModel.Win32Exception ex)
                    {
                        return; //If cancelled, do nothing
                    }

                    try
                    {
                        Application.ExitThread();
                        
                    }
                    catch
                    {
                        //Form.ActiveForm.Dispose();
                        //Application.Exit();
                        Application.ExitThread();
                    }
                }
                else
                {
                    MessageBox.Show("관리자권한이 아니면 프로그램이 제대로 동작하지 않을 수 있습니다.");//Nothing
                }
            }
       }

        public void AddShieldToButton(Button b)
        {
            b.FlatStyle = FlatStyle.System;
           SendMessage(b.Handle, BCM_SETSHIELD, 0, 0xFFFFFFFF);
           b.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            
        }

        
        private void Form1_Load(object sender, EventArgs e)//폼실행시
        {
         
               checkAdmin();// 관리자권한 있는지 없는지 확인
            
               DirectoryInfo temp = new DirectoryInfo(@"C:\temp"); //환경설정 저장을 위한 폴더, 파일입출력
               if (temp.Exists == false)
               {
                   temp.Create();
               }

               try//환경설정을 가져옴
               {

                   FileStream fs = new FileStream(@"C:\temp\Config.txt", FileMode.Open);
                   StreamReader r = new StreamReader(fs);
                   while (!r.EndOfStream)
                   {
                       ConfigAlways.Add(r.ReadLine());
                   }
                   r.Close();
                   r.Dispose();
                   
                   if (ConfigAlways[0].ToString() == "true")//프로세스 종료시 쿠키도 삭제 체크박스
                   {
                       child1.CkBox_OneClick.CheckState = CheckState.Checked;
                   }

                   if (ConfigAlways[1].ToString() == "true")//창 항상위 체크박스
                   {
                       child1.CkBox_Always.CheckState = CheckState.Checked;
                   }
                   
               }

               catch
               {

               }

               try //예외처리목록을 가져옴
               {
                   FileStream fs3 = new FileStream(@"C:\temp\Config2.txt", FileMode.Open);
                   StreamReader r3 = new StreamReader(fs3);
                   while (!r3.EndOfStream)
                   {
                       child3.ListBox_Process.Items.Add(r3.ReadLine());
                   }
                   r3.Close();
               }

               catch//환경설정 파일이 없어서 못 가져올경우
               {
                   if (MessageBox.Show("프로그램을 초기실행시 환경설정을 진행해야합니다. 진행하시겠습니까?", "Config?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                   {
                       child3 = new Form4(); //다시 인스턴스생성
                       child3.ShowDialog();//자식폼2 보여줌
                   }
               }
              /* 폰트 설정하면오류...
               PrivateFontCollection privateFonts = new PrivateFontCollection();
               privateFonts.AddFontFile("hanna.ttf");
               Font font = new Font(privateFonts.Families[0], 9f);
               Btn_AddFuction.Font = font;
               Btn_AllProcessKill.Font = font;
               Btn_DeleteCookie.Font = font;
               Btn_Exit.Font = font;
               Btn_SizeAdjust.Font = font;
               Btn_SelcetProcessKill.Font = font;
               Btn_Config.Font = font;
               Btn_Exception.Font = font;
            */

               if (Properties.Settings.Default.KeyHook == true) //설정값에 키보드 후킹이 true
               {
                   child1.CkBox_Keyboard.CheckState = CheckState.Checked; //설정값 체크
               }
               if (child1.CkBox_Keyboard.CheckState == CheckState.Checked)
               {
                   HookManager.KeyUp += HookManager_KeyUp;
               }

               else
               {
                   HookManager.KeyUp -= HookManager_KeyUp;
                   
               }
              
            
               
        }
        
      private void Btn_Oneclick_Click(object sender, EventArgs e) //원클릭기능 버튼 돌핀그림
        {
          ProcessAllKill(); //자식폼에서 모든프로세스종료함수 실행
          DeleteCookie();//자식폼에서 쿠키삭제함수 실행
        }

        private void Btn_SizeAdjust_Click(object sender, EventArgs e) //
        {
            if (this.Height == 204 && this.Width == 480)
            {
                this.Height = 170;
                this.Width = 137;
            }

            if(this.Height == 170 && this.Width == 137)
            {
                this.Height = 204;
                this.Width = 480;

            }
        }
   

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Width = 137;
            this.Height = 170;
            //gkh.unhook();
        }

        private void Btn_AllProcessKill_Click(object sender, EventArgs e)
        {
            ProcessAllKill();
            if (child1.CkBox_OneClick.CheckState == CheckState.Checked)
                DeleteCookie();
        }

        private void Btn_SelcetProcessKill_Click(object sender, EventArgs e)
        {
            if (child2.IsDisposed) // 컨트롤이 죽었으면 ☆
            {
                
                child2 = new Form3(); // 다시 인스턴스생성
                child2.ShowDialog();//자식폼2 보여줌
            }
            else
            {
                child2.ShowDialog();//자식폼2 보여줌
            }
        }

        private void Btn_DeleteCookie_Click(object sender, EventArgs e)
        {
            DeleteCookie();
        }

        private void Btn_DiskArrangement_Click(object sender, EventArgs e)
        {
            Process.Start("C:/windows/system32/cleanmgr.exe");//윈도우 디스크정리시작
        }

        private void Btn_CheckComputer_Click(object sender, EventArgs e)
        {
            if (child4.IsDisposed) // 컨트롤이 죽었으면 
            {
                child4 = new Form5(); // 다시 인스턴스생성
                child4.Show();//자식폼4 보여줌
            }
            else
            {
                child4.Show();//자식폼4 보여줌
            }    
        }

        public void ProcessAllKill() //모든프로세스종료 함수 시작
        {
            if (MessageBox.Show("모든 프로세스를 정리합니다. 정리합니까??", "Clean?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ExceptFileName.Clear();
                Process[] arryProgram = Process.GetProcesses(); //프로세서를 담는 배열
                {
                    ExceptFileName.Add("System Idle Process"); //예외(중요한 프로세서)
                    ExceptFileName.Add("conhost");
                    ExceptFileName.Add("services");
                    ExceptFileName.Add("lsm");
                    ExceptFileName.Add("dwm");
                    ExceptFileName.Add("taskhost.exe");
                    ExceptFileName.Add("taskmgr.");
                    ExceptFileName.Add("audiodg");
                    ExceptFileName.Add("wininit");
                    ExceptFileName.Add("smss");
                    ExceptFileName.Add("winlogon");
                    ExceptFileName.Add("wmpnetwk");
                    ExceptFileName.Add("DolphinManager");
                    ExceptFileName.Add("sqlservr");
                    ExceptFileName.Add("sqlwriter");
                    ExceptFileName.Add("spoolsv");
                    ExceptFileName.Add("System");
                    ExceptFileName.Add("searchindenxer");
                    ExceptFileName.Add("devenv");
                    ExceptFileName.Add("IMEDICTUPDATE");
                    ExceptFileName.Add("MpcmdRun");
                    ExceptFileName.Add("lsass");
                    ExceptFileName.Add("svchost");
                    ExceptFileName.Add("csrss");
                    ExceptFileName.Add("DolphinManager.vshost");
                    ExceptFileName.Add("Idle");
                    ExceptFileName.Add("conhost");
                    ExceptFileName.Add("ctfmon");//한글입력기
                    //if (child3.CkBox_Explorer.CheckState == CheckState.Unchecked)
                    ExceptFileName.Add("explorer"); //주석처리하면 열려있는 폴더도 종료시킴
                    //if (child3.CkBox_Chrome.CheckState == CheckState.Unchecked)
                    //ExceptFileName.Add("chrome");//크롬종료
                    //if (child3.CkBox_Internet.CheckState == CheckState.Unchecked)
                    //ExceptFileName.Add("iexplore");//인터넷종료
                    for (int i = 0; i < child3.ListBox_Process.Items.Count; i++)
                    {
                        ExceptFileName.Add(child3.ListBox_Process.Items[i]);
                    }

                }

                int ExptCount = ExceptFileName.Count;

                for (int i = 0; i < arryProgram.Length; i++)//프로세서총 개수만큼 반복 //알고리즘1
                {

                    try
                    {
                        find = false;

                        for (int i2 = 0; i2 < ExptCount; i2++)
                        {
                            if (
                                arryProgram[i].ProcessName == ExceptFileName[i2].ToString()
                               )
                            {
                                find = true;
                            }

                            //프로세서 종료. arryProgram[i].CloseMainWindow와 다름
                        }

                        if (find == false)
                        {
                            arryProgram[i].Kill();
                        }
                        else
                            continue;
                    }

                    catch
                    {
                    }


                }//for문의 끝
                /*
                for (int s2 = 0; s2 < aFilePathList.Count; s2++)프로세스 재실행코드
                {
                    Process.Start(aFilePathList[s2].ToString());
                } //모든프로세스가 종료되고 다시시작됨
                */
            }
            else
            {

            }
        }//모든프로세스종료 함수의 끝

        static void DeleteTempDirectory(string sTempFilesPath) //임시파일 비움
        {
            string[] sTempDiretories = Directory.GetDirectories(sTempFilesPath);
            try
            {
                foreach (string sTempDirectory in sTempDiretories)
                {
                    DeleteTempDirectory(sTempDirectory);
                }
            }
            catch
            { }
            string[] sTempFiles = Directory.GetFiles(sTempFilesPath);
            try
            {
                foreach (string sTempFile in sTempFiles)
                {

                    System.IO.File.Delete(sTempFile);
                }
            }
            catch
            { }
        }


        public void DeleteCookie() // 쿠키파일 비움
        {
            if (MessageBox.Show("쿠키삭제를 삭제하시겠습니까?", "DeleteCookie?", MessageBoxButtons.OKCancel) == DialogResult.OK)
            { 
                //System.Environment.SpecialFolder.Cookies
                //Recent
                //InternetCache
                //Cookies
                //history
                //C:\Users\HP\AppData\Local\Temp\Temporary Internet Files
                //C:\Users\HP\AppData\Local\Microsoft\Windows

            Process[] arryNowprogram = Process.GetProcesses();

            try
            {    
                for (int i = 0; i < arryNowprogram.Length; i++)//크롬검사
                {
                    if (arryNowprogram[i].ProcessName == "chrome")
                        findchrome = true;
                }

                if (findchrome == true)
                {
                     if (MessageBox.Show("크롬을 종료해야 쿠키가 정상적으로 삭제됩니다. 종료하시겠습니까?", "KillChrome?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                      
                         try
                         {
                             for (int s = 0; s < arryNowprogram.Length; s++) //크롬을 따로 종료시키기위한 for문
                                        {
                                                if (arryNowprogram[s].ProcessName == "chrome")
                                                                 {arryNowprogram[s].Kill();}
                                        }
                         }
   
                         catch
                         {
                         }
                }

                findchrome = false;
            }
            catch
            {
            }

          string chromePath2 =System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString() +"\\Google\\Chrome\\User Data";
          string[] chromePath2arr = Directory.GetFiles(chromePath2, "*.*", System.IO.SearchOption.AllDirectories);//디렉토리안에 있는 모든파일,폴더를 선택

          ChromeData.Add(chromePath2 + "\\Default\\Web Data-journal"); //ChromeData . 크롬의 임시데이터 파일들
          ChromeData.Add(chromePath2 + "\\Default\\Web Data");
          ChromeData.Add(chromePath2 + "\\Default\\Visited Links");
          ChromeData.Add(chromePath2 + "\\Default\\Top Sites-journal");
          ChromeData.Add(chromePath2 + "\\Default\\Top Sites");
          ChromeData.Add(chromePath2 + "\\Default\\Shortcuts-journal");
          ChromeData.Add(chromePath2 + "\\Default\\Shortcuts");
          ChromeData.Add(chromePath2 + "\\Default\\Login Data-journal");
          ChromeData.Add(chromePath2 + "\\Default\\Login Data");
          ChromeData.Add(chromePath2 + "\\Default\\History-journal");
          ChromeData.Add(chromePath2 + "\\Default\\History Provider Cache");
          ChromeData.Add(chromePath2 + "\\Default\\History Index 2012-11-journal");
          ChromeData.Add(chromePath2 + "\\Default\\History Index 2012-11");
          ChromeData.Add(chromePath2 + "\\Default\\History");
          ChromeData.Add(chromePath2 + "\\Default\\Current Tabs");
          ChromeData.Add(chromePath2 + "\\Default\\Current Session");
          ChromeData.Add(chromePath2 + "\\Default\\Cookies-journal");
          ChromeData.Add(chromePath2 + "\\Default\\Cookies");
          ChromeData.Add(chromePath2 + "\\Default\\Archived History-journal");
          ChromeData.Add(chromePath2 + "\\Default\\Archived History");


              for (int i = 0; i < 20; i++)
              {
                  try
                  {
                      File.Delete(ChromeData[i].ToString()); // 임시폴더내 파일들 삭제
                  }

                  catch
                  {
                      continue;
                  }
              }

              ChromeData.Clear();

            ///////////////익스플로러쿠키삭제 ↓

            try{
                string TempCache = System.Environment.GetFolderPath(System.Environment.SpecialFolder.InternetCache);// 디렉토리선언(?)
                string[] TempFiles = Directory.GetFiles(TempCache, "*.*", System.IO.SearchOption.AllDirectories);//디렉토리안에 있는 모든파일,폴더를 선택
                foreach (string TempFile in TempFiles)
                {
                        {
                            Directory.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.InternetCache), true);
                        }
                }
            }
            catch{
            }

            try{
                string TempRecent = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Recent);//11.20/2:25
                string[] TempRecentFiles = Directory.GetFiles(TempRecent, "*.*", System.IO.SearchOption.AllDirectories);
                foreach (string TempFile in TempRecentFiles)
                {
                        {
                            Directory.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Recent), true);
                        }
                }
            }
            catch
            {
            }
            try{
                 string TempCookie = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Cookies);
                 string[] TempCookieFiles = Directory.GetFiles(TempCookie, "*.*", System.IO.SearchOption.AllDirectories);

                foreach (string TempFile in TempCookieFiles)
                {
                    
                        {
                            Directory.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Cookies), true);
                        }
                }
            }
            catch
            {
            }

            try{
                 string TempHistory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.History);
                 string[] TempHistoryFiles = Directory.GetFiles(TempHistory, "*.*", System.IO.SearchOption.AllDirectories);
                foreach (string TempFile in TempHistoryFiles)
                {

                        {

                            Directory.Delete(System.Environment.GetFolderPath(System.Environment.SpecialFolder.History), true);
                        }
                }
            }
            catch{
            }

            try{
                string path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
                //for deleting files
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete(); 
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true); //delete subdirectories and files
                }
            }

            catch
            {
            }

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
                //for deleting files
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true); //delete subdirectories and files
                }
            }

            catch
            {
            }

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.History);
                //for deleting files
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true); //delete subdirectories and files
                }
            }

            catch
            {
            }


            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
                //for deleting files
                System.IO.DirectoryInfo di = new DirectoryInfo(path);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true); //delete subdirectories and files
                }
            }

            catch
            {
            }

            MessageBox.Show("Cookie가 삭제되었습니다.");
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //OFD 생성
            openFileDialog1.Filter = "exe Files(*.exe;)|*.exe;|" +
            "All files (*.*)|*.*"; // 선택가능한 확장자 필터
            openFileDialog1.DefaultExt = "exe"; //초기 선택값
            openFileDialog1.Multiselect = true; //다중선택 설정
            this.openFileDialog1.Title = "Start exe Browser"; //OFD창 이름

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // 파일 열기 대화상자에서 파일 클릭 후 열기 버튼 눌렀다면?
            {
                files = openFileDialog1.SafeFileNames; // 열기 대화상자에서 선택한 파일 이름들을 모두 가져옴
                //paths = openFileDialog1.FileNames; // 여기도 마찬가지, 다만 FileNames는 전체 경로를 포함합함

                this.aFilePathList.AddRange(openFileDialog1.FileNames); //OFD에서 가져온 파일들의 경로들을 aFilePathList araaylist 에 저장
                this.aFileNameList.AddRange(openFileDialog1.SafeFileNames);
               //이거하면 전에있던 연결리스트가 날아감   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            }

        private void button3_Click(object sender, EventArgs e) //환경설정(예외파일exe)
        {

            if (child3.IsDisposed) // 컨트롤이 죽었으면 ☆
            {
                child3 = new Form4(); // 다시 인스턴스생성
                child3.ShowDialog();//자식폼2 보여줌
            }
            else
            {
                child3.ShowDialog();//자식폼2 보여줌
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //시작표시줄? 에있는 돌핀아이콘 더블클릭할때
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다

        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Application.Exit();
            //gkh.unhook();
            this.Dispose();
            this.Close();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true; // 폼의 표시
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal; // 최소화를 멈춘다 
            this.Activate(); // 폼을 활성화 시킨다
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //돌핀플레이어를 x버튼눌러 종료하려고 할때
        {
            e.Cancel = true; // 종료 이벤트를 취소 시킨다
            this.Visible = false; // 폼을 표시하지 않는다;
        }


        private void 모든프로세스종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_AllProcessKill_Click(sender, e);
        }

        private void 선택프로세스종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_SelcetProcessKill_Click(sender, e);
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click_1(sender, e);
        }

        private void Form1_Activated1(object sender, EventArgs e) // 폼이 살아있을경우 , 항상위가 체크되어있으면 항상위 실행
        {
                if (child1.CkBox_Always.CheckState == CheckState.Checked)
                {
                    try
                    {
                        Form1.ActiveForm.TopMost = true;
                    }

                    catch
                    {
                    }
                }

                else
                {
                    try
                    {
                        Form1.ActiveForm.TopMost = false;
                    }

                    catch
                    {
                    }
                }
        }
        
        
        public bool EmptyIETemporaryInternetFiles(DirectoryInfo d) //IE 임시파일 삭제
        {
            try
            {
                foreach (FileInfo f in d.GetFiles())
                {
                    f.Delete();
                }
                foreach (DirectoryInfo sub in d.GetDirectories())
                {
                    //call ourselves to make sure we get everything
                    EmptyIETemporaryInternetFiles(sub);
                }
                return true;
            }
            catch 
            {
                return false;
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
             if (child1.IsDisposed) // 컨트롤이 죽었으면 ☆
             {
                 child1 = new Form2(); // 다시 인스턴스생성
                 child1.ShowDialog();//자식폼2 보여줌
             }
             else
             {
                 child1.ShowDialog();//자식폼2 보여줌
             }
        }

        private void 예외설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3_Click(sender, e);
        }

        private void 쿠키삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_DeleteCookie_Click(sender, e);
        }


        void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Btn_AllProcessKill_Click(sender, e);
            }
        }

        [DllImport("user32.dll")]
        static extern uint keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        private void Form1_Leave(object sender, EventArgs e)
        {
            //gkh.unhook();

        }




    }

        }
/*
 * 추가 필요사항
 * 다중선택종료 알고리즘 다시짜기 ok
 * 예외처리 placeholder ok
 * 관리자권한x시 방패모양아이콘 ok
 * -----------------------------------------------------------------------
 * 선택종료시 종료해도 listbox에 남는버그ok
 * alsong과 chrome, explorer 같이종료 안 되는 버그 ok
 * 선택종료시 같은프로세서 이름 있으면 한번에 제거 
 * -----------------------------------------------------------------------
 * 예외처리에서 프로세스이름 선택 -> 예외목록으로 추가 ok
 * 예외처리에서 이미 예외에 있으면 추가기능 막기 ok
 * 예외처리에서 어떤 프로세스인지 설명 
 * ---------------------------------------------------------------------
 * 키보드로 원클릭 이벤트 ok
 * 키보드 설정 config에 추가 , 환경설정 파일저장 -> setting에저장해보기 시도 ok
 * ---------------------------------------------------------------------
 * 
*/
