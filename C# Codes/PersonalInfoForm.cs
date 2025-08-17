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
            string lastName = GetInput("Please enter your last name: ");
            string firstName = GetInput("Please enter your first name: ");
            string middleName = GetInput("Please enter your middle name: ");

            Console.WriteLine("Enter your birth date:");
            string birthMonth = GetInput("Month: ");
            string birthDay = GetInput("Day: ");
            string birthYear = GetInput("Year: ");

            int birthYearNumeric = int.Parse(birthYear);
            int currentAge = 2024 - birthYearNumeric;

            string gender = GetInput("Sex (Male/Female): ");
            string civilStatus = GetInput("Civil Status: ");
            string address = GetInput("Home Address: ");
            string schoolGraduated = GetInput("School graduated from: ");
            string academicStrand = GetInput("Strand: ");
            string generalAverage = GetInput("General weighted average: ");

            // Display information
            Console.WriteLine("\n**************************PERSONAL INFORMATION******************************");
            Console.WriteLine($"\nName: {firstName} {middleName} {lastName}");
            Console.WriteLine($"\nBirth Date: {birthMonth} {birthDay}, {birthYear}    Age: {currentAge}");
            Console.WriteLine($"\nSex: {gender}                       Civil Status: {civilStatus}");
            Console.WriteLine($"\nHome Address: {address}");
            Console.WriteLine($"\nSchool Graduated: {schoolGraduated}");
            Console.WriteLine($"\nStrand: {academicStrand}                     General average: {generalAverage}");
            Console.WriteLine("\n****************************************************************************");
        }
    }
}
