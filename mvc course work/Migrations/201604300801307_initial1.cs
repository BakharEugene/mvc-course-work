namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Photo");
        }
    }
}
