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
        ConfigValues configValues;

        /* */
        bool ShiftKeyDown;
        bool CtrlKeyDown;
        bool AltKeyDown;

        public HotKeyInput(ConfigValues cv)
        {
            InitializeComponent();

            InitUI();

            configValues = cv;
        }



        private void InitUI()
        {
            /*  */
            this.BackColor = Color.FromArgb(255, 255, 255);

            this.label_Hotkey_Input.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Shift.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ctrl.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Alt.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_NormalKey.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            ClearUI();

        }



        private void HotKeyInput_Cancel(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void key_down(object sender, KeyEventArgs e)
        {
            //cb_Ctrl.Checked = e.Control;
            //cb_Alt.Checked = e.Alt;
            //cb_Shift.Checked = e.Shift;

            CtrlKeyDown = e.Control;
            pb_CheckBox_Ctrl.Image = CtrlKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            AltKeyDown = e.Alt;
            pb_CheckBox_Alt.Image = AltKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            ShiftKeyDown = e.Shift;
            pb_CheckBox_Shift.Image = ShiftKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;


            txtBox_NormalKey.Text = KeyCodeValues.GetKeyCodeString( e );

            /*  */
            if( KeyCodeValues.IsNormalKeyPressed(e) )
            {
                /* 이미 등록된 Key가 있는지 확인 */
                if( CheckKeyComboDuplicated(e) == true)
                {
                    MessageBox.Show("This keys are already registered.", "Setting Hotkey", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearUI();
                    return;
                }

                if (ProcessHotKeyInput(e))
                {
                    ClearUI();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }



        /// <summary>
        /// User가 입력한 Key가 이미 사용중인지 확인. 
        /// </summary>
        /// <param name="KeyEventArgs ">KeyEventArgs </param>
        private bool CheckKeyComboDuplicated(KeyEventArgs e)
        {
            KeyCombo tmpKey = new KeyCombo();

            //tmpKey.AltMod = cb_Alt.Checked;
            //tmpKey.ControlMod = cb_Ctrl.Checked;
            //tmpKey.ShiftMod = cb_Shift.Checked;

            tmpKey.AltMod = AltKeyDown;
            tmpKey.ControlMod = CtrlKeyDown;
            tmpKey.ShiftMod = ShiftKeyDown;

            tmpKey.KeyCode = e.KeyCode;

            if (configValues.CheckHotKeyDuplicated(tmpKey.ComboValue.ToString()))
                return true;
            else
                return false;

        }






        /// <summary>
        /// ProcessHotKeyInput
        /// </summary>
        /// <param name="KeyEventArgs ">KeyEventArgs </param>
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
                    //this.keyCombo.AltMod = cb_Alt.Checked;
                    //this.keyCombo.ControlMod = cb_Ctrl.Checked;
                    //this.keyCombo.ShiftMod = cb_Shift.Checked;

                    this.keyCombo.AltMod = AltKeyDown;
                    this.keyCombo.ControlMod = CtrlKeyDown;
                    this.keyCombo.ShiftMod = ShiftKeyDown;

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
            //cb_Ctrl.Checked = false;
            //cb_Alt.Checked = false;
            //cb_Shift.Checked = false;

            CtrlKeyDown = false;
            AltKeyDown = false;
            ShiftKeyDown = false;

            pb_CheckBox_Ctrl.Image = CtrlKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;
            pb_CheckBox_Alt.Image = AltKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;
            pb_CheckBox_Shift.Image = ShiftKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            txtBox_NormalKey.Text = "";
        }


        private string GetHotkeyString()
        {
            string Ret = "";

            //if (cb_Ctrl.Checked)
            //    Ret += "Ctrl + ";

            //if (cb_Alt.Checked)
            //    Ret += "Alt + ";

            //if (cb_Shift.Checked)
            //    Ret += "Shift + ";

            if (CtrlKeyDown)
                Ret += "Ctrl + ";

            if (AltKeyDown)
                Ret += "Alt + ";

            if (ShiftKeyDown)
                Ret += "Shift + ";

            Ret += txtBox_NormalKey.Text;

            return Ret;
        }



        private void key_up(object sender, KeyEventArgs e)
        {
            //cb_Ctrl.Checked = e.Control;
            //cb_Alt.Checked = e.Alt;
            //cb_Shift.Checked = e.Shift;

            CtrlKeyDown = e.Control;
            pb_CheckBox_Ctrl.Image = CtrlKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            AltKeyDown = e.Alt;
            pb_CheckBox_Alt.Image = AltKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            ShiftKeyDown = e.Shift;
            pb_CheckBox_Shift.Image = ShiftKeyDown ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            txtBox_NormalKey.Text = "";
        }


        private int CountModifierKey()
        {
            int ModifierCount = 0;

            //if (cb_Ctrl.Checked)
            //    ModifierCount++;

            //if (cb_Alt.Checked)
            //    ModifierCount++;

            //if (cb_Shift.Checked)
            //    ModifierCount++;

            if (CtrlKeyDown)
                ModifierCount++;

            if (AltKeyDown)
                ModifierCount++;

            if (ShiftKeyDown)
                ModifierCount++;

            return ModifierCount;
        }

        public KeyCombo GetKeyCombo()
        {
            return this.keyCombo;
        }

        private void txtBox_NormalKey_Enter(object sender, EventArgs e)
        {
            txtBox_NormalKey.Enabled = false;
            txtBox_NormalKey.Enabled = true;
        }
    }
}
