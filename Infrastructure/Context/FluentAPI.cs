using Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class StudentFlentAPI: EntityTypeConfiguration<Student>
    {
        public StudentFlentAPI()
        {
            Property(x => x.StudentID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}
