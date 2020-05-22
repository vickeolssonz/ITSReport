namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addProps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "Username", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.Reports", "PhoneNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "PhoneNumber");
            DropColumn("dbo.Reports", "Username");
        }
    }
}
