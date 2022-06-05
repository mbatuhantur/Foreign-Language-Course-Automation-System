using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Classroom
    {
        public Classroom()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string ClassroomName { get; set; }
        public int? BranchId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
