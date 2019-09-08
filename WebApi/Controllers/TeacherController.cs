using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Model;
using Application;
using Application.DTOModel;
using WebApi.Filter;

namespace WebApi.Controllers
{
    [TeacherAuthorize]
    public class TeacherController : ApiController
    {
        private  TeacherAppService TeacherAppService = new TeacherAppService();


    }
}
