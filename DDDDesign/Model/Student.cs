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
    public partial class Student : AggregateRoot
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
    public partial  class  Student
    {
        public static Student CreateStudent(string Name,int Age,string PhoneNumber)
        {
            return new Student
            {
                Name = Name,
                Age = Age,
                PhoneNumber = PhoneNumber,
                StudentID = IDPrefix.StudentIDPrefix + new Random().Next(1000)
            };
        }
    }
}
