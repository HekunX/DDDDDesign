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
    public class SubjectRepository:Repository<Subject>, ISubjectRepository
    {
        public SubjectRepository(EFContext Context) : base(Context)
        {

        }

        public Subject GetSubjectBySubjectID(string SubjectID)
        {
            return Context.Subject.Where(x => x.SubjectID == SubjectID).FirstOrDefault();
        }
    }
}
