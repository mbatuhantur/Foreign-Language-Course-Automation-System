using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class CourseRequest
    {
        public int Id { get; set; }
        public string CourseRequestTitle { get; set; }
        public string CourseRequestDescription { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
