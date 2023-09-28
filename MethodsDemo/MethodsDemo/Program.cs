namespace MethodsDemo
{
    internal class Program
    {
        private static double favoriteNumber;

        static void Main()
        {
            GetNum("alabala", 6);
            ChangeOil("Ford Focus Gen2");
            ChangeOil("Ford Focus Gen2", "duperMaslo", "full", true);//izrejdame poredni parametri
            ChangeOil(model: "Ford Mustang", reffilFuel: true); //preskachane na opt parametur
            ChangeOil(howMuch: "quarter", model: "C200 Mercedess");
            Refuel("ford-mustang 87");
            Refuel("ford-mustang 87", "benzine");
            Refuel("ford-mustang 87", "benzine", 0.98);
            int[] nums = { 1, 4, 6, 8, 12 };
            Console.WriteLine("Sumata na chislata e:" + SumNumbers(nums));
            Console.WriteLine("Sumata na chislata e:" + SumNumbers(10.43,2.7));
        }

        private static string SumNumbers(int[] nums)
        {
            throw new NotImplementedException();
        }

        public static double SumNumbers(double favoriteNumber, params double[] numbers)
        {
            double result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += result+ numbers[i];
            }
            result *= favoriteNumber;
            return result;
        }






        public static void ChangeOil(string model, string oil = "superMaslo", string howMuch = "half", bool reffilFuel=false)
        {
            Console.WriteLine("we change oil best");
        }
        //Overloading
        private static void Refuel()
        {
            throw new NotImplementedException();
        }
        private static void Refuel(string model)
        {
            throw new NotImplementedException();
        }
        public static void Refuel (string model, string fuelType)
        {
            Refuel(model);
            Console.WriteLine($"fuell added was {fuelType}");
        }
        public static void Refuel(string model, string fuelType,double quantityPercentage)
        {
            Refuel(model, fuelType);
            Console.WriteLine($"filled it to{quantityPercentage*100}% of cappacity");
        }
        public static int GetNum(string s1, int num1 = 6)
        {
            return 5;
        }
        //public static void Refuel(string model, string fuelType, double quantityPercentage)
        //{
        //    Refuel(model);
        //    Console.WriteLine("we refuel cars best, knowing model is{model}");
            
        //}

    }

}    
