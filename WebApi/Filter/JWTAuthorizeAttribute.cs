using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;
using Infrastructure.Authorize;
namespace WebApi.Filter
{
    public class JWTAuthorizeAttribute:AuthorizeAttribute
    {

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var authorization = actionContext.Request.Headers.Authorization;
            if (authorization == null || authorization.Scheme == null || authorization.Parameter == null || !JWT.Decode(authorization.Parameter))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            base.HandleUnauthorizedRequest(actionContext);
            actionContext.Response.Content = new StringContent(Json.Encode("Token验证失败！"),Encoding.UTF8,"application/json");
        }


    }
}