using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:      Florian Fabian
/// Datum:      25.08.2022
/// Funktion:   Klasse Kreis + Methoden, um mit dem Kreis grundlegene Manipulationen durchzuführen
/// Funktion:   Ergänzung 29.08.:Zugriffsmethoden Getter/Setter hinzugefügt
///

namespace Uebung51_Kreis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kreis k1 = new Kreis(2.9);
            Console.WriteLine(k1);

            k1.BerechneDurchmesser();
            Console.WriteLine(k1);

            k1.BerechneFlaeche();
            Console.WriteLine(k1);

            k1.BerechneUmfang();
            Console.WriteLine(k1);


        }
    }
}
