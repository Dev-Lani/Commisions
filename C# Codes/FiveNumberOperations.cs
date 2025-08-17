using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int value2 = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            int value3 = int.Parse(Console.ReadLine());

            Console.Write("Enter 4th number: ");
            int value4 = int.Parse(Console.ReadLine());

            Console.Write("Enter 5th number: ");
            int value5 = int.Parse(Console.ReadLine());

            int sum = value1 + value2 + value3 + value4 + value5;
            int avg = value1 + value2 + value3 + value4 + value5 / 5;
            int product = value1 * value2 * value3 * value4 * value5;
            int sumOfSquares = (value1 * value1) + (value2 * value2) + (value3 * value3) + (value4 * value4) + (value5 * value5);

            Console.WriteLine($"\nSum --> {value1} + {value2} + {value3} + {value4} + {value5} = {sum}");
            Console.WriteLine($"Average --> ({value1} + {value2} + {value3} + {value4} + {value5}) / 5 = {avg:F2}");
            Console.WriteLine($"Product --> {value1} x {value2} x {value3} x {value4} x {value5} = {product}");
            Console.WriteLine($"Sum of Squares = {value1} x {value1} + {value2} x {value2} + {value3} x {value3} + {value4} x {value4} + {value5} x {value5} = {sumOfSquares}");
        }
    }
}