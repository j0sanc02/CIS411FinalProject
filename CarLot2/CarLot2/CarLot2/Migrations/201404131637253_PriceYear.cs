namespace CarLot2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PriceYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.Cars", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
            DropColumn("dbo.Cars", "Year");
        }
    }
}
