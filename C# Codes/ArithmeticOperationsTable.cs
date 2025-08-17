using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Input values for X and Y
            Console.Write("Enter value for X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter value for Y: ");
            int y = int.Parse(Console.ReadLine());

            // Display table headers
            Console.WriteLine("\nX-Value Y-Value Expression Result");

            // Perform each operation and display results
            int result = x + y;
            Console.WriteLine($"{x} {y} X += Y X = {result}");

            result = (x - 2) - y;
            Console.WriteLine($"{x} {y} X -= Y - 2 X = {result}");

            result = x * (y * 5);
            Console.WriteLine($"{x} {y} X *= Y * 5 X = {result}");

            result = x / y;
            Console.WriteLine($"{x} {y} X /= Y X = {result}");

            result = x % y;
            Console.WriteLine($"{x} {y} X %= Y X = {result}");
        }
    }
}
