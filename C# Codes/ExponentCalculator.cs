using System;

class Program
{
    static void Main(string[] args)
    {
        string tryAgain = "Y";

        while (tryAgain.ToUpper() == "Y")
        {
            Console.Write("Enter base: ");
            int baseValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            int result = CalculateExponent(baseValue, exponent);

            Console.WriteLine($"{baseValue} raised to {exponent} = base {baseValue}, exponent {exponent} = {result}");

            Console.Write("Try again: [Y/N]: ");
            tryAgain = Console.ReadLine();
        }

        Console.WriteLine("Program terminated normally.");
    }

    static int CalculateExponent(int baseValue, int exponent)
    {
        int result = 1;

        for (int i = 1; i <= exponent; i++)
        {
            result *= baseValue;
        }

        return result;
    }
}
