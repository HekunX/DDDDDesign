using Domain.EnumType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.ViewModel
{
	public class User
	{
        
        /// <summary>
        /// 用户名
        /// </summary>
        [Required,MinLength(1)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required,MinLength(1)]
        public string UserPwd { get; set; }
        /// <summary>
        /// 用户角色
        /// </summary>
        [Required]
        public RoleType Role { get; set; }



    }
}