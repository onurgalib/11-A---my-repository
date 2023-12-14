namespace Generic
{
    internal class Program
    {
        static void Main()
        {
            List<int> intList = new List<int> { 1, -6, 23, 8, 9, 21 };
            List<double> doubleList = new List<double> { 1.6, -6.2, 23.545, 8.8, 9, 21 };

            List<decimal> decimalList = new List<decimal> { 4.2m, 6.3m, -7.54m };

            List<string> words = "Words don't come easy to me. How can I find a way..."
                .Split(" ").Select(w => w.Replace(".", "").ToUpper()).ToList();

            var special_words = GetNthElementsFromCollection(intList, 2);
            Console.WriteLine(string.Join("\n", special_words));


            var gencho = new Person<Person, string>("Gencho");
            var johny = new Person<decimal, int>("Johny");

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

        //public static long SumTwoNumbers(long a, long b)
        //{
        //    return a + b;
        //}

        public static int SumAllElements(List<int> nums)
        {
            return nums.Sum();
        }
        public static double SumAllElements(List<double> nums)
        {
            return nums.Sum();
        }

        public static int SumAllElements(int[] nums)
        {
            return nums.Sum();
        }

        public static List<T> GetNthElementsFromCollection<T>(ICollection<T> colection, int n = 2)
        where T : IComparable<T>
        {
            var arr = colection.ToArray();
            var answer = new List<T>();

            for (int i = 0; i < list.Count(); i += n)
            {
                answer.Add(arr[i]);
            }
            return answer;
        }



        //  public static double SumTwoNumbers(double a, double b) => a + b;



    }

    public class Person<T, S>
    {
        public S Id { get; set; }
        public Person(string name)
        {
            Name = name;
        }

        public T SpecialItem { get; set; }
        public string Name { get; set; }
        public T GiveTheSpecialItem()
        {
            return SpecialItem;
        }
    }


}