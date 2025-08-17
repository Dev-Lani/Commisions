using System;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int integerValue = 42;
            object boxedInteger = integerValue;
            Console.WriteLine("Boxed value (object): " + boxedInteger);

            int unboxedInteger = (int)boxedInteger;
            Console.WriteLine("Unboxed value (int): " + unboxedInteger);

            double doubleValue = 23.75;
            object boxedDoubleValue = doubleValue;
            Console.WriteLine("Boxed double (object): " + boxedDoubleValue);

            double unboxedDoubleValue = (double)boxedDoubleValue;
            Console.WriteLine("Unboxed value (double): " + unboxedDoubleValue);
        }
    }
}
