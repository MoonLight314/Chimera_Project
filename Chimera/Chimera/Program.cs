using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
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
            /* UD5가 Attached되어 있는지 확인 후 실행 */
            if ( CheckDeviceInstalled() )
            {
                WarningDuplicatedHotkey w = new WarningDuplicatedHotkey("Warning", "The device is not installed.");
                w.ShowDialog();
                return;
            }

            /* 중복 실행 방지 */
            if ( CheckDuplicatedRunning() )
            {
                WarningDuplicatedHotkey w = new WarningDuplicatedHotkey("Warning", "The application is already running.");
                w.ShowDialog();
                return;
            }
            
            /*  */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BaseForm form = new BaseForm();
            Application.Run();

        }


        /**
        UD5가 설치된 경우에만 Application이 실행되도록 수정.
            - Ethernet Card의 이름(Description)과 MAC Address의 첫 3 Byte를 확인하는 방식으로 UD5를 Detect한다.
        */
        static bool CheckDeviceInstalled()
        {
            bool Ret = true;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                string MAC_Address = nic.GetPhysicalAddress().ToString();
                string Name = nic.Description;
                
                if (string.IsNullOrEmpty(MAC_Address) == false && string.IsNullOrEmpty(Name) == false)
                {
                    string MAC_Address_Prefix = MAC_Address.Substring(0, Properties.Resources.UD5_ETHERNET_MAC_ADDRESS_PREFIX.Length);
                    string Name_Prefix = Name.Substring(0, Properties.Resources.UD5_ETHERNET_NAME.Length);

                    /*  */
                    if(string.Compare(MAC_Address_Prefix , Properties.Resources.UD5_ETHERNET_MAC_ADDRESS_PREFIX , false) == 0 &&
                        string.Compare(Name_Prefix, Properties.Resources.UD5_ETHERNET_NAME , false) == 0 )
                    {
                        Ret = false;
                        //Ret = true;
                        break;
                    }
                }
                else
                    continue;
            }

            return Ret;
        }




        static bool CheckDuplicatedRunning()
        {
            /* 중복 실행 방지 */
            Process[] procs = Process.GetProcessesByName("MultiMonitorManager");

            if (procs.Length > 1)
                return true;
            else
                return false;
        }
    }
}
