using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Drawing.Drawing2D;
using Chimera.Resources;


namespace Chimera
{
    public partial class ManageMultiMonitor : Form
    {

        IList<MonitorSetInfo> MonitorSettingInfo;
        DisplayDevices _displayDevices;
        String CurrentSelMonitorName;

        #if SUPPORT_CUSTOM_TRACKBAR
        float cusTrackBar_Min, cusTrackBar_Max;
        float Default_value = 0.1f;
        bool cusTrackBar_Mouse_Pushed;
        #endif


        /*   */
        public ManageMultiMonitor(IList<DisplayDevice> allMonitorProperties, DisplayDevices displayDevices)
        {

            InitializeComponent();

            /*  */
            

            MonitorSettingInfo = new List<MonitorSetInfo>();

            _displayDevices = displayDevices;

            CurrentSelMonitorName = "All Monitors";

            GetOnlyActiveMonitors(allMonitorProperties);

            /*  */
            InitUI();

            #if SUPPORT_CUSTOM_TRACKBAR
            cusTrackBar_Min = 0.0f;
            cusTrackBar_Max = 1.0f;
            cusTrackBar_Mouse_Pushed = false;
            #endif
        }


        void GetOnlyActiveMonitors(IList<DisplayDevice> allMonitorProperties)
        {
            uint pdwMinimumContrast = 0, pdwCurrentContrast = 0, pdwMaximumContrast = 0;

            foreach (DisplayDevice dd in allMonitorProperties)
            {
                if (dd.IsActive)
                {
                    MonitorSetInfo msi = new MonitorSetInfo();
                    msi.displaydevice = dd;

                    if (dd.IsPrimary)
                        msi.SetAsPrimary = true;

                    /* MonitorIndex를 Display Device의 Path Index를 사용하지만,  */
                    /* 추후 Issue 발생시 추가검토 필요성 있음  */
                    msi.MonitorIndex = dd.PathIndex;

                    /* 각 Monitor의 Contrast 값을 가져옵니다. */
                    _displayDevices.GetMonitorContrast(msi.MonitorIndex, ref pdwMinimumContrast, ref pdwCurrentContrast, ref pdwMaximumContrast);
                    msi.MinimumContrast = pdwMinimumContrast;
                    msi.CurrentContrast = pdwCurrentContrast;
                    msi.MaximumContrast = pdwMaximumContrast;

                    MonitorSettingInfo.Add(msi);
                    msi = null;

                }
            }
        }




        /// <summary>
        /// UI 초기화
        /// </summary>
        void InitUI()
        {
            /*  */
            Bitmap bmp = Properties.Resources.Manager_Form_Icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            /*  */
            this.BackColor = Color.FromArgb(255, 255, 255);

            /*  */
            lv_Monitors.View = View.Tile;
            lv_Monitors.Columns.Add("Column1Name");

            ImageList ilt = new ImageList();
            ListViewItem item;            
            ilt.ImageSize = new Size(48, 48);

            Image[] img = { Properties.Resources.Monitor_No_01,
                            Properties.Resources.Monitor_No_02,
                            Properties.Resources.Monitor_No_03};

            foreach (Image i in img)
                ilt.Images.Add(i);

            lv_Monitors.LargeImageList = ilt;


            /**/
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                item = new ListViewItem(msi.displaydevice.FriendlyName, 0);
                lv_Monitors.Items.Add(item);
            }


            foreach (ColumnHeader column in lv_Monitors.Columns)
            {
                column.Width = -1;
            }

            lv_Monitors.Select();
            lv_Monitors.Items[0].Selected = true;

