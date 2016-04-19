namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Races", "country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Races", "country");
        }
    }
}
