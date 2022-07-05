using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* 중복 실행 방지 */
            Process[] procs = Process.GetProcessesByName("MultiMonitorManager");

            if (procs.Length > 0)
            {
                WarningDuplicatedHotkey w = new WarningDuplicatedHotkey("Warning", "The application is already running.");
                w.ShowDialog();
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                BaseForm form = new BaseForm();
                Application.Run();
            }
        }
    }
}
