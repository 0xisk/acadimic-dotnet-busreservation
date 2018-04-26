namespace BusOnlineReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlinetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lines",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        FromCity = c.String(nullable: false),
                        ToCity = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        distance = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lines");
        }
    }
}
