using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using Chimera.Resources;

namespace Chimera
{
    /// <summary>
    /// This is a small wrapper for the HotKey which links the
    /// Hotkey itself with the form to edit it and the property
    /// required to make its key combination persistant.
    /// </summary>
    class HotKeyController : IDisposable
    {
        // The HotKey does the real work
        private HotKey hotKey;
        //public HotKey hotKey { get; set; }

        // The name used in Properties.Settings.Default. to persist
        // the value of the hotkey between sessions.
        // Note: we cannot use a reference direct to the setting as it is
        // a property.  This means we have no compile time checks that
        // the name is spelt correctly or the type is correct as we would
        // have if we use the property directly.
        private string propertyName;

        // short description of the hotkey
        private string description;

        // displayable string representing the hotkey that Windows 7
        // uses for this hotkey operation.  Leave empty if Windows 7 does
        // not have such a key.
        private string win7Key;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="form">Form to receive hotkey notifications</param>
        /// <param name="id">Unique identifier for this hotkey</param>
        /// <param name="propertyName">Name within Properties.Settings used to persist the hotkey combo</param>
        /// <param name="description">Short description of the hotkey 
        /// - used when editing the hotkey to remind the user what they are changing.</param>
        /// <param name="win7Key">String representation of what Windows 7 uses for this hotkey 
        /// - again for display to the user when they are changing the hotkey</param>
        /// <param name="handler">The delegate to handle events for this hotkey</param>
        public HotKeyController(Form form, int id, string propertyName, string description, string win7Key, HotKey.HotKeyHandler handler , ConfigValues cv)
        {
            // remember these for use later on
            this.propertyName = propertyName;
            this.description = description;
            this.win7Key = win7Key;

            // now create the hotkey and hook it up with the handler
            hotKey = new HotKey(form, id);
            hotKey.RegisterHotKey( GetSavedKeyCombo(cv) ) ;
            hotKey.HotKeyPressed += handler;
        }

        ~HotKeyController()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                hotKey.Dispose();
            }
        }

#if TEST
        /// <summary>
        /// Show the HotKeyFrom to allow the hotkey to be chnaged.
        /// </summary>
        /// <returns>true if user OK'd the HotKeyForm</returns>
        public bool Edit()
        {
            bool edited = false;

            // If Windows 7 has its own hotkey for this,
            // then we display a note to the user about it.
            // The content of the note will depend on whether they
            // are running Windows 7 or not.
            string note = "";
            if (win7Key != null && win7Key.Length > 0)
            {
                if (OsHelper.IsWin7OrLater())
                {
                    note = string.Format(Properties.Resources.Win7, win7Key);                    
                }
                else
                {
                    note = string.Format(Properties.Resources.NotWin7, win7Key);
                }
            }

            HotKeyForm dlg = new HotKeyForm(hotKey, description, note);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // persist the new value
                SaveKeyCombo();
                // and commit it now
                //Properties.Settings.Default.Save();
                CursorController.Instance.SaveSettings();
                //// update display
                //lbl.Text = hotKey.HotKeyCombo.ToString();
                // indicate OK has been pressed
                edited = true;
            }

            return edited;
        }
#endif




        /// <summary>
        /// Checks if the hotkey is enabled
        /// </summary>
        /// <returns>true if the hotkey is in use</returns>
        public bool IsEnabled()
        {
            //return hotKey.HotKeyCombo.ToPropertyValue() != KeyCombo.DisabledComboValue;
            return hotKey.HotKeyCombo.Enabled;
        }





        public KeyCombo GetHotKeyCombo()
        {
            //return hotKey.HotKeyCombo.ToPropertyValue() != KeyCombo.DisabledComboValue;
            return hotKey.HotKeyCombo;
        }






        private uint ConvertKeyCombo(string HotkeyValueString)
        {
            uint Ret;

            if (string.Compare("Not Defined", HotkeyValueString) == 0)
                Ret = KeyCombo.DisabledComboValue;
            else
                Ret = UInt32.Parse(HotkeyValueString);

            return Ret;
        }







        /* Hot Key Add Part */
        /// <summary>
        /// Gets the HotKey combo value from the persisted value in Poperties.Settings
        /// </summary>
        private KeyCombo GetSavedKeyCombo(ConfigValues cv)
        {
            KeyCombo keyCombo = new KeyCombo();

            if (cv.EnableCursorFeature)
            {
                /* Hotkey Feature가 Enable된 상태일때만 */
                switch (this.propertyName)
                {
                    case "CursorNextScreenHotKey":
                        if (cv.EnableMoveCursorNextScreen)
                            keyCombo.FromPropertyValue(ConvertKeyCombo(cv.HotkeyMoveCursorNextScreen));
                        else
                            keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
                        break;

                    case "CursorPrevScreenHotKey":
                        if (cv.EnableMoveCursorPrevScreen)
                            keyCombo.FromPropertyValue(ConvertKeyCombo(cv.HotkeyMoveCursorPrevScreen));
                        else
                            keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
                        break;


                    case "CursorPrimaryScreenHotKey":
                        if (cv.EnableMoveCursorPrimaryScreen)
                            keyCombo.FromPropertyValue(ConvertKeyCombo(cv.HotkeyMoveCursorPrimaryScreen));
                        else
                            keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
                        break;


                    case "LockCursorHotKey":
                        if (cv.EnableLockCursorToScreen)
                            keyCombo.FromPropertyValue(ConvertKeyCombo(cv.HotkeyLockCursorToScreen));
                        else
                            keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
                        break;

                    default:
                        keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
                        break;
                }
            }
            else
            {
                keyCombo.FromPropertyValue(KeyCombo.DisabledComboValue);
            }
#if TEST
            // if we have any trouble accessing the saved value of the KeyCombo
            // we default to disabling it
            uint hotKeyValue = KeyCombo.DisabledComboValue;
            try
            {
                hotKeyValue = (uint)Properties.Settings.Default[propertyName];
            }
            catch (Exception ex)
            {
                // looks like the property name is mis-spelt or the wrong type
                Debug.Assert(true, ex.Message);
            }
            keyCombo.FromPropertyValue(hotKeyValue);
#endif
            return keyCombo;
        }




        // Persists the hotkey combo value to Properties.Settings
        public void SaveKeyCombo(KeyCombo keyCombo)
        {
            hotKey.HotKeyCombo = keyCombo;
        }




        /// <summary>
        /// Gets a user displayable string of the key combination of this hotkey.
        /// </summary>
        /// <returns>User displayable string of the key combination for this hotkey</returns>
        public override string ToString()
        {
            return hotKey.HotKeyCombo.ToString();
        }



        /// <summary>
        /// 설정된 Hot Key를 등록한다.
        /// </summary>
        /// <returns>Hot Key 등록 성공 여부</returns>
        public bool RegisterHotkey()
        {
            return hotKey.RegisterHotKey();
        }

    }
}