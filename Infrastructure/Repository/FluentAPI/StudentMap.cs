using Domain.Model;
using Infrastructure.DataBaseContext.EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.FluentAPI
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            HasRequired(x => x.Class).WithMany(x => x.Students).HasForeignKey(x => x.ClassGUID);

            ToTable("Student");
        }
    }
}
