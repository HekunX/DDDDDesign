using Domain.BaseModel;
using Domain.BaseModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IRepository<TAggregateRoot>:IUnitOfWork where TAggregateRoot:AggregateRoot
    {
        //增
        int Add(TAggregateRoot aggregateRoot);
        int Add(IEnumerable<TAggregateRoot> aggregateRoots);
        //删
        int Delete(TAggregateRoot aggregateRoot);
        int Delete(IEnumerable<TAggregateRoot> aggregateRoots);
        //改
        int Update(TAggregateRoot aggregateRoot);
        int Update(IEnumerable<TAggregateRoot> aggregateRoots);
        //查
        TAggregateRoot Find(Guid ID);

    }
}
