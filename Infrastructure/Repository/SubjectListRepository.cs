
using Domain.IRepository;
using Domain.Model;
using Infrastructure.DataBaseContext;
using Infrastructure.DataBaseContext.EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infrastructure.Repository
{
    public class SubjectListRepository : EFRepo.EFRepository<SubjectList>,ISubjectListRepository
    {
        public SubjectListRepository(EFContext eFcontext):base(eFcontext)
        {

        }
    }
}
