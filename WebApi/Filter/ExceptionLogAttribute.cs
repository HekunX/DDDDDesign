using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Http.Filters;
using Infrastructure.LogHelper;
using System.Threading;
using System.Threading.Tasks;

namespace WebApi.Filter
{
    public class ExceptionLogAttribute: ExceptionFilterAttribute
    {

        private string LogDir = HttpRuntime.AppDomainAppPath+@"ExceptionLog\";
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            ExceptionLog.WriteLog(actionExecutedContext.Exception,LogDir);
        }
    }
}