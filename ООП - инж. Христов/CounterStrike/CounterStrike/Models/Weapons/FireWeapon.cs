using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike.Models
{
    public abstract class FireWeapon : IWeapon
    {
        protected FireWeapon(string name, int bulletCount, double rountSize, bool supportAutomaticFire, double weight, int rateOfFirePerMinte, int reloadTimeInSecondsAverage, double dammageRate)
        {
            Name = name;
            BulletCount = bulletCount;
            RountSize = rountSize;
            SupportAutomaticFire = supportAutomaticFire;
            Weight = weight;
            RateOfFirePerMinte = rateOfFirePerMinte;
            ReloadTimeInSecondsAverage = reloadTimeInSecondsAverage;
            DammageRate = dammageRate;
        }

        public string Name { get; set; }
        public int BulletCount { get; set; }
        public double RountSize { get; set; }
        public bool SupportAutomaticFire { get; set; } = false;
        public double Weight { get; set; }
        public int RateOfFirePerMinte { get; set; }
        public int ReloadTimeInSecondsAverage { get; set; }
        public double DammageRate { get; set; }
    }
}