using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLCP.Entitiy.DTOs
{
    public class BranchDto
    {
        public int Id { get; set; }
        public string BranchName { get; set; }
        public string BranchPhone { get; set; }
        public string BranchAdress { get; set; }
        public int CityId { get; set; }
    }
}
