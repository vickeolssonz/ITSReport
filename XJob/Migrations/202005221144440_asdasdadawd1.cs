namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdasdadawd1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "OnGoing", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reports", "OnGoing");
        }
    }
}
