using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    class Movie:Item
    {
        public decimal LengthHours { get; set; }
        public string Languages { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
