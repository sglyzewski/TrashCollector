namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'40d47ce0-9fff-4fa3-8b6b-9383bc86e588', N'user@trashcollector.com', 0, N'AP0SP+k1ZWnGnx1XnBHu6s04vfm9K3AW9hrYj3nkefDrf9EdpEq0JO569rfQT98ATw==', N'7d4e2fd5-506e-4ad6-b17a-4c8916212086', NULL, 0, 0, NULL, 1, 0, N'user@trashcollector.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'44b647d1-516d-4527-8d27-10c882bedab5', N'worker@trashcollector.com', 0, N'ANBMav9433LIYf21WNPA0DZJ9/AViG4QBEIiXTOoganL+tD5dPmvQ/BLPxKFuzSUMA==', N'06011e12-b8ae-47a4-8328-9347ed2dda41', NULL, 0, 0, NULL, 1, 0, N'worker@trashcollector.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'873dd332-d971-4f57-a41a-b81102508d89', N'guest@trashcollector.com', 0, N'AFzEsHZFZCzu57BWZYW7fdy74Si85vwTt/MRZ+Lkg2pjqyJnuqgYD7uG1ydOwOUm0g==', N'4cb8f466-56dc-4d5f-ac8f-46ec83ddf020', NULL, 0, 0, NULL, 1, 0, N'guest@trashcollector.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'875d4fe2-5579-4cd4-a9d0-5eb62b7a37d8', N'user@hi.com', 0, N'ADfs3+ysz4zgxj7kp8RGKzRXbajdzjKfhltuf/W+JtXI5Ar/ivt3AgVHt7sDJaiUfA==', N'499b1a47-5cbe-459a-8d28-b7b83f8acd5d', NULL, 0, 0, NULL, 1, 0, N'user@hi.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f722ce1c-f181-4b3c-9395-70e1f3c7f099', N'trashcollector@trashcollector.com', 0, N'AAFdkgqUgyPV/Jfe/JX7/psq4gE5bS+REXLM4KF6leKqUrDmir3JZdvg0miM4I9TLw==', N'c6026a88-0367-44c3-a44e-416ece946eee', NULL, 0, 0, NULL, 1, 0, N'trashcollector@trashcollector.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9f06e01e-afd6-4aac-841d-f59b8e2b89f4', N'CanSeeAllPickups')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'44b647d1-516d-4527-8d27-10c882bedab5', N'9f06e01e-afd6-4aac-841d-f59b8e2b89f4')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f722ce1c-f181-4b3c-9395-70e1f3c7f099', N'9f06e01e-afd6-4aac-841d-f59b8e2b89f4')

");
        }
        
        public override void Down()
        {
        }
    }
}
