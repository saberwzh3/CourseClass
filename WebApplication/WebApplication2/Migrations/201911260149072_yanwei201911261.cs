namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yanwei201911261 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.课程表", "ClassId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.课程表", "ClassId", c => c.String());
        }
    }
}
