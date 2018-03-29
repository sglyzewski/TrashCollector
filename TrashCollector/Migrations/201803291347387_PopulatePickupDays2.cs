namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePickupDays2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PickupDays (Name, FirstPickup) VALUES ('Monday', '20180402 12:00:00 AM')");
            Sql("INSERT INTO PickupDays (Name, FirstPickup) VALUES ('Tuesday', '20180403 12:00:00 AM')");
            Sql("INSERT INTO PickupDays (Name, FirstPickup) VALUES ('Wednesday', '20180404 12:00:00 AM')");
            Sql("INSERT INTO PickupDays (Name, FirstPickup) VALUES ('Thursday', '20180329 12:00:00 AM')");
            Sql("INSERT INTO PickupDays (Name, FirstPickup) VALUES ('Friday', '20180330 12:00:00 AM')");
        }
        
        public override void Down()
        {
        }
    }
}
