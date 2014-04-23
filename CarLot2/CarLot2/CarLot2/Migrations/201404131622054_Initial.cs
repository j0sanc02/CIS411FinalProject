namespace CarLot2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Make = c.String(maxLength: 60),
                        Model = c.String(maxLength: 60),
                        Mileage = c.Int(nullable: false),
                        ExtColor = c.String(maxLength: 30),
                        IntColor = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
