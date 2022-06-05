using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class MentorWorkingDay
    {
        public int Id { get; set; }
        public int MentorId { get; set; }
        public int WorkingDayId { get; set; }

        public virtual Mentor Mentor { get; set; }
        public virtual WorkingDay WorkingDay { get; set; }
    }
}
