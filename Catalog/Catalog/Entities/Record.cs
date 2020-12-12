using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    class Record: Item
    {
        public int LengthMins { get; set; }

        public int NumberOfSongs { get; set; }

    }
}
