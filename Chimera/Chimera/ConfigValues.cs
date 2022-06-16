﻿using System;
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

        public bool EnableLockCursorToScreen { get; set; }

        public string HotkeyLockCursorToScreen { get; set; }

        public ConfigValues()
        {
            EnableCursorFeature = true;
            EnableMoveCursorNextScreen = true;
            HotkeyMoveCursorNextScreen = "";
            EnableMoveCursorPrevScreen = true;
            HotkeyMoveCursorPrevScreen = "";
            EnableLockCursorToScreen = true;
            HotkeyLockCursorToScreen = "";
        }

        public ConfigValues ShallowCopy()
        {
            return (ConfigValues)this.MemberwiseClone();
        }
    }
}