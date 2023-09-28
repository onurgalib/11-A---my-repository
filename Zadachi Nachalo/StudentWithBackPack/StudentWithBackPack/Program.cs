using System.Collections.Generic;
using System;
using System.Linq;

namespace StudentWithBackPack
{
    internal class Program
    {
        static void Main()
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
                // student.BackPack = new BackPack() { Color = "Oranjeva", Price = 19.99m, Volume = 15.6d };
                // student.BackPack.Color = "Oranjevo";
                students.Add(student);
                Console.WriteLine("Input another student? Y/N");
                string answer = Console.ReadLine().ToUpper();
                if (answer.StartsWith("N"))
                {
                    break;
                }
                Console.WriteLine(new string('=', 20));
            }
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Grades Phase");
            Console.WriteLine(new string('=', 20));
            Console.WriteLine("Choose Student from List:");
            for (int i = 0; i < students.Count(); i++)
            {
                var current = students[i];
                Console.WriteLine($"[{i + 1}.] {current.Name} {current.FamilyName}");
            }
            Console.WriteLine(new string('=', 20));

            while (true)
            {
                Console.Write("Choose Student Number OR stop:");
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int chosenIndex = int.Parse(input) - 1;
                Student selectedStudent = students[chosenIndex];
                Console.WriteLine("Input grades separated with spaces/ex. 3 5 6 2/");
                var grades = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                selectedStudent.Grades.AddRange(grades);
            }
            Console.Clear();
            Console.WriteLine("Awards Phase: ");
            foreach (Student s in students.OrderByDescending(x => x.Age))
            {
                Console.WriteLine($"{s.Name} {s.FamilyName}. Age - {s.Age}");
                Console.WriteLine($"Has Backpack : {s.BackPack.Color} - color");
                Console.WriteLine($"Average Score : {s.GetAverageGrade():F2}");
                Console.WriteLine(new string('~', 20));
            }

            #region LastTimeDemo
            //Student st1 = new Student() { Name = "Gancho", FamilyName = "Petrov", Age = 15 };
            //BackPack bp1 = new BackPack() { Volume = 15.6, Color = "Camoflage", Price = 69.75m };
            //st1.BackPack = bp1;
            ////  st1.Grades = new List<int>();
            //st1.Grades.Add(5);
            //st1.Grades.Add(4);
            //st1.Grades.Add(6);
            //st1.Grades.Add(5);
            //st1.Grades.Add(6);
            //Console.WriteLine("Sreden uspeh e :" + st1.GetAverageGrade()); 
            #endregion
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

        public BackPack BackPack { get; set; } = new BackPack() { Color = "Cherven", Price = 19.99m, Volume = 15.6d };

        public List<int> Grades { get; set; } = new List<int>();

        public void PresentYourSelf()
        {
            //Console.WriteLine($"I am {name} and I am {Age} years old!");
            //IncreaseAge();
        }

        public double GetAverageGrade()
        {
            //  double result = Grades.Sum()/Grades.Count();
            double result = Grades.Average();
            return result;
        }
        private void IncreaseAge()
        {
            Age++;
        }
    }




}