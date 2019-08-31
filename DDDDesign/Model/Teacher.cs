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
    public partial class Teacher : AggregateRoot
    {
        public string TeacherID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

    }
    public partial class Teacher
    {
        public static Teacher CreateTeacher(string Name,int Age,string PhoneNumber)
        {
            return new Teacher
            {
                Name = Name,
                Age = Age,
                PhoneNumber = PhoneNumber,
                TeacherID = IDPrefix.TeacherIDPrefix + new Random().Next(1000)
            };
        }
        public static Teacher CreateTeacher(Teacher teacher)
        {
            return new Teacher
            {
                Name = teacher.Name,
                Age = teacher.Age,
                PhoneNumber = teacher.PhoneNumber,
                TeacherID = IDPrefix.TeacherIDPrefix + new Random().Next(1000)
            };
        }
    }
}
