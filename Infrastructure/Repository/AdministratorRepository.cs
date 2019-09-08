using Domain.IRepository;
using Domain.Model;
using Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AdministratorRepository : Repository<Administrator>,IAdministratorRepository
    {
        public AdministratorRepository(EFContext EFContext):base(EFContext)
        {
                
        }
        public Administrator GetAdministrtorByAdminID(string AdminID)
        {
            return Context.Set<Administrator>().Where(x => x.AdminID == AdminID).FirstOrDefault();
        }
    }
}
