using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Spave_SHooter.Class
{
    public class RoundLabel : Label
    {
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            this.Region = new System.Drawing.Region(path);
            base.OnPaint(pe);
        }
    }
}
