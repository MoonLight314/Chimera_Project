using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Chimera
{
    public partial class AboutBox : Form
    {
        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint WINEVENT_INCONTEXT = 4;
        private const uint WINEVENT_SKIPOWNPROCESS = 2;
        private const uint WINEVENT_SKIPOWNTHREAD = 1;

        private const uint EVENT_SYSTEM_FOREGROUND = 3;
        private const uint EVENT_SYSTEM_MINIMIZEEND = 0x17;

        //delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

//WinEventDelegate dele = null;

#if TEST
        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);
#endif
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool QueryFullProcessImageName(IntPtr hProcess, uint dwFlags,[Out, MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpExeName,ref int lpdwSize);


        [DllImport("psapi.dll")]
        static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In] [MarshalAs(UnmanagedType.U4)] int nSize);


        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);


        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, Int32 bInheritHandle, UInt32 dwProcessId);

        public AboutBox()
        {
            InitializeComponent();

            InitUI();
#if TEST
            dele = new WinEventDelegate(WinEventProc);
            IntPtr m_hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_MINIMIZEEND,//EVENT_SYSTEM_FOREGROUND, 
                                                IntPtr.Zero, 
                                                dele, 
                                                0, 
                                                0, 
                                                WINEVENT_OUTOFCONTEXT | WINEVENT_SKIPOWNPROCESS);
#endif
        }


        private void InitUI()
        {
            /*  */
            Bitmap bmp = Properties.Resources.Manager_Form_Icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            /*  */
            this.BackColor = Color.FromArgb(255, 255, 255);

            /*  */
            pictureBox_Product_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Product_Image.Image = Properties.Resources.About_Box_Logo_Image;

            /*  */
            this.label_AboutBox.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Bold(), 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Monitor_Manager.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }




        private string GetActiveWindowTitle()
        {
            int nChars = 1024;
            uint processId = 0;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);

            handle = Win32.GetForegroundWindow();
            //handle = Win32.GetActiveWindow();

            if (handle == IntPtr.Zero)
            {
                return "NULL";
            }

            //bool ret = QueryFullProcessImageName(handle, 0, Buff, ref nChars);
            GetWindowThreadProcessId(handle, out processId);
            IntPtr hProcess = OpenProcess(1040, 0, processId);
            uint ret = GetModuleFileNameEx(hProcess, IntPtr.Zero, Buff, nChars);
            //string fullPath = Buff.ToString(0, nChars);
            string[] tokens = Buff.ToString().Split('\\');

            return tokens.Last();

            if (Win32.GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (eventType == EVENT_SYSTEM_FOREGROUND ||
                eventType == EVENT_SYSTEM_MINIMIZEEND
                )
            {
                Log.AppendText(GetActiveWindowTitle() + "\r\n");
            }

        }


        private void button_Test_Click(object sender, EventArgs e)
        {
            //HotKeyConfirm h = new HotKeyConfirm();            
            //h.ShowDialog();

            WarningDuplicatedHotkey w = new WarningDuplicatedHotkey();
            w.ShowDialog();
        }


    }
}
