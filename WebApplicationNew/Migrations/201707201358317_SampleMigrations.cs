namespace WebApplicationNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "start_time", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "end_time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "end_time");
            DropColumn("dbo.Users", "start_time");
        }
    }
}
