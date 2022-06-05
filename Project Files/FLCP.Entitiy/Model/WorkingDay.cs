using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class WorkingDay
    {
        public WorkingDay()
        {
            MentorWorkingDays = new HashSet<MentorWorkingDay>();
        }

        public int Id { get; set; }
        public string DayName { get; set; }

        public virtual ICollection<MentorWorkingDay> MentorWorkingDays { get; set; }
    }
}
