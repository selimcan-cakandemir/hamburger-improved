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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
        
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = Hamburger.Hamburgerler.ToList();

            for (int i = 0; i < Ekstra.Ekstralar.Count; i++)
            {
                Button button = new Button();
                button.Width = 80;
                button.Height = 60;
                button.Text = Ekstra.Ekstralar[i].ToString();
                flwEkstra.Controls.Add(button);
                
            }
        }
        decimal sonfiyat = 0m;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            if (nudAdet.Value == 0)
            {
                MessageBox.Show("0 dan büyük bir adet seçiniz");
            }
            else
            {
                Siparis siparis = new Siparis();
                siparis.Hamburger = (Hamburger)cmbMenu.SelectedItem;

                if (rbKucuk.Checked)
                {
                    siparis.Boyut = (Boyut)0;
                    siparis.Fiyat += 10;
                }
                else if (rbOrta.Checked)
                {
                    siparis.Boyut = (Boyut)1;
                    siparis.Fiyat += 20;
                }
                else if (rbBuyuk.Checked)
                {
                    siparis.Boyut = (Boyut)2;
                    siparis.Fiyat += 30;
                }

                foreach (Hamburger hamburger in Hamburger.Hamburgerler)
                {
                    if (hamburger == (Hamburger)cmbMenu.SelectedItem)
                    {
                        siparis.Fiyat += hamburger.Fiyat;
                    }
                }

                foreach (Ekstra ekstra in Ekstra.Ekstralar)
                {
                    siparis.Fiyat += ekstra.Fiyat;
                }

                siparis.Fiyat *= nudAdet.Value;
                siparis.Adet = Convert.ToInt32(nudAdet.Value);
                
                sonfiyat += siparis.Fiyat;
                Siparis.Siparisler.Add(siparis);                                       
                lblToplamTutar.Text = sonfiyat.ToString() + "₺" ;
                listBox1.Items.Add(siparis.ToString());


            }
             

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Toplam tutar :" + lblToplamTutar.Text + "\nOnaylıyormusunuz?", "Sipariş Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Sipariş oluşturuldu. \nSipariş bilgilerini aynı isimli sekmeden kontrol edebilirsiniz.");
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilmedi");
            }
        }


    }
}
