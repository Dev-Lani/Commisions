using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter six-digit number: ");
            string inputNumber = Console.ReadLine();

            var reversedDigits = inputNumber.Reverse().ToArray();

            if (reversedDigits.Length == 6)
            {
                for (int index = 0; index < reversedDigits.Length; index++)
                {
                    Console.Write($"d{index + 1} = {int.Parse(reversedDigits[index].ToString())}, ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid six-digit number.");
            }
        }
    }
}
