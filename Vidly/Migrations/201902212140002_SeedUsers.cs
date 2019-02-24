namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3543827-288a-4d7b-8480-d7ec1aa38f71', N'romuald.murzakov@gmail.com', 0, N'AGJ1rLF62kxdXEmLrV9xfy/D2lyQX8XfxIB1HK5EJOQEJDG9+ANzQTz5LPSBaudjpg==', N'63ebee15-8fb0-472d-8b4e-385f701ca91d', NULL, 0, 0, NULL, 1, 0, N'romuald.murzakov@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e4d4e5d2-172d-4742-87d7-ffabb6c1ff52', N'admin@vidly.com', 0, N'AKKqGthIKtbepESyEzTRdkwoz74IOfhXxBZmYImONaTh6wD69XbJg0uMaMsL/MODag==', N'06369673-ad68-4386-b271-cb99d2d8152d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3779fa66-126a-41e5-94a5-31af26780347', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e4d4e5d2-172d-4742-87d7-ffabb6c1ff52', N'3779fa66-126a-41e5-94a5-31af26780347')
                    ");
        }
        
        public override void Down()
        {
        }
    }
}
