﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IStudentRepository:IRepository<Student>
    {
        Student GetStudentByStudnetID(string StudentID);
    }
}
