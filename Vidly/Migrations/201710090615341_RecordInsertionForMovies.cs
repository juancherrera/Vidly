namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecordInsertionForMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleasedDate, AddedDate, NumberInStock, GenreId) VALUES (1, 'Hangover', '06-02-2009', '08-30-2009', 20, 3)");
            Sql("INSERT INTO Movies (Id, Name, ReleasedDate, AddedDate, NumberInStock, GenreId) VALUES (2, 'Die Hard', '07-12-1988', '11-10-1988', 2, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleasedDate, AddedDate, NumberInStock, GenreId) VALUES (3, 'The Terminator', '10-26-1984', '01-20-1985', 4, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleasedDate, AddedDate, NumberInStock, GenreId) VALUES (4, 'Toy Story', '11-22-1995', '02-03-1996', 5, 5)");
            Sql("INSERT INTO Movies (Id, Name, ReleasedDate, AddedDate, NumberInStock, GenreId) VALUES (5, 'Titanic ', '12-19-1997', '4-03-1998', 6, 6)");
            Sql("SET IDENTITY_INSERT Movies Off");
        }
        
        public override void Down()
        {
        }
    }
}