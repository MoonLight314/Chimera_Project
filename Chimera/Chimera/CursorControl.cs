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
        ConfigValues configValues = new ConfigValues();
        ConfigValues backupConfigValue = new ConfigValues();

        /* Hot Key Add Part */
        KeyCombo CurNextkeyCombo = new KeyCombo();
        KeyCombo CurPrevkeyCombo = new KeyCombo();
        KeyCombo CurPrimarykeyCombo = new KeyCombo();
        KeyCombo LockCurkeyCombo = new KeyCombo();

        Form form;

        /* 각 항목별 Check Box 설정 저장 */
        bool FeatureEnable;
        bool MovCursorNextScreen;
        bool MovCursorPrevScreen;
        bool MovCursorPrimary;
        bool LockToScreen;


        //public CursorControl()
        public CursorControl(Form BaseForm , ConfigValues cv)
        {
            InitializeComponent();

            InitUI();

            /* 참고. Screen.AllScreens는 현재 Active되어 있는 Screen 정보만 보여준다. */
            /* 나중에 활용할 때가 있을지도... */
            /* Screen.AllScreens; */

            configValues = cv;
            this.form = BaseForm;

            InitKeyCombos(KeyCombo.DisabledComboValue);

            CursorController.Instance.Init(form , cv);

            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }



        private void InitUI()
        {
            /*  */
            Bitmap bmp = Properties.Resources.Manager_Form_Icon;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            /*  */
            this.BackColor = Color.FromArgb(255, 255, 255);

            this.label_CursorControl.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Bold(), 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureBox_CursorControl_Comment.Image = Properties.Resources.Cursor_Control_Text;
            this.label_Feature_Enable.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.cursorControl_Reset.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FeatureEnable.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label_Features.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
        }
        



        public void RestoreConfigValue()
        {
            configValues = backupConfigValue.ShallowCopy(); ;
        }

        
        /* Hot Key Add Part */
        private void InitKeyCombos(uint keyComboValue)
        {
            CurNextkeyCombo.FromPropertyValue(keyComboValue);
            CurPrevkeyCombo.FromPropertyValue(keyComboValue);
            CurPrimarykeyCombo.FromPropertyValue(keyComboValue);
            LockCurkeyCombo.FromPropertyValue(keyComboValue);
        }



        /* Hot Key Add Part */
        private void InitKeyCombos(ConfigValues cv)
        {
            CurNextkeyCombo.FromPropertyValue(  string.Compare(cv.HotkeyMoveCursorNextScreen,"Not Defined") == 0 ? 
                                                   KeyCombo.DisabledComboValue : 
                                                   UInt32.Parse(cv.HotkeyMoveCursorNextScreen) );


            CurPrevkeyCombo.FromPropertyValue(  string.Compare(cv.HotkeyMoveCursorPrevScreen, "Not Defined") == 0 ?
                                                    KeyCombo.DisabledComboValue :
                                                    UInt32.Parse(cv.HotkeyMoveCursorPrevScreen));

            CurPrimarykeyCombo.FromPropertyValue(string.Compare(cv.HotkeyMoveCursorPrimaryScreen, "Not Defined") == 0 ?
                                                    KeyCombo.DisabledComboValue :
                                                    UInt32.Parse(cv.HotkeyMoveCursorPrimaryScreen));


            LockCurkeyCombo.FromPropertyValue(  string.Compare(cv.HotkeyLockCursorToScreen, "Not Defined") == 0 ?
                                                    KeyCombo.DisabledComboValue :
                                                    UInt32.Parse(cv.HotkeyLockCursorToScreen));
        }




        /* Hot Key Add Part */
        private void UIControlAll(bool Value)
        {
            FeatureEnable = Value;
            pb_CheckBox_FeatureEnable.Image = FeatureEnable ? Properties.Resources.Toggle_Switch_On : Properties.Resources.Toggle_Switch_Off;

            MovCursorNextScreen = Value;
            pb_CheckBox_MovCursorNextScreen.Image = MovCursorNextScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            MovCursorPrevScreen = Value;
            pb_CheckBox_MovCursorPrevScreen.Image = MovCursorPrevScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            MovCursorPrimary = Value;
            pb_CheckBox_MovCursorPrimary.Image = MovCursorPrimary ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            LockToScreen = Value;
            pb_CheckBox_LockToScreen.Image = LockToScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

            txtBox_Hotkey_MovCurNextScreen.Enabled = Value;
            txtBox_Hotkey_MovCurPrevScreen.Enabled = Value;
            txtBox_Hotkey_MoveCurPrimary.Enabled = Value;
            txtBox_Hotkey_LockToScreen.Enabled = Value;

            cursorControl_Reset.Enabled = Value;
            cursorControl_Reset.Image = cursorControl_Reset.Enabled ? Properties.Resources.Reset_Enabled : Properties.Resources.Reset_Disabled;


        }



        /* Hot Key Add Part */
        private void ApplyConfigSettingToUI()
        {
            /*  */
            txtBox_Hotkey_MovCurNextScreen.Text = CurNextkeyCombo.ToString(true);
            txtBox_Hotkey_MovCurPrevScreen.Text = CurPrevkeyCombo.ToString(true);
            txtBox_Hotkey_MoveCurPrimary.Text = CurPrimarykeyCombo.ToString(true);
            txtBox_Hotkey_LockToScreen.Text = LockCurkeyCombo.ToString(true);

            /* 전체 Disable인 경우 */
            if (configValues.EnableCursorFeature == false )
                UIControlAll( false );

            /* 전체 기능 Enable인 상태 */
            /* 개별적 기능 설정 */
            else
            {
                UIControlAll( true );

                /*  */
                if (configValues.EnableMoveCursorNextScreen == false)
                {
                    txtBox_Hotkey_MovCurNextScreen.Enabled = false;
                    MovCursorNextScreen = false;
                }
                else
                {
                    txtBox_Hotkey_MovCurNextScreen.Enabled = true;
                    MovCursorNextScreen = true;
                }

                /*  */
                if (configValues.EnableMoveCursorPrevScreen == false)
                {
                    txtBox_Hotkey_MovCurPrevScreen.Enabled = false;
                    MovCursorPrevScreen = false;
                }
                else
                {
                    txtBox_Hotkey_MovCurPrevScreen.Enabled = true;
                    MovCursorPrevScreen = true;
                }


                /*  */
                if (configValues.EnableMoveCursorPrimaryScreen == false)
                {
                    txtBox_Hotkey_MoveCurPrimary.Enabled = false;
                    MovCursorPrimary = false;
                }
                else
                {
                    txtBox_Hotkey_MoveCurPrimary.Enabled = true;
                    MovCursorPrimary = true;
                }


                /*  */
                if (configValues.EnableLockCursorToScreen == false)
                {
                    txtBox_Hotkey_LockToScreen.Enabled = false;
                    LockToScreen = false;
                }
                else
                {
                    txtBox_Hotkey_LockToScreen.Enabled = true;
                    LockToScreen = true;
                }

                /*  */
                pb_CheckBox_MovCursorNextScreen.Image = MovCursorNextScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;
                pb_CheckBox_MovCursorPrevScreen.Image = MovCursorPrevScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;
                pb_CheckBox_MovCursorPrimary.Image = MovCursorPrimary ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;
                pb_CheckBox_LockToScreen.Image = LockToScreen ? Properties.Resources.Checkbox_Checked : Properties.Resources.Checkbox_Not_Checked;

                label_MovCursorNextScreen.ForeColor = MovCursorNextScreen ? Color.FromArgb(1, 1, 1) : Color.FromArgb(0x86, 0x86, 0x86);
                label_MovCursorPrevScreen.ForeColor = MovCursorPrevScreen ? Color.FromArgb(1, 1, 1) : Color.FromArgb(0x86, 0x86, 0x86);
                label_MovCursorPrimary.ForeColor = MovCursorPrimary ? Color.FromArgb(1, 1, 1) : Color.FromArgb(0x86, 0x86, 0x86);
                label_LockToScreen.ForeColor = LockToScreen ? Color.FromArgb(1, 1, 1) : Color.FromArgb(0x86, 0x86, 0x86);

            }
                        
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



        /* Hot Key Add Part */
        /// <summary>
        /// 변경사항들을 Config Value에 Update한다.
        /// </summary>        
        private void UpdateConfigValues()
        {
            if (CurNextkeyCombo.Enabled)
            {
                configValues.HotkeyMoveCursorNextScreen = CurNextkeyCombo.ComboValue.ToString();                
            }

            CursorController.Instance.CursorNextScreenHotKeyController.SaveKeyCombo(CurNextkeyCombo);

            if (CurPrevkeyCombo.Enabled)
            {
                configValues.HotkeyMoveCursorPrevScreen = CurPrevkeyCombo.ComboValue.ToString();                
            }

            CursorController.Instance.CursorPrevScreenHotKeyController.SaveKeyCombo(CurPrevkeyCombo);

            /*  */
            if (CurPrimarykeyCombo.Enabled)
            {
                configValues.HotkeyMoveCursorPrimaryScreen = CurPrimarykeyCombo.ComboValue.ToString();
            }

            CursorController.Instance.CursorPrimaryScreenHotKeyController.SaveKeyCombo(CurPrimarykeyCombo);


            /*  */
            if (LockCurkeyCombo.Enabled)
            {
                configValues.HotkeyLockCursorToScreen = LockCurkeyCombo.ComboValue.ToString();                
            }

            CursorController.Instance.LockCursorHotKeyController.SaveKeyCombo(LockCurkeyCombo);
        }


        /// <summary>
        /// SET 버튼 처리 함수
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        //private void cursorControl_Set_click(object sender, EventArgs e)
        //{
        //    UpdateConfigValues();
        //    this.DialogResult = DialogResult.OK;
        //    this.Close();
        //}



#if TEST
        /// <summary>
        /// CANCEL 버튼 처리 함수 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        private void cursorControl_Cancel_click(object sender, EventArgs e)
        {
            RestoreConfigValue();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
#endif


        /// <summary>
        /// Form이 Load될 때 호출된다. 
        /// </summary>        
        private void ShownForm(object sender, EventArgs e)
        {
            InitKeyCombos( this.configValues );
            backupConfigValue = configValues.ShallowCopy();
            ApplyConfigSettingToUI();
        }



        /// <summary>
        /// Cursor Next Screen Key Combo Cancel Button 처리
        /// 각 Key Combo Cancel을 따로 함수로 만든 이유는 RESET Button 기능 구현을 하기 위함
        /// </summary>        
        private void CurNextkeyCombo_Cancel()
        {
            CurNextkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            configValues.HotkeyMoveCursorNextScreen = "Not Defined";
            txtBox_Hotkey_MovCurNextScreen.Text = CurNextkeyCombo.ToString();
        }


        /// <summary>
        /// Cursor Prev Screen Key Combo Cancel Button 처리
        /// </summary>        
        private void CurPrevkeyCombo_Cancel()
        {
            CurPrevkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            configValues.HotkeyMoveCursorPrevScreen = "Not Defined";
            txtBox_Hotkey_MovCurPrevScreen.Text = CurPrevkeyCombo.ToString();
        }


        /// <summary>
        /// Cursor Primary Screen Key Combo Cancel Button 처리
        /// </summary>
        private void CurPrimarykeyCombo_Cancel()
        {
            CurPrimarykeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            configValues.HotkeyMoveCursorPrimaryScreen = "Not Defined";
            txtBox_Hotkey_MoveCurPrimary.Text = CurPrimarykeyCombo.ToString();
        }


        /// <summary>
        /// Cursor Lock Screen Key Combo Cancel Button 처리
        /// </summary>        
        private void LockCurkeyCombo_Cancel()
        {
            LockCurkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            configValues.HotkeyLockCursorToScreen = "Not Defined";
            txtBox_Hotkey_LockToScreen.Text = LockCurkeyCombo.ToString();
        }




        /// <summary>
        /// Cursor Dialog의 Reset Button 처리.
        /// 현재 설정값 값들을 모두 Reset한다.
        /// </summary>        
        private void cursorControl_Reset_Click(object sender, EventArgs e)
        {
            CurNextkeyCombo_Cancel();
            CurPrevkeyCombo_Cancel();
            CurPrimarykeyCombo_Cancel();
            LockCurkeyCombo_Cancel();

            ApplyConfigSettingToUI();
        }

        private void txtBox_Hotkey_MovCurNextScreen_Enter(object sender, EventArgs e)
        {
            txtBox_Hotkey_MovCurNextScreen.Enabled = false;
            txtBox_Hotkey_MovCurNextScreen.Enabled = true;
        }

        private void txtBox_Hotkey_MovCurPrevScreen_Enter(object sender, EventArgs e)
        {
            txtBox_Hotkey_MovCurPrevScreen.Enabled = false;
            txtBox_Hotkey_MovCurPrevScreen.Enabled = true;
        }

        private void txtBox_Hotkey_MoveCurPrimary_Enter(object sender, EventArgs e)
        {
            txtBox_Hotkey_MoveCurPrimary.Enabled = false;
            txtBox_Hotkey_MoveCurPrimary.Enabled = true;
        }

        private void txtBox_Hotkey_LockToScreen_Enter(object sender, EventArgs e)
        {
            txtBox_Hotkey_LockToScreen.Enabled = false;
            txtBox_Hotkey_LockToScreen.Enabled = true;
        }

        /*  */
        private void pb_CheckBox_FeatureEnable_Click(object sender, EventArgs e)
        {
            FeatureEnable = !FeatureEnable;

            if (FeatureEnable)
            {
                pb_CheckBox_FeatureEnable.Image = Properties.Resources.Toggle_Switch_On;
                configValues.EnableCursorFeature = true;
            }
            else
            {
                pb_CheckBox_FeatureEnable.Image = Properties.Resources.Toggle_Switch_Off;
                configValues.EnableCursorFeature = false;
            }

            ApplyConfigSettingToUI();
        }


        /*  */
        private void pb_CheckBox_MovCursorNextScreen_Click(object sender, EventArgs e)
        {
            if (FeatureEnable)
            {
                MovCursorNextScreen = !MovCursorNextScreen;

                if (MovCursorNextScreen)
                {
                    pb_CheckBox_MovCursorNextScreen.Image = Properties.Resources.Checkbox_Checked;
                    configValues.EnableMoveCursorNextScreen = true;
                }
                else
                {
                    pb_CheckBox_MovCursorNextScreen.Image = Properties.Resources.Checkbox_Not_Checked;
                    configValues.EnableMoveCursorNextScreen = false;
                }

                ApplyConfigSettingToUI();
            }
        }

        /*  */
        private void pb_CheckBox_MovCursorPrevScreen_Click(object sender, EventArgs e)
        {
            if (FeatureEnable)
            {
                MovCursorPrevScreen = !MovCursorPrevScreen;

                if (MovCursorPrevScreen)
                {
                    pb_CheckBox_MovCursorPrevScreen.Image = Properties.Resources.Checkbox_Checked;
                    configValues.EnableMoveCursorPrevScreen = true;
                }
                else
                {
                    pb_CheckBox_MovCursorPrevScreen.Image = Properties.Resources.Checkbox_Not_Checked;
                    configValues.EnableMoveCursorPrevScreen = false;
                }

                ApplyConfigSettingToUI();
            }
        }



        /*  */
        private void pb_CheckBox_MovCursorPrimary_Click(object sender, EventArgs e)
        {
            if (FeatureEnable)
            {
                MovCursorPrimary = !MovCursorPrimary;

                if (MovCursorPrimary)
                {
                    pb_CheckBox_MovCursorPrimary.Image = Properties.Resources.Checkbox_Checked;
                    configValues.EnableMoveCursorPrimaryScreen = true;
                }
                else
                {
                    pb_CheckBox_MovCursorPrimary.Image = Properties.Resources.Checkbox_Not_Checked;
                    configValues.EnableMoveCursorPrimaryScreen = false;
                }

                ApplyConfigSettingToUI();
            }
        }




        /*  */
        private void pb_CheckBox_LockToScreen_Click(object sender, EventArgs e)
        {
            if (FeatureEnable)
            {
                LockToScreen = !LockToScreen;

                if (LockToScreen)
                {
                    pb_CheckBox_LockToScreen.Image = Properties.Resources.Checkbox_Checked;
                    configValues.EnableLockCursorToScreen = true;
                }
                else
                {
                    pb_CheckBox_LockToScreen.Image = Properties.Resources.Checkbox_Not_Checked;
                    configValues.EnableLockCursorToScreen = false;
                }

                ApplyConfigSettingToUI();
            }
        }




        /*  */
        private void txtBox_Hotkey_MovCurNextScreen_Click(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput(configValues);

            /* Show()는 Form이 시작되고 바로 다음 Line으로 실행이 넘어간다. */
            /* ShowDialog()를 사용하면, Form이 닫힌 다음에 다음 Line으로 실행이 넘어간다. */
            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                CurNextkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyMoveCursorNextScreen = CurNextkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_MovCurNextScreen.Text = CurNextkeyCombo.ToString();
            }
            else if (Ret == DialogResult.Cancel)
            {
                CurNextkeyCombo_Cancel();
            }

            ApplyConfigSettingToUI();
        }

        private void txtBox_Hotkey_MovCurPrevScreen_Click(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput(configValues);

            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                CurPrevkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyMoveCursorPrevScreen = CurPrevkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_MovCurPrevScreen.Text = CurPrevkeyCombo.ToString();
            }
            else if (Ret == DialogResult.Cancel)
            {
                CurPrevkeyCombo_Cancel();
            }

            ApplyConfigSettingToUI();
        }

        private void txtBox_Hotkey_MoveCurPrimary_Click(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput(configValues);

            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                CurPrimarykeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyMoveCursorPrimaryScreen = CurPrimarykeyCombo.ComboValue.ToString();
                txtBox_Hotkey_MoveCurPrimary.Text = CurPrimarykeyCombo.ToString();
            }
            else if (Ret == DialogResult.Cancel)
            {
                CurPrimarykeyCombo_Cancel();
            }

            ApplyConfigSettingToUI();
        }

        private void txtBox_Hotkey_LockToScreen_Click(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput(configValues);

            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                LockCurkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyLockCursorToScreen = LockCurkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_LockToScreen.Text = LockCurkeyCombo.ToString();
            }
            else if (Ret == DialogResult.Cancel)
            {
                LockCurkeyCombo_Cancel();
            }

            ApplyConfigSettingToUI();
        }

        private void CursorControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateConfigValues();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
