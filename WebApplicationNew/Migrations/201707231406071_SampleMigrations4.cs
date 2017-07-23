namespace WebApplicationNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WTLs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WTLs", "Name");
        }
    }
}
