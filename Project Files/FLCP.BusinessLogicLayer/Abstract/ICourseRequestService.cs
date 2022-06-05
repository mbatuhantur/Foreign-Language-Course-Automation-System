using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Abstract
{
    public interface ICourseRequestService : IGenericService<CourseRequest>
    {
        List<CourseRequestDto> GetAllCourseRequests();
        List<CourseRequestDto> GetCourseRequestByStudentId(int Id);
    }
}
