namespace DefiniraneNaPoletaiSvoystva
{
    internal class DefiniraneNaPoletaiSvoystva
    {
        private static object rolledNumber;

        static void Main()
        {
            Console.WriteLine("Hello world!");
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            d1.Sides = 7;
            d2.Sides = 5;
            d1.PresentInfo();
            //Console.WriteLine($"Broiat strani na zar1 e: { d1.Sides}. A cveta na zarcheto{ d1.Color}");
            Console.WriteLine(new string('=', 20));
            d1.Color = "Magenta";
            d1.Sides = 15;
            Console.WriteLine($"Broiat strani na zar2 e:" + d2.Sides);

            d2.PresentInfo();
            d1.PresentInfo();
            for (int i = 0; i < 10; i++)
            {
                int rolledNumber = d1.RollDice();
                Console.WriteLine($"Hvurlihme zarche N1 i poluchihme:{rolledNumber}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Broiat strani na zar2 e: " + d2.Sides);

            Dice d3 = new Dice { Sides = 12, Color = "Oranjevo" };
            d3.PresentInfo();
        }
    }
    public class Dice
    {
        int sides;
        public int Sides { get => sides; set => sides = value; }
        string color = "white";
        public string Color { get => color; set => color = value; }
        public void PresentInfo()
        {
            Console.WriteLine($"Broiat strani na zar1 e: {Sides}. A cveta na zarcheto {Color}");
        }
         public int RollDice()
        {
            Random rnd = new Random();
            int result = rnd.Next(1,Sides +1);
            return result;
        }
    }
}