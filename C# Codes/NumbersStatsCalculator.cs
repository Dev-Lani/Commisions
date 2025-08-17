using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter 4th number: ");
            int num4 = int.Parse(Console.ReadLine());

            Console.Write("Enter 5th number: ");
            int num5 = int.Parse(Console.ReadLine());

            int total = num1 + num2 + num3 + num4 + num5;
            int average = (num1 + num2 + num3 + num4 + num5) / 5;
            int product = num1 * num2 * num3 * num4 * num5;
            int sumOfSquares = (num1 * num1) + (num2 * num2) + (num3 * num3) + (num4 * num4) + (num5 * num5);

            Console.WriteLine($"\nSum --> {num1} + {num2} + {num3} + {num4} + {num5} = {total}");
            Console.WriteLine($"Average --> ({num1} + {num2} + {num3} + {num4} + {num5}) / 5 = {average:F2}");
            Console.WriteLine($"Product --> {num1} x {num2} x {num3} x {num4} x {num5} = {product}");
            Console.WriteLine($"Sum of Squares = {num1} x {num1} + {num2} x {num2} + {num3} x {num3} + {num4} x {num4} + {num5} x {num5} = {sumOfSquares}");
        }
    }
}
