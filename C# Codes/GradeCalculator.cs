using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Helper function to get numeric input from the user
            double GetScore(string prompt)
            {
                double score;
                do
                {
                    Console.Write(prompt);
                }
                while (!double.TryParse(Console.ReadLine(), out score));
                return score;
            }

            // User information input
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            // Midterm Period Inputs
            Console.WriteLine("\n=============MIDTERM PERIOD=============");
            double midtermQuiz1 = GetScore("Enter Quiz-1 Score: ");
            double midtermQuiz2 = GetScore("Enter Quiz-2 Score: ");
            double midtermClassStanding = GetScore("Enter Class Standing Grade: ");
            double midtermExam = GetScore("Enter Exam Grade: ");
            double midtermLabGrade = GetScore("Enter Midterm Lab Grade: ");

            // Final Period Inputs
            Console.WriteLine("\n===============FINAL PERIOD==============");
            double finalQuiz1 = GetScore("Enter Quiz-1 Score: ");
            double finalQuiz2 = GetScore("Enter Quiz-2 Score: ");
            double finalClassStanding = GetScore("Enter Class Standing Grade: ");
            double finalExam = GetScore("Enter Exam Grade: ");
            double finalLabGrade = GetScore("Enter Final Lab Grade: ");

            // Calculations
            double midtermQuizAvg = (midtermQuiz1 + midtermQuiz2) / 2;
            double midtermLectureGrade = (midtermQuizAvg * 0.4) + (midtermClassStanding * 0.1) + (midtermExam * 0.5);
            double midtermGrade = (midtermLectureGrade * 0.5) + (midtermLabGrade * 0.5);

            double finalQuizAvg = (finalQuiz1 + finalQuiz2) / 2;
            double finalLectureGrade = (finalQuizAvg * 0.4) + (finalClassStanding * 0.1) + (finalExam * 0.5);
            double finalGrade = (finalLectureGrade * 0.5) + (finalLabGrade * 0.5);

            double rating = (midtermGrade * 0.5) + (finalGrade * 0.5);
            string remarks = rating >= 75.0 ? "Passed" : "Failed";

            // Display Output
            Console.WriteLine("\n================GRADE SHEET=================");
            Console.WriteLine($"\nName: {name}");
            Console.WriteLine($"\nCourse: {course}");
            Console.WriteLine("\nPeriod           Lecture    Laboratory    Grade");
            Console.WriteLine($"\nMidterm          {midtermLectureGrade:F2}     {midtermLabGrade:F2}        {midtermGrade:F2}");
            Console.WriteLine($"\nFinal            {finalLectureGrade:F2}     {finalLabGrade:F2}        {finalGrade:F2}");
            Console.WriteLine($"\nRating           {rating:F2}     Remarks: {remarks}");
            Console.WriteLine("\n============NOTHING FOLLOWS=================");
        }
    }
}
