﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Chimera
{
    /// <summary>
    /// A panel to allow the entry of a KeyCombo,
    /// i.e. a KeyCode and a set of modifiers.
    /// </summary>
    public partial class KeyComboPanel : UserControl
    {
#if TEST
        #region Virtual Key Codes
        /// <summary>
        /// Private structure representing a single key.
        /// This is used to map between a key code and
        /// a displayable name for the key code.
        /// </summary>
        private struct VirtualKey
        {
            public Keys virtKey;

            private string keyName;
            public string KeyName
            {
                get { return keyName; }
            }

            public VirtualKey(Keys virtKey, string keyName)
            {
                this.virtKey = virtKey;
                this.keyName = keyName;
            }
        }
        private static VirtualKey[] virtualKeys = new VirtualKey[]
        {
            new VirtualKey(Keys.Back, "<Backspace>" ),
            new VirtualKey(Keys.Delete, "<Delete>" ),
            new VirtualKey(Keys.Divide, "<Divide>" ),
            new VirtualKey(Keys.Down, "<Down>" ),
            new VirtualKey(Keys.End, "<End>" ),
            new VirtualKey(Keys.Enter, "<Enter>" ),
            new VirtualKey(Keys.Escape, "<Esc>" ),
            new VirtualKey(Keys.Home, "<Home>" ),
            new VirtualKey(Keys.Insert, "<Insert>" ),
            new VirtualKey(Keys.Left, "<Left>" ),
            new VirtualKey(Keys.PageDown, "<PageDown>" ),
            new VirtualKey(Keys.PageUp, "<PageUp>" ),
            new VirtualKey(Keys.Pause, "<Pause>" ),
            new VirtualKey(Keys.PrintScreen, "<PrintScrn>" ),
            new VirtualKey(Keys.Right, "<Right>" ),
            new VirtualKey(Keys.Scroll, "<ScrollLock>" ),
            new VirtualKey(Keys.Space, "<Space>" ),
            new VirtualKey(Keys.Tab, "<Tab>" ),
            new VirtualKey(Keys.Up, "<Up>" ),

            new VirtualKey(Keys.OemBackslash, "<OemBackslash>" ),
            new VirtualKey(Keys.OemCloseBrackets, "<OemCloseBrackets>" ),
            new VirtualKey(Keys.Oemcomma, "<OemComma>" ),
            new VirtualKey(Keys.OemMinus, "<OemMinus>" ),
            new VirtualKey(Keys.OemOpenBrackets, "<OemOpenBrackets>" ),
            new VirtualKey(Keys.OemPeriod, "<OemPeriod>" ),
            new VirtualKey(Keys.OemPipe, "<OemPipe>" ),
            new VirtualKey(Keys.Oemplus, "<OemPlus>" ),
            new VirtualKey(Keys.OemQuestion, "<OemQuestion>" ),
            new VirtualKey(Keys.OemQuotes, "<OemQuotes>" ),
            new VirtualKey(Keys.OemSemicolon, "<OemSemicolon>" ),
            new VirtualKey(Keys.Oemtilde, "<OemTilde>" ),


            new VirtualKey(Keys.F1, "<F1>" ),
            new VirtualKey(Keys.F2, "<F2>" ),
            new VirtualKey(Keys.F3, "<F3>" ),
            new VirtualKey(Keys.F4, "<F4>" ),
            new VirtualKey(Keys.F5, "<F5>" ),
            new VirtualKey(Keys.F6, "<F6>" ),
            new VirtualKey(Keys.F7, "<F7>" ),
            new VirtualKey(Keys.F8, "<F8>" ),
            new VirtualKey(Keys.F9, "<F9>" ),
            new VirtualKey(Keys.F10, "<F10>" ),
            new VirtualKey(Keys.F11, "<F11>" ),
            new VirtualKey(Keys.F12, "<F12>" ),

			// The multimedia keys (with and without moddifiers)
			// can't be used as hotkeys
			//new VirtualKey(Keys.MediaNextTrack, "<MediaNextTrack>" ),
			//new VirtualKey(Keys.MediaPlayPause, "<MediaPlayPause>" ),
			//new VirtualKey(Keys.MediaPreviousTrack, "<MediaPreviousTrack>" ),
			//new VirtualKey(Keys.MediaStop, "<MediaStop>" ),
			//new VirtualKey(Keys.VolumeDown, "<VolumeDown>" ),
			//new VirtualKey(Keys.VolumeDown, "<VolumeMute>" ),
			//new VirtualKey(Keys.VolumeUp, "<VolumeUp>" ),

			//new VirtualKey(Keys.BrowserBack, "<BrowserBack>" ),
			//new VirtualKey(Keys.BrowserFavorites, "<BrowserFavorites>" ),
			//new VirtualKey(Keys.BrowserForward, "<BrowserForward>" ),
			//new VirtualKey(Keys.BrowserHome, "<BrowserHome>" ),
			//new VirtualKey(Keys.BrowserRefresh, "<BrowserRefresh>" ),
			//new VirtualKey(Keys.BrowserSearch, "<BrowserSearch>" ),
			//new VirtualKey(Keys.BrowserStop, "<BrowserStop>" ),

			new VirtualKey(Keys.NumPad0, "<Num0>" ),
            new VirtualKey(Keys.NumPad1, "<Num1>" ),
            new VirtualKey(Keys.NumPad2, "<Num2>" ),
            new VirtualKey(Keys.NumPad3, "<Num3>" ),
            new VirtualKey(Keys.NumPad4, "<Num4>" ),
            new VirtualKey(Keys.NumPad5, "<Num5>" ),
            new VirtualKey(Keys.NumPad6, "<Num6>" ),
            new VirtualKey(Keys.NumPad7, "<Num7>" ),
            new VirtualKey(Keys.NumPad8, "<Num8>" ),
            new VirtualKey(Keys.NumPad9, "<Num9>" ),

            new VirtualKey(Keys.Multiply, "<Num*>" ),
            new VirtualKey(Keys.Add, "<Num+>" ),
            new VirtualKey(Keys.Subtract, "<Num->" ),
            new VirtualKey(Keys.Decimal, "<Num.>" ),
            new VirtualKey(Keys.Divide, "<Num/>" ),

            new VirtualKey(Keys.D0, "0" ),
            new VirtualKey(Keys.D1, "1" ),
            new VirtualKey(Keys.D2, "2" ),
            new VirtualKey(Keys.D3, "3" ),
            new VirtualKey(Keys.D4, "4" ),
            new VirtualKey(Keys.D5, "5" ),
            new VirtualKey(Keys.D6, "6" ),
            new VirtualKey(Keys.D7, "7" ),
            new VirtualKey(Keys.D8, "8" ),
            new VirtualKey(Keys.D9, "9" ),

            new VirtualKey(Keys.A, "A" ),
            new VirtualKey(Keys.B, "B" ),
            new VirtualKey(Keys.C, "C" ),
            new VirtualKey(Keys.D, "D" ),
            new VirtualKey(Keys.E, "E" ),
            new VirtualKey(Keys.F, "F" ),
            new VirtualKey(Keys.G, "G" ),
            new VirtualKey(Keys.H, "H" ),
            new VirtualKey(Keys.I, "I" ),
            new VirtualKey(Keys.J, "J" ),
            new VirtualKey(Keys.K, "K" ),
            new VirtualKey(Keys.L, "L" ),
            new VirtualKey(Keys.M, "M" ),
            new VirtualKey(Keys.N, "N" ),
            new VirtualKey(Keys.O, "O" ),
            new VirtualKey(Keys.P, "P" ),
            new VirtualKey(Keys.Q, "Q" ),
            new VirtualKey(Keys.R, "R" ),
            new VirtualKey(Keys.S, "S" ),
            new VirtualKey(Keys.T, "T" ),
            new VirtualKey(Keys.U, "U" ),
            new VirtualKey(Keys.V, "V" ),
            new VirtualKey(Keys.W, "W" ),
            new VirtualKey(Keys.X, "X" ),
            new VirtualKey(Keys.Y, "Y" ),
            new VirtualKey(Keys.Z, "Z" )
        };
        #endregion

        /// <summary>
        /// Used to show a KeyCombo in the panel,
        /// or to retieve the KeyCombo currently shown in the panel.
        /// </summary>
        public KeyCombo KeyCombo
        {
            get
            {
                return KeyComboFromPanel();
            }
            set
            {
                KeyComboToPanel(value);
            }
        }

        /// <summary>
        /// Constructor which initialises the panel
        /// </summary>
        public KeyComboPanel()
        {
            InitializeComponent();
            FillKeysCombo();
        }

        /// <summary>
        /// Writeable value indicating if the Win modifier key is allowed
        /// </summary>
        public bool AllowWin
        {
            // TODO: use Enabled or Visible?
            set { chkWin.Enabled = value; }
        }

        private KeyCombo KeyComboFromPanel()
        {
            KeyCombo keyCombo = new KeyCombo();

            if (comboKey.SelectedItem != null)
            {
                keyCombo.KeyCode = NameToKeyCode(this.comboKey.SelectedItem.ToString());
                keyCombo.AltMod = chkAlt.Checked;
                keyCombo.ControlMod = chkCtrl.Checked;
                keyCombo.ShiftMod = chkShift.Checked;
                keyCombo.WinMod = chkWin.Checked;
            }

            return keyCombo;
        }

        private void KeyComboToPanel(KeyCombo keyCombo)
        {
            chkAlt.Checked = keyCombo.AltMod;
            chkCtrl.Checked = keyCombo.ControlMod;
            chkShift.Checked = keyCombo.ShiftMod;
            chkWin.Checked = keyCombo.WinMod;

            string keyName = KeyCodeToName(keyCombo.KeyCode);
            comboKey.SelectedItem = keyName;
        }

        private void FillKeysCombo()
        {
            comboKey.BeginUpdate();
            comboKey.Items.Clear();
            foreach (VirtualKey virtualKey in virtualKeys)
            {
                comboKey.Items.Add(virtualKey.KeyName);
            }
            comboKey.EndUpdate();
        }

        /// <summary>
        /// Converts the keycode to a displayable name
        /// </summary>
        /// <param name="keyCode"></param>
        /// <returns></returns>
        public static string KeyCodeToName(Keys keyCode)
        {
            string keyName = "?";
            foreach (VirtualKey virtualKey in virtualKeys)
            {
                if (virtualKey.virtKey == keyCode)
                {
                    keyName = virtualKey.KeyName;
                    break;
                }
            }
            return keyName;
        }

        private static Keys NameToKeyCode(string keyName)
        {
            Keys keyCode = 0;
            foreach (VirtualKey virtualKey in virtualKeys)
            {
                if (virtualKey.KeyName == keyName)
                {
                    keyCode = virtualKey.virtKey;
                    break;
                }
            }
            return keyCode;
        }
#endif
    }
}
