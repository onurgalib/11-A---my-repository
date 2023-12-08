using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models
{
    public class Knife : IWeapon
    {
        public Knife()
        {
            Name = "Military Knife";
            DammageRate = 0.4;
            WeightKg = 0.8;
            BladeLengthCm = 18.6;
        }
        public string Name { get; }
        public double DammageRate { get; }
        public double WeightKg { get; }
        public double BladeLengthCm { get; }
    }
}