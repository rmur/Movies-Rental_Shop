namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoreGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (4,'Romantic');");
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (5,'Action');");
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (6,'Family');");
        }
        
        public override void Down()
        {
        }
    }
}
