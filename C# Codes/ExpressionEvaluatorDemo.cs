using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int X = 10;
            int Y = 5;

            int calculation1 = ((X > Y ? X + Y : X * Y) + 12 * 4 % 5) + 150;
            int calculation2 = (((X | 5) + (Y ^ 5)) * 25 % 10) * 5;
            int calculation3 = (X * X + 2 * Y) + (200 / 5) * X;

            Console.WriteLine($"The answer for No. 1 is: {calculation1}");
            Console.WriteLine($"The answer for No. 2 is: {calculation2}");
            Console.WriteLine($"The answer for No. 3 is: {calculation3}");
        }
    }
}
