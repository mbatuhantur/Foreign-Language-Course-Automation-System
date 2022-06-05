using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfCityDal : ICityDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedCity = context.Cities.Find(id);
                context.Cities.Remove(deletedCity);
                context.SaveChanges();
            }
        }

        public IEnumerable<City> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<City>();
            }
        }

        public List<CityDto> GetAllCities()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var cities = from c in context.Cities
                             select new CityDto()
                             {
                                 Id = c.Id,
                                 CirtyName = c.CirtyName,
                                 RegionId = (int)c.RegionId
                                 
                             };
                return cities.ToList();
            }
        }

        public City GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Cities.Find(id);
            }
        }

        public void Insert(City city)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Cities.Add(city);
                context.SaveChanges();
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(City city)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Cities.Update(city);
                context.SaveChanges();
            }
        }
    }
}
