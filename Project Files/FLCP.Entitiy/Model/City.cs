using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class City
    {
        public City()
        {
            Branches = new HashSet<Branch>();
        }

        public int Id { get; set; }
        public string CirtyName { get; set; }
        public int? RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
