namespace XJob.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a62b6f62-8b75-49cb-9048-0543173a329c', N'Guest@vidly.com', 0, N'AFSCobozNk3gHs5UKiG2ttlyXgeYyURGX8LFB5hY7bPrlx/j5VeGjV2WIt4YTH7H5Q==', N'612c37f5-2283-4b2c-b25d-f9d3e07d08c6', NULL, 0, 0, NULL, 1, 0, N'Guest@vidly.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'aa187e5d-c0df-4d7e-ba12-24a8aeddf08b', N'admin@vidly.com', 0, N'AC8X10XFNsuExw5S9JEuqntj/qrXLzVFkYILYjJIXaeUmysVUWax18UO7QwhcCycLQ==', N'1b80cbe0-8b6c-4f49-8402-77b1c121edb0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'efccc443-bfe1-45d0-af13-694a1f7f055f', N'CanManageReport')

            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa187e5d-c0df-4d7e-ba12-24a8aeddf08b', N'efccc443-bfe1-45d0-af13-694a1f7f055f')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
