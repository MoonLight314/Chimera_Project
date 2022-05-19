using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public partial class BaseForm : Form
    {
        DisplayDevices          displayDevices;
        IList<DisplayDevice>    allMonitorProperties;

        ////IList<DisplayDevice> allMonitorProperties = displayDevices.Items;
        // = displayDevices.Items();

        public BaseForm()
        {
            InitializeComponent();

            this.Load += notifyIcon1_Load;

            /*  */
            displayDevices = new DisplayDevices();
            allMonitorProperties = displayDevices.Items;

        }


        /*  */
        public void notifyIcon1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }




        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        /*  */
        private void ManageItemClick(object sender, EventArgs e)
        {
            ManageMultiMonitor managemultimonitor = new ManageMultiMonitor( allMonitorProperties );
            managemultimonitor.ShowDialog();
        }



        /*  */
        private void settingWallpaper_Click(object sender, EventArgs e)
        {
            SettingWallpaper settingwallpaper = new SettingWallpaper( allMonitorProperties );
            settingwallpaper.ShowDialog();
        }
    }
}
