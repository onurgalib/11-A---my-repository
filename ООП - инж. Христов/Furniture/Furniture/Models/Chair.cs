namespace Furnitures
{
    public class Chair : Furniture
    {
        public Chair(string name, decimal price, double h) : base(name, price)
        {
            Height = h;
        }

        public Chair(string name, decimal price, double weight, string manufacturer, Material material, double h) : base(name, price, manufacturer, material)
        {
            Height = h;
        }
        public double Height { get; set; }
        public bool CanRotate { get; set; } = false;
        public bool HasSpring { get; set; } = false;
        public bool HasHandlers { get; set; } = false;
        public double WeightSupport { get; set; } = 120;
    }

}