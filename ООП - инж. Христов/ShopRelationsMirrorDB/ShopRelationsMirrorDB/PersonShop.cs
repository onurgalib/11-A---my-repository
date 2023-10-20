namespace ShopRelationsMirrorDB.Models
{
    public class PersonShop
    {
        public string PersonId { get; set; }
        public virtual Person Person { get; set; }

        public string ShopId { get; set; }
        public virtual Shop Shop { get; set; }
    }
}