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

        KeyCombo CurNextkeyCombo = new KeyCombo();
        KeyCombo CurPrevkeyCombo = new KeyCombo();
        KeyCombo LockCurkeyCombo = new KeyCombo();

        //public CursorControl()
        public CursorControl(Form form , ConfigValues cv)
        {
            InitializeComponent();

            /* 참고. Screen.AllScreens는 현재 Active되어 있는 Screen 정보만 보여준다. */
            /* 나중에 활용할 때가 있을지도... */
            /* Screen.AllScreens; */

            configValues = cv;

            CursorController.Instance.Init(form , cv);               

            SystemEvents.DisplaySettingsChanged += new EventHandler(SystemEvents_DisplaySettingsChanged);
        }


        public void RestoreConfigValue()
        {
            configValues = backupConfigValue.ShallowCopy(); ;
        }


        private void InitKeyCombos()
        {
            CurNextkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            CurPrevkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            LockCurkeyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
        }


        private void UIControlAll(bool Value)
        {
            cb_FeatureEnable.Checked = Value;
            cb_MovCursorNextScreen.Enabled = Value;
            cb_MovCursorPrevScreen.Enabled = Value;
            cb_LockToScreen.Enabled = Value;

            txtBox_Hotkey_MovCurNextScreen.Enabled = Value;
            txtBox_Hotkey_MovCurPrevScreen.Enabled = Value;
            txtBox_Hotkey_LockToScreen.Enabled = Value;

            btn_CursorMov_Next_Screen_KeyChange.Enabled = Value;
            btn_CursorMov_Prev_Screen_KeyChange.Enabled = Value;
            btn_Cursor_Lock_Screen_KeyChange.Enabled = Value;
        }



        /*  */
        private void ApplyConfigSettingToUI()
        {
            /*  */
#if TEST
            txtBox_Hotkey_MovCurNextScreen.Text = CursorController.Instance.CursorNextScreenHotKeyController.ToString();
            txtBox_Hotkey_MovCurPrevScreen.Text = CursorController.Instance.CursorPrevScreenHotKeyController.ToString();
            txtBox_Hotkey_LockToScreen.Text = CursorController.Instance.LockCursorHotKeyController.ToString();
#else
            txtBox_Hotkey_MovCurNextScreen.Text = CurNextkeyCombo.ToString();
            txtBox_Hotkey_MovCurPrevScreen.Text = CurPrevkeyCombo.ToString();
            txtBox_Hotkey_LockToScreen.Text = LockCurkeyCombo.ToString();
#endif

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
                    btn_CursorMov_Next_Screen_KeyChange.Enabled = false;
                    cb_MovCursorNextScreen.Checked = false;
                }
                else
                {
                    txtBox_Hotkey_MovCurNextScreen.Enabled = true;
                    btn_CursorMov_Next_Screen_KeyChange.Enabled = true;
                    cb_MovCursorNextScreen.Checked = true;
                }

                /*  */
                if (configValues.EnableMoveCursorPrevScreen == false)
                {
                    txtBox_Hotkey_MovCurPrevScreen.Enabled = false;
                    btn_CursorMov_Prev_Screen_KeyChange.Enabled = false;
                    cb_MovCursorPrevScreen.Checked = false;
                }
                else
                {
                    txtBox_Hotkey_MovCurPrevScreen.Enabled = true;
                    btn_CursorMov_Prev_Screen_KeyChange.Enabled = true;
                    cb_MovCursorPrevScreen.Checked = true;
                }

                /*  */
                if (configValues.EnableLockCursorToScreen == false)
                {
                    txtBox_Hotkey_LockToScreen.Enabled = false;
                    btn_Cursor_Lock_Screen_KeyChange.Enabled = false;
                    cb_LockToScreen.Checked = false;
                }
                else
                {
                    txtBox_Hotkey_LockToScreen.Enabled = true;
                    btn_Cursor_Lock_Screen_KeyChange.Enabled = true;
                    cb_LockToScreen.Checked = true;
                }
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



        /* 변경사항들을 Config Value에 Update한다. */
        private void UpdateConfigValues()
        {           
            if (CurNextkeyCombo.Enabled)
            {
                configValues.HotkeyMoveCursorNextScreen = CurNextkeyCombo.ComboValue.ToString();
                CursorController.Instance.CursorNextScreenHotKeyController.SaveKeyCombo(CurNextkeyCombo);
            }

            if (CurPrevkeyCombo.Enabled)
            {
                configValues.HotkeyMoveCursorPrevScreen = CurPrevkeyCombo.ComboValue.ToString();
                CursorController.Instance.CursorPrevScreenHotKeyController.SaveKeyCombo(CurPrevkeyCombo);
            }

            if (LockCurkeyCombo.Enabled)
            {
                configValues.HotkeyLockCursorToScreen = LockCurkeyCombo.ComboValue.ToString();
                CursorController.Instance.LockCursorHotKeyController.SaveKeyCombo(LockCurkeyCombo);
            }

        }


        /// <summary>
        /// SET 버튼 처리 함수
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        private void cursorControl_Set_click(object sender, EventArgs e)
        {
            UpdateConfigValues();            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


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




        /// <summary>
        /// Enable Cursor Features CheckBox 상태 변경
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="EventArgs ">EventArgs </param>
        private void cb_FeatureEnable_ChangeCheck(object sender, EventArgs e)
        {
            if( cb_FeatureEnable.Checked )
                configValues.EnableCursorFeature = true;                
            else
                configValues.EnableCursorFeature = false;

            ApplyConfigSettingToUI();
        }

        /* Move Cursor To Next Screen CheckBox 상태 변경 */
        private void cb_CursorNextScreen_ChangeCheck(object sender, EventArgs e)
        {
            if (cb_MovCursorNextScreen.Checked)
                configValues.EnableMoveCursorNextScreen = true;
            else
                configValues.EnableMoveCursorNextScreen = false;

            ApplyConfigSettingToUI();
        }


        /* Move Cursor To Prev Screen CheckBox 상태 변경 */
        private void cb_CursorPrevScreen_ChangeCheck(object sender, EventArgs e)
        {
            if (cb_MovCursorPrevScreen.Checked)
                configValues.EnableMoveCursorPrevScreen = true;
            else
                configValues.EnableMoveCursorPrevScreen = false;

            ApplyConfigSettingToUI();
        }

        /* Lock To Screen CheckBox 상태 변경 */
        private void cb_LockScreen_ChangeCheck(object sender, EventArgs e)
        {
            if (cb_LockToScreen.Checked)
                configValues.EnableLockCursorToScreen = true;
            else
                configValues.EnableLockCursorToScreen = false;

            ApplyConfigSettingToUI();
        }



        /* Move Cursor To Next Screen key 변경 Button */
        private void btn_Click_CursorMov_Next_Screen_KeyChange(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput();           

            /* Show()는 Form이 시작되고 바로 다음 Line으로 실행이 넘어간다. */
            /* ShowDialog()를 사용하면, Form이 닫힌 다음에 다음 Line으로 실행이 넘어간다. */
            DialogResult Ret = hotKeyInput.ShowDialog();

            if( Ret == DialogResult.OK )
            {
                CurNextkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyMoveCursorNextScreen = CurNextkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_MovCurNextScreen.Text = CurNextkeyCombo.ToString();                
            }

            ApplyConfigSettingToUI();
        }



        /* Move Cursor To Prev Screen key 변경 Button */
        private void btn_Click_CursorMov_Prev_Screen_KeyChange(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput();

            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                CurPrevkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyMoveCursorPrevScreen = CurPrevkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_MovCurPrevScreen.Text = CurPrevkeyCombo.ToString();
            }

            ApplyConfigSettingToUI();
        }


        /* Lock To Screen key 변경 Button */
        private void btn_Click_Cursor_Lock_Screen_KeyChange(object sender, EventArgs e)
        {
            HotKeyInput hotKeyInput = new HotKeyInput();

            DialogResult Ret = hotKeyInput.ShowDialog();

            if (Ret == DialogResult.OK)
            {
                LockCurkeyCombo = hotKeyInput.GetKeyCombo();
                configValues.HotkeyLockCursorToScreen = LockCurkeyCombo.ComboValue.ToString();
                txtBox_Hotkey_LockToScreen.Text = LockCurkeyCombo.ToString();
            }

            ApplyConfigSettingToUI();
        }


        /* Form이 Load될 때 호출된다. */
        private void ShownForm(object sender, EventArgs e)
        {
            InitKeyCombos();
            backupConfigValue = configValues.ShallowCopy();
            ApplyConfigSettingToUI();
        }
    }
}
