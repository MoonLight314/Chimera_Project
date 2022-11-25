using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
    public partial class ModernUIBasePanel : Form
    {
        /*  */
        private const int NONE              = 0;
        private const int ABOUT_BOX         = 1;
        private const int CURSOR_CONTROL    = 2;
        private const int MANAGE            = 3;
        private const int WALLPAPER         = 4;

        int CurrentSelectedBtn;

        AboutBox aboutBox;
        CursorControl cursorControl;
        SettingWallpaper settingwallpaper;
        ManageMultiMonitor managemultimonitor;

        ConfigManager configManager;
        ConfigValues configValues;
        DisplayDevices displayDevices;
        IList<DisplayDevice> allMonitorProperties;

        Form BaseForm;

        Image About_Button_Unselected;
        Image Cursor_Control_Button_Unselected;
        Image Mange_Button_Unselected;
        Image Wallpaper_Button_Unselected;



        public ModernUIBasePanel(   Form BaseForm, 
                                    CursorControl cursorControl , 
                                    ConfigManager configManager , 
                                    ConfigValues configValues ,
                                    DisplayDevices displayDevices,
                                    IList<DisplayDevice> allMonitorProperties
                                    )
        {
            InitializeComponent();

            /*  */
            InitUI();

            /*  */
            this.cursorControl = cursorControl;
            this.configManager = configManager;
            this.configValues = configValues;
            this.BaseForm = BaseForm;
            this.allMonitorProperties = allMonitorProperties;
            this.displayDevices = displayDevices;

        }




        private void InitUI()
        {
            Bitmap bmp = Properties.Resources.Manager_Form_Icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
            this.Text = Properties.Resources.PRODUCT_NAME;
            this.BackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);

            this.btn_AboutBox.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));           
            this.btn_Cursor.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Manage.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Wallpaper.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

            About_Button_Unselected = (Image)(new Bitmap(Properties.Resources.About_Button_Unselected));
            Cursor_Control_Button_Unselected = (Image)(new Bitmap(Properties.Resources.Cursor_Control_Button_Unselected));
            Mange_Button_Unselected = (Image)(new Bitmap(Properties.Resources.Mange_Button_Unselected));
            Wallpaper_Button_Unselected = (Image)(new Bitmap(Properties.Resources.Wallpaper_Button_Unselected));

        }




        /* 처음 Load하면 About Box를 보여주도록 한다. */
        private void ModernUIBasePanel_Load(object sender, EventArgs e)
        {
            
        }

        private void ModernUIBasePanel_Shown(object sender, EventArgs e)
        {
            panelForm.Controls.Clear();
            btn_AboutBox.PerformClick();
        }



        private void ChangeBtnBackColor(int CurrentClickedBtn)
        {            
            btn_AboutBox.BackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_AboutBox.FlatAppearance.MouseOverBackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_AboutBox.Image = About_Button_Unselected;
            btn_AboutBox.BackgroundImage = null;

            btn_Cursor.BackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Cursor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Cursor.Image = Cursor_Control_Button_Unselected;
            btn_Cursor.BackgroundImage = null;

            btn_Manage.BackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Manage.FlatAppearance.MouseOverBackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Manage.Image = Mange_Button_Unselected;
            btn_Manage.BackgroundImage = null;

            btn_Wallpaper.BackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Wallpaper.FlatAppearance.MouseOverBackColor = Color.FromArgb(0xF5, 0xF5, 0xF5);
            btn_Wallpaper.Image = Wallpaper_Button_Unselected;
            btn_Wallpaper.BackgroundImage = null;

            switch (CurrentClickedBtn)
            {
                case ABOUT_BOX:
                    CurrentSelectedBtn = ABOUT_BOX;
                    btn_AboutBox.BackColor = Color.White;
                    btn_AboutBox.BackgroundImage = Properties.Resources.Select_Trans;
                    break;

                case CURSOR_CONTROL:
                    CurrentSelectedBtn = CURSOR_CONTROL;
                    btn_Cursor.BackColor = Color.White;
                    btn_Cursor.BackgroundImage = Properties.Resources.Select_Trans;
                    break;

                case MANAGE:
                    CurrentSelectedBtn = MANAGE;
                    btn_Manage.BackColor = Color.White;
                    btn_Manage.BackgroundImage = Properties.Resources.Select_Trans;
                    break;

                case WALLPAPER:
                    CurrentSelectedBtn = WALLPAPER;
                    btn_Wallpaper.BackColor = Color.White;
                    btn_Wallpaper.BackgroundImage = Properties.Resources.Select_Trans;
                    break;                    

                default:
                    break;
            }

    }       



        /*  */
        private void btn_AboutBox_Click(object sender, EventArgs e)
        {
            /*  */
            FinishUpProcess();

            panelForm.Controls.Clear();

            ChangeBtnBackColor(ABOUT_BOX);

            aboutBox = new AboutBox();
            aboutBox.TopLevel = false;
            aboutBox.Dock = System.Windows.Forms.DockStyle.Fill;
            aboutBox.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(aboutBox);
            
            aboutBox.Show();
        }

        /*  */
        private void btn_Cursor_Click(object sender, EventArgs e)
        {
            /*  */
            FinishUpProcess();

            panelForm.Controls.Clear();

            ChangeBtnBackColor(CURSOR_CONTROL);

            /* 등록된 전체 Hot Key를 Unregister하고 시작한다. */
            /* 등록 과정에서  Hot Key를 입력하는 경우 꼬이는 경우를 미연에 방지하기 위함이다. */
            CursorController.Instance.Term();

            cursorControl.TopLevel = false;
            cursorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            cursorControl.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(cursorControl);
            cursorControl.Show();
        }



        
        private void btn_Manage_Click(object sender, EventArgs e)
        {
            /*  */
            FinishUpProcess();

            panelForm.Controls.Clear();

            ChangeBtnBackColor(MANAGE);
            
            this.managemultimonitor = new ManageMultiMonitor(allMonitorProperties, displayDevices);

            managemultimonitor.TopLevel = false;
            managemultimonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            managemultimonitor.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(managemultimonitor);
            managemultimonitor.Show();
        }


        private void btn_Wallpaper_Click(object sender, EventArgs e)
        {
            /*  */
            FinishUpProcess();

            panelForm.Controls.Clear();

            ChangeBtnBackColor(WALLPAPER);

            settingwallpaper = new SettingWallpaper(allMonitorProperties);

            settingwallpaper.TopLevel = false;
            settingwallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            settingwallpaper.FormBorderStyle = FormBorderStyle.None;
            panelForm.Controls.Add(settingwallpaper);
            settingwallpaper.Show();
        }




        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            switch (CurrentSelectedBtn)
            {
                case ABOUT_BOX:
                    btn_AboutBox.FlatAppearance.MouseOverBackColor = Color.White;
                    break;
                case CURSOR_CONTROL:
                    btn_Cursor.FlatAppearance.MouseOverBackColor = Color.White;
                    break;
                case MANAGE:
                    btn_Manage.FlatAppearance.MouseOverBackColor = Color.White;
                    break;
                case WALLPAPER:
                    btn_Wallpaper.FlatAppearance.MouseOverBackColor = Color.White;
                    break;
                default:
                    break;
            }
        }


        /// <summary>
        /// 어떤 Button이 눌렸을 때, 이전 Button을 동작을 마무리 하는 역할
        /// 예를 들어, Cursor Contol Tab에서 설정을 하다가, About Box Button을 누르면
        /// About Box Dialog를 보여주기 전에, Cursor Contol에서 했던 설정들을 적용하는 동작을 
        /// 이 함수에서 수행한다.
        /// </summary>
        private void FinishUpProcess()
        {
            switch (CurrentSelectedBtn)
            {
                case ABOUT_BOX:
                    
                    break;
                case CURSOR_CONTROL:
                    FinishUpCursorControl();
                    break;
                case MANAGE:
                    FinishUpManageMultiMonitor();
                    break;
                case WALLPAPER:
                    FinishUpWallpaperSetting();
                    break;
                default:
                    break;
            }
        }




        private void FinishUpCursorControl()
        {
            /* Config File에 설정을 저장한다. */
            configManager.SaveConfigValuesToFile(configValues);

            /* 변경된 Hotkey를 Regsiter 한다. */
            /* 각 Feature가 Enable인지 Disable인지 확인 후 진행   */
            /* Disable인 경우 Unreginster 한다. */
            CursorController.Instance.Init(BaseForm, configValues);
        }



        private void FinishUpManageMultiMonitor()
        {
            if (managemultimonitor != null)
            {
                managemultimonitor.Dispose();
                managemultimonitor = null;
            }
        }

        private void FinishUpWallpaperSetting()
        {
            if (settingwallpaper != null)
            {
                settingwallpaper.Dispose();
                settingwallpaper = null;
            }
        }




        private void ModernUIBasePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FinishUpProcess();
        }
                
    }
}
