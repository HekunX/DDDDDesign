using DDDDesign.IRepository;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public int Add(Student aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public int Add(IQueryable<Student> aggregateRoots)
        {
            throw new NotImplementedException();
        }

        public bool BeginTransition()
        {
            throw new NotImplementedException();
        }

        public bool Commit()
        {
            throw new NotImplementedException();
        }

        public int Delete(Student aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public int Delete(IQueryable<Student> aggregateRoots)
        {
            throw new NotImplementedException();
        }

        public Student Find(Guid ID)
        {
            throw new NotImplementedException();
        }

        public bool RollBack()
        {
            throw new NotImplementedException();
        }

        public int Update(Student aggregateRoot)
        {
            throw new NotImplementedException();
        }

        public int Update(IQueryable<Student> aggregateRoots)
        {
            throw new NotImplementedException();
        }
    }
}
