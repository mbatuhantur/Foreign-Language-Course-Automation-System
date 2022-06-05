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
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Delete(int id)
        {
            _courseDal.Delete(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return  _courseDal.GetAll();
        }

        public List<CourseDto> GetAllCourses()
        {
            return _courseDal.GetAllCourses();
        }

        public List<CourseDto> GetAllCoursesByMentor(int ID)
        {
            return _courseDal.GetAllCoursesByMentor(ID);
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }


        public void Insert(Course course)
        {
            _courseDal.Insert(course);
        }


        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
