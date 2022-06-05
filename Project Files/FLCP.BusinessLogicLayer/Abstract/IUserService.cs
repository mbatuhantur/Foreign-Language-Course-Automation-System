using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        bool LoginControl(int ID, string PhoneNumber);
    }
}
