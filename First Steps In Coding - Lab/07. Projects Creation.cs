using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int proekti = int.Parse(Console.ReadLine());
            int chasove = proekti * 3;
            string a = "The architect " + name + " " + "will need " + chasove + " " + "hours to complete " + proekti + " " + "project/s.";
            Console.WriteLine(a);
        } 

    }
}