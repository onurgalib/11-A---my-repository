using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        protected double speedMetersPerSecond =2;

        public Animal(string name, int age, double weight)
        {
            FullName = name;
            Age = age;
            Weight = weight;
        }

        public string FullName { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public int RunForTimeSeconds(double distanceMeters)
        {
            int timeRequired = (int)Math.Ceiling(distanceMeters / speedMetersPerSecond);
            return timeRequired;
        }

}
}
