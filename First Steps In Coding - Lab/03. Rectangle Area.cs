using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kvMetri = double.Parse(Console.ReadLine());
            double sum = kvMetri * 7.61;
            double otstupka = (sum) / (18 / 100);
            Console.WriteLine($"The final price is: {sum} lv.");
            Console.WriteLine($"The discount is: {otstupka} lv.");
        } 

    }
}