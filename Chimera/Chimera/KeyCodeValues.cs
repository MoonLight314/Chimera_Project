using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimera
{
    static class KeyCodeValues
    {
        static Dictionary<Keys, string> KeyCodeValueSet = new Dictionary<Keys, string>()
        {
            { Keys.Back, "<Backspace>" },
            { Keys.Delete, "<Delete>" },
            { Keys.Down, "<Down>"},
            { Keys.End, "<End>"},
            { Keys.Enter, "<Enter>"},
            { Keys.Escape, "<Esc>"},
            { Keys.Home, "<Home>"},
            { Keys.Insert, "<Insert>"},
            { Keys.Left, "<Left>"},
            { Keys.PageDown, "<PageDown>"},
            { Keys.PageUp, "<PageUp>"},
            { Keys.Pause, "<Pause>"},
            { Keys.PrintScreen, "<PrintScrn>"},
            { Keys.Right, "<Right>"},
            { Keys.Scroll, "<ScrollLock>"},
            { Keys.Space, "<Space>"},
            { Keys.Tab, "<Tab>"},
            { Keys.Up, "<Up>"},
            { Keys.OemBackslash, "<Back Slash>"},
            { Keys.OemCloseBrackets, "<Close Brackets>"},
            { Keys.Oemcomma, "<Comma>"},
            { Keys.OemMinus, "<Minus>"},
            { Keys.OemOpenBrackets, "<Open Brackets>"},
            { Keys.OemPeriod, "<Period>"},
            { Keys.OemPipe, "<Pipe>"},
            { Keys.Oemplus, "<Plus>"},
            { Keys.OemQuestion, "<Question>"},
            { Keys.OemQuotes, "<Quotes>"},
            { Keys.OemSemicolon, "<Semi-Colon>"},
            { Keys.Oemtilde, "<Tilde>"},
            { Keys.F1, "<F1>"},
            { Keys.F2, "<F2>"},
            { Keys.F3, "<F3>"},
            { Keys.F4, "<F4>"},
            { Keys.F5, "<F5>"},
            { Keys.F6, "<F6>"},
            { Keys.F7, "<F7>"},
            { Keys.F8, "<F8>"},
            { Keys.F9, "<F9>"},
            { Keys.F10, "<F10>"},
            { Keys.F11, "<F11>"},
            { Keys.F12, "<F12>"},
            { Keys.NumPad0, "<Num0>"},
            { Keys.NumPad1, "<Num1>"},
            { Keys.NumPad2, "<Num2>"},
            { Keys.NumPad3, "<Num3>"},
            { Keys.NumPad4, "<Num4>"},
            { Keys.NumPad5, "<Num5>"},
            { Keys.NumPad6, "<Num6>"},
            { Keys.NumPad7, "<Num7>"},
            { Keys.NumPad8, "<Num8>"},
            { Keys.NumPad9, "<Num9>"},
            { Keys.Multiply, "<Num*>"},
            { Keys.Add, "<Num+>"},
            { Keys.Subtract, "<Num->"},
            { Keys.Decimal, "<Num.>"},
            { Keys.Divide, "<Num/>"},
            { Keys.D0, "0"},
            { Keys.D1, "1"},
            { Keys.D2, "2"},
            { Keys.D3, "3"},
            { Keys.D4, "4"},
            { Keys.D5, "5"},
            { Keys.D6, "6"},
            { Keys.D7, "7"},
            { Keys.D8, "8"},
            { Keys.D9, "9"},
            { Keys.A, "A"},
            { Keys.B, "B"},
            { Keys.C, "C"},
            { Keys.D, "D"},
            { Keys.E, "E"},
            { Keys.F, "F"},
            { Keys.G, "G"},
            { Keys.H, "H"},
            { Keys.I, "I"},
            { Keys.J, "J"},
            { Keys.K, "K"},
            { Keys.L, "L"},
            { Keys.M, "M"},
            { Keys.N, "N"},
            { Keys.O, "O"},
            { Keys.P, "P"},
            { Keys.Q, "Q"},
            { Keys.R, "R"},
            { Keys.S, "S"},
            { Keys.T, "T"},
            { Keys.U, "U"},
            { Keys.V, "V"},
            { Keys.W, "W"},
            { Keys.X, "X"},
            { Keys.Y, "Y"},
            { Keys.Z, "Z"}

        };




        public static string GetKeyCodeString(KeyEventArgs e)
        {
            string KeyValue;

            try
            {
                KeyValue = KeyCodeValueSet[e.KeyCode];
            }
            catch (Exception ex)
            {
                if (e.Alt ||
                    e.Control ||
                    e.Shift )
                    KeyValue = "";
                else
                    KeyValue = "Not Support";
            }

            return KeyValue;
        }


        public static bool IsNormalKeyPressed( KeyEventArgs e )
        {
            bool Ret;

            try
            {
                string KeyValue = KeyCodeValueSet[e.KeyCode];
                Ret = true;
            }
            catch (Exception ex)
            {
                Ret = false;
            }

            return Ret;
        }

    }    
}
