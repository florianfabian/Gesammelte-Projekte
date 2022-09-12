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
/// Edit:           12.09.2022: add + remove Lieferadresse mit List<Adresse>
/// 
///

namespace Uebung55_KundeMitAdressen
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Kunde k1 = new Kunde("Mustermann", new Adresse("Bahnhofstrasse", "Neustadt"), new Adresse("asd", "DSA"));
            Console.WriteLine(k1);

            Adresse a1 = new Adresse("Superstrasse", "München");
            Console.WriteLine(a1);

            Adresse a2 = new Adresse("Schulstraße", "Höxter");


        }
    }
}
