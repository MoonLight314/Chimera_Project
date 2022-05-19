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
        IList<DisplayDevice> allMonitorInfo;


        public ManageMultiMonitor( IList<DisplayDevice> allMonitorProperties )
        {
            InitializeComponent();

            allMonitorInfo = allMonitorProperties;

            InitTreeView();
        }



        void InitTreeView()
        {
            tv_Monitor_List.Nodes.Add("All Monitors");

            foreach (DisplayDevice dd in allMonitorInfo)
            {
                if (dd.IsActive)
                {
                    tv_Monitor_List.Nodes[0].Nodes.Add(dd.FriendlyName);
                }
            }

        }


        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //e.Node.Text;
            ;
        }
    }
}
