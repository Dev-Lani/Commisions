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

            // Collecting student's information
            string studentNumber = GetInput("Please enter your Student Number: ");
            string fullName = GetInput("Please enter your Full Name (First Middle Last): ");
            string college = GetInput("Please enter your College: ");
            string programCourse = GetInput("Please enter your Program/Course: ");
            string section = GetInput("Please enter your Section: ");
            string highSchoolType = GetInput("Type of High School Graduated from (Private/Public): ");
            string highSchoolName = GetInput("Name of High School Graduated from: ");
            string planAfterCompletion = GetInput("Plan after completion of the Program/Course: ");

            // Display student's information with the specified format
            Console.WriteLine("\n**************************STUDENT’S INFORMATION******************************");
            Console.WriteLine($"\nStudent Number: {studentNumber}     Full Name: {fullName}");
            Console.WriteLine($"\nCollege: {college}");
            Console.WriteLine($"\nProgram/Course: {programCourse}");
            Console.WriteLine($"\nSection: {section}                  Type of High School Graduated from: {highSchoolType}");
            Console.WriteLine($"\nName of High School Graduated from: {highSchoolName}");
            Console.WriteLine($"\nPlan after completion of the Program/Course: {planAfterCompletion}");
            Console.WriteLine("\n***********************************************************************************");
        }
    }
}
