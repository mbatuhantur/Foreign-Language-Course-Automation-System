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
    public class StudentManager : IStudentService
    {
        IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }
        public void Delete(int id)
        {
            _studentDal.Delete(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public List<StudentDto> GetAllStudents()
        {
            return _studentDal.GetAllStudents();
        }

        public Student GetById(int id)
        {
            return _studentDal.GetById(id);
        }

        public List<StudentWithCoursesAndPaymentsDto> GetStudentsWithCoursesAndPayments()
        {
            return _studentDal.GetStudentsWithCoursesAndPayments();
        }

        public void Insert(Student student)
        {
            _studentDal.Insert(student);
        }

        public bool LoginControl(int ID, string PhoneNumber)
        {
            bool a =   _studentDal.LoginControl(ID, PhoneNumber);
            if (a == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        
    }
}
