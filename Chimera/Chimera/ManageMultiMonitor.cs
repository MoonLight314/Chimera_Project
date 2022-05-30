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


        public ManageMultiMonitor(IList<DisplayDevice> allMonitorProperties , DisplayDevices displayDevices)
        {
            InitializeComponent();

            MonitorSettingInfo = new List<MonitorSetInfo>();

            _displayDevices = displayDevices;

            GetOnlyActiveMonitors( allMonitorProperties );

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

                    msi.MonitorIndex = allMonitorProperties.IndexOf(dd);
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
            if (e.Node.Text == "All Monitors")
            {
                ClearMonitorInfo();
            }
            else
            {
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

            cb_SetAsPrimary.Checked = msi.displaydevice.IsPrimary;
            cb_MonitorOff.Checked = msi.Off;

            if (msi.displaydevice.IsPrimary)
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
        }


        
        
        /* 종료 버튼 */
        private void manage_exit(object sender, EventArgs e)
        {
            this.Close();
        }




        /* 설정 반영하기 */
        private void manage_Set(object sender, EventArgs e)
        {
            //_displayDevices.MakePrimary(0);
            _displayDevices.MakeAsDisabled(2 , false);
            _displayDevices.MakeAsDisabled(2 , true);
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
