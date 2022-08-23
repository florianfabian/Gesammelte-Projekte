using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:      Florian Fabian
/// Datum:      22.08.22
/// Funktion:   Luftballon objektorientiert darstellen
/// Funktion:   Ergänzung Übung 51: Immobilie objektorientiert darstellen
///

namespace Übung50_KlasseLuftballon_FF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Luftballon lb1 = new Luftballon("rot", "rund", 1.2);

            Console.WriteLine(lb1);

            Luftballon lb2 = new Luftballon("blau", "rund", 1.3);

            Console.WriteLine(lb2);

            Immobilie immo1 = new Immobilie("Eigentumswohnung", 83.31, 3, 1991, 225000.00, false);
            Immobilie immo2 = new Immobilie("Doppelhaushälfte innenstadtnah", 110.00, 5, 1977, 210000.00, true);
            Immobilie immo3 = new Immobilie("Traumhaus am Waldrand", 165.00, 8, 2005, 650000.00, false);

            Console.WriteLine(immo1);
            Console.WriteLine(immo2);
            Console.WriteLine(immo3);
        }
    }
}
