using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public class Course : IEntity
    {
        /// <summary>
        /// 课程编号
        /// </summary>
        [Key]
        public string CourseID { get; set; }
        /// <summary>
        /// 课程名
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 课时
        /// </summary>
        public int CourseTime { get; set; }

        /// <summary>
        /// 一个课程可以由不同的老师教
        /// </summary>
        public virtual List<SubjectList> SubjectListes { get; set; }



        public Guid ID { get; set; }

    }
}
