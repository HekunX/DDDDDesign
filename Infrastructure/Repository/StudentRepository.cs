using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.IRepository;
using Domain.Model;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class StudentRepository: Repository<Student>,IStudentRepository
    {
        public StudentRepository(EFContext Context):base(Context)
        {
            
        }

        public Student GetStudentByStudnetID(string StudentID)
        {
            return Context.Set<Student>().Where(x => x.StudentID == StudentID).FirstOrDefault();
        }
    }
}
