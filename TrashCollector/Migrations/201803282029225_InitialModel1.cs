namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "AccountId", c => c.Byte());
            AlterColumn("dbo.Clients", "PickUpDayId", c => c.Byte());
            AlterColumn("dbo.Clients", "AddressId", c => c.Byte());
            AlterColumn("dbo.Clients", "NumberOfPickUpsYTD", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "NumberOfPickUpsYTD", c => c.Int(nullable: false));
            AlterColumn("dbo.Clients", "AddressId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clients", "PickUpDayId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Clients", "AccountId", c => c.Byte(nullable: false));
        }
    }
}
