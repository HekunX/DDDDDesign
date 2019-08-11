using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Model
{
    /// <summary>
    /// 班级表
    /// </summary>
    public partial class Class : IEntity
    {
        /// <summary>
        /// 班级编号
        /// </summary>
        [Key]
        public string ClassID { get; set; }
        /// <summary>
        /// 班级名
        /// </summary>
        public string ClassName { get; set; }

        //一个班级有许多学生
        public virtual List<Student> Students { get; set; }

        public Guid ID { get ; set; }
    }
    public partial class Class
    {
        public Class(string classID, string ClassName, List<Student> Students)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            this.Students = Students;
        }
    }


}
