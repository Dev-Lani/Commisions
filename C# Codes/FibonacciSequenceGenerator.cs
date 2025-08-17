using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter how many: ");
        int count = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[count];
        int sum = 0;

        if (count >= 1) fibonacci[0] = 1;
        if (count >= 2) fibonacci[1] = 1;

        for (int i = 2; i < count; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }

        Console.Write("Fibonacci Sequence: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(fibonacci[i] + " ");
            sum += fibonacci[i];
        }

        Console.WriteLine();
        Console.WriteLine("Sum of Sequence: " + sum);
    }
}
