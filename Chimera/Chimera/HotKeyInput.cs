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
    public partial class HotKeyInput : Form
    {
        KeysConverter converter = new KeysConverter();

        public HotKeyInput(KeyCombo keyCombo)
        {
            InitializeComponent();
        }

        private void HotKeyInput_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void key_down_test(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;

            if( e.KeyCode == Keys.O )
                txtBox_NormalKey.Text = "<O>";

            //string KeyValue = converter.ConvertToString(e.KeyCode);

            //if (txtBox_NormalKey.Text != "")
            //    txtBox_NormalKey.Text = KeyValue;
            //else
            //    txtBox_NormalKey.Text = "";

        }


        private void key_up_test(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;

            //string KeyValue = converter.ConvertToString(e.KeyCode);

            //if (txtBox_NormalKey.Text != "")
            //    txtBox_NormalKey.Text = KeyValue;
            //else
            //    txtBox_NormalKey.Text = "";
        }
    }
}
