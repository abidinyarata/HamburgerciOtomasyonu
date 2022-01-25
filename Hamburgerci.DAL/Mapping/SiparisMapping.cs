using Hamburgerci.DATA;
using Hamburgerci.UI;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    public class SiparisMapping : EntityTypeConfiguration<Siparis>
    {
        public SiparisMapping()
        {
            ToTable("Orders");

            HasKey(x => x.SiparisID);
            //Property(x => x.Boyutu).IsRequired().HasColumnType("nvarchar");
            Property(x => x.MenuSecimi).IsRequired().HasColumnType("nvarchar"); 
            Property(x => x.Adet).IsRequired().HasColumnType("int");
            Property(x => x.ToplamTutar).IsRequired().HasColumnType("decimal");

            Ignore(x => x.SeciliMenu);
            Ignore(x => x.EkstraMalzemeleri);
            Ignore(x => x.Boyutu);
            
        }
    }
}
