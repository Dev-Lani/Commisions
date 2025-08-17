using System;

class Program
{
    static void Main()
    {
        int[,] FloatArray = new int[5, 5];
        int sum = 0;

        Console.WriteLine("Enter 25 integer elements for a 5x5 array:");

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Element [{i + 1}, {j + 1}]: ");
                FloatArray[i, j] = int.Parse(Console.ReadLine());
                sum += FloatArray[i, j];
            }
        }

        int highest = FloatArray[0, 0];
        int smallest = FloatArray[0, 0];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (FloatArray[i, j] > highest)
                {
                    highest = FloatArray[i, j];
                }
                if (FloatArray[i, j] < smallest)
                {
                    smallest = FloatArray[i, j];
                }
            }
        }

        Console.WriteLine($"Highest: {highest}");
        Console.WriteLine($"Smallest: {smallest}");
        Console.WriteLine($"Sum: {sum}");
    }
}
