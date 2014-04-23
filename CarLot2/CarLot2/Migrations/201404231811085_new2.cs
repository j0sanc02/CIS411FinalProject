namespace CarLot2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "carID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "carID");
        }
    }
}
