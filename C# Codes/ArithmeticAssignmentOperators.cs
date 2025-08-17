using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value for X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter value for Y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("\nX-Value Y-Value Expression Result");

            int calculationResult = x + y;
            Console.WriteLine($"{x} {y} X += Y X = {calculationResult}");

            calculationResult = (x - 2) - y;
            Console.WriteLine($"{x} {y} X -= Y - 2 X = {calculationResult}");

            calculationResult = x * (y * 5);
            Console.WriteLine($"{x} {y} X *= Y * 5 X = {calculationResult}");

            calculationResult = x / y;
            Console.WriteLine($"{x} {y} X /= Y X = {calculationResult}");

            calculationResult = x % y;
            Console.WriteLine($"{x} {y} X %= Y X = {calculationResult}");
        }
    }
}
