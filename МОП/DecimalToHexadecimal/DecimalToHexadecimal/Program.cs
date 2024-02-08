using System;

class Program
{
    static string DecimalToHexadecimal(int decimalNumber)
    {
        if (decimalNumber == 0)
        {
            return "0";
        }

        string hexadecimal = "";
        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 16;
            hexadecimal = (remainder < 10 ? (char)(remainder + '0') : (char)(remainder - 10 + 'A')) + hexadecimal;
            decimalNumber /= 16;
        }
        return hexadecimal;
    }

    static void Main()
    {
        Console.WriteLine("Въведете число в десетична бройна система:");
        if (!int.TryParse(Console.ReadLine(), out int decimalInput))
        {
            Console.WriteLine("Моля въведете валидно цяло число.");
            return;
        }

        string hexadecimalResult = DecimalToHexadecimal(decimalInput);
        Console.WriteLine($"Резултатът в шестнадесетична бройна система е: {hexadecimalResult}");
    }
}
