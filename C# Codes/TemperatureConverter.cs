using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsiusTemperature = Convert.ToDouble(Console.ReadLine());

        double fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;

        Console.WriteLine($"{celsiusTemperature}°C is equivalent to: {fahrenheitTemperature}°F");
    }
}
