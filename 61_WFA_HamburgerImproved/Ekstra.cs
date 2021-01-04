using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_WFA_HamburgerImproved
{
    public class Ekstra
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }


        public static List<Ekstra> Ekstralar = new List<Ekstra>();

        public override string ToString()
        {
            return Ad;
        }

    }
}