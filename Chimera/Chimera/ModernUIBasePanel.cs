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
    public partial class ModernUIBasePanel : Form
    {
        AboutBox aboutBox;
        CursorControl cursorControl;
        SettingWallpaper settingwallpaper;
        ManageMultiMonitor managemultimonitor;


        public ModernUIBasePanel(ManageMultiMonitor managemultimonitor , SettingWallpaper settingwallpaper , CursorControl cursorControl)
        {
            InitializeComponent();

            this.cursorControl = cursorControl;
            this.managemultimonitor = managemultimonitor;
            this.settingwallpaper = settingwallpaper;
        }

        /* 처음 Load하면 About Box를 보여주도록 한다. */
        private void ModernUIBasePanel_Load(object sender, EventArgs e)
        {
            btn_AboutBox.PerformClick();
        }


        /*  */
        private void btn_AboutBox_Click(object sender, EventArgs e)
        {
            //Project1.Form1 f1 = new Project1.Form1();
            //f1.TopLevel = false;
            //f1.Dock = System.Windows.Forms.DockStyle.Fill;
            //panel4.Controls.Add(f1);
            //f1.Show();

            panelForm.Controls.Clear();

            aboutBox = new AboutBox();
            aboutBox.TopLevel = false;
            aboutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            aboutBox.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(aboutBox);
            //aboutBox.ShowDialog();
            aboutBox.Show();
            //aboutBox.Dispose();
            aboutBox = null;
        }

        /*  */
        private void btn_Cursor_Click(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();

            cursorControl.TopLevel = false;
            cursorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            cursorControl.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(cursorControl);
            //cursorControl.ShowDialog();
            cursorControl.Show();
            //cursorControl.Dispose();
            //cursorControl= null;
        }
    }
}
