using Hamburgerci.DAL.Context;
using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci.UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        ProjectContext db;
        private void Form4_Load(object sender, EventArgs e)
        {
            //Siparişler Form1'deki siparisler listesinden gelecek.
            //İlgili label'lar doldurulacak.
            decimal tutar = 0, ekstraTutar = 0;
            int satılanUrunAdedi = 0;
            foreach (Siparis siparis in db.Siparisler)
            {
                lbxTumSiparisler.Items.Add(siparis);
                tutar += siparis.ToplamTutar;
                satılanUrunAdedi += siparis.Adet;

                if (siparis.EkstraMalzemeleri != null)
                {
                    foreach (Ekstra ekstra in siparis.EkstraMalzemeleri)
                    {
                        ekstraTutar += ekstra.Fiyati;
                    }
                }
            }

            lblCiro.Text = tutar.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraTutar.ToString();
            lblToplamSiparis.Text = lbxTumSiparisler.Items.Count.ToString();
            lblSatilanUrunAdedi.Text = satılanUrunAdedi.ToString();

        }
    }
}
