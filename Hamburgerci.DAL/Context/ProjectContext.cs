using Hamburgerci.DAL.Mapping;
using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.Context
{
    public class ProjectContext :DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-48HDLSD;Database=HamburgerciDB;User Id=sa;Password=123";
        }

        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Ekstra> Ekstralar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new SiparisMapping());
            modelBuilder.Configurations.Add(new MenuMapping());
            modelBuilder.Configurations.Add(new EkstraMapping());

            modelBuilder.Entity<Siparis>()
                .HasMany(s => s.Menuler)
                .WithMany(m => m.MenuSiparisler)
                .Map(map =>
                {
                    map.ToTable("OrdersMenus");
                    map.MapLeftKey("SiparisID");
                    map.MapRightKey("MenuID");
                });

            modelBuilder.Entity<Siparis>()
                .HasMany(s => s.Ekstralar)
                .WithMany(e => e.EkstraSiparisler)
                .Map(map => 
                {
                    map.ToTable("OrdersExtras");
                    map.MapLeftKey("SiparisID");
                    map.MapRightKey("EkstraID");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
