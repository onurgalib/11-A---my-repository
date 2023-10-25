namespace ShopRelationsMirrorDB.Models
{
    public class Purpose
    {
        public Purpose()
        {
            Shops = new List<Shop>();
        }
        public Purpose(string name, string description) : this()
        {
            Name = name;
            Description = description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual IList<Shop> Shops { get; set; }
    }


}