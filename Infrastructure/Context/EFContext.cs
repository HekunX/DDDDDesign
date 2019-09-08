using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class EFContext:DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<ChoseCourse> ChoseCourse { get; set; }
        public EFContext():base("name=EFContext")
        {
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
