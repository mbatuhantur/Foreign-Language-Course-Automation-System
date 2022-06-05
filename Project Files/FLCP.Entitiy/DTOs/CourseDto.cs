using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.Entitiy.DTOs
{
    public class CourseDto
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public int CourseCredit { get; set; }
        public int MentorId { get; set; }
        public int LanguageId { get; set; }
        public int ClassroomId { get; set; }
        public decimal CoursePrice { get; set; }
    }
}
