using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.Entitiy.DTOs
{
    public class StudentWithCoursesAndPaymentsDto
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }
        public decimal CoursePrice { get; set; }
        public string BranchName { get; set; }
        public string RegionName { get; set; }
        public bool PaymentType { get; set; }
        public bool PaymentStatus { get; set; }
        public int NumberOfInstallments { get; set; }

    }
}
