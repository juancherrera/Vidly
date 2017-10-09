namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropBirthdateColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
        
        public override void Down()
        {
        }
    }
}
