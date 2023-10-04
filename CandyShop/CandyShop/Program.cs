namespace CandyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Candy = new Candy();
            string nameofCandy = Candy.Name;
            Candy.Calories = 120;
            Console.WriteLine(Candy.Weight);
            Candy.Weight = 300;
            //Candy.Amount = 223;

        }
    }
    public class Candy
    {
        private int calories;
        private int totalSold;
        public string Name { get; private set; }
        public int Calories
        {
            get { return calories; }
            set
            {
                if (value < 100)
                {
                    calories = 100;
                }
                else
                {
                    calories = value;
                }
            }
        }
        public double Weight { get; set; }
        public decimal PriceUSD 
        {
            get
            {
                return 1.2m * priceUSD;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine( "Invalid Price for Candy! 0.5$ is not happy!");
                    priceUSD = 5;
                    return;
                }
                priceUSD = value;
            }
        }

        private decimal priceUSD;
        private FamilyType famType;

        public int Amount { get; set; }
  
        public bool IsVeganAcceptable { get; set; }
        public FamilyType FamilyType { get; }

        public Candy(bool isVeganAcceptable = true)
        {
            Amount = 100;
            IsVeganAcceptable = isVeganAcceptable;
        }

        public Candy(string name, int calories) : this()
        {
            this.Name = name;
            this.Calories = calories;
        }
        public Candy(string name, int calories, double weight) : this(name, calories)
        {
            Weight = weight;
        }
        public Candy(string name, int calories, double weight, decimal priceUSD) : this(name, calories, weight)
        {
            PriceUSD = priceUSD;
            this.priceUSD = priceUSD;
        }
        public Candy(string uname, int ucalories, double uweight, decimal upriceUSD, FamilyType ufamilyType) : this(uname, ucalories, uweight, upriceUSD)
        {
            FamilyType = famType;
        }
        public void IncreaseAmount(int amount, string pwd = "")
        {
            if (pwd == "123#P")
            {
                Console.WriteLine("Welcome MasterChief!");
                Amount += amount;
                return;
            }
            if (amount <= 0)
            {
                Console.WriteLine("Nqma da uvelicha kolichestvoto.");
                return;
            }
            if (amount > 100)
            {
                Console.WriteLine("Bomba ne moje tolkova mnogo");
                return;
            }
            Amount += amount;
        }
        public void SellAmount(int amount)
        {
            Amount -= amount;
            totalSold += amount;

        }
        public decimal CalculateProfit()
        {
            return totalSold * PriceUSD;        

        }

    }

    public enum FamilyType
    {
        Bonbon,
        Cake,

    }
}