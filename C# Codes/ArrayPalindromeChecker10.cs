using System;

class Program
{
    static void Main()
    {
        int[] intArr = new int[10];

        Console.WriteLine("Enter 10 integer elements:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Element {i + 1}: ");
            intArr[i] = int.Parse(Console.ReadLine());
        }

        if (IsPalindrome(intArr))
        {
            Console.WriteLine("The array is a Palindrome.");
        }
        else
        {
            Console.WriteLine("The array is Not a Palindrome.");
        }
    }

    static bool IsPalindrome(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            if (arr[start] != arr[end])
            {
                return false;
            }
            start++;
            end--;
        }
        return true;
    }
}
