namespace WebApplicationNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "end_time");
            DropColumn("dbo.Users", "Monday");
            DropColumn("dbo.Users", "Tuesday");
            DropColumn("dbo.Users", "Wednesday");
            DropColumn("dbo.Users", "Thursday");
            DropColumn("dbo.Users", "Friday");
            DropColumn("dbo.Users", "Saturday");
            DropColumn("dbo.Users", "Sunday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Sunday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Saturday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Friday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Thursday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Wednesday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Tuesday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Monday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "end_time", c => c.DateTime(nullable: false));
        }
    }
}
