using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Language
    {
        public Language()
        {
            Courses = new HashSet<Course>();
            Mentors = new HashSet<Mentor>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Mentor> Mentors { get; set; }
    }
}
