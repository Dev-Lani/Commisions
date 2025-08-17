using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = 42;
            object boxedNumber = number;
            Console.WriteLine("Boxed value (object): " + boxedNumber);

            int unboxedNumber = (int)boxedNumber;
            Console.WriteLine("Unboxed value (int): " + unboxedNumber);

            double originalValue = 23.75;
            object boxedDouble = originalValue;
            Console.WriteLine("Boxed double (object): " + boxedDouble);

            double unboxedDouble = (double)boxedDouble;
            Console.WriteLine("Unboxed value (double): " + unboxedDouble);
        }
    }
}
