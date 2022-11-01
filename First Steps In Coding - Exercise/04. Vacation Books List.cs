using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PagesInTheBook = int.Parse(Console.ReadLine());
            int PagesReadedFor1Hour = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());
            int TimeToReadTheBook = PagesInTheBook / PagesReadedFor1Hour;
            int HoursOnDayToReadEveryDay = TimeToReadTheBook / Days;
            Console.WriteLine(HoursOnDayToReadEveryDay);
        }
    }
}