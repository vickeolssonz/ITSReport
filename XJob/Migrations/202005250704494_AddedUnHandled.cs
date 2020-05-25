namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUnHandled : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "UnHandled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "UnHandled");
        }
    }
}
