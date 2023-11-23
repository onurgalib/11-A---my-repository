using System;
using System.Collections.Generic;


namespace InheritanceExample
{
// Абстрактен клас Furniture
public abstract class Furniture
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Material Material { get; set; }
        public string Manufacturer { get; set; }
    }

    // Енумерация за материали
    public enum Material
    {
        Wood,
        Steel,
        Plastic
    }

    // Клас за легло
    public class Bed : Furniture
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public BedSpecs BedType { get; set; }
    }

    // Енумерация за типове на леглата
    public enum BedSpecs
    {
        Springs,
        Foam
    }

    // Клас за стол
    public class Chair : Furniture
    {
        public double Height { get; set; }
        public bool CanRotate { get; set; }
        public bool HasSpring { get; set; }
        public bool HasHandlers { get; set; }
        public double WeightSupport { get; set; }
    }

    // Клас за мебелен магазин
    public class FurnitureStore
    {
        private List<Furniture> furnitureList = new List<Furniture>();

        // Метод за регистриране на стол
        public void RegisterChair(string name, decimal price, Material mat, string manufacturer, double height, bool canRotate, bool hasSpring, bool hasHandlers, double weightSupport)
        {
            CheckForDuplicate(name);
            Chair chair = new Chair
            {
                Name = name,
                Price = price,
                Material = mat,
                Manufacturer = manufacturer,
                Height = height,
                CanRotate = canRotate,
                HasSpring = hasSpring,
                HasHandlers = hasHandlers,
                WeightSupport = weightSupport
            };
            furnitureList.Add(chair);
        }

        // Метод за регистриране на легло
        public void RegisterBed(string name, decimal price, Material mat, string manufacturer, double height, double width, BedSpecs bedType)
        {
            CheckForDuplicate(name);
            Bed bed = new Bed
            {
                Name = name,
                Price = price,
                Material = mat,
                Manufacturer = manufacturer,
                Height = height,
                Width = width,
                BedType = bedType
            };
            furnitureList.Add(bed);
        }

        // Метод за вземане на мебел по име
        public Furniture GetFurnitureByName(string name)
        {
            Furniture furniture = furnitureList.Find(f => f.Name == name);
            if (furniture == null)
            {
                throw new NotFoundProductException($"Product {name} is not found in our database!");
            }
            return furniture;
        }

        // Метод за брой столове
        public int CountOfChairs()
        {
            return furnitureList.FindAll(f => f is Chair).Count;
        }

        // Метод за брой легла
        public int CountOfBeds()
        {
            return furnitureList.FindAll(f => f is Bed).Count;
        }

        // Метод за изписване на имената на столовете
        public void PrintChairsNames()
        {
            List<string> chairNames = furnitureList.FindAll(f => f is Chair).ConvertAll(f => f.Name);
            Console.WriteLine(string.Join(", ", chairNames));
        }

        // Метод за изписване на имената на леглата
        public void PrintBedNames()
        {
            List<string> bedNames = furnitureList.FindAll(f => f is Bed).ConvertAll(f => f.Name);
            foreach (var bedName in bedNames)
            {
                Console.WriteLine(bedName);
            }
        }

        // Проверка за дублиран продукт
        private void CheckForDuplicate(string name)
        {
            if (furnitureList.Exists(f => f.Name == name))
            {
                throw new DuplicatingProductException($"Product {name} already exists in database!");
            }
        }
    }

    // Изключение за дублиран продукт
    public class DuplicatingProductException : ApplicationException
    {
        public DuplicatingProductException(string message) : base(message)
        {        }
    }

    // Изключение за липсващ продукт
    public class NotFoundProductException : ApplicationException
    {
        public NotFoundProductException(string message) : base(message)
        {        }
    }

    class Program
    {
        static void Main()
        {
            FurnitureStore furnitureStore = new FurnitureStore();

            Console.WriteLine("Input Furniture");

            string input;
            do
            {
                Console.WriteLine("Enter a furniture item or type 'END' to finish:");
                input = Console.ReadLine();

                if (input != "END")
                {
                    try
                    {
                        ParseAndRegisterFurniture(furnitureStore, input);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            } while (input != "END");

            Console.WriteLine("Welcome to Our Furniture Store");

            do
            {
                Console.WriteLine("Enter a command ('END' to exit):");
                input = Console.ReadLine();

                if (input != "END")
                {
                    ProcessCommand(furnitureStore, input);
                }

            } while (input != "END");
        }

        static void ParseAndRegisterFurniture(FurnitureStore furnitureStore, string input)
        {
            string[] tokens = input.Split('-');
            string type = tokens[0];
            decimal price = decimal.Parse(tokens[1]);
            string name = tokens[2];
            Material material = Enum.Parse<Material>(tokens[3]);
            string manufacturer = tokens[4];

            if (type == "Chair")
            {
                double height = double.Parse(tokens[5]);
                bool canRotate = bool.Parse(tokens[6]);
                bool hasSpring = bool.Parse(tokens[7]);
                bool hasHandlers = bool.Parse(tokens[8]);
                double weightSupport = double.Parse(tokens[9]);

                furnitureStore.RegisterChair(name, price, material, manufacturer, height, canRotate, hasSpring, hasHandlers, weightSupport);
            }
            else if (type == "Bed")
            {
                double height = double.Parse(tokens[5]);
                double width = double.Parse(tokens[6]);
                BedSpecs bedType = Enum.Parse<BedSpecs>(tokens[7]);

                furnitureStore.RegisterBed(name, price, material, manufacturer, height, width, bedType);
            }
            else
            {
                Console.WriteLine("Invalid furniture type.");
            }
        }

        static void ProcessCommand(FurnitureStore furnitureStore, string input)
        {
            string[] tokens = input.Split('-');
            string command = tokens[0];

            switch (command)
            {
                case "FindProduct":
                    string productName = tokens[1];
                    try
                    {
                        Furniture product = furnitureStore.GetFurnitureByName(productName);
                        Console.WriteLine($"Product Details: {product.Name}, {product.Price}, {product.Material}, {product.Manufacturer}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "CountOfChairs":
                    Console.WriteLine($"Number of Chairs: {furnitureStore.CountOfChairs()}");
                    break;
                case "CountOfBeds":
                    Console.WriteLine($"Number of Beds: {furnitureStore.CountOfBeds()}");
                    break;
                case "AllChairs":
                    Console.WriteLine("Chair Names: ");
                    furnitureStore.PrintChairsNames();
                    break;
                case "AllBeds":
                    Console.WriteLine("Bed Names: ");
                    furnitureStore.PrintBedNames();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}