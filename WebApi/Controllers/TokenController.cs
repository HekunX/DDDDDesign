using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Domain.EnumType;
using Domain.IRepository;
using Domain.Model;
using Infrastructure.Authorize;
using Infrastructure.Repository;
using WebApi.ViewModel;
using WebApi.Filter;
namespace WebApi.Controllers
{
    public class TokenController : ApiController
    {
        readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        /// <summary>
        /// 获得令牌
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IHttpActionResult Get([FromBody]User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            object o = null;
            switch (user.Role)
            {
                case RoleType.学生:
                    {
                        if ((o = UnitOfWork.StudentRepository.GetStudentByStudnetID(user.UserName)) != null)
                        {

                            return Ok(JWT.Encode(user.UserName,(o as Student).ID,RoleType.学生.ToString()));
                        }
                            
                    }
                    break;
                case RoleType.教师:
                    {
                        if ((o = UnitOfWork.TeacherRepository.GetTeacherByTeacherID(user.UserName)) != null)
                        {
                            return Ok(JWT.Encode(user.UserName,(o as Teacher).ID,RoleType.教师.ToString()));
                        }
                    }
                    break;
                case RoleType.管理员:
                    {
                        if ((o = UnitOfWork.AdministratorRepository.GetAdministrtorByAdminID(user.UserName)) != null)
                        {
                            return Ok(JWT.Encode(user.UserName, (o as Administrator).ID, RoleType.管理员.ToString()));
                        }
                    }
                    break;
                default:
                    break;
            }

            return Ok("用户账号验证未通过！");
           
        }
    }
}
