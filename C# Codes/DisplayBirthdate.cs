using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate in terms of:");
            Console.Write("Month: ");
            string birthMonth = Console.ReadLine();

            Console.Write("Day: ");
            string birthDay = Console.ReadLine();

            Console.Write("Year: ");
            string birthYear = Console.ReadLine();

            Console.WriteLine($"Your Birthday is: {birthMonth} {birthDay}, {birthYear}");
        }
    }
}
