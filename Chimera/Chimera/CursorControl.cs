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
    public partial class CursorControl : Form
    {
        public CursorControl()
        {
            InitializeComponent();
        }

        private void cursorControl_OK_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
