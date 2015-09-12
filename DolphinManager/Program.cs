using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace DolphinManager
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
           //Application.Run(new Form1());


            ////////////////////////////////////////////////////////////////////////////////////////////
            
              
            bool createdNew;
            Mutex dup = new Mutex(true, "WIA_DIO_COM", out createdNew);
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                dup.ReleaseMutex();
             
            }
            else
            {
                ////중복실행에 대한 처리
                //System.Media.SystemSounds.Beep.Play();f
                MessageBox.Show("Program Running... System OFF!");
            }
            
            
            
        }
    }
}
