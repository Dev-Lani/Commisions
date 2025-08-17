using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            int days;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        days = 366;
                    }
                    else
                    {
                        days = 365;
                    }
                }
                else
                {
                    days = 366;
                }
            }
            else
            {
                days = 365;
            }

            Console.WriteLine($"The year {year} has {days} days");
        }
    }
}
