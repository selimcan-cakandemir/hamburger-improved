using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_WFA_HamburgerImproved
{
    public class Siparis
    {
        public decimal Fiyat { get; set; }
        public Hamburger Hamburger { get; set; }        
        public Boyut Boyut { get; set; }
        public int Adet { get; set; }

        public static List<Siparis> Siparisler = new List<Siparis>();
        

        public override string ToString()
        {
            return $"Fiyat: {Fiyat}₺ \nBoyut: {Boyut}, Menü: {Hamburger}, Adet: {Adet}";
        }
    }
}
