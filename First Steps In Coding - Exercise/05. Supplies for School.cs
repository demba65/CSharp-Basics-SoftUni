using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brPaketiHimikali = int.Parse(Console.ReadLine());
            int brPaketiMarkeri = int.Parse(Console.ReadLine());
            int litriPreparatZaPochistvaneNaDuska = int.Parse(Console.ReadLine());
            int procentNamalenie = int.Parse(Console.ReadLine());
            double himikaliCena = 5.80;
            double markeriCena = 7.20;
            double liturPreparatCena = 1.20;
            double obshtaSuma = (brPaketiHimikali * himikaliCena) + (brPaketiMarkeri * markeriCena) + (litriPreparatZaPochistvaneNaDuska * liturPreparatCena);
            double nujniPari = obshtaSuma - (obshtaSuma * procentNamalenie / 100);
            Console.WriteLine(nujniPari);
        }
    }
}