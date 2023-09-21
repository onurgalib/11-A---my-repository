using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWithBackPack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student() {Name="Gancho", FamilyName="Petrov", Age = 15 };
            BackPack bp1 = new BackPack() { Volume = 15.6, Color = "Camoflage", Price = 69.75m };
            st1.BackPack = bp1;
            //  st1.Grades = new List<int>();
            st1.Grades.Add(5);
            st1.Grades.Add(4);
            st1.Grades.Add(6);
            st1.Grades.Add(5);
            Console.WriteLine("Sreden uspeh e: " + st1.GetAverageGrade());
            st1.PresentYourself();
        }
    }
    public class BackPack
    {
        public double Volume { get; set; }
        public string Color { get; set; }
        public decimal Price { get;  set; }
    }
    public class Student
    {
        public string Name { get; set; }
        private string familyName;

        public BackPack BackPack { get; set; }
        public List<int> Grades { get; set; }
        public string FamilyName
        {
            get
            {
                return familyName.ToUpper().Substring(0, 1) + ".";
            }
            set => familyName = value;
        }

        public int Age { get; set; }
        public double GetAverageGrade()
        {
            double result = Grades.Sum()/Grades.Count();
            return result;
        }
        public void PresentYourself()
        {
          //  Console.WriteLine($"I am {Name} and I am {Age} ");
          //  IncreaseAge();
        }
        private void IncreaseAge()
        {
            Age++;
        }


    }
}
