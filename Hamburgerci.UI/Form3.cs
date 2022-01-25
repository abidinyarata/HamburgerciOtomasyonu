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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void btnMalzemeKaydet_Click(object sender, EventArgs e)
        {
            //Form1'deki ekstra Malzemeler listesine eklenecek ve ekleme işleminden sonra ilgili kontroller temizlenecek.
            Ekstra ekstra = new Ekstra()
            {
                EkstraAdi = txtEkstraMalzemeAdi.Text,
                Fiyati = nmrEkstraMalzemeFiyati.Value
            };

            db.Ekstralar.Add(ekstra);
            MessageBox.Show("Ekstra malzeme başarılı bir şekilde eklendi");
            Metot.Temizle(grpMalzemeEkle.Controls);
        }
    }
}
