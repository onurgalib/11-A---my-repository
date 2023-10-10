using StaticConstructorsDestructorsStackAndHeap;
using System;
namespace Animal
{
    internal class Dog
    {
        //Statichen broiach
        private static int idCounter = 1;
        public int Id { get; }
        public Dog()
        {
            Id = idCounter++;
            idCounter++;
        }
        public Dog(string name) : this()
        {
            Name = name;
        }
        // Statichen konstruktor
        static Dog()
        {
            ZooName = "Genadi";
        }
        //Destructor
        ~Dog()
        {
            Console.WriteLine($"Goodbye from {Name}. Kucheto go ubi Garbage kolektora");
        }
        public static string ZooName { get; set; }
        public string Name { get; set; } 
        public void PrintData()
        {
            Console.WriteLine($"I am a doggy. I am {Name}.My Id is{Id}");
            Console.WriteLine($"I visit clinic {VetClinic.Name}");
        }
    }
}