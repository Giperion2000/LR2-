namespace LR2.Migrations
{
    using LR2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LR2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "LR2.Models.ApplicationDbContext";
        }

        protected override void Seed(LR2.Models.ApplicationDbContext context)
        {
            context.Strahovs.Add(new Strahov { Path = "https://finclub.net/media/k2/items/cache/7196f2c0cf2d06b8c44ab3509a3014d1_XL.jpg", Name = "страхування", Type = "Життя", Price = 7000 });
            context.Strahovs.Add(new Strahov{ Path = "https://privatbank.ua/uploads/media/default/0001/08/7cb254eb45c43e85f76cdbade7aeb96938c1e269.jpeg", Name = "страхування", Type = "Житла", Price = 4000 });
            base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
