using Domain.BaseModel;
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Model
{
    public partial class ChoseCourse : IValueObject
    {
        [Key]
        public int RowID { get; set; }
        public Guid StudnetID { get; set; }
        public string TeacherName { get; set; }
        public string CourseName { get; set; }
    }
    public partial class ChoseCourse
    {
        public ChoseCourse(Guid StudentID, string TeacherName, string CourseName)
        {
            this.StudnetID = StudnetID;
            this.TeacherName = TeacherName;
            this.CourseName = CourseName;
        }
    }
}

