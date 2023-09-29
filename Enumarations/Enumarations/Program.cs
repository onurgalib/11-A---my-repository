namespace Enumarations
{
    internal class Program
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            var myCar = new Car()
            {
                YearOfMake = 1998,
                Mileage = 80085,
                Manufacturer = CarManufacturer.Mercedes,//1variant da go izberem
                Model = "Celica"
            };

            var myCar2 = new Car()
            {
                YearOfMake = 2003,
                Mileage = 60084,
                Manufacturer = Enum.Parse<CarManufacturer>("Toyota"),//ot string
                Model = "Celica"
            };
            cars.Add(myCar);
            cars.Add(myCar2);
            cars.Add(new Car()
            {
                YearOfMake = 2007,
                Mileage = 50084,
                Manufacturer = (CarManufacturer)13,//3ti variant kastvane ot chislo
                Model = "Corrola"
            });
            cars.Add(new Car()
            {
                YearOfMake = 2023,
                Mileage = 0,
                Manufacturer = CarManufacturer.Ford,//3ti variant kastvane ot chislo
                Model = "Mac-E"
            });
            foreach (Car car in cars)
            {
                if (car.Manufacturer==CarManufacturer.Toyota)
                {
                    Console.WriteLine("Imame toyota!!!");
                }
                switch (car.Manufacturer)
                {
                    case CarManufacturer.Ford:
                        {
                            Console.WriteLine("Imame Ford!!!");
                            break;
                        }
                    case CarManufacturer.Opel:
                        {
                            Console.WriteLine("Imame Opel!!!");
                            break;
                        }
                    case CarManufacturer.Mercedes:
                        { 
                            break;
                        }
                    case CarManufacturer.Toyota:
                        {
                            break;
                        }
                    case CarManufacturer.BMW:
                        {
                            break;
                        }
                    default:
                         break;
                }
            }
        }
    }
    public class Car
    {
        private int yearOfMake;
        public double Mileage { get; set; }
        public string Model { get; set; }
        public int YearOfMake
        {
            get { return yearOfMake; }
            set { yearOfMake = value; }
        }
        public CarManufacturer Manufacturer { get; set; }
    }
    public enum CarManufacturer
    {
        Ford=10, 
        Opel=11,
        Mercedes=12, 
        Toyota=13,
        BMW=9
    }
}