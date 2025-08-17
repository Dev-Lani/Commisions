using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will compute the number of years and days between two years.");

        Console.Write("Enter the starting year: ");
        int startYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the ending year: ");
        int endYear = Convert.ToInt32(Console.ReadLine());

        int totalYears = endYear - startYear + 1;
        int totalDays = CalculateDays(startYear, endYear);

        Console.WriteLine($"No. of year/s: {totalYears}");
        Console.WriteLine($"No. of days: {totalDays}");
    }

    static int CalculateDays(int startYear, int endYear)
    {
        int totalDays = 0;

        for (int year = startYear; year <= endYear; year++)
        {
            totalDays += IsLeapYear(year) ? 366 : 365;
        }

        return totalDays;
    }

    static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
}
