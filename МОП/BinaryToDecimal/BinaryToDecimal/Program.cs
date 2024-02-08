using System;

class Program
{
    static string DecimalToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string binary = "";
        while (decimalNumber > 0)
        {
            binary = (decimalNumber % 2) + binary;
            decimalNumber /= 2;
        }
        return binary;
    }

    static void Main()
    {
        Console.WriteLine("Въведете число в десетична бройна система:");
        if (!int.TryParse(Console.ReadLine(), out int decimalInput) || decimalInput < 0)
        {
            Console.WriteLine("Моля въведете положително число.");
            return;
        }

        if (decimalInput > 2147483647) // максималната стойност на int32
        {
            Console.WriteLine("Въведеното число е по-голямо от максималната стойност на int32.");
            return;
        }

        string binaryResult = DecimalToBinary(decimalInput);
        Console.WriteLine($"Резултатът в двоична бройна система е: {binaryResult}");
    }
}
