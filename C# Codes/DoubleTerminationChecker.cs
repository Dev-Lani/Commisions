using System;

class Program   
{
    static void Main(string[] args)
    {
        Console.WriteLine("The program will stop if the last input number is twice the previous number.");
        int previousNumber = 0; // To store the previous input
        int currentNumber = 0;  // To store the current input

        while (true)
        {
            Console.Write("Enter number: ");
            currentNumber = Convert.ToInt32(Console.ReadLine());

            // Check if the current number is twice the previous number
            if (currentNumber == previousNumber * 2 && previousNumber != 0)
            {
                Console.WriteLine($"Since {currentNumber} = {previousNumber} x 2, program terminated normally!");
                break;
            }

            // Update previousNumber to the current input for the next iteration
            previousNumber = currentNumber;
        }
    }
}
