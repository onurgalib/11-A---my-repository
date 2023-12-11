namespace RegisterAutomobilies
{



    public enum Manufacturer
    {
        Ford,
        Mercedes,
        BMW,
        Audi,
        Tesla
    }

    public class Battery
    {
        public int Capacity { get; set; }
    }

    public abstract class CarModel
    {
        protected CarModel(string model, Manufacturer manufacturer, int startYearOfModel, double maxSpeedKmPh, double weight, double loadCapacity)
        {
            Model = model;
            Manufacturer = manufacturer;
            StartYearOfModel = startYearOfModel;
            MaxSpeedKmPh = maxSpeedKmPh;
            Weight = weight;
            LoadCapacity = loadCapacity;
        }

        public string Model { get; }
        public Manufacturer Manufacturer { get; }
        public int StartYearOfModel { get; }
        public double MaxSpeedKmPh { get; set; }
        public double Weight { get; }
        public double LoadCapacity { get; }

        protected double GetHoursForTravel(double distance)
        {
            return distance / MaxSpeedKmPh;
        }
    }

    public interface ITravelable
    {
        double MaxTravelDistance { get; }
        void Refuel();
        TripInfo Travel(double distance);
    }

    public class TripInfo
    {
        public double Distance { get; }
        public double Hours { get; }

        public TripInfo(double distance, double hours)
        {
            Distance = distance;
            Hours = hours;
        }
    }

    public class ElectricCarData : CarModel, ITravelable
    {
        public Battery Battery { get; set; }
        public double TravelDistanceKoef { get; }
        public override double MaxTravelDistance => Battery.Capacity * TravelDistanceKoef;

        public ElectricCarData(string model, Manufacturer manufacturer, int startYearOfModel, double maxSpeedKmPh, double weight, double loadCapacity, Battery battery, double travelDistanceKoef)
            : base(model, manufacturer, startYearOfModel, maxSpeedKmPh, weight, loadCapacity)
        {
            Battery = battery;
            TravelDistanceKoef = travelDistanceKoef;
        }

        public void Refuel()
        {
            Console.WriteLine("Battery recharged.");
        }

        public TripInfo Travel(double distance)
        {
            if (distance > MaxTravelDistance)
            {
                throw new ApplicationException("ImpossibleTravel!");
            }

            double hours = GetHoursForTravel(distance);

            if (Battery.Capacity < 100)
            {
                Console.WriteLine("Recharge needed...");
            }

            return new TripInfo(distance, hours);
        }
    }
    public class FuelCarData : CarModel, ITravelable
    {
        public Tank Tank { get; set; }
        public double MaxTravelDistanceKoef { get; }
        public override double MaxTravelDistance => Tank.Capacity * MaxTravelDistanceKoef;

        public FuelCarData(string model, Manufacturer manufacturer, int startYearOfModel, double maxSpeedKmPh, double weight, double loadCapacity, Tank tank, double maxTravelDistanceKoef)
            : base(model, manufacturer, startYearOfModel, maxSpeedKmPh, weight, loadCapacity)
        {
            Tank = tank;
            MaxTravelDistanceKoef = maxTravelDistanceKoef;
        }

        public void Refuel()
        {
            Console.WriteLine("Tank refueled.");
        }
        public TripInfo Travel(double distance)
        {
            if (distance > MaxTravelDistance)
            {
                throw new ApplicationException("ImpossibleTravel!");
            }

            double hours = GetHoursForTravel(distance);

            if (Tank.Capacity < 100)
            {
                Console.WriteLine("Refuel needed...");
            }

            return new TripInfo(distance, hours);
        }
    }

    public class Tank
    {
        public int Capacity { get; set; }
    }

    public interface ITravelable
    {
        double MaxTravelDistance { get; }
        void Refuel();
        TripInfo Travel(double distance);
    }
    public enum FuelType
    {
        Benzine,
        Gas,
        Diesel,
        Metan,
        Coal,
        Wood
    }
    public class Tank
    {
        public double MaxCapacity { get; set; }
        public double RemainingCapacity { get; }
        public string Type { get; }
        public Tank()
        {
            MaxCapacity = 50;
            RemainingCapacity = 50;
            Type = "Benzine";
        }
        public Tank(double maxCapacity, string type = "Benzine")
        {
            MaxCapacity = maxCapacity;
            RemainingCapacity = maxCapacity;
            Type = type;
        }
        public void Refuel()
        {
            RemainingCapacity = MaxCapacity;
        }
    }
    public class Battery
    {
        public enum TechnologyType
        {
            LiIon,
            NiOx,
            Gel,
            LedAcid
        }
        public TechnologyType BatteryTechnology { get; }
        private int rechargeCyclesMax;
        private int cyclesReached;
        public int MaxCapacity { get; }
        public double Capacity { get; private set; }
        public double Health => (double)(rechargeCyclesMax - cyclesReached) / rechargeCyclesMax;
        public Battery(TechnologyType technologyType, int rechargeCyclesMax, double maxCapacity)
        {
            BatteryTechnology = technologyType;
            this.rechargeCyclesMax = rechargeCyclesMax;
            MaxCapacity = maxCapacity;
            Capacity = maxCapacity;
        }
        public void Recharge()
        {
            if (cyclesReached >= rechargeCyclesMax)
            {
                throw new BatteryFailureException("Battery is dead, replacement needed");
            }

            Capacity = MaxCapacity;
            cyclesReached++;
        }
    }
    public interface ITravelable
    {
        double MaxTravelDistance { get; }
        void Refuel();
        TripInfo Travel(double distance);
    }
    public class TripInfo
    {
        public double TravelTime { get; set; }
        public double Distance { get; }
        public string ModelCar { get; }
        public TripInfo(string modelCar, double travelTime, double distance)
        {
            ModelCar = modelCar;
            TravelTime = travelTime;
            Distance = distance;
        }
        public override string ToString()
        {
            return $"{ModelCar} traveled {Distance} km, for {TravelTime} hours";
        }
    }
    public class BatteryFailureException : Exception
    {
        public BatteryFailureException(string message) : base(message) { }
    }
    public enum Manufacturer
    {
        Ford,
        Mercedes,
        BMW,
        Audi,
        Tesla
    }
    public enum TechnologyType
    {
        LiIon,
        NiOx,
        Gel,
        LedAcid
    }
    public enum FuelType
    {
        Benzine,
        Gas,
        Diesel,
        Metan,
        Coal,
        Wood
    }
} 