using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models.Weapons.Snipers
{
    public class Scout : FireWeapon
    {
        public double ZoomRate { get; set; }
        public Scout() : base("SSG 08", 10, 7.62, false, 4.5, 50, 30, 0.72)
        {
            ZoomRate = 2.2;
        }
    }
}