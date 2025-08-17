using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter seven positive integers:");

        Console.Write("Enter number 1: ");
        int number = int.Parse(Console.ReadLine());
        int largest = number;
        int smallest = number;

        for (int i = 2; i <= 7; i++)
        {
            Console.Write($"Enter number {i}: ");
            number = int.Parse(Console.ReadLine());

            largest = (number > largest) ? number : largest;
            smallest = (number < smallest) ? number : smallest;
        }

        Console.WriteLine($"\nLargest number: {largest}");
        Console.WriteLine($"Smallest number: {smallest}");
    }
}
