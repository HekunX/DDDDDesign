using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataBaseContext
{
    public class StudentContext:DbContext
    {
        DbSet<Student> Student { get; set; }


        public StudentContext() : base(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=DDD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
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
