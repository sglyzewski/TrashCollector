namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateClients : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Clients (Name) VALUES ('John Smith')");
            Sql("INSERT INTO Clients (Name) VALUES ('Stephanie')");
        }
        
        public override void Down()
        {
        }
    }
}
