using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Helper function to get numeric input from the user
            double GetInput(string message)
            {
                double value;
                do
                {
                    Console.Write(message);
                }
                while (!double.TryParse(Console.ReadLine(), out value));
                return value;
            }

            // Student information input
            Console.Write("Enter Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Course: ");
            string studentCourse = Console.ReadLine();

            // Midterm Period Inputs
            Console.WriteLine("\n=============MIDTERM PERIOD=============");
            double quiz1Midterm = GetInput("Enter Quiz-1 Score: ");
            double quiz2Midterm = GetInput("Enter Quiz-2 Score: ");
            double classStandingMidterm = GetInput("Enter Class Standing Grade: ");
            double examMidterm = GetInput("Enter Exam Grade: ");
            double labGradeMidterm = GetInput("Enter Midterm Lab Grade: ");

            // Final Period Inputs
            Console.WriteLine("\n===============FINAL PERIOD==============");
            double quiz1Final = GetInput("Enter Quiz-1 Score: ");
            double quiz2Final = GetInput("Enter Quiz-2 Score: ");
            double classStandingFinal = GetInput("Enter Class Standing Grade: ");
            double examFinal = GetInput("Enter Exam Grade: ");
            double labGradeFinal = GetInput("Enter Final Lab Grade: ");

            // Calculations
            double averageQuizMidterm = (quiz1Midterm + quiz2Midterm) / 2;
            double lectureGradeMidterm = (averageQuizMidterm * 0.4) + (classStandingMidterm * 0.1) + (examMidterm * 0.5);
            double midtermOverallGrade = (lectureGradeMidterm * 0.5) + (labGradeMidterm * 0.5);

            double averageQuizFinal = (quiz1Final + quiz2Final) / 2;
            double lectureGradeFinal = (averageQuizFinal * 0.4) + (classStandingFinal * 0.1) + (examFinal * 0.5);
            double finalOverallGrade = (lectureGradeFinal * 0.5) + (labGradeFinal * 0.5);

            double finalRating = (midtermOverallGrade * 0.5) + (finalOverallGrade * 0.5);
            string studentRemarks = finalRating >= 75.0 ? "Passed" : "Failed";

            // Display Output
            Console.WriteLine("\n================GRADE SHEET=================");
            Console.WriteLine($"\nName: {studentName}");
            Console.WriteLine($"\nCourse: {studentCourse}");
            Console.WriteLine("\nPeriod           Lecture    Laboratory    Grade");
            Console.WriteLine($"\nMidterm          {lectureGradeMidterm:F2}     {labGradeMidterm:F2}        {midtermOverallGrade:F2}");
            Console.WriteLine($"\nFinal            {lectureGradeFinal:F2}     {labGradeFinal:F2}        {finalOverallGrade:F2}");
            Console.WriteLine($"\nRating           {finalRating:F2}     Remarks: {studentRemarks}");
            Console.WriteLine("\n============NOTHING FOLLOWS=================");
        }
    }
}
