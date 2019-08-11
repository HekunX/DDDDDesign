
using Domain.IRepository;
using Infrastructure.Repository.EFRepo;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DataBaseContext.EFContext;

namespace Infrastructure.Repository
{
    public class StudentRepository : EFRepository<Student>,IStudentRepository
    {
        public StudentRepository(EFContext eFContext):base(eFContext)
        {
           
        }
    }
}
