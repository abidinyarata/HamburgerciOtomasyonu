namespace Hamburgerci.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hamburgerci.DAL.Context.ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Hamburgerci.DAL.Context.ProjectContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Menuler.AddOrUpdate(x => x.MenuID,
                new DATA.Menu { MenuAdi = "Big King", Fiyati = 18.25M },
                new DATA.Menu { MenuAdi = "Double King Chiken", Fiyati = 24.50M },
                new DATA.Menu { MenuAdi = "Big Royal", Fiyati = 25.75M },
                new DATA.Menu { MenuAdi = "Whooper", Fiyati = 23.25M },
                new DATA.Menu { MenuAdi = "Steak House", Fiyati = 27.25M },
                new DATA.Menu { MenuAdi = "Double Whooper", Fiyati = 21.00M }
            );

            context.Ekstralar.AddOrUpdate(x => x.EkstraID,
                new DATA.Ekstra { EkstraAdi = "Ketçap", Fiyati = 0.25M },
                new DATA.Ekstra { EkstraAdi = "Mayonez", Fiyati = 0.25M },
                new DATA.Ekstra { EkstraAdi = "Ranch Sos", Fiyati = 0.50M },
                new DATA.Ekstra { EkstraAdi = "BBQ Sos", Fiyati = 0.50M },
                new DATA.Ekstra { EkstraAdi = "Hardal", Fiyati = 0.75M },
                new DATA.Ekstra { EkstraAdi = "Buffalo Sos", Fiyati = 1.00M }
            );
        }
    }
}
