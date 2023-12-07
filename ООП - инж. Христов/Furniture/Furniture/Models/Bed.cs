namespace Furnitures
{
    public class Bed : Furniture
    {
        public Bed(string name, decimal price, double h, double width, double length, BedSpec bs)
            : base(name, price, "Kuncho-EOOD", Material.Wood)
        {
            Height = h;
            Width = width;
            Lenght = length;
            BedSpec = bs;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public double Lenght { get; set; }

        public int UsersCount
        {
            get
            {
                if (Width <= 90)
                {
                    return 1;
                }
                else if (Width <= 150)
                {
                    return 2;
                }
                return 0;
            }
        }

        public int UsersCount2 => Width <= 90 ? 1 : Width <= 150 ? 2 : 0;

        public BedSpec BedSpec { get; set; }
    }
}