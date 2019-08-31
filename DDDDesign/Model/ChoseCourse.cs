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
        public static ChoseCourse CreateChoseCourse(Guid StudentID, string TeacherName, string CourseName)
        {
            return new ChoseCourse
            {
                StudnetID = StudentID,
                TeacherName = TeacherName,
                CourseName = CourseName
            };
        }
    }
}

