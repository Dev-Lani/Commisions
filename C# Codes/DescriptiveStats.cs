using System;

class Program
{
    static void Main()
    {
        // Array to store 15 scores
        double[] scores = new double[15];

        Console.WriteLine("Enter the scores of 15 students:");

        // Input scores 
        for (int i = 0; i < scores.Length; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = double.Parse(Console.ReadLine());
        }

        // Mean
        double total = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            total += scores[i];
        }
        double mean = total / scores.Length;

        // Minimum and Maximum
        double min = scores[0];
        double max = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min) min = scores[i];
            if (scores[i] > max) max = scores[i];
        }

        // Range
        double range = max - min;

        // Variance
        double sumOfSquares = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sumOfSquares += Math.Pow(scores[i] - mean, 2);
        }
        double variance = sumOfSquares / scores.Length;

        // Standard Deviation
        double standardDeviation = Math.Sqrt(variance);

        Console.WriteLine("\nDescriptive Statistics:");
        Console.WriteLine($"Mean: {mean:F2}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Range: {range}");
        Console.WriteLine($"Variance: {variance:F2}");
        Console.WriteLine($"Standard Deviation: {standardDeviation:F2}");
    }
}
