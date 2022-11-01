using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int cats = int.Parse(Console.ReadLine());
            double dogsPrice = dogs * 2.50;
            int catsPrice = cats * 4;
            double sum = dogsPrice + catsPrice;
            string a = sum + " lv.";
            Console.WriteLine(a);
        } 

    }
}
