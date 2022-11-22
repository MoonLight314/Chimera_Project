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
            modernUIBasePanelForm = new ModernUIBasePanel(this, settingwallpaper , cursorControl, configManager , configValues);
            modernUIBasePanelForm.ShowDialog();
            modernUIBasePanelForm.Dispose();
            modernUIBasePanelForm = null;
        }
    }
}

