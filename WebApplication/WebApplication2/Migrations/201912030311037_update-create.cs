namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecreate : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.课程表");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.课程表",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.String(nullable: false),
                        TeacherId = c.String(),
                        KemuId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
