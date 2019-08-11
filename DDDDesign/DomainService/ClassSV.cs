using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.IRepository;
using Domain.Model;

namespace Domain.DomainService
{
    public class ClassSV
    {
        private readonly IClassRepository _IClassRepository;

        public ClassSV(IClassRepository classRepository)
        {
            _IClassRepository = classRepository;
        }

        public bool AddClass(Class @class)
        {
            _IClassRepository.Add(@class);
            return _IClassRepository.SaveChanges() > 0;
        }

        public bool DeleteClass(Guid ID)
        {
            //var @class = _IClassRepository.Find(ID);
            //if (@class != null)
            //{
            //    _IClassRepository.Delete(@class);
            //    _IClassRepository.SaveChanges();
            //    return true;
            //}
            //else return false;

            _IClassRepository.Delete(new Class { ID = ID});
            _IClassRepository.SaveChanges();
            return true;

        }

        public bool UpdateClass(Class @class)
        {
            _IClassRepository.Update(@class);
            _IClassRepository.SaveChanges();
            return true;
        }

        public Class GetClass(Guid ID )
        {
            return _IClassRepository.Find(ID);
        }

    }
}