            /*  */
            this.cb_SetAsPrimary.Font = new System.Drawing.Font("LG스마트체 Regular", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Brightness.Font = new System.Drawing.Font("LG스마트체 Regular", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contrast.Font = new System.Drawing.Font("LG스마트체 Regular", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Primary.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Resolution.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BitPerPixel.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Output.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Rotation.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Primary.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Rotation.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OutputTech.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BitPerPixel.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Resolution.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Multi_Monitor.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Bold(), 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Monitors.Font = new System.Drawing.Font("LG스마트체 SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FriendlyName.Font = new System.Drawing.Font("LG스마트체 Bold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Setting.Font = new System.Drawing.Font("LG스마트체 SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Current_Contrast_Value.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Current_Brightness_Value.Font = new System.Drawing.Font("LG스마트체 Regular", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


        }




#if SUPPORT_MONITOR_OFF_FEATURE
        /// <summary>
        /// 모니터 정보 Tree View 선택시
        /// </summary>
        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            CurrentSelMonitorName = e.Node.Text;

            if( CurrentSelMonitorName == "All Monitors" )
            {
                ClearMonitorInfo();
            }
            else
            {
                cb_SetAsPrimary.Enabled = true;
#if SUPPORT_MONITOR_OFF_FEATURE
                cb_MonitorOff.Enabled = true;
#endif

                foreach (MonitorSetInfo msi in MonitorSettingInfo)
                {
                    /* 선택한 Monitor에 대한 정보를 표시한다. */
                        if (msi.displaydevice.FriendlyName == e.Node.Text)
                    {
                        DisplaySelectedMonitorInfo(msi);
                        return;
                    }
                }
            }
        }
#endif



        private void DisplaySelectedMonitorInfo(MonitorSetInfo msi)
        {
            textBox_Primary.Text = msi.displaydevice.IsPrimary ? "Yes" : "No";
            //textBox_FriendlyName.Text = msi.displaydevice.FriendlyName;
            textBox_Resolution.Text = string.Format("{0} X {1}", msi.displaydevice.Bounds.Size.Width, msi.displaydevice.Bounds.Size.Height);
            textBox_BitPerPixel.Text = string.Format("{0}", msi.displaydevice.BitsPerPixel);
            textBox_OutputTech.Text = msi.displaydevice.OutputTechnology;
            textBox_Rotation.Text = string.Format("{0}", msi.displaydevice.RotationDegrees);

            cb_SetAsPrimary.Checked = msi.SetAsPrimary;
#if SUPPORT_MONITOR_OFF_FEATURE
            cb_MonitorOff.Checked = msi.Off;


            if (msi.SetAsPrimary)
                cb_MonitorOff.Enabled = false;
            else
                cb_MonitorOff.Enabled = true;
#endif

            /* Brightness */
            trackBar_Brightness.Enabled = true;
            trackBar_Brightness.SetRange((int)msi.displaydevice.MinBrightness, (int)msi.displaydevice.MaxBrightness);
            trackBar_Brightness.Value = (int)msi.displaydevice.CurBrightness;
            label_Current_Brightness_Value.Text = msi.displaydevice.CurBrightness.ToString();

            /* Contrast */
            trackBar_Contrast.Enabled = true;
            trackBar_Contrast.SetRange((int)msi.MinimumContrast, (int)msi.MaximumContrast);
            trackBar_Contrast.Value = (int)msi.CurrentContrast;
            label_Current_Contrast_Value.Text = msi.CurrentContrast.ToString();
        }



        /* 모니터 정보를 모두 지운다. */
        private void ClearMonitorInfo()
        {
            textBox_Primary.Text = "";
            //textBox_FriendlyName.Text = "";
            textBox_Resolution.Text = "";
            textBox_BitPerPixel.Text = "";
            textBox_OutputTech.Text = "";
            textBox_Rotation.Text = "";

            cb_SetAsPrimary.Checked = false;
#if SUPPORT_MONITOR_OFF_FEATURE
            cb_MonitorOff.Checked = false;
#endif

            if (CurrentSelMonitorName == "")
            {
                cb_SetAsPrimary.Enabled = false;
                label_FriendlyName.Text = "";
                trackBar_Brightness.Enabled = false;
                trackBar_Contrast.Enabled = false;

#if SUPPORT_MONITOR_OFF_FEATURE
                cb_MonitorOff.Enabled = false;
#endif
            }
        }




        /* 종료 버튼 */
        private void manage_exit(object sender, EventArgs e)
        {
            this.Close();
        }




        /* 설정 반영하기 */
        private void manage_Set(object sender, EventArgs e)
        {
            /*  */
            if (CheckSettingValidity() == false)
            {
                //throw new ApplicationException(string.Format("Setting Error : The number of primary monitor must be one."));
                MessageBox.Show("The number of primary monitor must be one.", "Setting Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _displayDevices.Reset();

            /* Monitor Off 설정 */
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if (msi.Off)
                {
                    _displayDevices.MakeAsDisabled(msi.MonitorIndex, false);
                }

            }

            /* Primary Monitor */
            _displayDevices.MakePrimary(GetPrimaryMonitorIndex());

            /* 변경된 설정 적용 */
            _displayDevices.ApplyDisplayChange();
        }






        private int GetPrimaryMonitorIndex()
        {
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if (msi.SetAsPrimary)
                    return msi.MonitorIndex;
            }

            return -1;
        }



        /* 입력한 Setting 정보가 실제 변경을 할 수 있는 상황인지 판단 */
        private bool CheckSettingValidity()
        {
            uint TotalPrimaryMonitorNo = 0;

            /*  */
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if (msi.SetAsPrimary)
                    TotalPrimaryMonitorNo++;
            }

            if (TotalPrimaryMonitorNo != 1)
            {
                return false;
            }
            else
                return true;
        }







        /* 'Set As Primary' Button Click 처리 */
        private void click_SetAsPrimary(object sender, EventArgs e)
        {
            if (CurrentSelMonitorName == "All Monitors")
            {
                cb_SetAsPrimary.Checked = false;
            }

            /*  */
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if (msi.displaydevice.FriendlyName == CurrentSelMonitorName)
                {
                    /* Primary로 선택된 Monitor는 끌 수 없게 한다. */
                    msi.SetAsPrimary = cb_SetAsPrimary.Checked;
#if SUPPORT_MONITOR_OFF_FEATURE
                    cb_MonitorOff.Enabled = msi.SetAsPrimary ? false : true;                    

                    if(msi.SetAsPrimary && cb_MonitorOff.Checked)
                    {
                        cb_MonitorOff.Checked = false;
                        msi.Off = false;
                    }
#endif

                    DisplaySelectedMonitorInfo(msi);
                    break;
                }
            }

            //tv_Monitor_List.Select();
        }



#if SUPPORT_MONITOR_OFF_FEATURE
        /* 'Monitor Off' Button Click 처리 */
        private void click_MonitorOff(object sender, EventArgs e)
        {            
            if (CurrentSelMonitorName == "All Monitors")
            {
                cb_MonitorOff.Checked = false;
            }            

            /*  */
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if (msi.displaydevice.FriendlyName == CurrentSelMonitorName)
                {
#if SUPPORT_MONITOR_OFF_FEATURE
                    msi.Off = cb_MonitorOff.Checked;
#endif

                    DisplaySelectedMonitorInfo(msi);
                    break;
                }
            }

            tv_Monitor_List.Select();
        }
#endif






