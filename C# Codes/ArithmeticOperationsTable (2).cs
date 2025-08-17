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

            Console.WriteLine("X-Value Y-Value Expression Result");
            Console.WriteLine($"{X}    {Y}    X    =    Y + 3 X    = {Y + 3}");
            Console.WriteLine($"{X}    {Y}    X    =    Y - 2 X    = {Y - 2}");
            Console.WriteLine($"{X}    {Y}    X    =    Y * 5 X    = {Y * 5}");
            Console.WriteLine($"{X}    {Y}    X    =    X / Y X    = {X / Y}");
            Console.WriteLine($"{X}    {Y}    X    =    X % Y X    = {X % Y}");
        }
    }
}
