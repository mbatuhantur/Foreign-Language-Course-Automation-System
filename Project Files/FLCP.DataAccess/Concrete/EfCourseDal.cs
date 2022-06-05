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
    public class EfCourseDal : ICourseDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedCourse = context.Courses.Find(id);
                context.Courses.Remove(deletedCourse);
                context.SaveChanges();
            }
        }

        public IEnumerable<Course> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Course>().ToList();
            }
        }

        public List<CourseDto> GetAllCourses()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courses = from c in context.Courses
                              select new CourseDto()
                              {
                                  Id = c.Id,
                                  CourseCode = c.CourseCode,
                                  CourseCredit = (int)c.CourseCredit,
                                  MentorId = c.MentorId,
                                  LanguageId = c.LanguageId,
                                  ClassroomId = c.ClassroomId,
                                  CoursePrice = (decimal)c.CoursePrice
                              };
                return courses.ToList();
            }
        }

        public List<CourseDto> GetAllCoursesByMentor(int ID)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var courses = from c in context.Courses
                              select new CourseDto()
                              {
                                  Id = c.Id,
                                  CourseCode = c.CourseCode,
                                  CourseCredit = (int)c.CourseCredit,
                                  LanguageId = c.LanguageId,
                                  ClassroomId = c.ClassroomId,
                                  MentorId = c.MentorId
                                  
                              };
                return courses.Where(x => x.MentorId == ID).ToList();
            }
        }

        public Course GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Courses.Find(id);
            }
        }

        

        public void Insert(Course course)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        

        public void Update(Course course)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Courses.Update(course);
                context.SaveChanges();
            }
        }
    }
}
