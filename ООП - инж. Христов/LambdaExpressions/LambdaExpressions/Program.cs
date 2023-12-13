namespace LambdaExpressions
{
    internal class Program
    {
        static void Main()
        {
            //    Console.WriteLine("Hello, World!" + Age);
            //    Person p1 = new Person();
            //    p1.PrintSomething("edno dve tri");
            var pr1 = new Program();
            pr1.GiveMeANumber(15, "kuncho");
            var multiply = (double x, double y) => x * y;
            Console.WriteLine(multiply(3.2, 6.4));

            //Lambda and NonLambda example:
            string[] numbersAsStrings = new string[] { "5.6", "23.1", "16.9", "-5.3", "0.0003" };

            var numbers = numbersAsStrings.Select(x=>double.Parse(x)).ToArray();//[5.6,23.1,16.9]

            List<double> results = new List<double>();
            foreach (var item in numbersAsStrings) 
            { 
                results.Add(double.Parse(item));
            }
        }
        public static double Calculate(string x)
        {
            var result = double.Parse(x);
            if (result > 5)
            {
                return result;
            }
            else
            {
                return 100;
            }
        }
        public int GiveMeANumber(int age, string name, bool isImportant=false)
        {
            return 5;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
public class Person
{
    public Person(int age)
    {
        Age = age;
    }

    public int Age { get; set; }
    public void PrintSomething(string something)
    {
        Console.WriteLine(something + "abrakadabra");
    }
}
