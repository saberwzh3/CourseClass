namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Migrations.Seeds;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Models.StuManagementEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication2.Models.StuManagementEntities context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            new ActionLinkCreate(context).Seed();
            new SidebarCreate(context).Seed();
            new UserCreate(context).Seed();
        }
    }
}
