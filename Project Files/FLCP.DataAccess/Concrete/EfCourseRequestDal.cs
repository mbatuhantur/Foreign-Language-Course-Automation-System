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
    public class EfCourseRequestDal : ICourseRequestDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedCourseRequest = context.CourseRequests.Find(id);
                context.CourseRequests.Remove(deletedCourseRequest);
                context.SaveChanges();
            }
        }

        public IEnumerable<CourseRequest> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<CourseRequest>().ToList();
            }
        }

        public List<CourseRequestDto> GetAllCourseRequests()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courseRequests = from c in context.CourseRequests
                             select new CourseRequestDto()
                             {
                                 Id = c.Id,
                                 CourseRequestTitle = c.CourseRequestTitle,
                                 CourseRequestDescription = c.CourseRequestDescription,
                                 StudentId = c.StudentId,
                                 
                             };
                return courseRequests.ToList();
            }
        }

        public CourseRequest GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.CourseRequests.Find(id);
            }
        }

        public List<CourseRequestDto> GetCourseRequestByStudentId(int Id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courseRequests = from c in context.CourseRequests
                                     select new CourseRequestDto()
                                     {
                                         Id = c.Id,
                                         CourseRequestTitle = c.CourseRequestTitle,
                                         CourseRequestDescription = c.CourseRequestDescription,
                                         StudentId = c.StudentId,

                                     };
                return courseRequests.Where(x => x.StudentId == Id).ToList();
            }
        }

        public void Insert(CourseRequest courseRequest)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.CourseRequests.Add(courseRequest);
                context.SaveChanges();
            }
        }


        public void Update(CourseRequest courseRequest)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.CourseRequests.Update(courseRequest);
                context.SaveChanges();
            }
        }
    }
}
