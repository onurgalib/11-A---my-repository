using Furnitures;
namespace FurnitureStore2
{
    internal class Program
    {
        static void Main()
        {
            FurnitureStore fs = new FurnitureStore();
            Console.WriteLine("Iput Furniture");
            string[] inputArray = Console.ReadLine().Split("-");

            if (inputArray[0] == "Chair")
            {
                //
                //

            }
            else if (inputArray[0] == "Bed")
            {
                //Типa Клас-Price-Name-Material-Manufacturer-Height-Width-BedSpecs
                //“Bed-304.99-Meko Udobno-Wood-Mebeli Videnov-41.5-120-Springs”
                decimal Price = decimal.Parse(inputArray[1]);
                string name = inputArray[2];
                string manufacturer = inputArray[4];
                Material mat = Enum.Parse<Material>(inputArray[3]);
                double height = double.Parse(inputArray[5]);
                double width = double.Parse(inputArray[6]);
                BedSpec bs = Enum.Parse<BedSpec>(inputArray[7]);
                fs.RegisterBed(name, Price, mat, manufacturer, height, width, bs);
            }


        }
    }
}