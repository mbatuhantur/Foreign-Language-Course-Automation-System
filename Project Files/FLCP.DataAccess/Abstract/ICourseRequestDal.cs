using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Abstract
{
    public interface ICourseRequestDal:IGenericRepository<CourseRequest>
    {
        List<CourseRequestDto> GetAllCourseRequests();
        List<CourseRequestDto> GetCourseRequestByStudentId(int Id);
    }
}
