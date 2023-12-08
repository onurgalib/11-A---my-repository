using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CounterStrike.Contracts;

namespace CounterStrike.Models
{
    public class Terrorist : ITarget
    {
        public IPlayer Player { get; set; }

        public SkinTypeT SkinTypeT { get; set; }

    }
}