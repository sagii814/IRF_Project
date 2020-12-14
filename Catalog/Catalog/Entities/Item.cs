using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog.Entities
{
    public class Item
    {  
       
        public string Creator { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Catalog { get; set; }
        public Item()
        {
        }

    }
}
