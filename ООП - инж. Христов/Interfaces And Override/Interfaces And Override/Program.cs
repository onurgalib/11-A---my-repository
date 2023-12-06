namespace Interfaces_And_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Student std = new Student() { Name = "Grisho", Age = 27 };
            Person prs = new Person() { Name = "Kuncho", Age = 47 };


            Person[]people = { (Person)std, prs };

            people[0].SayHello();
            people[1].SayHello();


            Console.WriteLine(std);


            std.SayHello();
            Console.WriteLine(new string('=' ,20));
            prs.SayHello();
        }
    }
}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void SayHello()
    {
        Console.WriteLine($"Hello from parent{Name}");
    }
    public void WriteNumber(int number)
    {
        Console.WriteLine(  number);
    }
    public override bool Equals(object? obj)
    {
        if (Age>((Person)obj).Age)
        {
           return true;
        }   
        return false;
    }
    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}

public class Student:Person
{
    public string SchoolName { get; set; } = "PGMETT";
    public override void SayHello()
    {
        //base.SayHello();
        Console.WriteLine("We all live in a yellow submarine");
    }
    public override string ToString()
    {
        return base.ToString()+$"I am a student from {SchoolName}";
    }
}