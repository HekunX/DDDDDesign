using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IUnitOfWork
    {
        bool BeginTransition();

        bool Commit();
        bool RollBack();

        int SaveChanges();

    }
}
