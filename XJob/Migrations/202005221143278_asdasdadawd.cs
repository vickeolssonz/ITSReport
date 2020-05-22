namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdadawd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "IsDone", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "IsDone");
        }
    }
}
