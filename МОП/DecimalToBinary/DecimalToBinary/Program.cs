using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Въведете число в десетична бройна система:");
        int input = Convert.ToInt32(Console.ReadLine());

        string binary = DecimalToBinary(input);

        Console.WriteLine($"Числото {input} в двоична бройна система е: {binary}");
    }

    static string DecimalToBinary(int number)
    {
        if (number == 0)
            return "0";

        string result = "";

        while (number > 0)
        {
            int remainder = number % 2;
            result = remainder + result;
            number /= 2;
        }

        return result;
    }
}
