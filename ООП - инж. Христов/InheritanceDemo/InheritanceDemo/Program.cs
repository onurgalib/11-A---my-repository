
public class Furniture
{
    public Furniture (double weight, decimal price, string name, Material material, string manufacturer):this(name,price)
    {
        Weight = weight;
        Price = price;
        Name = name;
        Material = Material.Unidentified;
        Manufacturer = manufacturer;
    }
   
    public double Weight { get; set; }
    public decimal Price { get; set; }
    public string Name { get; set; }
    public Material Material { get; set; }
    public string Manufacturer { get; set; }
}
public enum Material
{ Unidentified=0 ,PVC=1, Steel=2, Aluminium=3, Wood=4, Glass=5}


public class Bed:Furniture
   
{
    public Bed(double weight, decimal price, string name, Material material, string manufacturer) : base(weight, price, name, material, manufacturer)
    {    }

    public int Height { get; set; }
    public double Width { get; set; }
    public int UserCount { get; set; }
    public int BedSpecs
}
public class Chair:Furniture
{
    public double Height { get; set; }
    public int CamRotate { get; set; }
    public double WeightSupport { get; set; }
    public Chair (bool camrotate, bool hasSpring, bool hasHandResters)
    { }

    public Chair(double height, int camRotate, double weightSupport, bool hasSpring)
    {
        Height = height;
        CamRotate = camRotate;
        WeightSupport = weightSupport;
        HasSpring = hasSpring;
    }

    public bool HasSpring { get; set; }
}
public enum BedSpec
{
    Mattress,TopMatress,Bords,Nails,Springs
}