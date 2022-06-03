using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;



namespace Chimera
{
    public partial class CursorControl : Form
    {
        public CursorControl()
        {
            InitializeComponent();

            /* 참고. Screen.AllScreens는 현재 Active되어 있는 Screen 정보만 보여준다. */
            /* 나중에 활용할 때가 있을지도... */
            /* Screen.AllScreens; */

            CursorController.Instance.Init(this);

            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }




        // This method is called when the display settings change.
        static void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            CursorHelper.DisplaySettingsChanged();
        }



        private void cursorControl_OK_click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void moveNext_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
