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
    public partial class WarningDuplicatedHotkey : Form
    {
        public WarningDuplicatedHotkey(string Title , string Message)
        {
            InitializeComponent();

            InitUI();

            label_Setting_HotKey.Text = Title;
            label_Message.Text = Message;
        }


        private void InitUI()
        {
            this.label_Setting_HotKey.Font = new System.Drawing.Font(FontManager.LG_Smart_H_SemiBold(), 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label_Message.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.button_Close.Font = new System.Drawing.Font(FontManager.LG_Smart_H_Regular(), 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
        }



        private void button_Close_Enter(object sender, EventArgs e)
        {
            this.button_Close.BackColor = Color.FromArgb(0xCA, 0x00, 0x4C);
        }

        private void button_Close_MouseEnter(object sender, EventArgs e)
        {
            this.button_Close.BackColor = Color.FromArgb(0xCA, 0x00, 0x4C);
        }

        private void button_Close_Leave(object sender, EventArgs e)
        {
            this.button_Close.BackColor = Color.White;
        }

        private void button_Close_MouseLeave(object sender, EventArgs e)
        {
            this.button_Close.BackColor = Color.White;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
