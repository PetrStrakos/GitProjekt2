using System;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            Console.WriteLine(osoba.DatumNarození);
            Console.WriteLine("Zadej datum narození:");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(osoba.Vek());

            Console.ReadKey();
        }
    }
}
