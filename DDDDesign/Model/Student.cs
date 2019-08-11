using Domain.BaseModel;
using Domain.BaseModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    /// <summary>
    /// 学生信息表
    /// </summary>
    public  class Student : AggregateRoot
    {
        [Key]
        public override Guid ID { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        [Required]
        public string StudentID { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string StudnetName { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Required]
        public uint Age { get; set; }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string HomeAddress { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 父亲姓名
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// 母亲姓名
        /// </summary>
        public string MotherName { get; set; }
        /// <summary>
        /// 所在班级ID
        /// </summary>

        public Guid ClassGUID { get; set; }

        /// <summary>
        /// 一个学生只在一个班级
        /// </summary>
        public virtual Class Class { get; set; }

        /// <summary>
        /// 一个学生可以选择多们课程
        /// </summary>
        public virtual List<StudentSubjectList> StudentSubjectLists { get; set; }


    }





}
