using System;

class Program
{
    static void Main()
    {
        int[,] Transpose = new int[4, 4];
        int[,] Transposed = new int[4, 4];

        Console.WriteLine("Enter the elements for a 4x4 array:");

        // Input values for the original 4x4 array
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"Element [{i + 1}, {j + 1}]: ");
                Transpose[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Transpose the array
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Transposed[j, i] = Transpose[i, j];
            }
        }

        // Display the original and transposed arrays
        Console.WriteLine("\nOriginal Entries:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(Transpose[i, j] + " ");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("\nTransposed Entries:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(Transposed[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
