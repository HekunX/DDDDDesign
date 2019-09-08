using Domain.IRepository;
using Domain.Model;
using Infrastructure.Repository;
using Application.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class TeacherAppService
    {
        private readonly IUnitOfWork UnitOfWork;
        public TeacherAppService()
        {
            this.UnitOfWork = new UnitOfWork();
        }
        public void AddTeacher(TeacherDTO teacherDTO)
        {
            try
            {
                UnitOfWork.TeacherRepository.Add(Teacher.CreateTeacher(teacherDTO.Name,teacherDTO.Age,teacherDTO.PhoneNumber));
                UnitOfWork.Commit();
            }
            catch(Exception e)
            {
                //写入日志
                //  return new ResultEntity<DBNull>(null, "发生异常，请稍后再试，若重复出现此错误，请联系客服！", 400);
                throw e;
            }
        }
        public bool ExistTeacher(TeacherDTO teacherDTO)
        {
            Teacher teacher = null;
            try
            {
                 teacher = UnitOfWork.TeacherRepository.GetTeacherByTeacherID(teacherDTO.TeacherID);
            }
            catch(Exception e)
            {
                throw e;
            }
            return teacher != null;
        }
    }
}
