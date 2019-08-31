using Domain.IRepository;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private  EFContext Context;
        private  CourseRepository _CourseRepository;
        private StudentRepository _StudentRepository;
        private SubjectRepository _SubjectRepository;
        private TeacherRepository _TeacherRepository;


        public UnitOfWork()
        {
            this.Context = new EFContext();
        }

        public ICourseRepository CourseRepository
        {
            get
            {
                if(_CourseRepository == null)
                {
                    _CourseRepository = new CourseRepository(Context);
                    return _CourseRepository;
                }
                else
                {
                    return _CourseRepository;
                }
            }
        }

        public IStudentRepository StudentRepository
        {
            get
            {
                if (_StudentRepository == null)
                {
                    _StudentRepository = new StudentRepository(Context);
                    return _StudentRepository;
                }
                else
                {
                    return _StudentRepository;
                }
            }
        }

        public ISubjectRepository SubjectRepository
        {
            get
            {
                if (_SubjectRepository == null)
                {
                    _SubjectRepository = new SubjectRepository(Context);
                    return _SubjectRepository;
                }
                else
                {
                    return _SubjectRepository;
                }
            }
        }

        public ITeacherRepository TeacherRepository
        {
            get
            {
                if (_TeacherRepository == null)
                {
                    _TeacherRepository = new TeacherRepository(Context);
                    return _TeacherRepository;
                }
                else
                {
                    return _TeacherRepository;
                }
            }
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
