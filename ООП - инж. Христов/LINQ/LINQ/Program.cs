namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input = "Doberman Spiner 15|Kangal Sharo 5|Mops Kircho 3|PitBul Koko 2|Doberman Alex 7|Mops RikiTiki 5|Kangal BlackSmoke 4 PitBul Rickardo 9|Mops Shailo 10|Doberman Spinderman 7|PitBul XnaKvadrat 7|Mops nFakturel 6";
            var dogs=input
                .Split("|")
                .Select(element => element.Split(" "))
                .Select(strArr=>new Dog(strArr[1], int.Parse(strArr[2]), Enum.Parse<Breed>(strArr[0])
                ))
                .ToList();
           // "D-Spiner-15 years"
            List<string> names = dogs.OrderBy(d => d.Age).Select(d => $"{d.Breed.ToString()[0]}-{d.Name}-{d.Age} years").ToList();
            while (true)
            {
            Console.WriteLine("Please select dog breed:");
            string selectedTypeOfDog = Console.ReadLine();//pitbul PitBul
            var dogsFd = dogs
                .Where(x => x.Breed.ToString().ToLower() == selectedTypeOfDog.ToLower())
                .OrderByDescending(x => x.Name[0])
                .ToArray();

            Console.WriteLine("Mops dogs are :" + dogsFd.Count());

            foreach (var dog in dogsFd)
            {
                Console.WriteLine(dog);
            }
                Console.WriteLine(new string('=',40));
            }
        }
    }

    public class Dog
    {
        public Dog(string name, int age, Breed breed)
        {
            Age = age;
            Name = name;
            Breed = breed;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public override string ToString()
        {
            return $"Dog:[{Breed.ToString()}]{Name}.{Age} years old.";
        }
        public void Bark()
        {
            Console.WriteLine($"Woof woof said {Name} - {Breed}");
        }
    }
    
    public enum Breed
    {
        PitBul,Kangal,Doberman,Mops
    }
}
