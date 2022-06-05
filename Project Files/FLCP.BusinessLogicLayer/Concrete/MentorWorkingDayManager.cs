using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class MentorWorkingDayManager : IMentorWorkingDayService
    {
        IMentorWorkingDayDal _mentorWorkingDayDal;
        public MentorWorkingDayManager(IMentorWorkingDayDal mentorWorkingDayDal)
        {
            _mentorWorkingDayDal = mentorWorkingDayDal;
        }
        public void Delete(int id)
        {
            _mentorWorkingDayDal.Delete(id);
        }

        public IEnumerable<MentorWorkingDay> GetAll()
        {
            return _mentorWorkingDayDal.GetAll();
        }

        public MentorWorkingDay GetById(int id)
        {
            return _mentorWorkingDayDal.GetById(id);
        }

        public List<MentorWorkingDay> GetDaysByMentor(int ID)
        {
            return _mentorWorkingDayDal.GetDaysByMentor(ID);
        }

        public void Insert(MentorWorkingDay mentorWorkingDay)
        {
            _mentorWorkingDayDal.Insert(mentorWorkingDay);
        }

        

        public void Update(MentorWorkingDay mentorWorkingDay)
        {
            _mentorWorkingDayDal.Update(mentorWorkingDay);
        }
    }
}
