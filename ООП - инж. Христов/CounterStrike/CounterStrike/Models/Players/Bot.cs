using CounterStrike.Contracts;

namespace CounterStrike.Models
{
    public class Bot : IPlayer
    {
        public Bot(int id, string userName, SkillRank skillRank)
        {
            Id = id;
            UserName = userName;
            SkillRank = skillRank;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public SkillRank SkillRank { get; set; } = SkillRank.Easy;
    }

}