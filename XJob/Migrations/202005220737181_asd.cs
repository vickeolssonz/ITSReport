namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reports", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Reports", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reports", "Description", c => c.String());
            AlterColumn("dbo.Reports", "Title", c => c.String());
        }
    }
}
