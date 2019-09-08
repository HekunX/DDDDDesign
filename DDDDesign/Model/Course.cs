using Domain.BaseModel;
using Domain.BaseModel;
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
        public static Course CreateCourse(string CourseName,int CourseTime)
        {
            return new Course
            {
                CourseName = CourseName,
                CourseTime = CourseTime,
                CourseID = IDPrefix.CourseIDPrefix + new Random().Next(1000)
            };
        }
        public static Course CreateCourse(Course course)
        {
            return new Course
            {
                CourseName = course.CourseName,
                CourseTime = course.CourseTime,
                CourseID = IDPrefix.CourseIDPrefix + new Random().Next(1000)
            };
        }
    }
}
