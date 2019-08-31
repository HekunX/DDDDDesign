using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Model;
using Service;
using Service.DTOModel;

namespace WebApi.Controllers
{
    public class TeacherController : ApiController
    {
        TeacherAppService TeacherAppService = new TeacherAppService();
        /// <summary>
        /// 添加教师
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public ResultEntity<DBNull> AddTeacher(TeacherDTO teacher)
        {
            return TeacherAppService.AddTeacher(teacher);
        }
    }
}
