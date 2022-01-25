using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    class MenuMapping : EntityTypeConfiguration<Menu>
    {
        public MenuMapping()
        {
            ToTable("Menus");

            HasKey(x => x.MenuID);
            Property(x => x.MenuAdi).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            Property(x => x.Fiyati).IsRequired().HasColumnType("decimal");            
        }
    }
}
