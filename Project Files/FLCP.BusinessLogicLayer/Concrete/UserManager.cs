using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public void Delete(int id)
        {
            _userDal.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.GetById(id);
        }

        public void Insert(User user)
        {
            _userDal.Insert(user);
        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            bool IsValid = _userDal.LoginControl(ID, PhoneNumber);
            if (IsValid == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public void Update(User user)
        {
            _userDal.Update(user);
        }
    }
}
