﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
namespace Domain.IRepository
{
    public interface IAdministratorRepository:IRepository<Administrator>
    {
        Administrator GetAdministrtorByAdminID(string AdminID);
    }
}
