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
    public partial class p5W15 : Form
    {
        public p5W15()
        {
            InitializeComponent();
        }

        private void p5W15_Load(object sender, EventArgs e)
        {
            animation.AnimateWindow(this.Handle, 500, animation.CENTER);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
