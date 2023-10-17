using Animals;

namespace NameSpacesDemo
{
    internal class Program
    {
        static void Main()
        {
            var dog = new Animals.Dog();
            Makarel fish1 = new Makarel();
            var cat1 = new Cat();
            Console.WriteLine("Hello, World!");
            dog.Age = 15;


            #region StaticDemonstartion
            var p1 = new Person() { Name = "Berk" };
            var p2 = new Person() { Name = "Valentin" };
            var p3 = new Person() { Name = "Denis" };
            var p4 = new Person() { Name = "Hristian" };
            Person.TownName = "Shumen";

            p1.SayHello();
            p2.SayHello();
            p3.SayHello();
            p4.SayHello();

            Person.TownName = "Burgas";

            p1.SayHello();
            p2.SayHello();
            p3.SayHello();
            p4.SayHello();


            Console.WriteLine(Person.TownName);

            #endregion

        }
        public class Person
        {
            public string Name { get; set; }
            public static string TownName { get; set; }

            public void SayHello()
            {
                Console.WriteLine($"I am {Name} from {TownName}");
            }
        }
    }
}