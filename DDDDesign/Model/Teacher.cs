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
        public Teacher(string Name,int Age,string PhoneNumber)
        {
            this.Name = Name;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;

            this.TeacherID = IDPrefix.TeacherIDPrefix + new Random().Next(1000);
        }
    }
}
