using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfUserDal : IUserDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedUser = context.Users.Find(id);
                context.Users.Remove(deletedUser);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<User>().ToList();
            }
        }

        public User GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Users.Find(id);
            }
        }

        public void Insert(User user)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {

                var user = context.Users.Where(x => x.Id == ID && x.Phone == PhoneNumber);

                if (user != null)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        public void Update(User user)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Users.Update(user);
                context.SaveChanges();
            }
        }
    }
}
