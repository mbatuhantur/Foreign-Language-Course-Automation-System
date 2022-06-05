using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Student
    {
        public Student()
        {
            CourseRegistrations = new HashSet<CourseRegistration>();
            CourseRequests = new HashSet<CourseRequest>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual ICollection<CourseRegistration> CourseRegistrations { get; set; }
        public virtual ICollection<CourseRequest> CourseRequests { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
