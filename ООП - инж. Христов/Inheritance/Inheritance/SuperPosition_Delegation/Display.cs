using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SuperPosition_Delegation
{
    public class display
    {
        private int[] brightnessRange = new int[] { 0, 10 };
        private int brightnessLevel = 5;
        public double SizeInches { get; set; }
        public int HeightResolution { get; set; } = 1080;
        public int WidthResolution { get; set; } = 1920;
        public TypeOfCover TypeOfCover { get; set; }
        public int IncreaseBrightness()
        {
            if(brightnessLevel < brightnessRange[1])
            {
                brightnessLevel++;
            }
            return brightnessLevel;
        }
        public int DecreaseBrightness()
        {
            if (brightnessLevel > brightnessRange[0])
            {
                brightnessLevel--;
            }
            return brightnessLevel;
        }
    }
    public enum TypeOfCover
    {
        Glosyy,Matt
    }
    public class SmartPhone
    {
        public SmartPhone(string model)
        {
            Model = model;
            display = new display();
        }

        public SmartPhone(string model, display display):this(model)
        {
            display = display;
        }

        public string Model  { get; set; }

        private display display;

        public void MakeBrighter()
        {
            int currentBrightnessLevel = display.IncreaseBrightness();
            Console.WriteLine(  $"Brightness was set to {currentBrightnessLevel}");
        }
    }
}
