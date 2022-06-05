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
    public class RegionManager : IRegionService
    {
        IRegionDal _regionDal;
        public RegionManager(IRegionDal regionDal)
        {
            _regionDal = regionDal;
        }
        public void Delete(int id)
        {
            _regionDal.Delete(id);
        }

        public IEnumerable<Region> GetAll()
        {
            return _regionDal.GetAll();
        }

        public List<RegionDto> GetAllRegions()
        {
            return _regionDal.GetAllRegions();
        }

        public Region GetById(int id)
        {
           return  _regionDal.GetById(id);
        }

        public void Insert(Region region)
        {
            _regionDal.Insert(region);
        }


        public void Update(Region region)
        {
            _regionDal.Update(region);
        }
    }
}
