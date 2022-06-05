using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfBranchDal : IBranchDal
    {
        
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedBranch = context.Branches.Find(id);
                context.Branches.Remove(deletedBranch);
                context.SaveChanges();
            }
        }

        public IEnumerable<Branch> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Branch>().ToList();
            }
        }

        public List<BranchDto> GetAllBranches()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var cities = from c in context.Branches
                             select new BranchDto()
                             {
                                 Id = c.Id,
                                 BranchName = c.BranchName,
                                 BranchPhone = c.BranchPhone,
                                 BranchAdress = c.BranchAdress,
                                 CityId = (int)c.CityId
                             };
                return cities.ToList();
            }
            
        }

       

        public Branch GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Branches.Find(id);
            }
        }

        public void Insert(Branch branch)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Branches.Add(branch);
                context.SaveChanges();
            }
        }

        public void Update(Branch branch)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Branches.Update(branch);
                context.SaveChanges();
            }
        }
    }
}
