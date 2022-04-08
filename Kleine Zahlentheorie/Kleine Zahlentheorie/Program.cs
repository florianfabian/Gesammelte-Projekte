using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      01.04.2022              Log:    Grundprogramm erstellt
///             06.04.2022                      Zahlentheorie-Klasse erstellt
///                                             UnitTest1 und UnitTesttheory erstellt
///
/// Funktion:   
/// </summary>
namespace Kleine_Zahlentheorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie zwei Zahlen für den GGT ein: \n");
            Console.WriteLine("Zahl 1: ");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nZahl 2: ");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBitte geben Sie zwei Zahlen für den KGV ein: ");
            Console.WriteLine("\nZahl 3: ");
            int zahl3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nZahl 4: ");
            int zahl4 = Convert.ToInt32(Console.ReadLine());

            int ggt = Zahlentheorie.BerechneGGT(zahl1, zahl2);
            int kgv = Zahlentheorie.BerechneKGV(zahl3, zahl4);
            Console.WriteLine("\nGGT = " + ggt);
            Console.WriteLine("KGV = " + kgv);

        }


    }
}
