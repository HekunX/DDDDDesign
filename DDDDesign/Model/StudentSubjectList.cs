using Domain.BaseModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    /// <summary>
    /// 学生选课表
    /// </summary>
    public class StudentSubjectList : IEntity
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public int StudentSubjectListID { get; set; }
        [Required]
        public Guid SubjectListGUID { get; set; }
        [Required]
        public Guid StudentGUID { get; set; }

        /// <summary>
        /// 一条选课记录对应一个学生
        /// </summary>
        public virtual Student Student { set; get; }
        /// <summary>
        /// 一条选课记录对应一个课程信息
        /// </summary>
        public virtual SubjectList SubjectList { get; set; }



    }
}
