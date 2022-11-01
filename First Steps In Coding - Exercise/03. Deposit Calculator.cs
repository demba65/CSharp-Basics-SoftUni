using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depoziranaSuma = double.Parse(Console.ReadLine());
            int srokNaDepozita = int.Parse(Console.ReadLine());
            double godishenLihvenProcent = double.Parse(Console.ReadLine());
            double natrupanaLihva = depoziranaSuma * godishenLihvenProcent / 100;
            double lihvaZaEdinMesec = natrupanaLihva / 12;
            double sum = depoziranaSuma + srokNaDepozita * lihvaZaEdinMesec;
            Console.WriteLine(sum);

        }

    }
}