        /// <summary>
        /// Brightness Track Bar 변경시 Brightness 값 변경 및 UI Update
        /// </summary>
        private void trackBar_Brightness_Scroll(object sender, EventArgs e)
        {
            _displayDevices.ChangeMonitorBrightness(lv_Monitors.SelectedIndices[0], (uint)trackBar_Brightness.Value);
            UpdateBrightness();
        }






        /// <summary>
        /// 
        /// </summary>
        private void UpdateBrightness()
        {
            uint minBrightness = 0, maxBrightness = 0, curBrightness = 0;

            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                /* 선택한 Monitor에 대한 정보를 표시한다. */
                if (msi.displaydevice.FriendlyName == CurrentSelMonitorName)
                {
                    DisplayDevice displayDevice = msi.displaydevice;

                    if (displayDevice != null)
                    {
                        uint numPhysicalMonitors = 0;

                        IntPtr hMonitor = _displayDevices.Items[lv_Monitors.SelectedIndices[0]].MonitorHandle;

                        NativeMethods.GetNumberOfPhysicalMonitorsFromHMONITOR(hMonitor, ref numPhysicalMonitors);

                        // we just handle the simple case for now, 
                        // otherwise we will have difficulty mapping between the physical monitors
                        // and out display devices
                        if (numPhysicalMonitors == 1)
                        {
                            NativeMethods.PHYSICAL_MONITOR[] physicalMonitors = new NativeMethods.PHYSICAL_MONITOR[numPhysicalMonitors];
                            if (NativeMethods.GetPhysicalMonitorsFromHMONITOR(hMonitor, numPhysicalMonitors, physicalMonitors))
                            {
                                for (int i = 0; i < numPhysicalMonitors; i++)
                                {
                                    bool ret = NativeMethods.GetMonitorBrightness(physicalMonitors[i].hPhysicalMonitor, out minBrightness, out curBrightness, out maxBrightness);
                                }
                            }

                            // release any resources used while looking at this virtual monitor
                            // TODO: do we really need to call this if GetPhysicalMonitorsFromHMONITOR fails?
                            NativeMethods.DestroyPhysicalMonitors(numPhysicalMonitors, physicalMonitors);
                        }
                    }

                    msi.displaydevice.CurBrightness = curBrightness;
                    DisplaySelectedMonitorInfo(msi);
                    return;
                }
            }
        }





        /// <summary>
        /// Contrast Track Bar 변경시 Contrast 값 변경 및 UI Update
        /// </summary>
        private void trackBar_Contrast_Scroll(object sender, EventArgs e)
        {            
            _displayDevices.ChangeMonitorContrast(lv_Monitors.SelectedIndices[0], (uint)trackBar_Contrast.Value);
            UpdateContrast();
        }




