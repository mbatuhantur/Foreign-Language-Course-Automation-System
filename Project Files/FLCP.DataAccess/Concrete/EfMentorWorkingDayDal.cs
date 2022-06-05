using FLCP.DataAccess.Abstract;
using FLCP.DataAccess.Model;
using FLCP.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Concrete
{
    public class EfMentorWorkingDayDal : IMentorWorkingDayDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedMentorWorkingDay = context.MentorWorkingDays.Find(id);
                context.MentorWorkingDays.Remove(deletedMentorWorkingDay);
                context.SaveChanges();
            }
        }

        public IEnumerable<MentorWorkingDay> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<MentorWorkingDay>().ToList();
            }
        }

        public MentorWorkingDay GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.MentorWorkingDays.Find(id);
            }
        }

        public List<MentorWorkingDay> GetDaysByMentor(int ID)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<MentorWorkingDay>().Where(x => x.MentorId == ID).ToList();
               
                           
            }
        }

        public void Insert(MentorWorkingDay mentorWorkingDay)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.MentorWorkingDays.Add(mentorWorkingDay);
                context.SaveChanges();
            }
        }


        public void Update(MentorWorkingDay mentorWorkingDay)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.MentorWorkingDays.Update(mentorWorkingDay);
                context.SaveChanges();
            }
        }
    }
}
