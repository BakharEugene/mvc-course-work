namespace mvc_course_work.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "number");
        }
    }
}
