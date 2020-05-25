namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v10 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Voits");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Voits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false),
                        Username = c.String(nullable: false, maxLength: 255),
                        PhoneNumber = c.Int(nullable: false),
                        IsDone = c.Boolean(nullable: false),
                        OnGoing = c.Boolean(nullable: false),
                        UnHandled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
