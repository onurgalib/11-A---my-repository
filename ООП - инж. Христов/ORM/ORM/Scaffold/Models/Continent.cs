using System;
using System.Collections.Generic;

namespace Scaffold.Models
{
    public partial class Continent
    {
        public Continent()
        {
            Countries = new HashSet<Country>();
        }

        public string ContinentCode { get; set; } = null!;
        public string ContinentName { get; set; } = null!;

        public virtual ICollection<Country> Countries { get; set; }
    }
}
