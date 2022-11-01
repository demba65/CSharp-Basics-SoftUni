using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegetarianMenu = int.Parse(Console.ReadLine());

            double chickenMenuPrice = chickenMenu * 10.35;
            double fishMenuPrice = fishMenu * 12.40;
            double vegetarianMenuPrice = vegetarianMenu * 8.15;
            double desertPrice = (chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice) * 0.2;
            double delivery = 2.50;

            double deliveryPrice = chickenMenuPrice + fishMenuPrice + vegetarianMenuPrice + desertPrice + delivery;
            Console.WriteLine(deliveryPrice);
        }
    }
}