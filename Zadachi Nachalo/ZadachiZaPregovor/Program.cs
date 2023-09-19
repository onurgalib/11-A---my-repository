namespace ZadachiZaPregovor
{
    internal class StartUP
    {
        private static object moneyLeft;

        static void Main(string[] args)
        {
            //  Zadacha1();
            //Zadacha2();
            Zadacha3();
        }

        private static void Zadacha3()
        {
            Console.Write("Име на филма:");
            string movieName = Console.ReadLine();
            Console.Write("Вид на залата:");
            string hallType = Console.ReadLine();
            Console.Write("Брой продадени билети:");
            int ticketNumber = int.Parse(Console.ReadLine());

            decimal eranings = 0;
            decimal ticketPrice = 0;

            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal") ticketPrice = 7.50m;
                else if (hallType == "luxury") ticketPrice = 10.50m;
                else if (hallType == "ultra luxury") ticketPrice = 13.50m;
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal") ticketPrice = 7.35m;
                else if (hallType == "luxury") ticketPrice = 9.45m;
                else if (hallType == "ultra luxury") ticketPrice = 12.75m;
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal") ticketPrice = 8.15m;
                else if (hallType == "luxury") ticketPrice = 10.25m;
                else if (hallType == "ultra luxury") ticketPrice = 13.25m;
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal") ticketPrice = 8.75m;
                else if (hallType == "luxury") ticketPrice = 10.25m;
                else if (hallType == "ultra luxury") ticketPrice = 13.95m;
            }

            decimal earning = ticketNumber * ticketPrice;
            Console.WriteLine($"{movieName} -> {earning} lv.");
        }

        private static void Zadacha1()
        {
            int rentOfHall = int.Parse(Console.ReadLine());
            decimal statuesValue = rentOfHall * 0.7m;
            decimal ceteringValue = statuesValue * 0.85m;
            var soundValue = ceteringValue / 2;
            decimal totalCost = rentOfHall + statuesValue + ceteringValue + soundValue;

            Console.WriteLine($"Otgovorut e {totalCost:F2}");
        }
        private static void Zadacha2()
        {

            decimal budget = decimal.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            decimal valueForOutfit = decimal.Parse(Console.ReadLine());
            decimal valueOfDecor = budget * 0.1m;
            decimal clothesPrice = statisti * valueForOutfit;
            if (statisti >= 150)
            {
                valueForOutfit = valueForOutfit * 0.9m;
            }
            decimal finalValue = valueOfDecor + clothesPrice;
            if (budget < finalValue)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyLeft:F2}");
            }
            else if (budget >= finalValue)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left");


            }
        }
    }
}
