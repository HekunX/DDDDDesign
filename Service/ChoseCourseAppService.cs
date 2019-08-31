using Domain.IRepository;
using Domain.Model;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ChoseCourseAppService
    {
        private readonly IUnitOfWork UnitOfWork;
        public ChoseCourseAppService()
        {
            this.UnitOfWork = new UnitOfWork();
        }

        public void AddSubject(Subject subject)
        {
            UnitOfWork.SubjectRepository.Add(subject);
            UnitOfWork.Commit();
        }
    }
}
