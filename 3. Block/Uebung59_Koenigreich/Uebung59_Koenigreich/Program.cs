using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
///Autor:       Florian Fabian
///Datum:       22.09.22
///Funktion:    Finanz und Steuerwesen im Mittelalter digitalisieren
///
///

namespace Uebung59_Koenigreich
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Koenig k1 = new Koenig(50000);
            Bauer b1 = new Bauer(1200);
            Adel a1 = new Adel(20000);
            Leibeigener l1 = new Leibeigener(200);

            Console.WriteLine("König : " + k1);
            Console.WriteLine("Bauer1 : " + b1);
            Console.WriteLine("Adel1 : " + a1);
            Console.WriteLine("Leibeigener1 : " + l1);

            int gesamteinnahmen = Finanzamt.berechneSteuerEinnahmen(k1.steuer()) + Finanzamt.berechneSteuerEinnahmen(b1.steuer())
                + Finanzamt.berechneSteuerEinnahmen(a1.steuer()) + Finanzamt.berechneSteuerEinnahmen(l1.steuer());

            Console.WriteLine("Gesamteinnahmen des Königreichs : " + gesamteinnahmen);

        }
    }
}
