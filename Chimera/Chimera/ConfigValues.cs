using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimera
{
    public class ConfigValues
    {
        public bool EnableCursorFeature { get; set; }        

        public bool EnableMoveCursorNextScreen { get; set; }

        public string HotkeyMoveCursorNextScreen { get; set; }

        public bool EnableMoveCursorPrevScreen { get; set; }

        public string HotkeyMoveCursorPrevScreen { get; set; }

        public bool EnableMoveCursorPrimaryScreen { get; set; }
        public string HotkeyMoveCursorPrimaryScreen { get; set; }

        public bool EnableLockCursorToScreen { get; set; }

        public string HotkeyLockCursorToScreen { get; set; }

        public ConfigValues()
        {
            EnableCursorFeature = true;

            EnableMoveCursorNextScreen = true;
            HotkeyMoveCursorNextScreen = "";
            EnableMoveCursorPrevScreen = true;
            HotkeyMoveCursorPrevScreen = "";
            EnableMoveCursorPrimaryScreen = true;
            HotkeyMoveCursorPrimaryScreen = "";
            EnableLockCursorToScreen = true;
            HotkeyLockCursorToScreen = "";
        }

        public ConfigValues ShallowCopy()
        {
            return (ConfigValues)this.MemberwiseClone();
        }


        /* Hot Key Add Part */
        public bool CheckHotKeyDuplicated(string keyComboValue)
        {
            if (string.Compare(HotkeyMoveCursorNextScreen, keyComboValue) == 0 ||
                string.Compare(HotkeyMoveCursorPrevScreen, keyComboValue) == 0 ||
                string.Compare(HotkeyMoveCursorPrimaryScreen, keyComboValue) == 0 ||
                string.Compare(HotkeyLockCursorToScreen, keyComboValue) == 0)
                return true;
            else
                return false;
        }
    }
}
