using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double Celsius = Convert.ToDouble(Console.ReadLine());

        double fahr = (Celsius * 9 / 5) + 32;

        Console.WriteLine($"{Celsius}°C is equivalent to: {fahr}°F");
    }
}
