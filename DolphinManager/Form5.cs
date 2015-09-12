using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing.Text;

namespace DolphinManager
{
    public partial class Form5 : Form
    {
        Form6 child5;

        public Form5()
        {
            child5 = new Form6();
            InitializeComponent();
        }

        private void Btn_DiskDefrag_Click(object sender, EventArgs e)//디스크 조각모음
        {
            System.Diagnostics.Process.Start(@"c:\windows\system32\dfrgui.exe");
        }

        private void Btn_DiskArrangement_Click(object sender, EventArgs e)
        {
            Process.Start("C:/windows/system32/cleanmgr.exe");//윈도우 디스크정리시작
        }

        private void Btn_diskCheck_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/K cd.. & cd.. & cd.. & cd.. & cd.. & cd.. &cd..&cd..&cd..&chkdsk"); //디스크체크
        }

        private void Btn_comSatatus_Click(object sender, EventArgs e) //컴퓨터 상태표시
        {
            if (child5.IsDisposed) // 컨트롤이 죽었으면 
            {
                child5 = new Form6(); // 다시 인스턴스생성
                child5.ShowDialog();//자식폼4 보여줌
            }
            else
            {
                child5.ShowDialog();//자식폼4 보여줌
            }

           

        }

        private void Form5_Load(object sender, EventArgs e)
        {
         //   PrivateFontCollection privateFonts = new PrivateFontCollection();
        //    privateFonts.AddFontFile("hanna.ttf");
         //   Font font = new Font(privateFonts.Families[0], 9f);
         //   Btn_comSatatus.Font = font;
         //   Btn_DiskArrangement.Font = font;
         //   Btn_diskCheck.Font = font;
          //  Btn_DiskDefrag.Font = font;
        }
    }
}
