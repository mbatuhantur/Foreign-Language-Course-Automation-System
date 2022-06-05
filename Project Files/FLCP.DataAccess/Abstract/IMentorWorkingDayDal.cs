using FLCP.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.DataAccess.Abstract
{
    public interface IMentorWorkingDayDal:IGenericRepository<MentorWorkingDay>
    {
        List<MentorWorkingDay> GetDaysByMentor(int ID);
    }
}
