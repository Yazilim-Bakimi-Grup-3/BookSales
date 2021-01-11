using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi.KitapSatisUygulamasi
{
   public class Book
    {
        public int id { get; set; }
        public string WriterFullName { get; set; }
        public string BookName { get; set; }
        public string Price { get; set; }
        public string Genre { get; set; }
    }
}
