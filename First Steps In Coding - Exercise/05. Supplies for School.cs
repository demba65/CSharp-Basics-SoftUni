using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paketsPens = int.Parse(Console.ReadLine());
            int paketsMarkers = int.Parse(Console.ReadLine());
            int litrePreparation = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double litrePreparationPrice = 1.20;
            double sum = (paketsPens * pensPrice) + (paketsMarkers * markersPrice) + (litrePreparation * litrePreparationPrice);
            double money = sum - (sum * discount / 100);
            Console.WriteLine(money);
        }
    }
}
