namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (1,'Horror');");
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (2,'Comedy');");
            Sql("INSERT INTO dbo.Genres (Id,Name) VALUES (3,'Drama');");
        }
        
        public override void Down()
        {
        }
    }
}
