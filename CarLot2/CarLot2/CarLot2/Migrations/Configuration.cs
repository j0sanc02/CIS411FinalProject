namespace CarLot2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CarLot2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CarLot2.Models.CarDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarLot2.Models.CarDBContext context)
        {
            context.Cars.AddOrUpdate(i => i.Make,
                    new Car
                    {
                        Year = 2005,
                        Make = "Jeep",
                        Model = "Grand Cherokee",
                        Mileage = 137,
                        ExtColor = "Grey",
                        IntColor = "Grey",
                        Price = 4000.00M

                    }

                );
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
