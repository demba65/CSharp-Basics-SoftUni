using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine()) + 2;
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hoursForWorkers = double.Parse(Console.ReadLine());
            
            double nailonKvMetur = 1.50;
            double paintLitre = 14.50;
            double thinnerLitre = 5;
            double pouchPrice = 0.40;

            double nylonPrice = nylon * nylonSquareMetre;
            double paintPrice = (paint + 0.1 * paint) * paintLitre;
            double thinnerPrice = thinner * thinnerLitre;

            double moneyForMaterials = nylonPrice + paintPrice + thinnerPrice + pouchPrice;
            double moneyForWorkers = (moneyForMaterials * 0.3) * hoursForWorkers;
            double sum = moneyForMaterials + moneyForWorkers;

            Console.WriteLine(sum);
        }
    }
}
