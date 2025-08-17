using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[6];
        int oddSum = 0, evenSum = 0;

        Console.WriteLine("Enter six (6) numbers:");

        // Accept 6 numbers
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Number {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"{numbers[i]} is an even number.");
                    evenSum += numbers[i];
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is an odd number.");
                    oddSum += numbers[i];
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Retry the current iteration
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Sum of odd numbers: {oddSum}");
        Console.WriteLine($"Sum of even numbers: {evenSum}");

        // Compare sums and calculate based on the condition
        if (oddSum > evenSum)
        {
            Console.WriteLine("The sum of odd numbers is greater than the sum of even numbers.");
            Console.WriteLine($"Result: {oddSum}");
        }
        else
        {
            Console.WriteLine("The sum of even numbers is greater than or equal to the sum of odd numbers.");
            Console.WriteLine($"Result: {evenSum}");
        }
    }
}
