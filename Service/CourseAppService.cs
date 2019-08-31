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
    public class CourseAppService
    {
        private readonly IUnitOfWork UnitOfWork;
        public CourseAppService()
        {
            this.UnitOfWork = new UnitOfWork();
        }
        public ResultEntity<DBNull> AddCourse(Course course)
        {
            try
            {
                UnitOfWork.CourseRepository.Add(Course.CreateCourse(course));
            }
            catch (Exception e)
            {
                //写入日志
                return new ResultEntity<DBNull>(null, "发生异常，请稍后再试，若重复出现此错误，请联系客服！", 400);
            }
            return new ResultEntity<DBNull>();
        }
    }
}
