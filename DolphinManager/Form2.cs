using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Drawing.Text;


namespace DolphinManager
{
    public partial class Form2 : Form  //Config폼
    {
        ArrayList ConfigAlways = new ArrayList();//항상위설정 연결리스트 사용O
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //PrivateFontCollection privateFonts = new PrivateFontCollection();
            //privateFonts.AddFontFile("hanna.ttf");
           // Font font = new Font(privateFonts.Families[0], 9f);

           // Btn_configSave.Font = font;
          //  CkBox_Always.Font = font;
           // CkBox_OneClick.Font = font;
           // CkBox_Keyboard.Font = font;


        }
        private void Btn_saveConfig_Click(object sender, EventArgs e) // SaveButton 클릭
        {
            if(CkBox_Keyboard.CheckState == CheckState.Checked)
            {//
                Properties.Settings.Default.KeyHook = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KeyHook = false;
                Properties.Settings.Default.Save();
                
            }




            ConfigAlways.Clear();
            if (CkBox_OneClick.CheckState == CheckState.Checked)
            {
                ConfigAlways.Add("true");
            }

            else
            {
                ConfigAlways.Add("false");
            }

            if (CkBox_Always.CheckState == CheckState.Checked)
            {
                ConfigAlways.Add("true");
            }

            else
            {
                ConfigAlways.Add("false");
            }

            StreamWriter sw; //configSave한 결과를 파일로 저장
            sw = new StreamWriter(@"C:\temp\Config.txt");


            for (int i = 0; i < ConfigAlways.Count; i++)
            {
                ConfigAlways[i] += "\r\n";
                sw.Write(ConfigAlways[i]);

            }
            sw.Close();

            this.Close();
        }
    }   
    }