        /// <summary>
        /// 
        /// </summary>
        private void UpdateContrast()
        {
            uint pdwMinimumContrast = 0, pdwCurrentContrast = 0, pdwMaximumContrast = 0;

            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                /* 선택한 Monitor에 대한 정보를 표시한다. */
                if (msi.displaydevice.FriendlyName == CurrentSelMonitorName)
                {
                    _displayDevices.GetMonitorContrast(lv_Monitors.SelectedIndices[0], ref pdwMinimumContrast, ref pdwCurrentContrast, ref pdwMaximumContrast);
                    msi.CurrentContrast = pdwCurrentContrast;
                    DisplaySelectedMonitorInfo(msi);
                    return;
                }
            }       
            
        }





        /*  */
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Monitors.SelectedIndices.Count > 0)
            {
                label_FriendlyName.Text = lv_Monitors.SelectedItems[0].Text;
                CurrentSelMonitorName = lv_Monitors.SelectedItems[0].Text;

                cb_SetAsPrimary.Enabled = true;
#if SUPPORT_MONITOR_OFF_FEATURE
                cb_MonitorOff.Enabled = true;
#endif

                foreach (MonitorSetInfo msi in MonitorSettingInfo)
                {
                    /* 선택한 Monitor에 대한 정보를 표시한다. */
                    if (msi.displaydevice.FriendlyName == CurrentSelMonitorName)
                    {
                        DisplaySelectedMonitorInfo(msi);
                        return;
                    }
                }

            }
            else
            {
                CurrentSelMonitorName = "";
                ClearMonitorInfo();
            }

        }

#if SUPPORT_CUSTOM_TRACKBAR
        private void cusTrackbar_Brightness_Paint(object sender, PaintEventArgs e)
        {
            float bar_size = 0.45f;
            float x = ConversionValueToXPosition( Default_value );
            int y = (int)(cusTrackbar_Brightness.Height * bar_size);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.FillRectangle(Brushes.DimGray, 0, y, cusTrackbar_Brightness.Width, y / 2);
            e.Graphics.FillRectangle(Brushes.Red, 0, y, x, cusTrackbar_Brightness.Height - 2 * y);

            using (Pen pen = new Pen(Color.Black, 8))
            {
                e.Graphics.DrawEllipse(pen, x + 4, y - 2, cusTrackbar_Brightness.Height / 2, cusTrackbar_Brightness.Height / 2);
                e.Graphics.FillEllipse(Brushes.Red, x + 4, y - 6, cusTrackbar_Brightness.Height / 2, cusTrackbar_Brightness.Height / 2);
            }

            //using (Pen pen = new Pen(Color.White, 5))
            //{
            //    e.Graphics.DrawEllipse(pen, x + 4, y - 6, cusTrackbar_Brightness.Height / 2, cusTrackbar_Brightness.Height / 2);
            //}
        }


        public float ConversionValueToXPosition(float value)
        {
            return (cusTrackbar_Brightness.Width - 12) * (value - cusTrackBar_Min) / (float)(cusTrackBar_Max - cusTrackBar_Min);
        }


        public float slider_width(int x)
        {
            return cusTrackBar_Min + (cusTrackBar_Max - cusTrackBar_Min) * x / (float)(cusTrackbar_Brightness.Width);
        }

        private void cusTrackbar_Brightness_MouseDown(object sender, MouseEventArgs e)
        {
            cusTrackBar_Mouse_Pushed = true;
            float a = slider_width(e.X);
            thumb(a);
        }

        private void cusTrackbar_Brightness_MouseMove(object sender, MouseEventArgs e)
        {
            if ( !cusTrackBar_Mouse_Pushed )
                return;

            float a = slider_width(e.X);
            thumb(a);
        }

        private void cusTrackbar_Brightness_MouseUp(object sender, MouseEventArgs e)
        {
            cusTrackBar_Mouse_Pushed = false;
        }

        public void thumb(float value)
        {
            if (value < cusTrackBar_Min) value = cusTrackBar_Min;
            if (value > cusTrackBar_Max) value = cusTrackBar_Max;

            Default_value = value;
            cusTrackbar_Brightness.Refresh();
        }
#endif
    }


    public class MonitorSetInfo
    {
        public DisplayDevice   displaydevice { get; set; }
        public bool SetAsPrimary { get; set; }
        public bool Off { get; set; }

        public int MonitorIndex { get; set; }

        public uint MinimumContrast { get; set; }
        public uint CurrentContrast { get; set; }
        public uint MaximumContrast { get; set; }

        public MonitorSetInfo()
        {
            displaydevice = null;
            SetAsPrimary = false;
            Off = false;
            MonitorIndex = -1;

            MinimumContrast = 0;
            CurrentContrast = 0;
            MaximumContrast = 0;
        }
    }




}
