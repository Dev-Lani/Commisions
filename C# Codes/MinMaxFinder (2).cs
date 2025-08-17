using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter seven positive integers:");

        Console.Write("Enter number 1: ");
        int currentNumber = int.Parse(Console.ReadLine());
        int largestNumber = currentNumber;
        int smallestNumber = currentNumber;

        for (int i = 2; i <= 7; i++)
        {
            Console.Write($"Enter number {i}: ");
            currentNumber = int.Parse(Console.ReadLine());

            largestNumber = (currentNumber > largestNumber) ? currentNumber : largestNumber;
            smallestNumber = (currentNumber < smallestNumber) ? currentNumber : smallestNumber;
        }

        Console.WriteLine($"\nLargest number: {largestNumber}");
        Console.WriteLine($"Smallest number: {smallestNumber}");
    }
}
