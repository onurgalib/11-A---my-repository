using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models
{
    public class Deagle : FireWeapon
    {
        public Deagle() : base("Desert Eagle", 7, 12.7, false, 1.95, 7, 20, 0.3)
        { }
    }
}