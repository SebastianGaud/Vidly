namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenre : DbMigration
    {
        public override void Up ()
        {
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Horror')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Action')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Drama')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Fiction')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Cult')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Romantic')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Comedy')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Gangster')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Crime')" );
            Sql( "INSERT INTO Genres ( Name) VALUES ( 'Science Fiction')" );

        }

        public override void Down ()
        {
        }
    }
}
