namespace WebApplicationNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Monday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Tuesday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Wednesday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Thursday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Friday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Saturday", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Sunday", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Sunday");
            DropColumn("dbo.Users", "Saturday");
            DropColumn("dbo.Users", "Friday");
            DropColumn("dbo.Users", "Thursday");
            DropColumn("dbo.Users", "Wednesday");
            DropColumn("dbo.Users", "Tuesday");
            DropColumn("dbo.Users", "Monday");
        }
    }
}
