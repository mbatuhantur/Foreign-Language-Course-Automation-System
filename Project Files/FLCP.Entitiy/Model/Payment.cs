using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Payment
    {
        public int Id { get; set; }
        public string PaymentTitle { get; set; }
        public string PaymentDescription { get; set; }
        public bool? PaymentType { get; set; }
        public bool? PaymentStatus { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int? NumberOfInstallments { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
