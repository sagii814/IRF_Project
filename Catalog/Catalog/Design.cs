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
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4), 10, 10, 30, 30);
        }
    }
}
