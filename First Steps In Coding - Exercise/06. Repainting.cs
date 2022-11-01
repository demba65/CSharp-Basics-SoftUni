using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nailon = double.Parse(Console.ReadLine()) + 2;
            double boq = double.Parse(Console.ReadLine());
            double razreditel = double.Parse(Console.ReadLine());
            double chasoveNeobhodimiNaMaistorite = double.Parse(Console.ReadLine());
            
            double nailonKvMetur = 1.50;
            double boqLitur = 14.50;
            double razreditelZaBoqLitur = 5;
            double sumTorbichki = 0.40;

            double nailonCena = nailon * nailonKvMetur;
            double boqCena = (boq + 0.1 * boq) * boqLitur;
            double razreditelCena = razreditel * razreditelZaBoqLitur;

            double razhodiZaMateriali = nailonCena + boqCena + razreditelCena + sumTorbichki;
            double razhodiZaMaistori = (razhodiZaMateriali * 0.3) * chasoveNeobhodimiNaMaistorite;
            double sum = razhodiZaMateriali + razhodiZaMaistori;

            Console.WriteLine(sum);
        }
    }
}