using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BaseModel;
using Domain.BaseModel;
using Domain.IRepository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class Repository<TAggregateRoot> : IRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        public readonly EFContext Context;
        public Repository(EFContext Context)
        {
            this.Context = Context;
        }
        public void Add(TAggregateRoot aggregateRoot)
        {
            Context.Set<TAggregateRoot>().Add(aggregateRoot);
        }

        public TAggregateRoot Get(Guid ID)
        {
            return Context.Set<TAggregateRoot>().Find(ID);
        }

        public IEnumerable<TAggregateRoot> GetAll()
        {
            return Context.Set<TAggregateRoot>().ToList();
        }

        public void Remove(TAggregateRoot aggregateRoot)
        {
            Context.Set<TAggregateRoot>().Remove(aggregateRoot);
        }

        public void RemoveAll(IEnumerable<TAggregateRoot> aggregateRoots)
        {
            Context.Set<TAggregateRoot>().RemoveRange(aggregateRoots);
        }

    }
}
