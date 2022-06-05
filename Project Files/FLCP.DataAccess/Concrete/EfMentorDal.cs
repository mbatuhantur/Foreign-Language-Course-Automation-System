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
    public class EfMentorDal : IMentorDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedMentor = context.Mentors.Find(id);
                context.Mentors.Remove(deletedMentor);
                context.SaveChanges();
            }
        }

        public IEnumerable<Mentor> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext ())
            {
                return context.Set<Mentor>().ToList();
            }
        }

        public List<MentorDto> GetAllMentors()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var mentors = from c in context.Mentors
                             select new MentorDto()
                             {
                                 Id = c.Id,
                                 LanguageId = (int)c.LanguageId,
                                 BranchId = (int) c.BranchId,
                                 Name = c.Name,
                                 Surname = c.Surname,
                                 Gender = (int)c.Gender,
                                 BirthDate = (DateTime)c.BirthDate,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address
                             };
                return mentors.ToList();
            }
        }

        public Mentor GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Mentors.Find(id);
            }
        }

        public void Insert(Mentor mentor)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Mentors.Add(mentor);
                context.SaveChanges();
            }
        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {

                var user = context.Mentors.Where(x => x.Id == ID && x.PhoneNumber == PhoneNumber);

                if (user != null)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        public void Update(Mentor mentor)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Mentors.Update(mentor);
                context.SaveChanges();
            }
        }
    }
}
