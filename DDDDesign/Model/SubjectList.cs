using Domain.BaseModel;
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

        /// <summary>
        /// 课程编号
        /// </summary>
        [Key]
        public string SubjectListID { get; set; }
        /// <summary>
        /// 课程ID
        /// </summary>
        [Required]
        public string CourseID { get; set; }
        /// <summary>
        /// 教师ID
        /// </summary>
        [Required]
        public string TeacherID { get; set; }
        /// <summary>
        /// 教学地址
        /// </summary>
        [Required]
        public string ClassroomID { get; set; }




        public virtual Teacher Teacher { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual Course Course { get; set; }

        /// <summary>
        /// 一条课程记录可被多个学生选修
        /// </summary>
        public virtual List<StudentSubjectList> StudentSubjectLists { get; set; }

    }
}
