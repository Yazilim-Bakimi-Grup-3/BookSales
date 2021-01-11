using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi.KitapSatisUygulamasi.EntityClasses
{
    class Sale

    {
        public string TC { get; set; }
        public string customerName { get; set; }
        public string customerPhone { get; set; }
        public string customerAdress { get; set; }
        public string Price { get; set; }
        public string Order { get; set; }
        public string Date { get; internal set; }
    }
}
