using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Chimera.Resources;
using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;
using System.Management;



namespace Chimera
{
    public partial class BaseForm : Form
    {
        DisplayDevices          displayDevices;
        IList<DisplayDevice>    allMonitorProperties;

        CursorControl           cursorControl;
        ConfigManager           configManager;
        ConfigValues            configValues;

        AboutBox                aboutBox;
        ManageMultiMonitor      managemultimonitor;
        SettingWallpaper        settingwallpaper;
        ModernUIBasePanel       modernUIBasePanelForm;

        bool                    ShownOneForm;


        public BaseForm()
        {
            InitializeComponent();

            this.Load += notifyIcon1_Load;

            configValues = new ConfigValues();
            configManager = new ConfigManager(configValues);

            /*  */
            displayDevices = new DisplayDevices();
            allMonitorProperties = displayDevices.Items;

            /*  */
            cursorControl = new CursorControl(this , configValues);
            aboutBox = null;
            managemultimonitor = null;
            settingwallpaper = null;

            /*  */
            ShownOneForm = false;

            modernUIBasePanelForm = new ModernUIBasePanel(this, cursorControl, configManager, configValues , displayDevices , allMonitorProperties );
        }

        




        /*  */
        public void notifyIcon1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;            
        }




        /*  */
        private void aboutBoxMenuItem_click(object sender, EventArgs e)
        {
            if (aboutBox == null && ShownOneForm == false)
            {
                aboutBox = new AboutBox();
                ShownOneForm = true;
                aboutBox.ShowDialog();
                aboutBox.Dispose();
                aboutBox = null;
                ShownOneForm = false;
            }
            
        }




        /// <summary>
        /// Cursor Control 관련 설정 Dialog Box
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        private void cursorControlMenuItem_click(object sender, EventArgs e)
        {
            DialogResult Ret;

            /* 한 번에 하나의 Form만 표시되도록 하기 위함 */
            if (cursorControl.Visible == false && ShownOneForm == false)
            {
                /* 등록된 전체 Hot Key를 Unregister하고 시작한다. */
                /* 등록 과정에서  Hot Key를 입력하는 경우 꼬이는 경우를 미연에 방지하기 위함이다. */
                CursorController.Instance.Term();

                ShownOneForm = true;

                Ret = cursorControl.ShowDialog();

                if (Ret == DialogResult.OK)
                {
                    /* Config File에 설정을 저장한다. */
                    configManager.SaveConfigValuesToFile(configValues);

                    /* 변경된 Hotkey를 Regsiter 한다. */
                    /* 각 Feature가 Enable인지 Disable인지 확인 후 진행   */
                    /* Disable인 경우 Unreginster 한다. */
                    CursorController.Instance.Init(this, configValues);

                }
                else if (Ret == DialogResult.Cancel)
                {
                    /* Cancel하면 기존 Hot Key를 다시 등록 */
                    CursorController.Instance.Init(this, configValues);
                }

                ShownOneForm = false;
            }

        }


               



        /*  */
        private void ManageItemClick(object sender, EventArgs e)
        {
            if (managemultimonitor == null && ShownOneForm == false)
            {
                managemultimonitor = new ManageMultiMonitor(allMonitorProperties, displayDevices);
                ShownOneForm = true;
                managemultimonitor.ShowDialog();
                managemultimonitor.Dispose();
                managemultimonitor = null;
                ShownOneForm = false;
            }
        }





        /*  */
        private void settingWallpaper_Click(object sender, EventArgs e)
        {
            if (settingwallpaper == null && ShownOneForm == false)
            {
                settingwallpaper = new SettingWallpaper(allMonitorProperties);
                ShownOneForm = true;
                settingwallpaper.ShowDialog();
                settingwallpaper.Dispose();
                settingwallpaper = null;
                ShownOneForm = false;
            }
        }





