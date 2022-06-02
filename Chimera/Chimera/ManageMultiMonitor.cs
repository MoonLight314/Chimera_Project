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
    public partial class ManageMultiMonitor : Form
    {

        IList<MonitorSetInfo>   MonitorSettingInfo;
        DisplayDevices          _displayDevices;
        String                  CurrentSelMonitorName;



        /*   */
        public ManageMultiMonitor(IList<DisplayDevice> allMonitorProperties , DisplayDevices displayDevices)
        {
            InitializeComponent();

            MonitorSettingInfo = new List<MonitorSetInfo>();

            _displayDevices = displayDevices;

            CurrentSelMonitorName = "All Monitors";

            GetOnlyActiveMonitors( allMonitorProperties );

            /*  */
            InitUI();

        }


        void GetOnlyActiveMonitors(IList<DisplayDevice> allMonitorProperties)
        {           

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

                    MonitorSettingInfo.Add(msi);
                    msi = null;
                    
                }
            }
        }





        void InitUI()
        {
            tv_Monitor_List.Nodes.Add("All Monitors");

            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                tv_Monitor_List.Nodes[0].Nodes.Add(msi.displaydevice.FriendlyName);
            }            
        }



        /* 모니터 정보 Tree View 선택시 */
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
                cb_MonitorOff.Enabled = true;

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




        private void DisplaySelectedMonitorInfo(MonitorSetInfo msi )
        {
            textBox_Primary.Text = msi.displaydevice.IsPrimary ? "Yes" : "No";            
            textBox_FriendlyName.Text = msi.displaydevice.FriendlyName;
            textBox_Resolution.Text = string.Format("{0} X {1}", msi.displaydevice.Bounds.Size.Width , msi.displaydevice.Bounds.Size.Height );
            textBox_BitPerPixel.Text = string.Format("{0}", msi.displaydevice.BitsPerPixel );
            textBox_OutputTech.Text = msi.displaydevice.OutputTechnology;
            textBox_Rotation.Text = string.Format("{0}", msi.displaydevice.RotationDegrees );

            cb_SetAsPrimary.Checked = msi.SetAsPrimary;
            cb_MonitorOff.Checked = msi.Off;

            if (msi.SetAsPrimary)
                cb_MonitorOff.Enabled = false;
            else
                cb_MonitorOff.Enabled = true;
        }



        /* 모니터 정보를 모두 지운다. */
        private void ClearMonitorInfo()
        {
            textBox_Primary.Text = "";
            textBox_FriendlyName.Text = "";
            textBox_Resolution.Text = "";
            textBox_BitPerPixel.Text = "";
            textBox_OutputTech.Text = "";
            textBox_Rotation.Text = "";

            cb_SetAsPrimary.Checked = false;
            cb_MonitorOff.Checked = false;

            if (CurrentSelMonitorName == "All Monitors")
            {
                cb_SetAsPrimary.Enabled = false;
                cb_MonitorOff.Enabled = false;
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
            }

            _displayDevices.Reset();            

            /* Monitor Off 설정 */
            foreach (MonitorSetInfo msi in MonitorSettingInfo)
            {
                if ( msi.Off )
                {
                    _displayDevices.MakeAsDisabled(msi.MonitorIndex , false);
                }
                    
            }

            /* Primary Monitor */
            _displayDevices.MakePrimary( GetPrimaryMonitorIndex() );

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
            if( CurrentSelMonitorName == "All Monitors")
            {
                cb_SetAsPrimary.Checked = false;
            }

            /*  */
            foreach(MonitorSetInfo msi in MonitorSettingInfo)
            {
                if( msi.displaydevice.FriendlyName == CurrentSelMonitorName )
                {
                    /* Primary로 선택된 Monitor는 끌 수 없게 한다. */
                    msi.SetAsPrimary = cb_SetAsPrimary.Checked;
                    cb_MonitorOff.Enabled = msi.SetAsPrimary ? false : true;

                    if(msi.SetAsPrimary && cb_MonitorOff.Checked)
                    {
                        cb_MonitorOff.Checked = false;
                        msi.Off = false;
                    }

                    DisplaySelectedMonitorInfo(msi);
                    break;
                }
            }

            tv_Monitor_List.Select();            
        }




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
                    msi.Off = cb_MonitorOff.Checked;

                    DisplaySelectedMonitorInfo(msi);
                    break;
                }
            }

            tv_Monitor_List.Select();
        }
    }



    public class MonitorSetInfo
    {
        public DisplayDevice   displaydevice { get; set; }
        public bool SetAsPrimary { get; set; }
        public bool Off { get; set; }

        public int MonitorIndex { get; set; }

        public MonitorSetInfo()
        {
            displaydevice = null;
            SetAsPrimary = false;
            Off = false;
            MonitorIndex = -1;
        }

    }


}
