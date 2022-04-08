using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 19.11.2021
/// Funktion: Sortieren von 3 Zahlen
/// </summary>

namespace Übung20_SortierendreierZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Programm zur Größenordnung von drei Zahlen.\n");
            Console.WriteLine("\nBitte geben Sie die erste ganze Zahl ein: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie die zweite ganze Zahl ein: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie die dritte ganze Zahl ein: ");
            c = Convert.ToInt32(Console.ReadLine());

            int[] vergleich1 = { a, b, c };

            Console.WriteLine("\nReihenfolge vor dem Sortieren: ");
            Console.WriteLine(vergleich1[0] + " " + vergleich1[1] + " " + vergleich1[2]);

            Array.Sort(vergleich1);
            Console.WriteLine("\nSortierte Reihenfolge: ");
            Console.WriteLine(vergleich1[0] + " " + vergleich1[1] + " " + vergleich1[2]);



        }
    }
}
