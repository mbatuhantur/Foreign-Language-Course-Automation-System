using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Course
    {
        public Course()
        {
            CourseRegistrations = new HashSet<CourseRegistration>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string CourseCode { get; set; }
        public int? CourseCredit { get; set; }
        public int MentorId { get; set; }
        public int LanguageId { get; set; }
        public int ClassroomId { get; set; }
        public decimal? CoursePrice { get; set; }

        public virtual Classroom Classroom { get; set; }
        public virtual Language Language { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual ICollection<CourseRegistration> CourseRegistrations { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
