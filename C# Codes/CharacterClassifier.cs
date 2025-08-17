using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (Char.IsLetter(input))
        {
            if ("aeiouAEIOU".IndexOf(input) >= 0)
            {
                Console.WriteLine($"{input}, is a. Vowel");
            }
            else
            {
                Console.WriteLine($"{input}, is b. Consonant");
            }
        }
        else if (Char.IsDigit(input))
        {
            Console.WriteLine($"{input}, d. Digit");
        }
        else if (input == ' ')
        {
            Console.WriteLine($"{input}, e. Space");
        }
        else if (Char.IsPunctuation(input))
        {
            Console.WriteLine($"{input}, f. Punctuation Mark");
        }
        else if (Char.IsSymbol(input) || Char.IsControl(input))
        {
            Console.WriteLine($"{input}, g. Special Character");
        }
        else
        {
            Console.WriteLine($"{input}, is not a recognized character.");
        }
    }
}
