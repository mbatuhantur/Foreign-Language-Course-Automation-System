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
    public class EfStudentDal : IStudentDal
    {
        public void Delete(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var deletedStudent = context.Students.Find(id);
                context.Students.Remove(deletedStudent);
                context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Set<Student>().ToList();
            }
        }

        public List<StudentDto> GetAllStudents()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                var students = from c in context.Students
                             select new StudentDto()
                             {
                                 Id = c.Id,
                                 BranchId = c.BranchId,
                                 Name = c.Name,
                                 Surname = c.Surname,
                                 Gender = (int)c.Gender,
                                 BirthDate = (DateTime)c.BirthDate,
                                 PhoneNumber = c.PhoneNumber,
                                 Address = c.Address
                                 
                             };
                return students.ToList();
            }
        }

        public Student GetById(int id)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                return context.Students.Find(id);
            }
        }

        public List<StudentWithCoursesAndPaymentsDto> GetStudentsWithCoursesAndPayments()
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                
                return context.StudentWithCoursesAndPayments.FromSqlRaw("StudentsWithCourseRegistrationsAndPayments").ToList();
            }

        }

        public void Insert(Student student)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }


        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {

                var student = context.Students.Where(x => x.Id == ID && x.PhoneNumber == PhoneNumber);

                if (student != null)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
        }

        public void Update(Student student)
        {
            using (FLC_DBContext context = new FLC_DBContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
        }
    }
}
