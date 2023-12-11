namespace CarRacing
{

    public interface ICar
    {
        string Make { get; }
        string Model { get; }
        string VIN { get; }
        int HorsePower { get; }
        double FuelAvailable { get; }
        double FuelConsumptionPerRace { get; }

        void Drive();
    }

    public interface IRacer
    {
        string Username { get; }
        string RacingBehavior { get; }
        int DrivingExperience { get; }
    }

    public class Car : ICar
    {
        public string Make { get; }
        public string Model { get; }
        public string VIN { get; }
        public int HorsePower { get; private set; }
        public double FuelAvailable { get; private set; }
        public double FuelConsumptionPerRace { get; }

        public Car(string make, string model, string vin, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            if (string.IsNullOrWhiteSpace(make))
                throw new ArgumentException("Car make cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentException("Car model cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(vin) || vin.Length != 17)
                throw new ArgumentException("Car VIN must be exactly 17 characters long.");

            if (horsePower < 0)
                throw new ArgumentException("Horse power cannot be below 0.");

            if (fuelConsumptionPerRace < 0)
                throw new ArgumentException("Fuel consumption cannot be below 0.");

            Make = make;
            Model = model;
            VIN = vin;
            HorsePower = horsePower;
            FuelAvailable = Math.Max(0, fuelAvailable);
            FuelConsumptionPerRace = fuelConsumptionPerRace;
        }

        public virtual void Drive()
        {
            FuelAvailable = Math.Max(0, FuelAvailable - FuelConsumptionPerRace);
            if (this is TunedCar tunedCar)
            {
                double wearPercentage = 0.03; // 3% wear
                tunedCar.ReduceHorsePowerByPercentage(wearPercentage);
            }
        }
    }

    public class SuperCar : Car
    {
        public SuperCar(string make, string model, string vin, int horsePower)
            : base(make, model, vin, horsePower, 80, 10)
        {
        }
    }

    public class TunedCar : Car
    {
        public TunedCar(string make, string model, string vin, int horsePower)
            : base(make, model, vin, horsePower, 65, 7.5)
        {
        }

        public void ReduceHorsePowerByPercentage(double percentage)
        {
            ReduceHorsePowerByPercentage(percentage, HorsePower);
        }

        public void ReduceHorsePowerByPercentage(double percentage, int horsePower)
        {
            int reduction = (int)Math.Round(HorsePower * percentage);
            horsePower = Math.Max(0, HorsePower - reduction);
        }
    }

    public class Racer : IRacer
    {
        public string Username { get; }
        public string RacingBehavior { get; }
        public int DrivingExperience { get; }

        public Racer(string username, string racingBehavior, int drivingExperience)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(racingBehavior))
                throw new ArgumentException("Racing behavior cannot be null or empty.");

            if (drivingExperience < 0 || drivingExperience > 100)
                throw new ArgumentException("Racer driving experience must be between 0 and 100.");

            Username = username;
            RacingBehavior = racingBehavior;
            DrivingExperience = drivingExperience;
        }
    }

}
