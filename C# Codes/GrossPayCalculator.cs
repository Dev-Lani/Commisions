using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Gross Pay Calculator!");

        Console.Write("Enter the number of hours worked: ");
        string inputHours = Console.ReadLine();
        double hours = Convert.ToDouble(inputHours);


        Console.Write("Enter the hourly rate: ");
        string inputRate = Console.ReadLine();
        double rate = Convert.ToDouble(inputRate);

        double grossPay = 0;


        if (hours > 40)
        {
            double regularPay = 40 * rate;

            double overtimeHours = hours - 40;
            double overtimePay = overtimeHours * rate * 1.5;

            grossPay = regularPay + overtimePay;

            Console.WriteLine("You worked overtime!");
            Console.WriteLine($"Regular Pay: {regularPay}");
            Console.WriteLine($"Overtime Pay: {overtimePay}");
        }
        else
        {
            grossPay = hours * rate;
            Console.WriteLine("You did not work overtime.");
        }

        Console.WriteLine($"Your gross pay is: {grossPay}");
    }
}
