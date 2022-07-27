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
    public partial class HotKeyConfirm : Form
    {
        string HotKey;

        public HotKeyConfirm(string HotKeyMessage)
        {
            InitializeComponent();

            this.HotKey = HotKeyMessage;

            InitUI();           
        }


        private void InitUI()
        {
            this.BackColor = Color.FromArgb(255, 255, 255);

            this.label_Setting_HotKey.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Input_Hotkey.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

            this.button_Set.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_Cancel.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

            this.label_Input_Hotkey.Text = this.HotKey;
        }




        private void button_Set_MouseEnter(object sender, EventArgs e)
        {
            this.button_Set.BackColor = Color.FromArgb(0xCA, 0x00, 0x4C);
        }

        private void button_Set_MouseLeave(object sender, EventArgs e)
        {
            this.button_Set.BackColor = Color.White;
        }

        private void button_Cancel_MouseEnter(object sender, EventArgs e)
        {
            this.button_Cancel.BackColor = Color.FromArgb(0xCA, 0x00, 0x4C);
        }

        private void button_Cancel_MouseLeave(object sender, EventArgs e)
        {
            this.button_Cancel.BackColor = Color.White;
        }

        private void button_Set_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
