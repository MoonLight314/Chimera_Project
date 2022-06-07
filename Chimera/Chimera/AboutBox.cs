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
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void aboutBox_OK_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void key_down_test(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;
        }


        private void key_up_test(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;
        }
    }
}
