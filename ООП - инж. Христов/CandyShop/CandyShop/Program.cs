﻿namespace CandyShop
{
    internal class Program
    {
        public static decimal totalCost { get; private set; }

        static void Main(string[] args)
        {
            List<Candy> shopItems = new List<Candy>();
            #region FirstOption
            FillDataFirstOption(shopItems);
            #endregion
            //  FillDataSecondOption(shopItems);
            Console.WriteLine("List of Products In ourShop:");
            for (int i = 0; i < shopItems.Count(); i++)
            {
                Candy currentCandy = shopItems[i];
                Console.WriteLine($"{i}. {currentCandy.Name} - {currentCandy.PriceUSD:F2}$.");
            }
            while (true)
            {
                Console.WriteLine("What do you want to buy? Insert Number - Quantity (1-3)");
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                var choiseofProducts = input.Split("-").Select(x => int.Parse(x)).ToArray();
                int index = choiseofProducts[0];
                int ammount = choiseofProducts[1];
                shopItems[index].SellAmount(ammount);
                // Console.WriteLine($"you have purchased {shopItems[index].Name}x {ammount}!");
            }
            PrintData(shopItems);
        }
        private static void PrintData(List<Candy>shopItems)
        {
            foreach (var item in shopItems.Where(x => x.CalculateProfit()>0))
            {
                totalCost += item.CalculateProfit();
                Console.WriteLine($"{item.Name}x{item.Sold} [{item.PriceUSD}]={item.CalculateProfit()}");
            }
            Console.WriteLine($"Total Money Bill: {totalCost}");
        }
        private static void FillDataSecondOption(List<Candy> shopItems)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                shopItems.Add(new Candy());
            }
        }

        private static void FillDataFirstOption(List<Candy> shopItems)
        {
            while (true)
            {
                //"{Име}; {Калории}; {Тегло}; {Цена}; {Тип на изделието}"
                string[] inputArr = Console.ReadLine().Split("; ");//Donut; 500; 125; 0.49; Pretzels
                if (inputArr[0] == "END")
                {
                    break;
                }
                string name = inputArr[0];
                int calories = int.Parse(inputArr[1]);
                double weight = double.Parse(inputArr[2]);
                decimal price = decimal.Parse(inputArr[3]);
                FamilyType type = Enum.Parse<FamilyType>(inputArr[4]);
                shopItems.Add(new Candy(name, calories, weight, price, type));
            }
        }

        private static void Demo1()
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
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Price for Candy! 0.5$ is not happy!");
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
        public object Sold { get; internal set; }

        public Candy(string input)
        {
            var inputArr = input.Split("; ");
            Name = inputArr[0];
            Calories = int.Parse(inputArr[1]);
            Weight = double.Parse(inputArr[2]);
            PriceUSD = decimal.Parse(inputArr[3]);
            FamilyType type = Enum.Parse<FamilyType>(inputArr[4]);
        }
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
        Licorice,
        Pretzels,
        Waffle,
        ShugarMagic,
        FruitPower,
        Snacks,
        Unspecified

    }
}