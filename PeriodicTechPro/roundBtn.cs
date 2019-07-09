using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeriodicTechPro
{
    class roundBtn : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath roundBtn = new GraphicsPath();
            roundBtn.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(roundBtn);
            base.OnPaint(pevent);
        }
    }
}
