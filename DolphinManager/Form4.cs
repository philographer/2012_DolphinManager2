using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Drawing.Text;//Process사용

namespace DolphinManager
{
    public partial class Form4 : Form
    {


        ArrayList Config = new ArrayList();
        ArrayList Config2 = new ArrayList();
        Process[] arryProgram = Process.GetProcesses();//프로세스 정보를 배열에 담는다.
        Process[] arryProgram2;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) // 폼이 열릴때
        {
            MessageBox.Show("예외프로세스 입력시 .exe는 입력하지 않아야 합니다. 대소문자 구별. 띄어쓰기 포함     \n예시)ALSong");

            arryProgram = Process.GetProcesses();
            checkedListBox1.Items.Clear();
            for (int i = 0; i < arryProgram.Length; i++) //프로세서의 갯수만큼
            {
                checkedListBox1.Items.Add(arryProgram[i].ProcessName);//체크박스 리스트에 아이템추가
            }
            checkedListBox1.SetItemChecked(0, true);//선택상태
            checkedListBox1.SetItemChecked(1, true);//선택상태
            UncheckAll();//아무것도 체크되지않도록 

           /// PrivateFontCollection privateFonts = new PrivateFontCollection();
            //privateFonts.AddFontFile("hanna.ttf");
           // Font font = new Font(privateFonts.Families[0], 9f);

          //  Btn_addExceptionProcess.Font = font;
          //  Btn_addProcess.Font = font;
          //  Btn_deleteExceptionProcess.Font = font;
         //   Btn_exceptionSave.Font = font;

        }



        private void Btn_execptionSave_Click(object sender, EventArgs e)//예외설정 저장버튼
        {
            Config2.Clear();
            StreamWriter sw2; //예외설정 저장
            sw2 = new StreamWriter(@"C:\temp\Config2.txt");

            for (int i = 0; i < ListBox_Process.Items.Count; i++)
            {
                Config2.Add(ListBox_Process.Items[i]);
            }
            for (int i = 0; i < ListBox_Process.Items.Count; i++)
            {
                Config2[i] += "\r\n";
                sw2.Write(Config2[i]);
            }
            sw2.Close();

            this.Close();
            Config2.Clear();
        }

        private void Btn_addExceptionProcess_Click(object sender, EventArgs e)//예외 프로세스 추가버튼
        {
            if (TxtBox_Send.Text == "")
                MessageBox.Show("프로세스이름이 입력되지 않았습니다.");
            else
            {
                ListBox_Process.Items.Add(TxtBox_Send.Text.ToString());

                TxtBox_Send.Clear();
            }
        }

        private void Btn_deleteExceptionProcess_Click(object sender, EventArgs e) //예외 프로세스 제거버튼
        {

            int nIndex = ListBox_Process.SelectedIndex;
            if (nIndex >= 0)
            {
                ListBox_Process.Items.RemoveAt(nIndex); //선택한 인덱스를 리스트박스에서 제거
            }

            else
            {
                MessageBox.Show("삭제할 파일이 없습니다.", "파일 삭제"); //인덱스에서 선택하지 않았을때
            }
        }



        private void TxtBox_Send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Btn_addExceptionProcess_Click(sender, e);
        }

        private void TxtBox_Send_Click(object sender, EventArgs e)
        {
            if (TxtBox_Send.Text == "InputProcessName")
                TxtBox_Send.Text = "";
        }

        private void UncheckAll()//체크리스트박스의 리스트들을 모두체크해제하는 함수
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void Btn_addProcess_Click(object sender, EventArgs e)
        {
            int count = checkedListBox1.CheckedItems.Count;
            int count2 = ListBox_Process.Items.Count;
            bool sameProcess = false;

            for (int i = 0; i < count; i++)//프로세스 동일명인지 검사
            {
                arryProgram2 = Process.GetProcessesByName(checkedListBox1.CheckedItems[0].ToString());
                for (int i2 = 0; i2 < count2; i2++)
                {

                    if (arryProgram2[0].ProcessName == (String)ListBox_Process.Items[i2])
                    {
                        sameProcess = true; // 같은프로세스 찾음
                    }
                }


                    if (sameProcess == true)
                    {
                        MessageBox.Show(checkedListBox1.CheckedItems[0] + "는 이미 예외목록에 존재합니다.");
                    }
                    else
                    {
                        ListBox_Process.Items.Add(checkedListBox1.CheckedItems[0]);
                    }
                checkedListBox1.Items.Remove(checkedListBox1.CheckedItems[0]);
                sameProcess = false;
            }
            }//end of add to execption 함수
        } // end of public
} //end of namespace
