﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface ICourseRepository:IRepository<Course>
    {
        Course GetCourseByCourseID(string CourseID);
    }
}
