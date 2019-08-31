using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.IRepository;
using Domain.Model;

namespace Infrastructure.Repository
{
    public class StudentRepository: Repository<Student>,IStudentRepository
    {

    }
}
