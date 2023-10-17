using System;

public class Dog
{
	public Dog()
	{

	}
    public Dog( string name)
    {
        name = name;
    }
    public string Name { get; set; }
    public void PrintData()
    {
        Console.WriteLine{$"I am a doggy. I am {Name}="};
        Console.WriteLine($"I visit clinic {VetClinic.Name}");
    }
}
