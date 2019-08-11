using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    /// <summary>
    /// 教室表
    /// </summary>
    public class Classroom : IEntity
    {

        /// <summary>
        /// 教室编号
        /// </summary>
        [Key]
        public string ClassroomID { get; set; }
        /// <summary>
        ///教室名，比如多媒体教室、普通教室
        /// </summary>
        public string ClassroomName { get; set; }
        /// <summary>
        /// 教室内座位数量
        /// </summary>
        public int? SeatCount { get; set; }
        /// <summary>
        /// 教室描述
        /// </summary>
        public string Description { get; set; }

        ///一个教室可被很多课程表使用
        public virtual List<SubjectList> SubjectListes { get; set; }
        public Guid ID { get; set; }
    }
}
