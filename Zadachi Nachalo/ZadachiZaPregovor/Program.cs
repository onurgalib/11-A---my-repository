namespace ZadachiZaPregovor
{
    internal class StartUP
    {
        private static object moneyLeft;

        static void Main(string[] args)
        {
            //Zadacha1();
            //Zadacha2();
            //Zadacha3();
            //Zadacha4();
            //Zadacha5();
            Zadacha6();
        }
        private static void Zadacha6()
        {
            double countTickets = 0;
            int allTickets = 0;
            double countStandartTicket = 0;
            double countStudentTicket = 0;
            double countKidTicket = 0;
            int freeOnesPlaces = 0;
            string movieName = string.Empty;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Finish")
                {
                    //Console.WriteLine($"{movieName} - {(countTickets / freeOnesPlaces) * 100:f2}% full.");
                    break;
                }
                else
                {
                    movieName = input;
                    freeOnesPlaces = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= freeOnesPlaces; i++)
                    {
                        string ticketType = Console.ReadLine();
                        if (ticketType == "End")
                        {
                            Console.WriteLine($"{movieName} - {(countTickets / freeOnesPlaces) * 100:f2}% full.");
                            countTickets = 0;
                            break;
                        }
                        else
                        {
                            countTickets++;
                            allTickets++;
                            if (ticketType == "student")
                            {
                                countStudentTicket++;
                            }
                            else if (ticketType == "standard")
                            {
                                countStandartTicket++;
                            }
                            else if (ticketType == "kid")
                            {
                                countKidTicket++;
                            }
                        }
                        if (i == freeOnesPlaces)
                        {
                            Console.WriteLine($"{movieName} - {(countTickets / freeOnesPlaces) * 100:f2}% full.");
                        }
                    }
                }
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{(countStudentTicket / allTickets) * 100:f2}% student tickets.");
            Console.WriteLine($"{(countStandartTicket / allTickets) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(countKidTicket / allTickets) * 100:f2}% kids tickets.");
        }
    }
        private static void Zadacha5()
            {
        Scanner scanner = new Scanner(System,in);
            int filmsNumber = Integer.parseInt(scanner.nextLine());

            double maxRating = 0;
            double minRating = 11;
            double sumRating = 0;
            String highestRatingForFilm = "";
            String lowestRatingForFilm = "";

            for (int counter = 1; counter <= filmsNumber; counter++)
            {
                String filmName = scanner.nextLine();
                double filmRating = Double.parseDouble(scanner.nextLine());

                if (filmRating > maxRating)
                {
                    maxRating = filmRating;
                    highestRatingForFilm = filmName;
                }

                if (filmRating < minRating)
                {
                    minRating = filmRating;
                    lowestRatingForFilm = filmName;
                }
                sumRating += filmRating;
            }

            double averageRating = sumRating / filmsNumber;
        
            System.out.println(String.format("%s is with highest rating: %.1f", highestRatingForFilm, maxRating));
            System.out.println(String.format("%s is with lowest rating: %.1f", lowestRatingForFilm, minRating));
            System.out.println(String.format("Average rating: %.1f", averageRating));

        }
        private static void Zadacha4()
        {
            int voucherValue = int.Parse(Console.ReadLine());
            int moviePrice = 0;
            int productPrice = 0;
            int purchasedProducts = 0;
            int purchasedTickets = 0;
            while (voucherValue >= 0)
            {
                string purchase = Console.ReadLine();
                if (purchase == "End")
                {
                    Console.WriteLine($"{purchasedTickets}");
                    Console.WriteLine($"{purchasedProducts}");
                    break;
                }
                if (purchase.Length > 8)
                {
                    moviePrice = purchase[0] + purchase[1];
                    voucherValue -= moviePrice;
                    purchasedTickets++;
                    if (voucherValue < moviePrice)
                    {
                        Console.WriteLine($"{purchasedTickets}");
                        Console.WriteLine($"{purchasedProducts}");
                        break;
                    }
                }
                else if (purchase.Length <= 8)
                {
                    productPrice = purchase[0];
                    voucherValue -= productPrice;
                    purchasedProducts++;
                    if (voucherValue < productPrice)
                    {
                        Console.WriteLine($"{purchasedTickets}");
                        Console.WriteLine($"{purchasedProducts}");
                        break;
                    }
                }
            }
             static void Zadacha3()
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

             static void Zadacha1()
            {
                int rentOfHall = int.Parse(Console.ReadLine());
                decimal statuesValue = rentOfHall * 0.7m;
                decimal ceteringValue = statuesValue * 0.85m;
                var soundValue = ceteringValue / 2;
                decimal totalCost = rentOfHall + statuesValue + ceteringValue + soundValue;

                Console.WriteLine($"Otgovorut e {totalCost:F2}");
            }
             static void Zadacha2()
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
}
