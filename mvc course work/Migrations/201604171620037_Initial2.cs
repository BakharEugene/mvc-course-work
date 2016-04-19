namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "day", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "year", c => c.Int(nullable: false));
            AddColumn("dbo.Races", "month", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Races", "month");
            DropColumn("dbo.Races", "year");
            DropColumn("dbo.Races", "day");
        }
    }
}
