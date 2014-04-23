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

    Checked = false,

    carID = "18197",

    Year = 2005,

    Make = "Jeep",

    Model = "Grand Cherokee",

    Mileage = 137,

    ExtColor = "Grey",

    IntColor = "Grey",

    Price = 4000.00M


},


new Car

{
    Checked = false,

    carID = "12763",

    Year = 1995,

    Make = "Mitsubishi",

    Model = "Galant",

    Mileage = 15616,

    ExtColor = "Black",

    IntColor = "Grey",

    Price = 10000.00M


},

new Car

{
    Checked = false,

    carID = "13205",

    Year = 21998,

    Make = "Jeep",

    Model = "Grand Cherokee",

    Mileage = 137000,

    ExtColor = "Deep Slate",

    IntColor = "Gray",

    Price = 4500.00M


},

new Car

{
    Checked = false,

    carID = "20355",

    Year = 2003,

    Make = "Suburu",

    Model = "Baja",

    Mileage = 176000,

    ExtColor = "Yellow and Silver",

    IntColor = "Gray and Black",

    Price = 6700.00M


},

new Car

{

    Checked = false,

    carID = "10994",

    Year = 1996,

    Make = "Chevrolet",

    Model = "Lumina",

    Mileage = 152025,

    ExtColor = "White",

    IntColor = "Red",

    Price = 2000.00M


},

new Car

{

    Checked = false,

    carID = "10924",

    Year = 2003,

    Make = "Mazda",

    Model = "Protege",

    Mileage = 136032,

    ExtColor = "Red",

    IntColor = "Gray",

    Price = 4000.00M


},

new Car

{
    Checked = false,

    carID = "18121",

    Year = 1999,

    Make = "Saturn",

    Model = "Vue",

    Mileage = 145368,

    ExtColor = "Red",

    IntColor = "Black",

    Price = 6700.00M


},

new Car

{
    Checked = false,

    carID = "10620",

    Year = 2009,

    Make = "Chevrolet",

    Model = "Corvette",

    Mileage = 12565,

    ExtColor = "Blue",

    IntColor = "Black",

    Price = 26700.00M


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
