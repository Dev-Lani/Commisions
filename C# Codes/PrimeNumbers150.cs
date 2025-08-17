using System;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;  
        int num = 2;

        Console.WriteLine("First 150 Prime Numbers:");

        while (count < 150)
        {
            if (IsPrime(num))
            {
                Console.Write(num + " ");
                count++;
            }
            num++;
        }
    }


    static bool IsPrime(int number)
    {

        if (number <= 1)
            return false;


        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;  
        }
        return true; 
    }
}
