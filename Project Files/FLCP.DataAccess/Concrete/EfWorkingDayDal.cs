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
    public class EfWorkingDayDal : IWorkingDayDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedWorkingDay = context.WorkingDays.Find(id);
                context.WorkingDays.Remove(deletedWorkingDay);
                context.SaveChanges();
            }
        }

        public IEnumerable<WorkingDay> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<WorkingDay>().ToList();
            }
        }

        public List<WorkingDayDto> GetAllWorkingDays()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var workingDays = from c in context.WorkingDays
                             select new WorkingDayDto()
                             {
                                 Id = c.Id,
                                 DayName = c.DayName
                             };
                return workingDays.ToList();
            }
        }

        public WorkingDay GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.WorkingDays.Find(id);
            }
        }


        public void Insert(WorkingDay workingDay)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.WorkingDays.Add(workingDay);
                context.SaveChanges();
            }
        }


        public void Update(WorkingDay workingDay)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.WorkingDays.Update(workingDay);
                context.SaveChanges();
            }
        }
    }
}
