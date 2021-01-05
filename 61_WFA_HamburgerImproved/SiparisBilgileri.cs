using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61_WFA_HamburgerImproved
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }
        decimal toplamFiyat = 0m;
        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            foreach (Siparis siparis in Siparis.Siparisler)
            {
                listBox1.Items.Add(siparis);  
            }

            foreach (Siparis s in Siparis.Siparisler)
            {
                toplamFiyat += s.Fiyat;
                lblCiro.Text = toplamFiyat.ToString() + "₺";
            }

            int siparisSayisi = 0;
            foreach (Siparis s in Siparis.Siparisler)
            {
                siparisSayisi += 1;
                lblSiparisSayisi.Text = siparisSayisi.ToString();
            }
            int malzeme = 0;
            foreach (Ekstra ekstra in Ekstra.Ekstralar)
            {
                malzeme += 1;
                lblEkstraMalzemeGeliri.Text = malzeme.ToString() + "₺";
            }
            int toplam = 0;
            foreach (Siparis s in Siparis.Siparisler)
            {
                toplam = malzeme + siparisSayisi
                lblSatilan.Text = toplam.ToString();
            }

        }
    }
}
