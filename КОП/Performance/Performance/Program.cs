using System.Diagnostics;

namespace Performance
{
    internal class Program
    {
        static void Main()
        {
            int coresNumber= Environment.ProcessorCount;
            Console.WriteLine("Our PC Core Count is: " +coresNumber);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            SlowMethod(1000000);
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
        private static void SlowMethod(int topBorder=10000)
        {
            Console.WriteLine("Thread That Runs Our Program has ID"+Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Hello, World!");
            Thread.Sleep(10000);
            Console.WriteLine("Goodbye, World!");
            int a = 0;
            for (int i = 0; i < topBorder; i++)
            {
                a *= i;
            }
        }
    }
}
