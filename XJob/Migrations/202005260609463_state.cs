namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class state : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "Status", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "Status");
        }
    }
}
