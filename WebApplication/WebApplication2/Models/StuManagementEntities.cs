namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StuManagementEntities : DbContext
    {
        public StuManagementEntities()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Actiolink> Actiolink { get; set; }
        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Sidebars> Sidebars { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actiolink>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Actiolink>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Sidebars>()
                .Property(e => e.Controller)
                .IsUnicode(false);

            modelBuilder.Entity<Sidebars>()
                .Property(e => e.Action)
                .IsUnicode(false);
        }
    }
}
