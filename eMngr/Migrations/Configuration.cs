namespace eMngr.Migrations
{
    using eMngr.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<eMngr.Models.UsersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eMngr.Models.UsersContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Products.AddOrUpdate(
              p => p.sku,
              new ProductModel { sku = "EN-0001", Description="Sammy Wammy" },
              new ProductModel { sku = "EN-0002", Description = "Dingy Pingy" },
              new ProductModel { sku = "EN-0003", Description = "Rolly Polly" }
            );
            
        }
    }
}
