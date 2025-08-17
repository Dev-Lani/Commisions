using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter value for X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Enter value for Y: ");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Original values: X = {X}, Y = {Y}");

            int tempX = X, tempY = Y;
            X = tempY;
            Y = tempX;

            Console.WriteLine($"Swap values: X = {X}, Y = {Y}");
        }
    }
}
