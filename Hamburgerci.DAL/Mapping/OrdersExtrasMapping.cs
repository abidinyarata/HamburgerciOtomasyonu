using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Mapping
{
    public class OrdersExtrasMapping : EntityTypeConfiguration<Siparis>
    {
        public OrdersExtrasMapping()
        {
            HasMany(x => x.Ekstralar).WithMany(x => x.EkstraSiparisler);
        }
    }
}
