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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //a method that takes a value of Form
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width+22;
            this.Height = _childForm.Height + 68;
            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siparişYönetimiToolStripMenuItem.Enabled = false;
            ekstraMalzemeToolStripMenuItem.Enabled = false;
            siparişBilgileriToolStripMenuItem.Enabled = false;
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UrunEkle urunEkle = new UrunEkle();
            //urunEkle.MdiParent = this;
            //urunEkle.Show();

            ChildForm(new UrunEkle());
            ekstraMalzemeToolStripMenuItem.Enabled = true;
        }

        private void ekstraMalzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            //ekstraMalzeme.MdiParent = this;
            //ekstraMalzeme.Show();

            ChildForm(new EkstraMalzeme());
            siparişYönetimiToolStripMenuItem.Enabled = true;
        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SiparisOlustur siparisOlustur = new SiparisOlustur();
            //siparisOlustur.MdiParent = this;
            //siparisOlustur.Show();

            ChildForm(new SiparisOlustur());
            siparişBilgileriToolStripMenuItem.Enabled = true;
        }

      

      

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SiparisBilgileri siparisBilgileri = new SiparisBilgileri();
            //siparisBilgileri.MdiParent = this;
            //siparisBilgileri.Show();

            ChildForm(new SiparisBilgileri());
        }

        
    }
}
