using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Helper function to get non-empty input from the user
            string GetInput(string prompt)
            {
                string input;
                do
                {
                    Console.Write(prompt);
                    input = Console.ReadLine()?.Trim();
                }
                while (string.IsNullOrEmpty(input));
                return input;
            }

            // User information input
            string lName = GetInput("Please enter your last name: ");
            string fName = GetInput("Please enter your first name: ");
            string mName = GetInput("Please enter your middle name: ");

            Console.WriteLine("Enter your birth date:");
            string month = GetInput("Month: ");
            string day = GetInput("Day: ");
            string year = GetInput("Year: ");

            int birthYear = int.Parse(year);
            int age = 2024 - birthYear;

            string sex = GetInput("Sex (Male/Female): ");
            string civilStat = GetInput("Civil Status: ");
            string homeAddress = GetInput("Home Address: ");
            string schoolGrad = GetInput("School graduated from: ");
            string strand = GetInput("Strand: ");
            string genAvg = GetInput("General weighted average: ");

            // Display information
            Console.WriteLine("\n**************************PERSONAL INFORMATION******************************");
            Console.WriteLine($"\nName: {fName} {mName} {lName}");
            Console.WriteLine($"\nBirth Date: {month} {day}, {year}    Age: {age}");
            Console.WriteLine($"\nSex: {sex}                       Civil Status: {civilStat}");
            Console.WriteLine($"\nHome Address: {homeAddress}");
            Console.WriteLine($"\nSchool Graduated: {schoolGrad}");
            Console.WriteLine($"\nStrand: {strand}                     General average: {genAvg}");
            Console.WriteLine("\n****************************************************************************");
        }
    }
}
