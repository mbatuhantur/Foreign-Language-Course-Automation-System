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
    public class CourseRequestManager : ICourseRequestService
    {
        ICourseRequestDal _courseRequestDal;
        public CourseRequestManager(ICourseRequestDal courseRequestDal)
        {
            _courseRequestDal = courseRequestDal;
        }
        public void Delete(int id)
        {
            _courseRequestDal.Delete(id);
        }

        public IEnumerable<CourseRequest> GetAll()
        {
            return _courseRequestDal.GetAll();
        }

        public List<CourseRequestDto> GetAllCourseRequests()
        {
            return _courseRequestDal.GetAllCourseRequests();
        }

        public CourseRequest GetById(int id)
        {
            return _courseRequestDal.GetById(id);
        }

        public List<CourseRequestDto> GetCourseRequestByStudentId(int Id)
        {
            return _courseRequestDal.GetCourseRequestByStudentId(Id);
        }

        public void Insert(CourseRequest courseRequest)
        {
            _courseRequestDal.Insert(courseRequest);
        }

        

        public void Update(CourseRequest courseRequest)
        {
            _courseRequestDal.Update(courseRequest);
        }
    }
}