        /*  */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cursorControl.CleanUp();
            this.Close();
            Application.Exit();
        }



        /*  */
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenModernUIPanelForm();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenModernUIPanelForm();
        }

        private void OpenModernUIPanelForm()
        {
            /* 한 번에 하나의 UI만 보이도록 한다. */
            if (ShownOneForm == false)
            {
                ShownOneForm = true;
                modernUIBasePanelForm.ShowDialog();
                ShownOneForm = false;
            }
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {
            /* UD5가 Attached되어 있는지 확인 후 실행 */
            if (CheckDeviceInstalled() == false)
            {
                WarningDuplicatedHotkey w = new WarningDuplicatedHotkey("Warning", "The device is not installed.");
                w.ShowDialog();
                
                cursorControl.CleanUp();
                this.Close();
                Application.Exit();
            }

            /* 중복 실행 방지 */
            if (CheckDuplicatedRunning())
            {
                WarningDuplicatedHotkey w = new WarningDuplicatedHotkey("Warning", "The application is already running.");
                w.ShowDialog();

                cursorControl.CleanUp();
                this.Close();
                Application.Exit();
            }
        }


        /*
        UD5가 설치된 경우에만 Application이 실행되도록 수정.
        - Ethernet Card의 이름(Description)과 MAC Address의 첫 3 Byte를 확인하는 방식으로 UD5를 Detect한다.
        */
        private bool CheckDeviceInstalled()
        {
            /* Ethernet의 MAC Address 검사 */
            if (CheckMACAddress() == true)
                return true;

            /* USB Hub의 VID / PID를 확인한다. */
            if (CheckVIDPID() == true)
                return true;

            return false;            
        }


        private bool CheckMACAddress()
        {
            bool Ret = false;
            int NameLength;

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {

                string MAC_Address = nic.GetPhysicalAddress().ToString();
                string Name = nic.Description;

                if (string.IsNullOrEmpty(MAC_Address) == false && string.IsNullOrEmpty(Name) == false)
                {
                    string MAC_Address_Prefix = MAC_Address.Substring(0, Properties.Resources.UD5_ETHERNET_MAC_ADDRESS_PREFIX.Length);

                    /* UD5 Ethernet Name(Realtek USB GbE Family Controller)길이보다 짧은 이름을 가진 NIC의 경우에
                       오류를 발생시킬 수 있다.
                    */
                    NameLength = Name.Length <= Properties.Resources.UD5_ETHERNET_NAME.Length ? Name.Length : Properties.Resources.UD5_ETHERNET_NAME.Length;

                    string Name_Prefix = Name.Substring(0, NameLength);

                    /*  */
                    if (string.Compare(MAC_Address_Prefix, Properties.Resources.UD5_ETHERNET_MAC_ADDRESS_PREFIX, false) == 0 &&
                        string.Compare(Name_Prefix, Properties.Resources.UD5_ETHERNET_NAME, false) == 0)
                    {
                        Ret = true;
                        break;
                    }
                }
                else
                    continue;
            }

            return Ret;
        }



        private bool CheckVIDPID()
        {
            ManagementObjectCollection collection;
            string PNPDeviceID;
            bool Ret = false;

            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();


            foreach (var device in collection)
            {
                PNPDeviceID = (string)device.GetPropertyValue("PNPDeviceID");

                if (PNPDeviceID.Contains("VID") && PNPDeviceID.Contains("PID"))
                {
                    int VID_Pos = PNPDeviceID.IndexOf("VID", 0, PNPDeviceID.Length);
                    string VID = PNPDeviceID.Substring(VID_Pos + 4, Properties.Resources.VID.Length);

                    int PID_Pos = PNPDeviceID.IndexOf("PID", 0, PNPDeviceID.Length);
                    string PID = PNPDeviceID.Substring(PID_Pos + 4, Properties.Resources.HIGH_SPEED_PID.Length);

                    if (Properties.Resources.VID == VID && (Properties.Resources.HIGH_SPEED_PID == PID || Properties.Resources.SUPER_SPEED_PID == PID))
                    {
                        Ret = true;
                        break;
                    }
                }
            }

            collection.Dispose();

            return Ret;
        }




        private bool CheckDuplicatedRunning()
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

