using System;

class EA17_StudentNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number (n1): ");
        if (double.TryParse(Console.ReadLine(), out double n1))
        {
            Console.Write("Enter the second number (n2): ");
            if (double.TryParse(Console.ReadLine(), out double n2))
            {
                if (n1 > n2)
                {
                    double sum = n1 + n2;
                    Console.WriteLine($"The first number is larger. The sum of the numbers is: {sum}");
                }
                else
                {
                    double product = n1 * n2;
                    Console.WriteLine($"The second number is larger or equal. The product of the numbers is: {product}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number for n2.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for n1.");
        }
    }
}
