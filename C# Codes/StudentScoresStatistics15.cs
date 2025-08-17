using System;

class Program
{
    static void Main()
    {
        // Array to store 15 scores
        double[] studentScores = new double[15];

        Console.WriteLine("Enter the scores of 15 students:");

        // Input scores 
        for (int index = 0; index < studentScores.Length; index++)
        {
            Console.Write($"Score {index + 1}: ");
            studentScores[index] = double.Parse(Console.ReadLine());
        }

        // Mean
        double totalScore = 0;
        for (int index = 0; index < studentScores.Length; index++)
        {
            totalScore += studentScores[index];
        }
        double meanScore = totalScore / studentScores.Length;

        // Minimum and Maximum
        double minScore = studentScores[0];
        double maxScore = studentScores[0];
        for (int index = 1; index < studentScores.Length; index++)
        {
            if (studentScores[index] < minScore) minScore = studentScores[index];
            if (studentScores[index] > maxScore) maxScore = studentScores[index];
        }

        // Range
        double scoreRange = maxScore - minScore;

        // Variance
        double sumOfSquares = 0;
        for (int index = 0; index < studentScores.Length; index++)
        {
            sumOfSquares += Math.Pow(studentScores[index] - meanScore, 2);
        }
        double varianceScore = sumOfSquares / studentScores.Length;

        // Standard Deviation
        double standardDeviationScore = Math.Sqrt(varianceScore);

        Console.WriteLine("\nDescriptive Statistics:");
        Console.WriteLine($"Mean: {meanScore:F2}");
        Console.WriteLine($"Minimum: {minScore}");
        Console.WriteLine($"Maximum: {maxScore}");
        Console.WriteLine($"Range: {scoreRange}");
        Console.WriteLine($"Variance: {varianceScore:F2}");
        Console.WriteLine($"Standard Deviation: {standardDeviationScore:F2}");
    }
}
