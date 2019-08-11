using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDesign.IRepository
{
    public interface IUnitOfWork
    {
        bool BeginTransition();
        bool EndTransiton();
        bool Commit();
        bool RollBack();

    }
}
