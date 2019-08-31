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
    public partial class Subject : AggregateRoot
    {
        public string SubjectID { get; set; }
        public string CourseName { get; set; }
        public string TeacherName { get; set; }
        public int SubjectTime { get; set; }
        public string TeacherID { get; set; }
        public string CourseID { get; set; }

        public virtual IEnumerable<ChoseCourse> ChoseCourses { get; set; }
    }

    public partial class Subject
    {

        public static Subject CreateSubject(string CourseID,string CourseName,string TeacherID, string TeacherName,int SubjectTime)
        {
            return new Subject
            {
                CourseID = CourseID,
                TeacherID = TeacherID,
                CourseName = CourseName,
                TeacherName = TeacherName,
                SubjectTime = SubjectTime,
                SubjectID = IDPrefix.SubjectIDPrefix + new Random().Next(1000)
            };
        }


        public IEnumerable<ChoseCourse> GetAllChoseCourses()
        {
            return ChoseCourses;
        }
        public void AddStudent(Guid StudentID)
        {
            ChoseCourses.ToList().Add(ChoseCourse.CreateChoseCourse(StudentID, TeacherName, CourseName));
        }

    }
}
