


using Domain.Model;
using Service;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            //school.AddClass(new Class("1505", "网络15-1BF"));
            //school.AddStudent(new Student(2319, "何坤", 22, "湖南省衡阳市板市乡上市组43号", "何友良", "陈冬梅", "1505", "15073051480"));
            school.DeleteClass(new System.Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
