using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;
        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }
        public void Delete(int id)
        {
            _branchDal.Delete(id);
        }

        public IEnumerable<Branch> GetAll()
        {
            return _branchDal.GetAll();
        }

        public List<BranchDto> GetAllBranches()
        {
            return _branchDal.GetAllBranches();
        }

        public Branch GetById(int id)
        {
           return  _branchDal.GetById(id);
        }

        public void Insert(Branch branch)
        {
            _branchDal.Insert(branch);
        }


        public void Update(Branch branch)
        {
            _branchDal.Update(branch);
        }
    }
}
