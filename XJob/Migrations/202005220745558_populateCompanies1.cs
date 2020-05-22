namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateCompanies1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Name", c => c.String());
            DropColumn("dbo.Companies", "Mail");
            DropColumn("dbo.Companies", "Password");
            DropColumn("dbo.Companies", "PhoneNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "PhoneNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Companies", "Password", c => c.String());
            AddColumn("dbo.Companies", "Mail", c => c.String());
            DropColumn("dbo.Companies", "Name");
        }
    }
}
