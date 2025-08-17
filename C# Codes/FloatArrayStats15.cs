using System;

class Program
{
    static void Main()
    {
        float[] FloatArray = new float[15];
        float sum = 0;

        Console.WriteLine("Enter 15 float elements:");

        for (int i = 0; i < 15; i++)
        {
            bool validInput = false;

            while (!validInput)
            {
                Console.Write($"Element {i + 1}: ");
                string input = Console.ReadLine();

                if (float.TryParse(input, out FloatArray[i]))
                {
                    sum += FloatArray[i];
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid float value.");
                }
            }
        }

        float highest = FloatArray[0];
        float smallest = FloatArray[0];

        for (int i = 1; i < 15; i++)
        {
            if (FloatArray[i] > highest)
            {
                highest = FloatArray[i];
            }

            if (FloatArray[i] < smallest)
            {
                smallest = FloatArray[i];
            }
        }

        Console.WriteLine($"Highest: {highest}");
        Console.WriteLine($"Smallest: {smallest}");
        Console.WriteLine($"Sum: {sum}");
    }
}
