﻿using System;
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

        ////IList<DisplayDevice> allMonitorProperties = displayDevices.Items;
        // = displayDevices.Items();



        public BaseForm()
        {
            InitializeComponent();

            this.Load += notifyIcon1_Load;

            configValues = new ConfigValues();
            configManager = new ConfigManager(configValues);

            /*  */
            displayDevices = new DisplayDevices();
            allMonitorProperties = displayDevices.Items;

            cursorControl = new CursorControl(this , configValues);
        }

        




        /*  */
        public void notifyIcon1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
        }




        /*  */
        private void aboutBoxMenuItem_click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }




        /// <summary>
        /// Cursor Control 관련 설정 Dialog Box
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        private void cursorControlMenuItem_click(object sender, EventArgs e)
        {
            DialogResult Ret;

            Ret = cursorControl.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                /* Config File에 설정을 저장한다. */
                configManager.SaveConfigValuesToFile( configValues );

                /* Hotkey를 Regsiter 한다. */
                /* 각 Feature가 Enable인지 Disable인지 확인 후 진행   */
                /* Disable인 경우 Unreginster 한다. */
                CursorController.Instance.CursorNextScreenHotKeyController.RegisterHotkey();
                CursorController.Instance.CursorPrevScreenHotKeyController.RegisterHotkey();
                CursorController.Instance.LockCursorHotKeyController.RegisterHotkey();                

            }
            else if(Ret == DialogResult.Cancel)
            {
                
            }

        }


               



        /*  */
        private void ManageItemClick(object sender, EventArgs e)
        {
            ManageMultiMonitor managemultimonitor = new ManageMultiMonitor( allMonitorProperties , displayDevices );
            managemultimonitor.ShowDialog();
        }





        /*  */
        private void settingWallpaper_Click(object sender, EventArgs e)
        {
            SettingWallpaper settingwallpaper = new SettingWallpaper( allMonitorProperties );
            settingwallpaper.ShowDialog();
        }





        /*  */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cursorControl.CleanUp();
            this.Close();
            Application.Exit();
        }


    }
}
