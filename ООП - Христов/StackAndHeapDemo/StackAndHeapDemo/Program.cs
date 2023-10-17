namespace StackAndHeapDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koe demo iskash 1,2 ili 3");
            int demoN = int.Parse(Console.ReadLine());
            if (demoN==1)
            {
                Demo1();
            }
            if (demoN == 2)
            {
                Demo2();
            }
            if (demoN == 3)
            {
                Demo3();
            }
            // Demo1();
            // Demo2();
            // Demo3();
        }
        private static void Demo1()
        {
            int num1 = 4;
            int num2 = num1;
            num2 = 8;
            Console.WriteLine(num1);
            var arr1 = new[] { 1, 3, 5 };
            var arr2 = arr1;
            arr2[0] = 10;
            // arr1[0] = 10;
            Console.WriteLine(arr1[0]);
            var arr3 = new[] { 10, 3, 5 };
            if (arr1 == arr3)
            {
                Console.WriteLine("I dvata masiva sa s razlichni referencii 1 i 3");
            }
            if (arr1[0] == arr3[0])
            {
                Console.WriteLine("Tuk stoinostite sa ravni");
            }
            if (arr1 == arr2)
            {
                Console.WriteLine("I dvata masiva sa edna i sushta referenciq! 1 i 2");
            }
        }
        private static void Demo2()
        {
            List<int> nums = new List<int>();
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.Add(10);
            Console.WriteLine(string.Join(", ", nums));//3, 4, 5, 10
            DoSomethingWithList(nums);
            Console.WriteLine(string.Join(", ", nums));//3, 4, 5
            DoSomethingWithList(nums);
            Console.WriteLine(string.Join(", ", nums));//3, 4
            string text = "Onur";
            DoSomethingWithString(text);
            Console.WriteLine(text);//Onur
        }
        private static void Demo3()
        {
            List<Person> people1 = new List<Person>();
            people1.Add(new Person("Ivan"));
            people1.Add(new Person("Hristian"));
            people1.Add(new Person("Tolga"));
            people1.Add(new Person("Onur"));
            var people2 = people1.ToList();
            people2.Add(new Person("Luchio"));
            people2[0].Name = "IVAN";
        }



        public static void DoSomethingWithList(List<int> numbers)
        {
           numbers = new List<int>();
           // numbers = numbers.ToList();
           //var result = new List<int>();
           // for (int i = 0; i < numbers.Count(); i++)
           // {

           // }
           // numbers = result
            numbers.RemoveAt(numbers.Count()-1);
        }
        public static void DoSomethingWithString(string str)
        {
            str = "Ivan";
        }
        public class Person
        {
            public Person()
            { }
            public Person(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
        }
    }
}