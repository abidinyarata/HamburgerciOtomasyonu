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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DATA.Menu menu in db.Menuler.ToList())
                cmbMenu.Items.Add(menu);
            
            foreach (Ekstra ekstra in db.Ekstralar.ToList())
                flpMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.EkstraAdi, Tag = ekstra });

            foreach (Siparis siparis in mevcutSiparisler)
                lbxSiparisler.Items.Add(siparis);

            cmbMenu.SelectedIndex = 0;
            rdoKucuk.Checked = true;

            TutarHesapla();
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            Siparis gelen = null;

            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                gelen = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (DATA.Menu)cmbMenu.SelectedItem;

            if (rdoKucuk.Checked) //rdoKucuk.Checked == true
                yeniSiparis.MenuSecimi = rdoKucuk.Text;
            else if (rdoOrta.Checked) //rdoOrta.Checked == true
                yeniSiparis.MenuSecimi = rdoOrta.Text;
            else                      //rdoBuyuk.Checked == true
                yeniSiparis.MenuSecimi = rdoBuyuk.Text;

            yeniSiparis.EkstraMalzemeleri = new List<Ekstra>();

            foreach (CheckBox item in flpMalzemeler.Controls)
            {
                if (item.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((Ekstra)item.Tag);
            }

            yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();
            yeniSiparis.SiparişTarihi = DateTime.Now;

            lbxSiparisler.Items.Add(yeniSiparis);
            db.Siparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);
            db.SaveChanges();

            TutarHesapla();
            Metot.Temizle(this.Controls);
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın Alma işlemini tamamlamak ister misiniz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Sipariş Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İsteğiniz Üzerine İşlem İptal Edildi!");
            }
        }
    }
}
