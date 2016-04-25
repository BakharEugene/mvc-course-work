namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Podiums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        place = c.Int(nullable: false),
                        year = c.Int(nullable: false),
                        race_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Races", t => t.race_Id)
                .Index(t => t.race_Id);
            
            CreateTable(
                "dbo.PodiumDrivers",
                c => new
                    {
                        Podium_Id = c.Int(nullable: false),
                        Driver_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Podium_Id, t.Driver_Id })
                .ForeignKey("dbo.Podiums", t => t.Podium_Id, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.Driver_Id, cascadeDelete: true)
                .Index(t => t.Podium_Id)
                .Index(t => t.Driver_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Podiums", "race_Id", "dbo.Races");
            DropForeignKey("dbo.PodiumDrivers", "Driver_Id", "dbo.Drivers");
            DropForeignKey("dbo.PodiumDrivers", "Podium_Id", "dbo.Podiums");
            DropIndex("dbo.PodiumDrivers", new[] { "Driver_Id" });
            DropIndex("dbo.PodiumDrivers", new[] { "Podium_Id" });
            DropIndex("dbo.Podiums", new[] { "race_Id" });
            DropTable("dbo.PodiumDrivers");
            DropTable("dbo.Podiums");
        }
    }
}
