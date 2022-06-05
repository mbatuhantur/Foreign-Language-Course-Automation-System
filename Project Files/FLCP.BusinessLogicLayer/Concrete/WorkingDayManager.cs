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
    public class WorkingDayManager : IWorkingDayService
    {
        IWorkingDayDal _workingDayDal;
        public WorkingDayManager(IWorkingDayDal workingDayDal)
        {
            _workingDayDal = workingDayDal;
        }
        public void Delete(int id)
        {
            _workingDayDal.Delete(id);
        }

        public IEnumerable<WorkingDay> GetAll()
        {
            return _workingDayDal.GetAll();
        }

        public List<WorkingDayDto> GetAllWorkingDays()
        {
            return _workingDayDal.GetAllWorkingDays();
        }

        public WorkingDay GetById(int id)
        {
            return _workingDayDal.GetById(id);
        }

        public void Insert(WorkingDay workingDay)
        {
            _workingDayDal.Insert(workingDay);
        }

        

        public void Update(WorkingDay workingDay)
        {
            _workingDayDal.Update(workingDay);
        }
    }
}
