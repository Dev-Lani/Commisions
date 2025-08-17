using System;

class Program
{
    static void Main()
    {
        // Sample input values
        int n1 = 10, n2 = 25, n3 = 5;
        int x1 = 15, x2 = 30, x3 = 20;

        // Call Min and Max methods
        int smallest = Min(n1, n2, n3);
        int largest = Max(x1, x2, x3);

        // Output the results
        Console.WriteLine($"The smallest value is: {smallest}");
        Console.WriteLine($"The largest value is: {largest}");
    }

    // Min method to find the smallest value
    static int Min(int n1, int n2, int n3)
    {
        int smallest = n1;

        if (n2 < smallest)
        {
            smallest = n2;
        }

        if (n3 < smallest)
        {
            smallest = n3;
        }

        return smallest;
    }

    // Max method to find the largest value
    static int Max(int x1, int x2, int x3)
    {
        int largest = x1;

        if (x2 > largest)
        {
            largest = x2;
        }

        if (x3 > largest)
        {
            largest = x3;
        }

        return largest;
    }
}
