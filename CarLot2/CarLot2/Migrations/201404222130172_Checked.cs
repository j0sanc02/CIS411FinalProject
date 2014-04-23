namespace CarLot2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Checked : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Checked", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Checked");
        }
    }
}
