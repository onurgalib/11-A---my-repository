using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models.Weapons.Pistols
{
    public class CZAuto : FireWeapon
    {
        public CZAuto() : base("MG CZ 75 Full Auto", 25, 9, true, 1.1, 1000, 18, 0.2)
        { }
    }
}