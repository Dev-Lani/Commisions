using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int inputYear = int.Parse(Console.ReadLine());
            int totalDays;

            if (inputYear % 4 == 0)
            {
                if (inputYear % 100 == 0)
                {
                    if (inputYear % 400 == 0)
                    {
                        totalDays = 366;
                    }
                    else
                    {
                        totalDays = 365;
                    }
                }
                else
                {
                    totalDays = 366;
                }
            }
            else
            {
                totalDays = 365;
            }

            Console.WriteLine($"The year {inputYear} has {totalDays} days");
        }
    }
}
