using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Branch
    {
        public Branch()
        {
            Classrooms = new HashSet<Classroom>();
            Mentors = new HashSet<Mentor>();
            Students = new HashSet<Student>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string BranchName { get; set; }
        public string BranchPhone { get; set; }
        public string BranchAdress { get; set; }
        public int? CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Classroom> Classrooms { get; set; }
        public virtual ICollection<Mentor> Mentors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
