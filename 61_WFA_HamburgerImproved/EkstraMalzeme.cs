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
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            

            if (txtEkstra.Text == "" && nudEkstraFiyat.Value == 0)
            {
                MessageBox.Show("Fiyat ve ekstra ekleyiniz");
            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Ekstra ekleyiniz");
            }
            else if (nudEkstraFiyat.Value == 0)
            {
                MessageBox.Show("0'dan yüksek bir fiyat seçiniz");
            }           
            else
            {
                Ekstra ekstra = new Ekstra();
                ekstra.Ad = txtEkstra.Text;
                ekstra.Fiyat = nudEkstraFiyat.Value;
                Ekstra.Ekstralar.Add(ekstra);
                MessageBox.Show("Ekstra eklendi...");
            }
        }
    }
}
