using System;
using System.Collections.Generic;

namespace Scaffold.Models
{
    public partial class River
    {
        public River()
        {
            CountryCodes = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string RiverName { get; set; } = null!;
        public int Length { get; set; }
        public int DrainageArea { get; set; }
        public int AverageDischarge { get; set; }
        public string Outflow { get; set; } = null!;

        public virtual ICollection<Country> CountryCodes { get; set; }
    }
}
