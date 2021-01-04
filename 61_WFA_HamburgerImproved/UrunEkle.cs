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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtMenu.Text == "" && nudFiyat.Value==0)
            {
                MessageBox.Show("Fiyat ve hamburger ekleyiniz");
            }
            else if (txtMenu.Text=="")
            {
              MessageBox.Show("Hamburger ekleyiniz");
            }
            else if (nudFiyat.Value == 0)
            {
                MessageBox.Show("0'dan yüksek bir fiyat seçiniz");
            }
            else
            {
                Hamburger hamburger = new Hamburger();
                hamburger.Ad = txtMenu.Text;
                hamburger.Fiyat = nudFiyat.Value;
                Hamburger.Hamburgerler.Add(hamburger);
                MessageBox.Show("Hamburger eklendi...");
            }
            

        }
    }
}
