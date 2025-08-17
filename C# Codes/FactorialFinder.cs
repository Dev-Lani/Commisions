using System;

class Program
{
    static void Main()
    {
        int number = 5;
        double result = Factorial(number);
        Console.WriteLine($"The factorial of {number} is: {result}");
    }

    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}
