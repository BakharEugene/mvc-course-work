namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Base", c => c.String());
            AddColumn("dbo.Teams", "TeamChief", c => c.String());
            AddColumn("dbo.Teams", "TechnicalChief", c => c.String());
            AddColumn("dbo.Teams", "Chasis", c => c.String());
            AddColumn("dbo.Teams", "PowerUnit", c => c.String());
            AddColumn("dbo.Teams", "firstTeamEntry", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "firstTeamEntry");
            DropColumn("dbo.Teams", "PowerUnit");
            DropColumn("dbo.Teams", "Chasis");
            DropColumn("dbo.Teams", "TechnicalChief");
            DropColumn("dbo.Teams", "TeamChief");
            DropColumn("dbo.Teams", "Base");
        }
    }
}
