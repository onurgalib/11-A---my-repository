using System.Diagnostics.Contracts;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Generic
{
    internal class Program
    {
        static void Main()
        {
            List<int> list = new List<int> { 1, -6, 23, 8, 9, 21 };
            List<double> doublelist = new List<double> { 1.6, -6.6, 23.545, 8.8, 9, 21 };

            List<decimal> decimalList = new List<decimal> { 4.2m, 6.3m, -7.54m };
            List<string> words = "Words don't come easy to me. How can I find a way...".Split(" ").Select(w => w.Replace(".", "")).ToList();
            var special_words = GetNthElementsFromCollection<string>(words, 3);
            Console.WriteLine(string.Join("\n", special_words));

            var gencho = new Person<Person,string>("Gencho");
            var johny = new Person<decimal,int>("johny");

            gencho.SpecialItem = johny;
            johny.SpecialItem = 15.75m;
            Console.WriteLine(gencho.GiveTheSpecialItem());
        }

        public static double SumTwoNumbers(double a, double b)
        {
            return a + b;
        }

        public static decimal SumTwoNumbers(decimal a, decimal b)
        {
            return a + b;
        }
        public static int SumTwoNumbers(int a, int b)
        {
            return a + b;
        }
        public static long SumTwoNumbers(long a, long b)
        {
            return a + b;
        }
        public int SumAllElements(List<int> nums)
        {
            return nums.Sum();
        }
        public int SumAllElements(int[] nums)
        {
            return nums.Sum();
        }


        public static List<T> GetNthElementsFromCollection<T>(ICollection<T> list, int n = 2)
        
            where T:IComparable<T>
            {
            var arr = colection.ToArray();
            var answer = new List<T>();

            for (int i = 0; i<list.Count(); i+=n)
            {
                answer.Add(arr[i]);
            }
            return answer;
        }
    }
    public class Person<T, S>
    {
        public Person(string name)
        {
            Name = name;
        }

        public S Id {get;set;}
        public T SpecialItem { get; set; }
        public string Name { get; set; }
        public T GiveTheSpecialItem()
        {
            return SpecialItem;
        }
    }
}
