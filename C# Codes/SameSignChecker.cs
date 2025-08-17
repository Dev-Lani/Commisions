using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value 1: ");
            int firstValue = int.Parse(Console.ReadLine());

            Console.Write("Enter value 2: ");
            int secondValue = int.Parse(Console.ReadLine());

            string comparisonResult = (firstValue >= 0 && secondValue >= 0) || (firstValue < 0 && secondValue < 0)
                ? "The Same!"
                : "Not!";

            Console.WriteLine(comparisonResult);
        }
    }
}
