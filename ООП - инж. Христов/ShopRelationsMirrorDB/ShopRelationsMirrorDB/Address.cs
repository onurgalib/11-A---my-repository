namespace ShopRelationsMirrorDB.Models
{
    public class Address
    {
        public Address()
        {
            Shops = new List<Shop>();
        }
        public Address(int id, int townName, string streetName, string streetNumber, string description)
        {
            Id = id;
            TownName = townName;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Description = description;
        }

        public int Id { get; set; }
        public int TownName { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string Description { get; set; }

        public virtual IList<Shop> Shops { get; set; }

    }
}