using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum_ 12.11.2021
/// Funktion: Prüfen ob eine Zahl negativ ist, wenn ja dann positiv umwandeln - egal was, am Ende Zahl wieder ausgeben
/// </summary>

namespace Uebung13_Absolutwert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl eingeben bitte : ");
            double zahl = Convert.ToDouble(Console.ReadLine());
            double absolutwert = 0;

            //prüfen ob die zahl negativ, falls ja das vorzeichen ändern

            if (zahl < 0)
            {
                absolutwert = -zahl; 
            }
            else
            {
                absolutwert = zahl;
            }
            Console.WriteLine("Zahl positiv: " + absolutwert);
        }
    }
}
