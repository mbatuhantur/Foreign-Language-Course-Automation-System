using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Abstract
{
    public interface ICourseService : IGenericService<Course>
    {
        List<CourseDto> GetAllCourses();
        List<CourseDto> GetAllCoursesByMentor(int ID);
    }
}
