using System;

class Program
{
    static void Main(string[] args)
    {
        int[] years = new int[5];
        int leapYearCount = 0, nonLeapYearCount = 0;

        Console.WriteLine("Enter five (5) years:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Year {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out years[i]))
            {
                if (IsLeapYear(years[i]))
                {
                    Console.WriteLine($"{years[i]} is a leap year.");
                    leapYearCount++;
                }
                else
                {
                    Console.WriteLine($"{years[i]} is not a leap year.");
                    nonLeapYearCount++;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                i--;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Number of leap years: {leapYearCount}");
        Console.WriteLine($"Number of non-leap years: {nonLeapYearCount}");

        // Display result
        if (leapYearCount > nonLeapYearCount)
        {
            Console.WriteLine("More leap years.");
        }
        else
        {
            Console.WriteLine("Less leap years.");
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
