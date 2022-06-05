using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Abstract
{
    public interface IUserDal:IGenericRepository<User>
    {
        bool LoginControl(int ID, string PhoneNumber);
    }
}
