using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using Infrastructure.Authorize;
using WebApi.ViewModel;
namespace WebApi.Controllers
{
    public class TokenController : ApiController
    {
        /// <summary>
        /// 获得令牌
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public IHttpActionResult Get(User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if(user != null && user.UserName == "何坤")
            {
                return Ok(JWT.Encode());
            }

            return Ok("用户账号验证未通过！");
           
        }
    }
}
