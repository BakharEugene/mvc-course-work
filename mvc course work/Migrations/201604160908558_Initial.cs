namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "country", c => c.String());
            AddColumn("dbo.Drivers", "placeOfBirth", c => c.String());
            AddColumn("dbo.Drivers", "points", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "points");
            DropColumn("dbo.Drivers", "placeOfBirth");
            DropColumn("dbo.Drivers", "country");
        }
    }
}
