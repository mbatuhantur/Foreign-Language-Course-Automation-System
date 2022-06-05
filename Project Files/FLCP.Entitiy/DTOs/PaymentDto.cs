using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.Entitiy.DTOs
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public string PaymentTitle { get; set; }
        public string PaymentDescription { get; set; }
        public bool PaymentType { get; set; }
        public bool PaymentStatus { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int NumberOfInstallments { get; set; }
    }
}
