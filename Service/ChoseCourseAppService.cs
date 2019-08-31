using Domain.IRepository;
using Domain.Model;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ChoseCourseAppService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ChoseCourseAppService()
        {
            this.UnitOfWork = new UnitOfWork();
        }

        public ResultEntity<DBNull> AddSubject(Subject subject)
        {
            //首先判断TeacherID和CourseID是否存在
            Teacher Teacher = UnitOfWork.TeacherRepository.GetTeacherByTeacherID(subject.TeacherID);
            Course Course = UnitOfWork.CourseRepository.GetCourseByCourseID(subject.CourseID);

            if (Teacher == null)
            {
                return new ResultEntity<DBNull>(null, $"不存在教师{subject.TeacherID}", 400);
            }
            if(Course == null)
            {
                return new ResultEntity<DBNull>(null, $"不存在课程{subject.CourseID}", 400);
            }

            UnitOfWork.SubjectRepository.Add(subject);
            UnitOfWork.Commit();
            return new ResultEntity<DBNull>(); 
        }
        public ResultEntity<Subject> GetSubjectBySubjectID(string subjectID)
        {
            Subject Subject = UnitOfWork.SubjectRepository.GetSubjectBySubjectID(subjectID);
            return new ResultEntity<Subject>(Subject);
        }
    }
}
