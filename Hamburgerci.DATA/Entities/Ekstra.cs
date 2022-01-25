using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Ekstra
    {
        public int EkstraID { get; set; }
        public string EkstraAdi { get; set; }
        public decimal Fiyati { get; set; }
        public virtual List<Siparis> EkstraSiparisler { get; set; }
    }
}
