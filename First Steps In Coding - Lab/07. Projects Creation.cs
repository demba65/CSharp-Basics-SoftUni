using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;
            string a = "The architect " + name + " " + "will need " + hours + " " + "hours to complete " + projects + " " + "project/s.";
            Console.WriteLine(a);
        } 

    }
}
