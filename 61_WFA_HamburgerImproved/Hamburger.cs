using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_WFA_HamburgerImproved
{
    public class Hamburger
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }


        public static List<Hamburger> Hamburgerler = new List<Hamburger>();

        public override string ToString()
        {
            return Ad;
        }
    }
}
