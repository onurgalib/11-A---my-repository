using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models.Weapons.Snipers
{
    public class AWP : FireWeapon
    {
        public double ZoomRate { get; set; }

        public AWP() : base("Magnum Sniper Rifle", 5, 8.6, false, 6.9, 41, 30, 1)
        {
            ZoomRate = 3;
        }
    }
}