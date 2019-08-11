using Domain.IRepository;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainService
{
    /// <summary>
    /// 领域服务
    /// </summary>
    public class StudentSV
    {

        private readonly IStudentRepository _IStudentRepository;


        public StudentSV(IStudentRepository studentRepository)
        {
            _IStudentRepository = studentRepository;
        }


        /// <summary>
        /// 添加一个学生
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public bool AddStudent(Student student)
        {
            _IStudentRepository.Add(student);
            return _IStudentRepository.SaveChanges() > 0;
        }
        public bool AddStudents(List<Student> students)
        {
            _IStudentRepository.Add(students);
            return _IStudentRepository.SaveChanges() > 0;
        }

    }
}
