using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());
            double inch = cm * 2.54;

            Console.WriteLine(inch);
        } 

    }
}