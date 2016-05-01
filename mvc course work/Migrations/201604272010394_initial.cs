namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teams", "photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teams", "photo", c => c.String());
        }
    }
}
