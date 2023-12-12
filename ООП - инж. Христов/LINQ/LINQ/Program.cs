namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();


        }
    }
    public class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public override string ToString()
        {
            return $"Dog:[{Breed.ToString()}]{Name}.{Age} years old."
        }
        public void Bark()
        {
            Console.WriteLine($"Woof woof said {Name} - {Breed}");
        }
    }
    //Doberman Spiner 15|Kangal Sharo 5
    //|Mops Kircho3| Pitbul koko 2| Doberman Alex 7|Mops RikiTiki 5|Kangal BlackSmoke 4
    //Pitbul Rickardo 9|Mops Shailo 10|Doberman Spinderman 7|Pitbul XnaKvadrat 7|Mops nFakturel 6
    public enum Breed
    {
        PitBul,Kangal,Doberman,Mops
    }
}
