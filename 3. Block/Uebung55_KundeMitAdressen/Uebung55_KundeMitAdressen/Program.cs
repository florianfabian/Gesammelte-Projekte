using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
/// Autor:          Florian Fabian
/// Datum:          07.09.2022
/// Funktion:       Kunde wird angelegt mit Datensatz Adresse (Klasse Kunde, Klasse Adresse)
/// 
///

namespace Uebung55_KundeMitAdressen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Kunde k1 = new Kunde("Mustermann", new Adresse("Bahnhofstrasse", "Neustadt"));
            Console.WriteLine(k1);

            Adresse a1 = new Adresse("Superstrasse", "München");
            Console.WriteLine(a1);

            Adresse a2 = new Adresse("Schulstraße", "Höxter");
            Kunde k2 = new Kunde("Fabian", a2);


            Console.WriteLine(k2);

            Kunde k3 = new Kunde(new Adresse("Bahnhofsweg", "Paderborn"));


            Console.WriteLine(k3);

        }
    }
}
