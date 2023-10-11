namespace NestingClassesDEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.RegisterOwner(new Person() { Name = "Genadi" });
            car1.RegisterOwner(new Person() { Name = "Mitko" });
            foreach (Person owner in car1.Owners)
            {

            }
            List<Person> thiefs = new List<Person>()
            {
                new Person() {Name="Koko"},
                new Person() {Name="Boko"},
                new Person() {Name="Loko Plovdiv"},
            };
        }
    }
    class Car
    {
        public Car()
        {
            owners = new List<Person>();
        }
        public Car (int yearOfMake, string Model) : this()
        {
            YearOfMake = yearOfMake;
            Model = model;
        }
        public int YearOfMake { get => YearOfMake; set => YearOfMake = value; }
        public int Model { get; set; }
        public Engine Engine { get; set; }
        public List<string> TownsVisited { get; set; }

        private List<Person> owners;
        private readonly string model;

        public IReadOnlyCollection<Person> Owners { get => owners.AsReadOnly(); }
        public void RegisterOwner(Person p)
        {
            owners.Add(p);
        }
     

    }
    public class Engine
    {
        public int HorsePowers { get; set; }
        public int Model { get; set;}
        public int Brand { get; set;}
    }
    public class Person
    {
        public string Name { get; set; }
       
    }
}
