using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string stringValue = "My Program";
            char charValue = 'A';
            int integerValue = 25;
            float floatValue = 1.11f;
            double doubleValue = 99.99;
            bool boolValue = true;

            Console.WriteLine($"String Value: {stringValue}");
            Console.WriteLine($"Character Value: {charValue}");
            Console.WriteLine($"Integer Value: {integerValue}");
            Console.WriteLine($"Float Value: {floatValue}");
            Console.WriteLine($"Double Value: {doubleValue}");
            Console.WriteLine($"Boolean Value: {boolValue}");
        }
    }
}