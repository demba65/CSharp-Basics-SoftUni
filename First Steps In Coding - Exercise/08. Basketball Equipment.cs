using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());

            double basketballShoes = yearTax - (0.4 * yearTax);
            double basketballSuit = basketballShoes - (0.2 * basketballShoes);
            double basketballBall = basketballSuit * 0.25;
            double basketballAccessories = basketballBall * 0.2;

            double sum = basketballShoes + basketballSuit + basketballBall + basketballAccessories + yearTax;
            Console.WriteLine(sum);
        }
    }
}