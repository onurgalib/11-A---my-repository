namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person[] peopleArr = new Person[]
            //    {
            //    new Person("Ivan",14), 
            //    new Person("Hristian",13), 
            //    new Person ("Tolga", 17)
            //};
            //List<Person> peopleList = new List <Person>
            //{ 
            //    new Person ("Ivan",14),
            //    new Person("Hristian",13),
            //    new Person ("Tolga", 17)
            //};
            //Dictionary<int, Person> dict = new Dictionary<int, Person> ();

            string input = Console.ReadLine();  //Imalo edno vreme na zapad!
            Dictionary<char, int> letterCount = new Dictionary<char, int>();
            foreach(char symbol in input)
            {
                if (!letterCount.ContainsKey(symbol))
                {
                    letterCount.Add(symbol, 0);
                    letterCount[symbol] = 0;
                }
                letterCount[symbol]++;
            }
            Console.WriteLine("Letters: ");
            foreach (var kvp in letterCount)//.OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
            Console.WriteLine(letterCount['k']);
            letterCount['k'] = 233;
        }
    }

    class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Age > other.Age) return 1;
            else if (this.Age < other.Age) return -1;
            return 0;
            //return this.Age - other.Age;
        }
    }

}
