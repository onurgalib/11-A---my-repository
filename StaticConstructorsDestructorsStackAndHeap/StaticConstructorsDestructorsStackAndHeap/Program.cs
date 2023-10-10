using Animal;

namespace StaticConstructorsDestructorsStackAndHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoZaStatichniNeshta();
            //..............
            Console.ReadLine();
        }

        private static void DemoZaStatichniNeshta()
        {
            Console.WriteLine(Dog.ZooName);
            Dog.ZooName = "Mariaca";
            var dogs = new List<Dog>()
            {
                new Dog("Snoop Dog"),
                new Dog("Culio"),
                new Dog("G-Dog"),
                new Dog("Pameca"),
                new Dog("Dimov"),
                new Dog("Kocata"),
                new Dog("Kangala"),
            };
            Console.WriteLine(VetClinic.Name);
            for (int i = 0; i < dogs.Count(); i++)
            {
                int a = 5;
                dogs[i].PrintData();
            }
            var dogTest = new Dog();
            if (dogTest.Id < 10)
            {
                Dog d1 = new Dog("Kucheto koeto ne jivee izvun ifa");
            }
            var d2 = new Dog("Kucheto");
        }
    }
}