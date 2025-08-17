using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] inputNumbers = new int[6];

        Console.WriteLine("Enter 6 numbers:");
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }

        int[] squaredNumbers = inputNumbers.Select(n => n * n).ToArray();
        int[] cubedNumbers = inputNumbers.Select(n => n * n * n).ToArray();

        int totalSumOfSquares = squaredNumbers.Sum();
        int totalSumOfCubes = cubedNumbers.Sum();

        Console.WriteLine("\nNumber | Square | Cube");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            Console.WriteLine($"{inputNumbers[i],6} | {squaredNumbers[i],6} | {cubedNumbers[i],5}");
        }

        Console.WriteLine($"\nSum of Squares: {totalSumOfSquares}");
        Console.WriteLine($"Sum of Cubes: {totalSumOfCubes}");
    }
}
