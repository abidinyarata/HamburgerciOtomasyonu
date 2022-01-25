using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Siparis 
    {
        public int SiparisID { get; set; }
        public Menu SeciliMenu { get; set; }
        public List<Ekstra> EkstraMalzemeleri { get; set; }
        public Boyut Boyutu { get; set; }
        public string MenuSecimi { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }
        public DateTime SiparişTarihi { get; set; }

        public virtual List<Menu> Menuler { get; set; } 
        public virtual List<Ekstra> Ekstralar { get; set; } 

        public void Hesapla()
        {
            //Menu Fiyatımız 20 lira olsun.
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M; //ToplamTutar = 20 + (20 * 0.10)
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }

            foreach (Ekstra ekstra in EkstraMalzemeleri)
                ToplamTutar += ekstra.Fiyati;

            ToplamTutar *= Adet; //  => ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {
            if (EkstraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menu x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Ekstra ekstra in EkstraMalzemeleri)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ", ";
                }
                //ekstraMalzemeler = ketçap, mayonez, ranch sos, ...
                ekstraMalzemeler = ekstraMalzemeler.Trim(',', ' ');
                //ekstraMalzemeler = ketçap, mayonez, ranch sos
                return string.Format("{0} Menu x {1} Adet, {2} Boy, ({3}) Toplam: {4}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
