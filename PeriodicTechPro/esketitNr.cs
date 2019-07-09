using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicTechPro
{
    public partial class esketitNr : Form
    {
        public esketitNr()
        {
            InitializeComponent();
        }

        private void esketitNr_Load(object sender, EventArgs e)
        {
            animation.AnimateWindow(this.Handle, 500, animation.VER_Positive);
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            ToolTip closeThis = new ToolTip();
            closeThis.SetToolTip(this.close, "Close");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
