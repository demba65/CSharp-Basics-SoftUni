using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvMetri = double.Parse(Console.ReadLine());
            double sum = kvMetri * 7.61;
            double otstupka = 0.18 * sum;
            double sumOtstupka = sum - otstupka;
            Console.WriteLine($"The final price is: {sumOtstupka} lv.");
            Console.WriteLine($"The discount is: {otstupka} lv.");
           
        }

    }
}