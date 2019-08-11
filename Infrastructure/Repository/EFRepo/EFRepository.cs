using Domain.BaseModel;
using Domain.IRepository;
using Infrastructure.DataBaseContext.EFContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.EFRepo
{
    public class EFRepository<TAggregateRoot> : IRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        protected readonly EFContext _EFContext;
        public EFRepository(EFContext eFContext)
        {
            _EFContext = eFContext;
        }


        public int Add(TAggregateRoot aggregateRoot)
        {
            _EFContext.Set<TAggregateRoot>().Add(aggregateRoot);
            return 1;
        }

        public int Add(IEnumerable<TAggregateRoot> aggregateRoots)
        {
            _EFContext.Set<TAggregateRoot>().AddRange(aggregateRoots);
            return aggregateRoots.Count();
        }

        public bool BeginTransition()
        {
            try
            {
                _DbContextTransaction = _EFContext.Database.BeginTransaction();
            }
            catch (Exception e)
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

        public int Delete(TAggregateRoot aggregateRoot)
        {
            _EFContext.Entry(aggregateRoot).State = EntityState.Deleted;
            return 1;
        }

        public int Delete(IEnumerable<TAggregateRoot> aggregateRoots)
        {
            _EFContext.Set<TAggregateRoot>().RemoveRange(aggregateRoots);
            return aggregateRoots.Count();
        }

        public TAggregateRoot Find(Guid ID)
        {
            return _EFContext.Set<TAggregateRoot>().Where(x => x.ID == ID).AsNoTracking().FirstOrDefault();
        }



        public int Update(TAggregateRoot aggregateRoot)
        {
            _EFContext.Set<TAggregateRoot>().Attach(aggregateRoot);
            _EFContext.Entry(aggregateRoot).State = EntityState.Modified;
            return 1;
        }

        public int Update(IEnumerable<TAggregateRoot> aggregateRoots)
        {
            foreach (var aggregateRoot in aggregateRoots)
            {
                _EFContext.Set<TAggregateRoot>().Attach(aggregateRoot);
                _EFContext.Entry(aggregateRoot).State = EntityState.Modified;
            }
            return aggregateRoots.Count();
        }

        public int SaveChanges()
        {
            return _EFContext.SaveChanges();
        }

        private DbContextTransaction _DbContextTransaction = null;
    }
}
