using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number between 1 and 12: ");
        if (int.TryParse(Console.ReadLine(), out int monthNumber))
        {
            if (monthNumber == 1)
            {
                Console.WriteLine("The month is January.");
            }
            else if (monthNumber == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (monthNumber == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (monthNumber == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (monthNumber == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (monthNumber == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (monthNumber == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (monthNumber == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (monthNumber == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (monthNumber == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (monthNumber == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (monthNumber == 12)
            {
                Console.WriteLine("The month is December.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
