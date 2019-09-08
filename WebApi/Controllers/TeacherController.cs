using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Model;
using Service;
using Service.DTOModel;
using WebApi.Filter;

namespace WebApi.Controllers
{
    [TeacherAuthorize]
    public class TeacherController : ApiController
    {
        private  TeacherAppService TeacherAppService = new TeacherAppService();
        /// <summary>
        /// 添加教师
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public ResultEntity<IHttpActionResult> AddTeacher(TeacherDTO teacher)
        {
            if (!ModelState.IsValid) return new ResultEntity<IHttpActionResult>(BadRequest(ModelState), "模型错误", HttpStatusCode.BadRequest);
            try
            {
                TeacherAppService.AddTeacher(teacher);
            }
            catch(Exception e)
            {
                //这里写入日志
                return new ResultEntity<IHttpActionResult>(Ok(), "发生异常，请稍后再试，若重复出现此错误，请联系客服！", HttpStatusCode.LengthRequired);
            }
            return new ResultEntity<IHttpActionResult>(Ok());

        }
    }
}
