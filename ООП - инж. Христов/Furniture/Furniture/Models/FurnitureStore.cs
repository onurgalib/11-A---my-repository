using Furniture.Exeptions;


namespace Furnitures
{
    public class FurnitureStore
    {
        private List<Furniture> inventory;

        public FurnitureStore()
        {
            inventory = new List<Furniture>();
        }
        public void RegisterChair(string name, decimal price, Material mat, string manuf, double height, double weightSupport, bool canRotate = false, bool hasSpring = false, bool hasHandlers = false)
        {
            if (inventory.Any(x => x.Name == name))
            {
                throw new DuplicatingProductException($"Product {name} already exists in database!");
            }

            var newChair = new Chair(name, price, 0, manuf, mat, height);
            inventory.Add(newChair);

            newChair.CanRotate = canRotate;
            newChair.HasSpring = hasSpring;
            newChair.WeightSupport = weightSupport;
            newChair.HasHandlers = hasHandlers;
        }

        public void RegisterBed(string name, decimal price, Material mat, string manufacturer, double height, double width, BedSpec bedType)
        {
            if (inventory.Any(x => x.Name == name))
            {
                throw new DuplicatingProductException($"Product {name} already exists in database!");
            }

            var newBed = new Bed(name, price, height, width, 200, bedType);
            newBed.Manufacturer = manufacturer;
            newBed.Material = mat;
            inventory.Add(newBed);
        }

        public int CountOfChairs()
        {
            int chairCount = 0;
            foreach (var item in inventory)
            {
                if (item is Chair)
                {
                    chairCount++;
                }
            }
            return chairCount;
        }

        public int CountOfBeds()
        {
            return inventory.Count(x => x is Bed);
        }

        public void PrintChairsNames()
        {
            string chairNames = "";
            foreach (var item in inventory)
            {
                if (item is Chair)
                {
                    chairNames += item.Name + ", ";
                }
            }
            Console.WriteLine(chairNames);
        }

        public void PrintBedNames()
        {
            Console.WriteLine(string.Join(", ", inventory.Where(x => x is Bed).Select(x => x.Name)));
        }

        public Furniture GetFurtnitureByName(string name)
        {
            foreach (var item in inventory)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            throw new NotFoundProductException($"Product {name} is not found in our database!");
            //return inventory.FirstOrDefault(x => x.Name == name);
        }

    }
}