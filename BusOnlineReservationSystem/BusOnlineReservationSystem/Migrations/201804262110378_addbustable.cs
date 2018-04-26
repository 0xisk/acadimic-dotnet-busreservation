namespace BusOnlineReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbustable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        NumOfChairs = c.Int(nullable: false),
                        color = c.String(nullable: false),
                        lineID = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lines", t => t.lineID, cascadeDelete: true)
                .Index(t => t.lineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "lineID", "dbo.Lines");
            DropIndex("dbo.Buses", new[] { "lineID" });
            DropTable("dbo.Buses");
        }
    }
}
