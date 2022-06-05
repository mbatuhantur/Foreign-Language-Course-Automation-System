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
    public class EfRegionDal : IRegionDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedRegion = context.Regions.Find(id);
                context.Regions.Remove(deletedRegion);
                context.SaveChanges();
            }
        }

        public IEnumerable<Region> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Region>().ToList();
            }
        }

        public List<RegionDto> GetAllRegions()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var regions = from c in context.Regions
                             select new RegionDto()
                             {
                                 Id = c.Id,
                                 RegionName = c.RegionName
                             };
                return regions.ToList();
            }
        }

        public Region GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Regions.Find(id);
            }
        }

        public void Insert(Region region)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Regions.Add(region);
                context.SaveChanges();
            }
        }


        public void Update(Region region)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Regions.Update(region);
                context.SaveChanges();
            }
        }
    }
}
