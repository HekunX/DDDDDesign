using Application;
using Application.DTOModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Filter;
namespace WebApi.Controllers
{
    [AdminAuthorize]
    public class AdministratorController : ApiController
    {
        private TeacherAppService TeacherAppService = new TeacherAppService();
        /// <summary>
        /// 添加教师
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        [HttpPost]
        public ResultEntity AddTeacher(TeacherDTO teacher)
        {
            if (!ModelState.IsValid) return new ResultEntity(BadRequest(ModelState), "模型错误", HttpStatusCode.BadRequest);
            try
            {
                TeacherAppService.AddTeacher(teacher);
            }
            catch (Exception e)
            {
                //这里写入日志
                return new ResultEntity(Ok(), "发生异常，请稍后再试，若重复出现此错误，请联系客服！", HttpStatusCode.LengthRequired);
            }
            return new ResultEntity();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Left"></param>
        /// <param name="Right"></param>
        /// <returns></returns>
        [HttpGet,AllowAnonymous]
        public ResultEntity Test(int Left ,int Right)
        {
            return new ResultEntity(Left/Right);
        }
    }
}
