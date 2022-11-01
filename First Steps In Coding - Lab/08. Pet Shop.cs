using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kucheta = int.Parse(Console.ReadLine());
            int kotki = int.Parse(Console.ReadLine());
            double cenaKucheta = kucheta * 2.50;
            int cenaKotki = kotki * 4;
            double sum = cenaKucheta + cenaKotki;
            string a = sum + " lv.";
            Console.WriteLine(a);
        } 

    }
}