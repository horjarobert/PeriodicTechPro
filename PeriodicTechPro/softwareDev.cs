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
    public partial class softwareDev : Form
    {
        public softwareDev()
        {
            InitializeComponent();
        }

        private void softwareDev_Load(object sender, EventArgs e)
        {
            animation.AnimateWindow(this.Handle, 500, animation.HOR_Positive);
        }
    }
}
