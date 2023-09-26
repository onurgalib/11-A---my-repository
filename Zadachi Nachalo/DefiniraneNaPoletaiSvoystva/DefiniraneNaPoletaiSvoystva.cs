namespace DefiniraneNaPoletaIsvoistva
{
    internal class Program
    {
        static void Main()
        {
            #region first
            Console.WriteLine("Hello, World!");
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            d1.Sides = 7;
            d2.Sides = 5;
            d1.PresentInfo();
            //  Console.WriteLine($"Broiat strani na zar1 e: {d1.Sides}. A cveta na zarcheto e {d1.Color}");
            Console.WriteLine(new string('=', 20));
            d1.Color = "Magenta";
            d1.Sides = 15;

            d1.PresentInfo();
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d1.RollDice();
                Console.WriteLine($"Hvurlihme zarche N1 i poluchihme:{rolledNumber}");
                Thread.Sleep(1000);
            }

            d2.PresentInfo();
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d2.RollDice();
                Console.WriteLine($"Hvurlihme zarche N1 i poluchihme:{rolledNumber}");
                Thread.Sleep(1000);
            }



            Console.WriteLine("Broiat strani na zar2 e: " + d2.Sides);

            Dice d3 = new Dice { Sides = 12, Color = "Oranjevo" };

            d3.PresentInfo();
            #endregion

            Desk desk1 = new Desk();
            desk1.Price = 76.67m;
            Console.WriteLine(desk1.Price);

        }
    }

    public class Dice
    {
        int sides;
        public int Sides
        {
            get => sides;
            set
            {
                if (value <= 1)
                {
                    sides = 2;
                }
                else if (value > 24)
                {
                    sides = 24;
                }
                else
                {
                    sides = value;
                }
            }
        }

        string color = "white";
        public string Color
        { get => color; set => color = value; }

        public void PresentInfo()
        {
            Console.WriteLine($"Broiat strani na zar1 e: {Sides}. A cveta na zarcheto e {Color}");
        }

        public int RollDice()
        {
            Random rnd = new Random();
            int result = rnd.Next(1, Sides + 1);
            return result;
        }
    }

    public class Desk
    {
        private string name;

        public decimal Price { get; set; }

        public string Name
        {
            get
            {
                return name.ToUpper().First() + ".";
            }
            set
            {
                if (value.Length < 2)
                {
                    name = "Undefined";

                }
                else
                {
                    name = value;
                }
            }
        }

        private string manufacturer;
        public string Manufacturer
        {
            get => manufacturer;
            set { manufacturer = value; }
        }

        private string imageURL;
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }


    }





}