namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up ()
        {
            Sql( "INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 'Pay As You Go', 0, 0, 0)" );
            Sql( "INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 'One Month', 30, 1, 10)" );
            Sql( "INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 'Three Month', 90, 3, 15)" );
            Sql( "INSERT INTO MembershipTypes (Id, Name, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 'One Year', 300, 12, 20)" );
        }

        public override void Down ()
        {
        }
    }
}
