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
    public class EfCourseRegitrationDal : ICourseRegistrationDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var CourseRegistration = context.CourseRegistrations.Find(id);
                context.CourseRegistrations.Remove(CourseRegistration);
                context.SaveChanges();
            }
        }

        public IEnumerable<CourseRegistration> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<CourseRegistration>().ToList();
            }
        }

        public List<CourseRegistrationDto> GetAllCourseRegistration()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courseRegistrations = from c in context.CourseRegistrations
                             select new CourseRegistrationDto()
                             {
                                 Id = c.Id,
                                 CourseId = c.CourseId,
                                 StudentId = c.StudentId,
                                 Status = (bool)c.Status,
                                 
                             };
                return courseRegistrations.ToList();
            }
        }

        public CourseRegistration GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.CourseRegistrations.Find(id);
            }
        }

        public List<CourseRegistrationDto> GetCoursesByStudentId(int Id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courseRegistrations = from c in context.CourseRegistrations
                                          select new CourseRegistrationDto()
                                          {
                                              Id = c.Id,
                                              CourseId = c.CourseId,
                                              StudentId = c.StudentId,
                                              Status = (bool)c.Status,

                                          };
                return courseRegistrations.Where(x => x.StudentId == Id).ToList();
            }
        }

        public void Insert(CourseRegistration courseRegistration)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.CourseRegistrations.Add(courseRegistration);
                context.SaveChanges();
            }
        }

        

        public void Update(CourseRegistration courseRegistration)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.CourseRegistrations.Update(courseRegistration);
                context.SaveChanges();
            }
        }
    }
}
