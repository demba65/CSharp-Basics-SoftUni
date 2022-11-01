using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lengthCm = double.Parse(Console.ReadLine());
            double widthCm = double.Parse(Console.ReadLine());
            double heightCm = double.Parse(Console.ReadLine());
            double Procent = double.Parse(Console.ReadLine());
            
            double vCm = lengthCm * widthCm * heightCm;
            double vLit = vCm / 1000;
            double a = Procent / 100;
            double liters = vLit * (1 - a);

            Console.WriteLine(liters);
        }
    }
}