using DDDDesign.IRepository;
using Domain.Model;
using Infrastructure.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infrastructure.Repository
{
    public class SubjectListRepository : ISubjectListRepository
    {
        public readonly SubjectListContext _SubjectListContext;

        public SubjectListRepository(SubjectListContext subjectListContext)
        {
            _SubjectListContext = subjectListContext;
        }



        public int Add(SubjectList aggregateRoot)
        {
            _SubjectListContext.SubjectList.Add(aggregateRoot);
            return 1;
        }

        public int Add(IQueryable<SubjectList> aggregateRoots)
        {
            _SubjectListContext.SubjectList.AddRange(aggregateRoots);
            return aggregateRoots.Count();
        }

        public bool BeginTransition()
        {
            try
            {
                _DbContextTransaction = _SubjectListContext.Database.BeginTransaction();
            }
            catch(Exception e)
            {
                throw (e);
            }
            return true;    
        }

        public bool Commit()
        {
            if (_DbContextTransaction != null)
            {
                _DbContextTransaction.Commit();
                return true;
            }
            else return false;
        }

        public bool RollBack()
        {
            if (_DbContextTransaction != null)
            {
                _DbContextTransaction.Rollback();
                return true;
            }
            else return false;
        }

        public int Delete(SubjectList aggregateRoot)
        {
            _SubjectListContext.SubjectList.Remove(aggregateRoot);
            return 1;
        }

        public int Delete(IQueryable<SubjectList> aggregateRoots)
        {
            _SubjectListContext.SubjectList.RemoveRange(aggregateRoots);
            return aggregateRoots.Count();
        }



        public SubjectList Find(Guid ID)
        {
            return _SubjectListContext.SubjectList.Where(x => x.ID == ID).AsNoTracking().FirstOrDefault();
        }



        public int Update(SubjectList aggregateRoot)
        {
            _SubjectListContext.SubjectList.Attach(aggregateRoot);
            _SubjectListContext.Entry(aggregateRoot).State = EntityState.Modified;
            return 1;
        }

        public int Update(IQueryable<SubjectList> aggregateRoots)
        {
            foreach(var aggregateRoot in aggregateRoots )
            {
                _SubjectListContext.SubjectList.Attach(aggregateRoot);
                _SubjectListContext.Entry(aggregateRoot).State = EntityState.Modified;
            }
            return aggregateRoots.Count();
        }


        private DbContextTransaction _DbContextTransaction = null;
    }
}
