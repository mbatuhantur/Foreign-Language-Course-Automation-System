using FLCP.BusinessLogicLayer.Abstract;
using FLCP.DataAccess.Abstract;
using FLCP.Entitiy.DTOs;
using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.BusinessLogicLayer.Concrete
{
    public class MentorManager : IMentorService
    {
        IMentorDal _mentorDal;
        public MentorManager(IMentorDal mentorDal)
        {
            _mentorDal = mentorDal;
        }
        public void Delete(int id)
        {
            _mentorDal.Delete(id);
        }

        public IEnumerable<Mentor> GetAll()
        {
           return  _mentorDal.GetAll();
        }

        public List<MentorDto> GetAllMentors()
        {
            return _mentorDal.GetAllMentors();
        }

        public Mentor GetById(int id)
        {
            return _mentorDal.GetById(id);
        }

        public void Insert(Mentor mentor)
        {
            _mentorDal.Insert(mentor);
        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            bool a = _mentorDal.LoginControl(ID, PhoneNumber);
            if (a == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Update(Mentor mentor)
        {
            _mentorDal.Update(mentor);
        }
    }
}
