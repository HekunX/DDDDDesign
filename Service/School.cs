using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DomainService;
using Infrastructure.Repository;
using Infrastructure.DataBaseContext.EFContext;
using Domain.Model;

namespace Service
{
    public class School
    {

        StudentSV _StudentService;
        ClassSV _ClassSV;

        public School()
        {
            _StudentService = new StudentSV(new StudentRepository(new EFContext()));
            _ClassSV = new ClassSV(new ClassRepository(new EFContext()));
        }

        public void AddStudent(Student student)
        {
            _StudentService.AddStudent(student);
        }

        public void AddClass(Class @class)
        {
            _ClassSV.AddClass(@class);
        }

        public void DeleteClass(Guid ID)
        {
            _ClassSV.DeleteClass(ID);
        }
        public void UpdateClass(Class @class)
        {
            _ClassSV.UpdateClass(@class);
        }
        public Class GetClass(Guid ID)
        {
            return _ClassSV.GetClass(ID);
    }
    }
}
