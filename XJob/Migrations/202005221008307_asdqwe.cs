namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdqwe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reports", "User_Id", c => c.Int());
            CreateIndex("dbo.Reports", "User_Id");
            AddForeignKey("dbo.Reports", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reports", "User_Id", "dbo.Users");
            DropIndex("dbo.Reports", new[] { "User_Id" });
            DropColumn("dbo.Reports", "User_Id");
        }
    }
}
