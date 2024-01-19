using System;
using System.Collections.Generic;

namespace Scaffold.Models
{
    public partial class Country
    {
        public Country()
        {
            Mountains = new HashSet<Mountain>();
            Rivers = new HashSet<River>();
        }

        public string CountryCode { get; set; } = null!;
        public string IsoCode { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public string? CurrencyCode { get; set; }
        public string ContinentCode { get; set; } = null!;
        public int Population { get; set; }
        public int AreaInSqKm { get; set; }
        public string Capital { get; set; } = null!;

        public virtual Continent ContinentCodeNavigation { get; set; } = null!;
        public virtual Currency? CurrencyCodeNavigation { get; set; }

        public virtual ICollection<Mountain> Mountains { get; set; }
        public virtual ICollection<River> Rivers { get; set; }
    }
}
