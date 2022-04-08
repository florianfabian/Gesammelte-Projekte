using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Florian Fabian
/// Datum: 19.11.2021
/// Funktion: Quadratische Gleichung
/// </summary>

namespace Übung17___Quadratische_Gleichung
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double ergebnis;
            Console.WriteLine("Programm zu Berechnung der möglichen Lösungen einer Quadratischer Gleichung (ax^2 + bx +c = 0\n");
            Console.WriteLine("\nBitte geben Sie den Koeffizienten a ein: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie den Koeffizienten b ein: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie den Koeffizienten c ein: ");
            c = Convert.ToDouble(Console.ReadLine());
            ergebnis = Math.Pow(b, 2) - (4 * a * c);
            if (ergebnis == 0)
            {
                Console.WriteLine("\nDie Gleichung hat eine Lösung");
            }
            else if (ergebnis > 0)
            {
                Console.WriteLine("\nDie Gleichung hat zwei Lösungen");
            }
            else if (ergebnis < 0)
            {
                Console.WriteLine("\nDie Gleichung hat keine Lösung");
            }

        }
    }
}
