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
    public partial class verilogS116 : Form
    {
        public verilogS116()
        {
            InitializeComponent();
        }

        private void verilogS116_Load(object sender, EventArgs e)
        {
            animation.AnimateWindow(this.Handle, 500, animation.CENTER);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void title_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Verilog");
        }

        private void title_MouseHover(object sender, EventArgs e)
        {
            ToolTip goOnline = new ToolTip();
            goOnline.IsBalloon = true;
            goOnline.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            goOnline.ToolTipTitle = "||Visit||";
            goOnline.SetToolTip(this.title, "Click and learn!");
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            ToolTip closing = new ToolTip();
            closing.IsBalloon = true;
            closing.SetToolTip(this.close, "Close");
        }

        private void symbol_MouseHover(object sender, EventArgs e)
        {
            ToolTip symex = new ToolTip();
            symex.SetToolTip(this.symbol, "Symbol and a filename extension");
        }

        private void year_MouseHover(object sender, EventArgs e)
        {
            ToolTip yearB = new ToolTip();
            yearB.IsBalloon = true;
            yearB.SetToolTip(this.year, "year of birth");
        }

        private void number_MouseHover(object sender, EventArgs e)
        {
            ToolTip eskee = new ToolTip();
            eskee.ToolTipTitle = "[Esketit number]";
            eskee.SetToolTip(this.number, "RELEVANT");
        }

        private void abstraction_MouseHover(object sender, EventArgs e)
        {
            ToolTip infos = new ToolTip();
            infos.IsBalloon = true;
            infos.ToolTipTitle = "[Abstraction capability]";
            infos.SetToolTip(this.abstraction, "Scale: 1 to 10 => 7");
        }

        private void efficiency_MouseHover(object sender, EventArgs e)
        {
            ToolTip infos = new ToolTip();
            infos.IsBalloon = true;
            infos.ToolTipTitle = "[Efficiency power]";
            infos.SetToolTip(this.efficiency, "Scale: 1 to 10 => 8");
        }

        private void simplicity_MouseHover(object sender, EventArgs e)
        {
            ToolTip infos = new ToolTip();
            infos.IsBalloon = true;
            infos.ToolTipTitle = "[Philosophy of simplicity]";
            infos.SetToolTip(this.simplicity, "Scale: 1 to 10 => 7");
        }
    }
}
