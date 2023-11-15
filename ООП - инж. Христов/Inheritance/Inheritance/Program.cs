public class Program
{
    public static void Main()
    {
        var dog1 = new Inheritance.Dog("Sharo", 12, 15.4, DogBreed.Buldog);
    }
}
public class Dog
{
    private double speedMetersPerSecond = 3.0;

    public Dog(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
    public Dog(string name, int age, double weight, DogBreed dogBreed):this(name,age,weight)
    {
        Breed  = dogBreed;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public DogBreed Breed { get; set; }
public int RunForTimeSeconds(double distanceMeters)
    {
        int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
        return timeRequired;
    }
public void Bark()
{
    Console.WriteLine("Woff Woff");
}

}
public class Cat
{
    private double speedMetersPerSecond = 4.0;
    public Cat(string name, int age, double weight , int lives, CatBreed breed): this(name,age,weight)
    {
        Lives = lives;
        Breed = breed;
    }

    public Cat(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public int Lives { get; set; } = 9;
    public CatBreed Breed { get; set; }
    public int RunForTimeSeconds(double distanceMeters)
    {
        int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
        return timeRequired;
    }
    public void Meaw()
    {
        Console.WriteLine("Miew Meaw");
    }

}
