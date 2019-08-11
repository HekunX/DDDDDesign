using Domain.IRepository;
using Domain.Model;
using Infrastructure.DataBaseContext.EFContext;
using Infrastructure.Repository.EFRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ClassRepository: EFRepository<Class>,IClassRepository
    {
        public ClassRepository(EFContext eFContext):base(eFContext)
        {
               
        }
        
    }
}
