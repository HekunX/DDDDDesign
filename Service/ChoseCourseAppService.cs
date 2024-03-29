﻿using Domain.IRepository;
using Domain.Model;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Application
{
    public class ChoseCourseAppService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ChoseCourseAppService()
        {
            this.UnitOfWork = new UnitOfWork();
        }

        public ResultEntity AddSubject(Subject subject)
        {
            //首先判断TeacherID和CourseID是否存在
            Teacher Teacher = UnitOfWork.TeacherRepository.GetTeacherByTeacherID(subject.TeacherID);
            Course Course = UnitOfWork.CourseRepository.GetCourseByCourseID(subject.CourseID);

            if (Teacher == null)
            {
                return new ResultEntity(null, $"不存在教师{subject.TeacherID}",HttpStatusCode.BadRequest );
            }
            if(Course == null)
            {
                return new ResultEntity(null, $"不存在课程{subject.CourseID}", HttpStatusCode.BadRequest);
            }

            UnitOfWork.SubjectRepository.Add(subject);
            UnitOfWork.Commit();
            return new ResultEntity(); 
        }
        public ResultEntity GetSubjectBySubjectID(string subjectID)
        {
            Subject Subject = UnitOfWork.SubjectRepository.GetSubjectBySubjectID(subjectID);
            return new ResultEntity(Subject);
        }
    }
}
