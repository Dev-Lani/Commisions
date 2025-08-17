using System;


class Program
{
    static void Main()
    {
        int[] numbers = new int[6];

        Console.WriteLine("Enter 6 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] squares = numbers.Select(n => n * n).ToArray();
        int[] cubes = numbers.Select(n => n * n * n).ToArray();

        int sumOfSquares = squares.Sum();
        int sumOfCubes = cubes.Sum();

        Console.WriteLine("\nNumber | Square | Cube");
        Console.WriteLine("-------------------------");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i],6} | {squares[i],6} | {cubes[i],5}");
        }

        Console.WriteLine($"\nSum of Squares: {sumOfSquares}");
        Console.WriteLine($"Sum of Cubes: {sumOfCubes}");
    }
}
