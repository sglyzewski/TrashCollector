namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePickupDays : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PickupDays (Name) VALUES ('Monday')");
            Sql("INSERT INTO PickupDays (Name) VALUES ('Tuesday')");
            Sql("INSERT INTO PickupDays (Name) VALUES ('Wednesday')");
            Sql("INSERT INTO PickupDays (Name) VALUES ('Thursday')");
            Sql("INSERT INTO PickupDays (Name) VALUES ('Friday')");
        }
        
        public override void Down()
        {
        }
    }
}
