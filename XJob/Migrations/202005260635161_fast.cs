namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fast : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "HandledBy", c => c.String());
            DropColumn("dbo.Reports", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reports", "Status", c => c.String());
            DropColumn("dbo.Reports", "HandledBy");
        }
    }
}
