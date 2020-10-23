using CountryComparison.Germany;
using System;

namespace CountryComparison
{
    class Program
    {
        //Разработать приложение, в котором бы сравнивалось 
        //население трех столиц из разных стран.Причем страна
        //бы обозначалась пространством имен, а город - классом 
        //в данном пространстве.

        static void Main(string[] args)
        {
            Germany.Berlin berlin = new Germany.Berlin();
            Belarus.Minsk minsk = new Belarus.Minsk();
            Russia.Moscow moscow = new Russia.Moscow();

            Console.WriteLine("Population in Berlin:"); 
            berlin.Population();
            Console.WriteLine();

            Console.WriteLine("Population in Minsk:");
            minsk.Population();
            Console.WriteLine();

            Console.WriteLine("Population in Moscow:");
            moscow.Population();

        }
    }
}
