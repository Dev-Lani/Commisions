using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate in terms of:");
            Console.Write("Month: ");
            string Month = Console.ReadLine();

            Console.Write("Day: ");
            string Day = Console.ReadLine();

            Console.Write("Year: ");
            string Year = Console.ReadLine();

            Console.WriteLine($"Your Birthday is: {Month} {Day}, {Year}");
        }
    }
}