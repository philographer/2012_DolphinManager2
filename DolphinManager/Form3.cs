using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;//Process사용
using System.Collections;
using System.Drawing.Text;//연결리스트 사용

namespace DolphinManager
{
    public partial class Form3 : Form //SelectProcessKill 폼
    {
        Process[] arryProgram = Process.GetProcesses();//프로세스 정보를 배열에 담는다.
        Process[] arryProgram2;
        ArrayList checkitems = new ArrayList();
        bool AllcheckState = false;//전체선택됨
        bool findSameProcess = false;
        bool sayNo = false;
        int count2 = 0;


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) //폼3이 로드될때
        {
            arryProgram = Process.GetProcesses();
            checkedListBox1.Items.Clear();
            for (int i = 0; i < arryProgram.Length; i++) //프로세서의 갯수만큼
            {
                checkedListBox1.Items.Add(arryProgram[i].ProcessName);//체크박스 리스트에 아이템추가
            }
            //checkedListBox1.SetItemChecked(0, true);//선택상태
            //checkedListBox1.SetItemChecked(1, true);//선택상태
           // UncheckAll();//아무것도 체크되지않도록  

          //  PrivateFontCollection privateFonts = new PrivateFontCollection();
           // privateFonts.AddFontFile("hanna.ttf");
           // Font font = new Font(privateFonts.Families[0], 9f);

           // Btn_AllSelect.Font = font;
           // Btn_listboxReset.Font = font;
           // Btn_ReverseSelect.Font = font;
           // Btn_SelectKill.Font = font;
           // Btn_UnCheckAll.Font = font;
           
        }

        

        private void Btn_AllSelect_Click(object sender, EventArgs e) // 모두선택버튼
        {
            if (AllcheckState == false)//모든체크상태가 아니라면
            {
                CheckAll();//모두체크
                AllcheckState = true;//모두체크bool

            }

            else
            {
                UncheckAll();//모두체크해제
                AllcheckState = false;//X모두체크bool
            }

        }

        private void Btn_ReverseSelect_Click(object sender, EventArgs e) // 선택반전
        {
            ReverseAll();
        }



        private void Btn_UnCheckAll_Click(object sender, EventArgs e) // 모두 체크해제
        {
            UncheckAll();
        }

        private void Btn_SelectKill_Click(object sender, EventArgs e) //선택 프로세스 kill, 선택된 프로세스가 다중이면 삭제 안 되는 버그 잡기.
        {
            ProcessSelectKill(); // 프로세스종료
            Btn_listboxReset_Click(sender, e); // 리스트 갱신 (종료함수 실행후 바로 reprint하면 종료중에 남은 프로세스가 
            Btn_listboxReset_Click(sender, e); // 리스트 목록에 들어감 -> 여러번 reprint)
            Btn_listboxReset_Click(sender, e);
            Btn_listboxReset_Click(sender, e);

        }


        //////////////////함수////////////////////
        
