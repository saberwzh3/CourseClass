namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorseProject : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Logins", "VerificationCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Logins", "VerificationCode", c => c.String(nullable: false, maxLength: 6));
        }
    }
}
