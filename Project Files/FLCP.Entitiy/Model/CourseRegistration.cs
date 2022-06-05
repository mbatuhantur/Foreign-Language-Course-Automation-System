using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class CourseRegistration
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public bool? Status { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
