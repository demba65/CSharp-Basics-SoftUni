using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int periodDepozid = int.Parse(Console.ReadLine());
            double yearRateOfInterest = double.Parse(Console.ReadLine());
            double interest = depositSum * yearRateOfInterest / 100;
            double interestOnOneMonth = interest / 12;
            double sum = depositSum + periodDeposit * interestOnOneMonth;
            Console.WriteLine(sum);

        }

    }
}
