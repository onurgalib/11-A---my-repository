using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWithBackPack
{
    internal class Program
    {
        private static object selectedStudent;

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                Console.Write("Input student name: ");
                string studentName = Console.ReadLine();
                Console.Write("Input student family name: ");
                string studentFamilyName = Console.ReadLine();
                Console.Write("Input student age: ");
                int studentAge = int.Parse(Console.ReadLine());
                Student student = new Student() { Name = studentName, FamilyName = studentFamilyName, Age = studentAge };
                //student.BackPack = new BackPack() { Color = "Oranjevo", Price = 19.99m, Volume = 15.6d };
                //student.BackPack.Color = "Oranjevo";
                students.Add(student);
                Console.WriteLine("Input another student? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer.StartsWith("N"))
                {
                    break;
                }
                Console.WriteLine(new string('=', 40));
            }
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Input Grades");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Choose Student from List: ");
            for (int i = 0; i < students.Count(); i++)
            {
                var current = students[i];
                Console.WriteLine($"[{i+1}.] {current.Name} {current.FamilyName}. {current.Age} old!");
            }
            Console.Write("Choose Student Number OR stop: ");
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }
            int chosenIndex = int.Parse(input)-1;
            Student selectionStudent = students[chosenIndex];
            Console.WriteLine("Inpur grades separated with spaces/ex. 3 5 6 2");
            string gradesString = Console.ReadLine();
            var grades = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            selectedStudent.Grades.AddRange = (grades);
            foreach (var item in collection)
            {

            }


            Student st1 = new Student() { Name = "Gancho", FamilyName = "Petrov", Age = 15 };
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
        public decimal Price { get; set; }
    }
    public class Student
    {
        public string Name { get; set; }
        private string familyName;


        public string FamilyName
        {
            get
            {
                return familyName.ToUpper().Substring(0, 1) + ".";
            }
            set => familyName = value;
        }

        public int Age { get; set; }
        public BackPack BackPack { get; set; }
        public List<int> Grades { get; set; }
        public double GetAverageGrade()
        {
            double result = Grades.Sum() / Grades.Count();
            return result;
        }
        public void PresentYourself()
        {
            //  Console.WriteLine($"I am {Name} and I am {Age} ");
            //  IncreaseAge();
        }
        public double GetAverageGrades()
        {
            return Grades.Average();
        }
        private void IncreaseAge()
        {
            Age++;
        }


    }
}
