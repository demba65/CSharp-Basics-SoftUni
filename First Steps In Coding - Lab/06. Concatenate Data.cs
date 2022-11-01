using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string town = Console.ReadLine();
            string a = "You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town + ".";
            Console.WriteLine(a);
        } 

    }
}