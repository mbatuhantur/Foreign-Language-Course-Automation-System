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
    public class EfClassroomDal : IClassroomDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedClassroom = context.Classrooms.Find(id);
                context.Classrooms.Remove(deletedClassroom);
                context.SaveChanges();
            }
        }

        public IEnumerable<Classroom> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Classroom>().ToList();
            }
        }

        public List<ClassroomDto> GetAllClassrooms()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var classrooms = from c in context.Classrooms
                             select new ClassroomDto()
                             {
                                 Id = c.Id,
                                 ClassroomName = c.ClassroomName,
                                 BranchId = (int)c.BranchId
                             };
                return classrooms.ToList();
            }
        }

        public Classroom GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Classrooms.Find(id);
            }
        }

        public void Insert(Classroom classroom)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Classrooms.Add(classroom);
                context.SaveChanges();
            }
        }
        
        public void Update(Classroom classroom)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Classrooms.Update(classroom);
                context.SaveChanges();
            }
        }
    }
}
