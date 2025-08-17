using System;

class Program
{
    static void Main()
    {
        double[,] ArrScores = new double[5, 5];
        double sum = 0;
        int totalElements = 25;

        Console.WriteLine("Enter 25 elements for a 5x5 array:");

        // Input values for the 5x5 array
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Element [{i + 1}, {j + 1}]: ");
                ArrScores[i, j] = double.Parse(Console.ReadLine());
                sum += ArrScores[i, j];
            }
        }

        // Calculate the Mean
        double mean = sum / totalElements;

        // Calculate the Variance
        double varianceSum = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                varianceSum += Math.Pow(ArrScores[i, j] - mean, 2);
            }
        }
        double variance = varianceSum / totalElements;

        // Calculate the Standard Deviation
        double standardDeviation = Math.Sqrt(variance);

        // Output the results
        Console.WriteLine($"Mean: {mean}");
        Console.WriteLine($"Variance: {variance}");
        Console.WriteLine($"Standard Deviation: {standardDeviation}");
    }
}
