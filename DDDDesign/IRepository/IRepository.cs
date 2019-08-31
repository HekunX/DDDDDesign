using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IRepository<TAggregateRoot> where TAggregateRoot:IAggregateRoot
    {
        IEnumerable<TAggregateRoot> GetAll();
        void RemoveAll(IEnumerable<TAggregateRoot> aggregateRoots);
        TAggregateRoot Get(Guid ID);
        void Add(TAggregateRoot aggregateRoot);
        void Remove(TAggregateRoot aggregateRoot);
    }
}
