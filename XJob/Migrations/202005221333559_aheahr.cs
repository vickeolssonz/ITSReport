namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aheahr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reports", "User_Id", "dbo.Users");
            DropIndex("dbo.Reports", new[] { "User_Id" });
            DropColumn("dbo.Reports", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reports", "User_Id", c => c.Int());
            CreateIndex("dbo.Reports", "User_Id");
            AddForeignKey("dbo.Reports", "User_Id", "dbo.Users", "Id");
        }
    }
}
