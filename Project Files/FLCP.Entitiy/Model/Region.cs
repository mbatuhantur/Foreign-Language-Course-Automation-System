using System;
using System.Collections.Generic;

#nullable disable

namespace FLCP.Entity.Model
{
    public partial class Region
    {
        public Region()
        {
            Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
