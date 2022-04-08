using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 19.11.2021
/// Funktion: Bedingte Divison zweier double-Werte
/// </summary>

namespace Uebung14_Bedingte_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double zahl1, zahl2, ergebnis;
            bool bedingung = false;
            int eingabe = 0;
            do
            {
                Console.WriteLine("Programm zur Division einer beliebigen kleineren Zahl durch eine beliebige größere.");
                Console.WriteLine("\nBitte geben Sie die erste Zahl ein: ");
                zahl1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nBitte geben Sie die zweite Zahl ein: ");
                zahl2 = Convert.ToDouble(Console.ReadLine());
                if (zahl1 > zahl2)
                {
                    ergebnis = zahl2 / zahl1;
                    Console.WriteLine("\n" + Math.Round(zahl2, 2) + " : " + Math.Round(zahl1, 2) + " = " + Math.Round(ergebnis, 2));
                }
                else if (zahl2 >= zahl1)
                {
                    ergebnis = zahl1 / zahl2;
                    Console.WriteLine("\n" + Math.Round(zahl1, 2) + " : " + Math.Round(zahl2, 2) + " = " + Math.Round(ergebnis, 2));
                }
                Console.WriteLine("Nochmal? (1) Oder Programm beenden? (2)");
                eingabe = Convert.ToInt32(Console.ReadLine());
                if (eingabe == 2)
                {
                    bedingung = true;
                }


            } while (bedingung == false);
        }
    }
}
