using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumarations
{
    internal class Program1
    {
        static void Main()
        {
            // Get current day of week.
            DayOfWeek today = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is {0}", today);

            // Test current day of week.
            if (today == DayOfWeek.Monday)
            {
                Console.WriteLine("DO WORK");
            }

            // Demonstrate all DayOfWeek values.
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                DayOfWeek.Monday,
                DayOfWeek.Tuesday,
                DayOfWeek.Wednesday,
                DayOfWeek.Thursday,
                DayOfWeek.Friday,
                DayOfWeek.Saturday,
                DayOfWeek.Sunday);

        }
    }
}
