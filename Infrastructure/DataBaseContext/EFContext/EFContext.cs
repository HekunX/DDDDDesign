using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BaseModel;
using Domain.IRepository;
using Domain.Model;

namespace Infrastructure.DataBaseContext.EFContext
{
    public class EFContext:DbContext 
    {
        public DbSet<SubjectList> SubjectList { get; set; }

        public DbSet<Classroom> Classroom { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentSubjectList> StudentSubjectList { get; set; }
        public DbSet<Teacher> Teacher { get; set; }







        public EFContext():base(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DDD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //设置数据库初始化策略
            //Database.SetInitializer<SubjectListContext>(null);
            //利用反射配置FuentAPI
            //modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
            //关闭默认级联删除
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
