using Domain.BaseModel;
using Domain.BaseModule;
using Domain.EnumType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public partial class Course : AggregateRoot
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public int CourseTime { get; set; }
    }
    public partial class Course
    {
        public Course(string CourseName,int CourseTime)
        {
            this.CourseName = CourseName;
            this.CourseTime = CourseTime;

            this.CourseID = IDPrefix.CourseIDPrefix + new Random().Next(1000);
        }
    }
}
