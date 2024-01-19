using System;
using System.Collections.Generic;

namespace Scaffold.Models
{
    public partial class Mountain
    {
        public Mountain()
        {
            Peaks = new HashSet<Peak>();
            CountryCodes = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string MountainRange { get; set; } = null!;

        public virtual ICollection<Peak> Peaks { get; set; }

        public virtual ICollection<Country> CountryCodes { get; set; }
    }
}
