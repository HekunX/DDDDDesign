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
    public class TeacherRepository: Repository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(EFContext Context) : base(Context)
        {

        }

        public Teacher GetTeacherByTeacherID(string TeacherID)
        {
            return Context.Set<Teacher>().Where(x => x.TeacherID == TeacherID).FirstOrDefault();
        }
    }
}
