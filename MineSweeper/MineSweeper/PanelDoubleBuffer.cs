using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class PanelDoubleBuffer : System.Windows.Forms.Panel
    {
        public PanelDoubleBuffer() //form1.designer.cs this.panel = new PanelDoubleBuffer(); run and re-open
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }
    }
}
