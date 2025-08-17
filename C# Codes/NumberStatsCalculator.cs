using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask how many numbers the user wants to input
        Console.Write("Enter how many number/s to read: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int highest = int.MinValue;  // Initialize to a very small number
        int smallest = int.MaxValue; // Initialize to a very large number
        int oddCount = 0;
        int evenCount = 0;

        // Loop to read the specified number of inputs
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Update sum
            sum += number;

            // Find the highest and smallest number
            if (number > highest)
                highest = number;

            if (number < smallest)
                smallest = number;

            // Count odd and even numbers
            if (number % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        // Calculate average
        double average = (double)sum / n;

        // Display results
        Console.WriteLine();  // For an empty line before output
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average:F4}");
        Console.WriteLine($"Highest = {highest}");
        Console.WriteLine($"Smallest = {smallest}");
        Console.WriteLine($"No. of Odd number/s: {oddCount}");
        Console.WriteLine($"No. of Even number/s: {evenCount}");
    }
}
