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
    public class CourseRegistrationManager : ICourseRegistrationService
    {
        ICourseRegistrationDal _courseRegistrationDal;
        public CourseRegistrationManager(ICourseRegistrationDal courseRegistrationDal)
        {
            _courseRegistrationDal = courseRegistrationDal;
        }
        public void Delete(int id)
        {
            _courseRegistrationDal.Delete(id);
        }

        public IEnumerable<CourseRegistration> GetAll()
        {
            return _courseRegistrationDal.GetAll();
        }

        public List<CourseRegistrationDto> GetAllCourseRegistration()
        {
            return _courseRegistrationDal.GetAllCourseRegistration();
        }

        public CourseRegistration GetById(int id)
        {
            return _courseRegistrationDal.GetById(id);
        }

        public List<CourseRegistrationDto> GetCoursesByStudentId(int Id)
        {
            return _courseRegistrationDal.GetCoursesByStudentId(Id);
        }

        public void Insert(CourseRegistration courseRegistration)
        {
            _courseRegistrationDal.Insert(courseRegistration);
        }

        

        public void Update(CourseRegistration courseRegistration)
        {
            _courseRegistrationDal.Update(courseRegistration);
            
        }
    }
}
