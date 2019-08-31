using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.BaseModel;
using Domain.BaseModule;
using Domain.IRepository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class Repository<TAggregateRoot> : IRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        EFContext EFContext { get; set; }
        public void Add(TAggregateRoot aggregateRoot)
        {
            EFContext.Set<TAggregateRoot>().Add(aggregateRoot);
        }

        public TAggregateRoot Get(Guid ID)
        {
            return EFContext.Set<TAggregateRoot>().Find(ID);
        }

        public IEnumerable<TAggregateRoot> GetAll()
        {
            return EFContext.Set<TAggregateRoot>().ToList();
        }

        public void Remove(TAggregateRoot aggregateRoot)
        {
            EFContext.Set<TAggregateRoot>().Remove(aggregateRoot);
        }

        public void RemoveAll(IEnumerable<TAggregateRoot> aggregateRoots)
        {
            EFContext.Set<TAggregateRoot>().RemoveRange(aggregateRoots);
        }

    }
}
