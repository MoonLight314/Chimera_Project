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

        KeyCombo keyCombo;

        public HotKeyInput()
        {
            InitializeComponent();            
        }

        private void HotKeyInput_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void key_down(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;

            txtBox_NormalKey.Text = KeyCodeValues.GetKeyCodeString( e );

            /*  */
            if( KeyCodeValues.IsNormalKeyPressed(e) )
            {
                if (ProcessHotKeyInput(e))
                {
                    ClearUI();
                    this.Close();
                }

            }
        }



        private bool ProcessHotKeyInput(KeyEventArgs e)
        {
            string Hotkey = "Do you want to set Hotkey to " + GetHotkeyString() + " ?";

            if (CountModifierKey() >= 2)
            {
                DialogResult Ret = MessageBox.Show(Hotkey, "Setting Hotkey",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);                

                if (Ret == DialogResult.Yes)
                {
                    this.keyCombo.AltMod = cb_Alt.Checked;
                    this.keyCombo.ControlMod = cb_Ctrl.Checked;
                    this.keyCombo.ShiftMod = cb_Shift.Checked;
                    this.keyCombo.KeyCode = e.KeyCode;
                    return true;
                }
                else
                    return false;                
            }
            else
                return false;
        }

        private void ClearUI()
        {
            cb_Ctrl.Checked = false;
            cb_Alt.Checked = false;
            cb_Shift.Checked = false;
            txtBox_NormalKey.Text = "";
        }


        private string GetHotkeyString()
        {
            string Ret = "";

            if (cb_Ctrl.Checked)
                Ret += "Ctrl + ";

            if (cb_Alt.Checked)
                Ret += "Alt + ";

            if (cb_Shift.Checked)
                Ret += "Shift + ";

            Ret += txtBox_NormalKey.Text;

            return Ret;
        }



        private void key_up(object sender, KeyEventArgs e)
        {
            cb_Ctrl.Checked = e.Control;
            cb_Alt.Checked = e.Alt;
            cb_Shift.Checked = e.Shift;

            txtBox_NormalKey.Text = "";
        }


        private int CountModifierKey()
        {
            int ModifierCount = 0;

            if (cb_Ctrl.Checked)
                ModifierCount++;

            if (cb_Alt.Checked)
                ModifierCount++;

            if (cb_Shift.Checked)
                ModifierCount++;

            return ModifierCount;
        }
    }
}
