using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the input reference number for the processing of output: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
