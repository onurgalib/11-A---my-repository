namespace Furnitures
{
    public class Furniture
    {
        public int Id { get; set; }
        public Furniture(string name, decimal price)
        {
            Name = name;
            Price = price;
            Weight = 0;
            Manufacturer = "StoreShop";
            Material = Material.Unidentified;
        }

        public Furniture(string name, decimal price, string manufacturer, Material material) : this(name, price)
        {
            Manufacturer = manufacturer;
            Material = material;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public double Weight { get; set; }
        public string Manufacturer { get; set; }
        public Material Material { get; set; }
    }
}