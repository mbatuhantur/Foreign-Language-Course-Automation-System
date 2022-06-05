using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Mentor
    {
        public Mentor()
        {
            Courses = new HashSet<Course>();
            MentorWorkingDays = new HashSet<MentorWorkingDay>();
        }

        public int Id { get; set; }
        public int? LanguageId { get; set; }
        public int? BranchId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Language Language { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<MentorWorkingDay> MentorWorkingDays { get; set; }
    }
}
