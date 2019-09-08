using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EnumType
{
    public class IDPrefix
    {
        public static string TeacherIDPrefix = "100";
        public static string StudentIDPrefix = "200";
        public static string CourseIDPrefix = "300";
        public static string SubjectIDPrefix = "400";
    }
    [Flags]
    public enum RoleType:int
    {
        学生 = 0x1,
        教师 = 0x1<<1,
        管理员 = 0x1<<2
    }
}
