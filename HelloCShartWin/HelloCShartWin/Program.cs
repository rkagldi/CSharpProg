using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCShartWin
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main() //프로그램의 시작점
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator()); //Form1을 만들어서 띄우는 기능.
            //윈도우폼은 메인에 손댈것 없고 Form에서 코딩하면됨



        }
    }
}
