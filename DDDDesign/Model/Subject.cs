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

        public virtual IEnumerable<ChoseCourse> ChoseCourses { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Course Course { get; set; }
    
    }

    public partial class Subject
    {
        public Subject(string CourseName, string TeacherName,int SubjectTime)
        {
            this.CourseName = CourseName;
            this.TeacherName = TeacherName;
            this.SubjectTime = SubjectTime;

            this.SubjectID = IDPrefix.SubjectIDPrefix + new Random().Next(1000);
        }

        public IEnumerable<ChoseCourse> GetAllChoseCourses()
        {
            return ChoseCourses;
        }
        public void AddStudent(Guid StudentID)
        {
            ChoseCourses.ToList().Add(new ChoseCourse(StudentID, TeacherName, CourseName));
        }

    }
}
