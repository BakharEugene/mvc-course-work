namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "firstGrandPrix", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "numberOfLaps", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "circuitLength", c => c.Double(nullable: false));
            AddColumn("dbo.Races", "raceDistance", c => c.Double(nullable: false));
            AddColumn("dbo.Races", "lapRecord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Races", "lapRecord");
            DropColumn("dbo.Races", "raceDistance");
            DropColumn("dbo.Races", "circuitLength");
            DropColumn("dbo.Races", "numberOfLaps");
            DropColumn("dbo.Races", "firstGrandPrix");
        }
    }
}
