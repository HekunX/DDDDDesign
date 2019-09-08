using Domain.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain.Model
{
    public partial class Administrator:AggregateRoot
    {
        public string AdminID { get; set; }
        public string Name { get; set; }

    }
    public partial class Administrator
    {
        public static Administrator CreateAdministrator(string AdminID,string Name)
        {
            return new Administrator { AdminID = AdminID, Name = Name };
        }
    }
}
