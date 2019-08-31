﻿using Domain.IRepository;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class TeacherRepository: Repository<Teacher>, ITeacherRepository
    {
    }
}
