using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the input reference number for the processing of output: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number of row/s: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j <= n / 2; j++)
            {
                Console.Write(j + " " + (n - j + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
