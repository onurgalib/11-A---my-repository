using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models.Weapons.ColdWeapons
{
    public class Bat
    {
        public Bat()
        {
            Name = "BaseBall Bat";
            DammageRate = 0.3;
            WeightKg = 2.8;
            LengthCm = 56.3;
        }

        public string Name { get; }
        public double DammageRate { get; }
        public double WeightKg { get; }
        public double LengthCm { get; }
    }
}