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
    public class ClassroomManager : IClassroomService
    {
        IClassroomDal _classroomDal;
        public ClassroomManager(IClassroomDal classroomDal)
        {
            _classroomDal = classroomDal;
        }
        public void Delete(int id)
        {
            _classroomDal.Delete(id);
        }

        public IEnumerable<Classroom> GetAll()
        {
            return _classroomDal.GetAll();
        }

        public List<ClassroomDto> GetAllClassrooms()
        {
            return _classroomDal.GetAllClassrooms();
        }

        public Classroom GetById(int id)
        {
            return _classroomDal.GetById(id);
        }

        public void Insert(Classroom classroom)
        {
            _classroomDal.Insert(classroom);
        }

        

        public void Update(Classroom classroom)
        {
            _classroomDal.Update(classroom);
        }
    }
}
