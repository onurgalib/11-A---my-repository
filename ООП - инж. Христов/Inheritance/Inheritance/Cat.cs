using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal
    {
        public Cat(string name, int age, double weight) : base(name, age, weight)
        {}
        public Cat(string name, int age, double weight,int lives, CatBreed breed):this(name, age, weight)
        {
            Lives = lives;
            Breed = breed;
        }
        public int Lives { get; set; } = 9;
        public CatBreed Breed { get; set; }
        public void Meaw ()
        {
            Console.WriteLine(FullName);
            Console.WriteLine("Miew Meaw");
        }
    }
}
