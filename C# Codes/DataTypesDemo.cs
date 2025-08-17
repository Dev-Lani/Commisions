using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string programTitle = "My Program";
            char grade = 'A';
            int number = 99;
            float decimalValue = 9.99f;
            double largeDecimal = 88.88;
            bool isFalse = false;

            Console.WriteLine($"String Value: {programTitle}");
            Console.WriteLine($"Character Value: {grade}");
            Console.WriteLine($"Integer Value: {number}");
            Console.WriteLine($"Float Value: {decimalValue}");
            Console.WriteLine($"Double Value: {largeDecimal}");
            Console.WriteLine($"Boolean Value: {isFalse}");
        }
    }
}
