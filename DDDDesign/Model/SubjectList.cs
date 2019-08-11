using Domain.BaseModel;
using Domain.BaseModule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    /// <summary>
    /// 选课表
    /// </summary>
    public class SubjectList : AggregateRoot
    {

        [Key]
        public override Guid ID { get; set; }

        /// <summary>
        /// 课程编号
        /// </summary>
        [Required]
        public string SubjectListID { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        [Required]
        public Guid CourseGUID { get; set; }
        /// <summary>
        /// 教师ID
        /// </summary>
        [Required]
        public Guid TeacherGUIID { get; set; }
        /// <summary>
        /// 教学地址
        /// </summary>
        [Required]
        public Guid ClassroomGUIID { get; set; }




        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Course Course { get; set; }

        /// <summary>
        /// 一条课程记录可被多个学生选修
        /// </summary>
        public virtual List<StudentSubjectList> StudentSubjectLists { get; set; }


    }
}
