using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Entities
{
    public class Book:Item
    {
        public int Length { get; set; }
        public DateTime PublishDate { get; set; }

    }
}
