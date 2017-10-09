namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingJohnSmithBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-1-1' AS DATETIME) WHERE Name = 'John Smith'");
        }
        
        public override void Down()
        {
        }
    }
}
