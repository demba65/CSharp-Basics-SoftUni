using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMetre = double.Parse(Console.ReadLine());
            double sum = squareMetre * 7.61;
            double discount = 0.18 * sum;
            double sumDiscount = sum - discount;
            Console.WriteLine($"The final price is: {sumDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
           
        }

    }
}
