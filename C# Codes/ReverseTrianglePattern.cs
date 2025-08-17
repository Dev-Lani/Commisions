using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the input reference number for the processing of output: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = n; j > n - i - 1; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
