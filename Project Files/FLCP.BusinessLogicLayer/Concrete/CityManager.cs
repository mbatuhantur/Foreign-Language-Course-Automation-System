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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public void Delete(int id)
        {
            _cityDal.Delete(id);
        }

        public IEnumerable<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public List<CityDto> GetAllCities()
        {
            return _cityDal.GetAllCities();
        }

        public City GetById(int id)
        {
            return _cityDal.GetById(id);
        }

        public void Insert(City city)
        {
            _cityDal.Insert(city);
        }

        

        public void Update(City city)
        {
            _cityDal.Update(city);
        }
    }
}
