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
        //public CursorControl()
        public CursorControl(Form form)
        {
            InitializeComponent();

            /* 참고. Screen.AllScreens는 현재 Active되어 있는 Screen 정보만 보여준다. */
            /* 나중에 활용할 때가 있을지도... */
            /* Screen.AllScreens; */

            //CursorController.Instance.Init(this);
            CursorController.Instance.Init(form);

            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }




        public void CleanUp()
        {
            SystemEvents.DisplaySettingsChanged -= new EventHandler(SystemEvents_DisplaySettingsChanged);

            // Let the controller release all the hotkeys
            // and any other resources it has
            CursorController.Instance.Term();
        }





        // This method is called when the display settings change.
        static void SystemEvents_DisplaySettingsChanged(object sender, EventArgs e)
        {
            CursorHelper.DisplaySettingsChanged();
        }



        private void moveNext_Button_Click(object sender, EventArgs e)
        {

        }

        private void cursorControl_Set_click(object sender, EventArgs e)
        {
            Test();
        }

        private void cursorControl_Cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Test()
        {

        }
    }
}