        public void ProcessSelectKill() //선택한 목록 종료함수
        {
            int temp = checkedListBox1.CheckedItems.Count; // 반복횟수

            try
            {
                for (int s = 0; s < temp; s++) // 체크리스트박스의 체크한 아이템의 갯수만큼 반복
                {
                    arryProgram2 = Process.GetProcessesByName(checkedListBox1.CheckedItems[0].ToString()); //첫번째 체크한 
                    int temp2 = arryProgram2.Length;                                                       //프로세스의 엔트리를
                                                                                                           //arryProgram2
                                                                                                           //배열에 입력
                    try
                    {
                        for (int i = 0; i < temp2; i++)//프로세서총 개수만큼 반복 
                        {
                            if (arryProgram2[i].ProcessName == "System Idle Process" //예외(중요한 프로세서)
                                || arryProgram2[i].ProcessName == "conhost"
                                || arryProgram2[i].ProcessName == "services"
                                || arryProgram2[i].ProcessName == "lsm"
                                || arryProgram2[i].ProcessName == "dwm"
                                || arryProgram2[i].ProcessName == "explorer" //주석처리하면 열려있는 폴더도 종료실킴
                                || arryProgram2[i].ProcessName == "taskhost.exe"
                                || arryProgram2[i].ProcessName == "taskmgr."
                                || arryProgram2[i].ProcessName == "audiodg"
                                || arryProgram2[i].ProcessName == "wininit"
                                || arryProgram2[i].ProcessName == "smss"
                                || arryProgram2[i].ProcessName == "winlogon"
                                || arryProgram2[i].ProcessName == "wmpnetwk"
                                || arryProgram2[i].ProcessName == "DolphinManager"
                                || arryProgram2[i].ProcessName == "sqlservr"
                                || arryProgram2[i].ProcessName == "sqlwriter"
                                || arryProgram2[i].ProcessName == "spoolsv"
                                || arryProgram2[i].ProcessName == "System"
                                || arryProgram2[i].ProcessName == "searchindenxer"
                                || arryProgram2[i].ProcessName == "devenv"
                                || arryProgram2[i].ProcessName == "IMEDICTUPDATE"
                                || arryProgram2[i].ProcessName == "MpcmdRun"
                                || arryProgram2[i].ProcessName == "lsass"
                                || arryProgram2[i].ProcessName == "svchost"
                                || arryProgram2[i].ProcessName == "csrss"
                                || arryProgram2[i].ProcessName == "DolphinManager.vshost"
                                || arryProgram2[i].ProcessName == "Idle"
                                || arryProgram2[i].ProcessName == "conhost"
                                || arryProgram2[i].ProcessName == "ctfmon" //한글입력기
                               )
                            {
                                if (MessageBox.Show(arryProgram2[i].ProcessName + ": 이프로세서를 종료하면 문제가 발생할 수 있습니다. 종료하시겠습니까?", "Kill?", MessageBoxButtons.OKCancel) == DialogResult.OK)// 0? i?
                                {
                                    checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[i]);
                                    arryProgram2[i].Kill();
                                    continue;
                                }

                                else
                                {
                                    checkedListBox1.SetItemCheckState(checkedListBox1.CheckedIndices[i], CheckState.Unchecked);
                                    continue;
                                }
                            }
                            checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                            arryProgram2[i].Kill();//프로세서 종료. arryProgram[i].CloseMainWindow와 다름
                        }//for문의 끝
                    }//1번째 try의 끝1

                    catch // 종료할 수 없는 프로세스 or 자식이 있는 프로세스인데 부모프로세스 종료후 따라 종료되지 못한 프로세스
                    {                                   //ex) chrome, internetExplorer 같이 한 프로그램을 실행하면 같은이름으로
                                                        //여러 프로세스가 실행되는 프로그램에서 부모 프로세스를 종료하고 나면
                                                        //자식프로세스를 종료하려고 할때 예외처리.(checkedListBox1 에서 자식프로
                                                        //세스 체크드아이템들을 삭제함.
                        int count = checkedListBox1.CheckedItems.Count;//반복횟수 = 체크한 아이템
                        
                        for (int i = 0; i < count-2; i++ )
                        {
                            if ((String)checkedListBox1.CheckedItems[0] == (String)checkedListBox1.CheckedItems[1])
                                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                        }
                        checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                    }
                }
            }
            catch
            {

            }
        }//선택종료 함수의 끝

        private void CheckAll()//체크리스트박스의 리스트들을 모두체크하는 함수
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void UncheckAll()//체크리스트박스의 리스트들을 모두체크해제하는 함수
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void ReverseAll()//체크리스트박스의 리스트들을 모두반전하는 함수
        {
             for (int i = 0; i < checkedListBox1.Items.Count; i++)
             {
                 if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                     checkedListBox1.SetItemChecked(i, false);
                 else
                     checkedListBox1.SetItemChecked(i, true);
             }
        }

        private void Btn_listboxReset_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();// 체크박스 목록 비우고 

            arryProgram = Process.GetProcesses(); //프로세서 목록을 다시담고

            for (int i = 0; i < arryProgram.Length; i++) //프로세서의 갯수만큼
            {
                checkedListBox1.Items.Add(arryProgram[i].ProcessName);//체크박스 리스트에 아이템추가
            }

        }



        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    int count = checkedListBox1.Items.Count;

                    while (count2 < count)
                    {
                        if ((String)checkedListBox1.Items[e.Index] == (String)checkedListBox1.Items[count2])//같은 프로세스가 있는지 검사
                        {
                            if (e.Index == count2)
                            {
                                count2++;
                            }
                            else
                            {
                                if (findSameProcess == false && sayNo == false)
                                {
                                    if (MessageBox.Show((String)checkedListBox1.Items[e.Index] + ": 동일명의 프로세스가 존재합니다. 다중선택합니까?", "Select?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                                    {
                                        findSameProcess = true;
                                        
                                        count2++;
                                        checkedListBox1.SetItemCheckState((count2-1), CheckState.Checked);
                                        
                                    }
                                    else
                                    {
                                        sayNo = true;
                                        //checkedListBox1.SetItemCheckState(count2, CheckState.Unchecked);
                                    }
                                }
                                else if(sayNo==false)// 같은프로세스 찾았고, yes클릭
                                {
                                    count2++;
                                    checkedListBox1.SetItemCheckState((count2) - 1, CheckState.Checked);
                                }
                                else //같은프로세스 찾았고 N 클릭
                                {
                                    count2++;
                                    
                                }

                            }
                        }
                        else
                        {
                            count2++;
                        }
                    }//while 끝               
                }//if checkbox == uncheck 끝
                findSameProcess = false;
                sayNo = false;
                return;
        }//선택종료 함수의 끝

        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {
            count2 = 0;
        }

        
    }
    }// end of public particial class




        

  

