using Service;
using Domain.Model;
using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoseCourseAppService ChoseCourseAppService = new ChoseCourseAppService();
            var Result = ChoseCourseAppService.AddSubject(Subject.CreateSubject("100", "领域驱动设计", "100", "何坤", 14));
            Console.WriteLine(Result.Infomation);
        }
    }
}
