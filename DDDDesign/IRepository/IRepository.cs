using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDesign.IRepository
{
    public interface IRepository<TAggregateRoot>:IUnitOfWork where TAggregateRoot:AggregateRoot
    {
        //增
        int Add(TAggregateRoot aggregateRoot);
        int Add(List<TAggregateRoot> aggregateRoots);
        //删
        int Delete(TAggregateRoot aggregateRoot);
        int Delete(List<TAggregateRoot> aggregateRoots);
        //改
        int Update(TAggregateRoot aggregateRoot);
        int Update(List<TAggregateRoot> aggregateRoots);
        //查
        TAggregateRoot Find(Guid ID);

    }
}
