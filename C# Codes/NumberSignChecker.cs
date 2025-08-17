using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter a number: ");
            int value = int.Parse(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("The value is Negative");
            }

            else if (value > 0)
            {
                Console.WriteLine("The value is Positive");
            }

            else
            {
                Console.WriteLine("The value is Zero");

            }
        }
    }
}