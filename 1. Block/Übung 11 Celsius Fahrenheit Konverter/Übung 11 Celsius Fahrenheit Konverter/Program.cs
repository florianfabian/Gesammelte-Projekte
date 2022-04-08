using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 05.11.2021
/// Funktion: Celsius <-> Fahrenheit umrechnen
/// </summary>

namespace Übung_11_Celsius_Fahrenheit_Konverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double eingabe, ausgabe;
            Console.WriteLine("Programm zum Umrechnen Celsius -> Fahrenheit.\n");
            Console.WriteLine("Bitte einen Wert in Celsius eingeben : ");
            eingabe = Convert.ToDouble(Console.ReadLine());
            ausgabe = (eingabe * 9 / 5) + 32;
            Console.WriteLine("Wert in Fahrenheit  :  " + ausgabe);

            //test mit formelumstellung:
            ausgabe = (9 / 5 * eingabe) + 32;
            Console.WriteLine("\n#### Umstellung der Formel, Ergebnis in Fahrenheit  :  " + ausgabe + " ####");
            Console.WriteLine("####");
            Console.WriteLine("\nErgebnis könnte anders sein aufgrund der Formatierung in C#, welches automatisch erkennt, dass ein Bruch geschrieben wird. (Wenn der Bruch nachfolgend der Multiplikation ist.)\n");
            Console.WriteLine("\nEr erkennt also entweder zuerst einen Int Datentyp, oder bei der richtigen Rechnung einen double Datentyp.\n");
            Console.WriteLine("Es ist also wichtig, immer den Datentyp zuerst zu nennen, damit der Compiler es richtig übersetzt. \n");
            Console.WriteLine("####");

        }
    }
}
