using System.Diagnostics;

namespace CarRacing
{
    public abstract class Car : ICar
    {
        public string Make { get; }
        public string Model { get; }
        public string VIN { get; }
        public int HorsePower { get; }
        public double FuelAvailable { get; set; }
        public double FuelConsumptionPerRace { get; }

        protected Car(string make, string model, string vin, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            // Validation logic
        }

        public abstract void Drive();
    }

    public interface ICar
    {
    }

    public class SuperCar : Car
    {
        public SuperCar(string make, string model, string vin, int horsePower) : base(make, model, vin, horsePower, 80, 10) { }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }

    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string vin, int horsePower) : base(make, model, vin, horsePower, 65, 7.5) { }

        public override void Drive()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class Racer : IRacer
    {
        public string Username { get; }
        public string RacingBehavior { get; }
        public int DrivingExperience { get; }
        public ICar Car { get; }

        protected Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            // Validation logic
        }

        public abstract void Race();
        public abstract bool IsAvailable();
    }

    public interface IRacer
    {
    }

    public class ProfessionalRacer : Racer
    {
        public ProfessionalRacer(string username, ICar car) : base(username, "strict", 30, car) { }

        public override bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public override void Race()
        {
            throw new NotImplementedException();
        }
    }

    public class StreetRacer : Racer
    {
        public StreetRacer(string username, ICar car) : base(username, "aggressive", 10, car) { }

        public override bool IsAvailable()
        {
            throw new NotImplementedException();
        }

        public override void Race()
        {
            throw new NotImplementedException();
        }
    }
    public class Map : MapBase, IMap
    {
    }

    public interface IMap
    {
    }

    public class CarRepository : CarRepositoryBase, ICarRepository
    {
        private readonly List<ICar> cars;

        public CarRepository()
        {
            cars = new List<ICar>();
        }

        public static void Add(ICar car)
        {
            // Add car logic
        }
    }

    public interface ICarRepository
    {
        ICar FindBy(string property);
    }

    public class RacerRepository : RacerRepositoryBase, IRacerRepository
    {
        private readonly List<IRacer> racers;

        public RacerRepository()
        {
            racers = new List<IRacer>();
        }

        public static void Add(IRacer racer)
        {
            // Add racer logic
        }
    }

    public interface IRacerRepository
    {
    }

    public class Controller : ControllerBase, IController
    {
        private readonly ICarRepository cars;
        private readonly IRacerRepository racers;
        private readonly IMap map;

        public Controller(ICarRepository cars, IRacerRepository racers, IMap map)
        {
            this.cars = cars;
            this.racers = racers;
            this.map = map;
        }

        public void Exit()
        {
            // Exit logic
        }
    }

    public interface IController
    {
        string AddRacer(string type, string username, string carVIN);
    }

    public interface IEngine
    {
        void Run();
    }

}
