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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Form1'deki menü listesine eklenecek ve ekleme işleminden sonra ilgili kontroller temizlenecek.
            DATA.Menu menu = new DATA.Menu()
            {
                MenuAdi = txtMenuAdi.Text,
                Fiyati = nmrMenuFiyati.Value
            };
            db.Menuler.Add(menu);
            MessageBox.Show("Menü başarılı bir şekilde eklendi");
            Metot.Temizle(grpMenuEkle.Controls);
        }

        private void grpMenuEkle_Enter(object sender, EventArgs e)
        {

        }
    }
}
