namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yanwei20191126 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.课程表",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassId = c.String(),
                        TeacherId = c.String(),
                        KemuId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.课程表");
        }
    }
}
