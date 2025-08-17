using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter six-digit number: ");
            string userInput = Console.ReadLine();

            var reversedDigits = userInput.Reverse().ToArray();

            if (reversedDigits.Length == 6)
            {
                for (int i = 0; i < reversedDigits.Length; i++)
                {
                    Console.Write($"d{i + 1} = {int.Parse(reversedDigits[i].ToString())}, ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid six-digit number.");
            }
        }
    }
}
