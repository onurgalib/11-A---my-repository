namespace ShopRelationsMirrorDB.Models
{
    public class Shop
    {
        public Shop(int id, string name, int startHour, int endHour, int adressId, Address address, int purposeId, Purpose purpose)
        {
            Id = id;
            Name = name;
            StartHour = startHour;
            EndHour = endHour;
            AdressId = adressId;
            Address = address;
            PurposeId = purposeId;
            Purpose = purpose;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int StartHour {  get; set; }
        public int EndHour { get; set; }

        public int AdressId { get; set; }
        public virtual Address Address { get; set; }

        public int PurposeId {  get; set; }
        public virtual Purpose Purpose { get; set; }
    public virtual IList<PersonShop> ShopPeople { get; set; }
    }


}