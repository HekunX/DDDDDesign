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
    public class CourseRepository:Repository<Course>, ICourseRepository
    {
        public CourseRepository(EFContext Context):base(Context)
        {

        }
    }
}
