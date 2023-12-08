using CounterStrike.Contracts;

namespace CounterStrike.Models
{
    public class CounterTerrorist : ITarget
    {
        public IPlayer Player { get; set; }
        public SkinTypeC SkinTypeT { get; set; }
        public IWeapon MainWeapon { get; set; }
        public List<IWeapon> Weapons { get; set; }

    }
}