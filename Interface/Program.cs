using Service;
using Domain.Model;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            ChoseCourseAppService ChoseCourseAppService = new ChoseCourseAppService();
            ChoseCourseAppService.AddSubject(new Subject("领域驱动设计","何坤",40));
        }
    }
}
