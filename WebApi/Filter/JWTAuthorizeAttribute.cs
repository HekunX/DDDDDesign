using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Domain.EnumType;
using Infrastructure.Authorize;
namespace WebApi.Filter
{
    public class PayLoad
    {
        public int Exp { get; set; }
        public string Name { get; set; }
        public Guid Id { get; set; }
        public RoleType Role { get; set; }
    }
    public class GenericIdentity : IIdentity
    {
        public GenericIdentity(string name,Guid id,params string[] roles)
        {
            Name = name;
            Id = id;
            Roles = roles;
        }
        public string Name { get; }
        public Guid Id { get; }
        public string[] Roles { get; }
        public string AuthenticationType { get; }

        public bool IsAuthenticated { get; }
    }
    public class GenericPrincipal : IPrincipal
    {
        public GenericPrincipal(string name,Guid id,params string[] roles)
        {
            Identity = new GenericIdentity(name, id, roles);
        }
        public IIdentity Identity { get; }

        public bool IsInRole(string role)
        {
            return (Identity as GenericIdentity).Roles.ToList().Exists(x => x==role);
        }
    }
    public class TeacherAuthorizeAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any())
            {
                return;
            }
            var authorization = actionContext.Request.Headers.Authorization;
            string payLoadJson = null;
            if (authorization == null || authorization.Scheme == null || authorization.Parameter == null || !JWT.Decode(authorization.Parameter, out payLoadJson))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new HttpError("Token验证未通过!"));
            }
            else
            {
                var payLoad = Json.Decode<PayLoad>(payLoadJson);
                if (payLoad.Role.HasFlag(RoleType.教师))
                {
                    actionContext.RequestContext.Principal = new GenericPrincipal(payLoad.Name, payLoad.Id, payLoad.Role.ToString());
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new HttpError("Token验证通过!，但无权限"));
                }
            }
        }

    }

    public class AdminAuthorizeAttribute : AuthorizationFilterAttribute
    {

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().Any())
            {
                return;
            }
            var authorization = actionContext.Request.Headers.Authorization;
            string payLoadJson = null;
            if (authorization == null || authorization.Scheme == null || authorization.Parameter == null || !JWT.Decode(authorization.Parameter, out payLoadJson))
            {
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new HttpError("Token验证未通过!"));
            }
            else
            {
                var payLoad = Json.Decode<PayLoad>(payLoadJson);
                if (payLoad.Role.HasFlag(RoleType.管理员))
                {
                    actionContext.RequestContext.Principal = new GenericPrincipal(payLoad.Name, payLoad.Id, payLoad.Role.ToString());
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.Unauthorized, new HttpError("Token验证通过!，但无权限。"));
                }
            }
        }


    }
}