using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.Entitiy.DTOs
{
    public class CourseRequestDto
    {
        public int Id { get; set; }
        public string CourseRequestTitle { get; set; }
        public string CourseRequestDescription { get; set; }
        public int StudentId { get; set; }
    }
}
