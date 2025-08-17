using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter value 1: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.Write("Enter value 2: ");
            int val2 = int.Parse(Console.ReadLine());

            string result = (val1 >= 0 && val2 >= 0) || (val1 < 0 && val2 < 0) ? "The Same!" : "Not!";

            Console.WriteLine(result);
        }
    }
}