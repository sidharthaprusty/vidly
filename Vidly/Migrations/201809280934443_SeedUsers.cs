namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'a25a875a-ec93-4731-9358-8e3b663ede03', N'sidharth', N'ADoQK/RI7V00TMuqUbUFe0B2mpYqL+WrjG1pyjCFid6yDT9h8XofIqhVY2mRJ46fMQ==', N'01e0500c-918b-44df-9f2a-77bc6d98fe07', N'ApplicationUser')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'fb6c1048-fcb2-4b4a-bacb-58bfb3826557', N'abc', N'AFZS5K4P6IeXwrnoLMX2AitE2TSLBjxMqoddCgd+ysXuINRqE5ShbwSMFmmpiIPV4w==', N'85e3477e-2567-47af-ac01-b1284c3e500c', N'ApplicationUser')

            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1d8c15c9-2c88-4c01-a5f0-7257caeba359', N'CanManageMovies')
            INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a25a875a-ec93-4731-9358-8e3b663ede03', N'1d8c15c9-2c88-4c01-a5f0-7257caeba359')

            ");
        }

        public override void Down()
        {
        }
    }
}
