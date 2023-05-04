using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
///Autor:       Florian Fabian
///Datum:       12.09.22
///Funktion:    Vererbungen darstellen am Objekt der Angestellten
///Edit:        15.09.22 : Klasse Manager hinzugefügt, mit Override Klassenfremder Methoden
///
///

namespace Uebung58_Angestellte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angestellter a1 = new Angestellter(1500);
            Sekretaerin s1 = new Sekretaerin(1100, a1);
            Verkaeufer v1 = new Verkaeufer(2000, 150);

            Manager m1 = new Manager(3000, true, 12);

            Console.WriteLine(a1);
            Console.WriteLine(s1);
            Console.WriteLine(v1);

            Console.WriteLine("Gehalt vom Verkäufer v1 = " + v1.BerechneJahresgehalt());

            Console.WriteLine(m1);

        }
    }
}
