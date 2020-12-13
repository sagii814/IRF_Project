using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public class Design: Label
    {
        public Design()
        {
            Paint += Design_Paint;
        }

        private void Design_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black,2);

            e.Graphics.DrawRectangle(p, 0, 0, 15, 20);
            for (int i = 4; i < 18; i = i+4)
            {
                e.Graphics.DrawLine(p, 2, i, 13, i);
            }
            
        }
    }
}
