using System;
using System.Collections.Generic;

namespace Scaffold.Models
{
    public partial class Currency
    {
        public Currency()
        {
            Countries = new HashSet<Country>();
        }

        public string CurrencyCode { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Country> Countries { get; set; }
    }
}
