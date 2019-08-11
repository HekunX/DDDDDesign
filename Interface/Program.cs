


using Domain.Model;
using Service;
using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Guid id = Guid.NewGuid();
              school.AddClass(new Class { ClassID = "1505", ClassName = "网络15-1BF", ID = id, Students = new List<Student> { new Student { ID = Guid.NewGuid(), StudentID = "14154502320", StudnetName = "何坤"} } });
            // school.UpdateClass(new Class { ID = new Guid("58D277EA-7566-4E49-8A54-316A02AA11D5"),ClassID = "1415",ClassName = "软件工程" });

            //school.AddStudent(new Student(2319, "何坤", 22, "湖南省衡阳市板市乡上市组43号", "何友良", "陈冬梅", "1505", "15073051480"));
            //  school.DeleteClass(new System.Guid("00000000-0000-0000-0000-000000000000"));
            //Console.WriteLine($"{school.GetClass(new Guid("58D277EA-7566-4E49-8A54-316A02AA11D5")).Students[0].StudnetName}");


            //Class @class = school.GetClass(new Guid("58D277EA-7566-4E49-8A54-316A02AA11D5"));
            //@class.ClassName = "jike ";
            //@class.Students[0].StudnetName = "范易凡";
            //school.UpdateClass(@class);
            //Console.ReadLine();
        }
    }
}
