namespace WebApplicationNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WTLs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monday = c.DateTime(nullable: false),
                        Tuesday = c.DateTime(nullable: false),
                        Wednesday = c.DateTime(nullable: false),
                        Thursday = c.DateTime(nullable: false),
                        Friday = c.DateTime(nullable: false),
                        Saturday = c.DateTime(nullable: false),
                        Sunday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WTLs");
        }
    }
}
