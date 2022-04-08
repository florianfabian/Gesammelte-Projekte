using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      01.12.21
/// Funktion:   Hausratversicherung
/// </summary>

namespace Hausratversicherung_01._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int personen = 0;
            double quadratmeteranzahl = 0.00, ergebnis = 0.00;
            Console.WriteLine("Programm zur Berechnung einer Hausratversicherung");
            Console.WriteLine("\nBitte geben Sie die Anzahl Ihrer Mitbewohner (Sie inklusive) ein : ");
            personen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie die Quadratmeteranzahl Ihrer Wohnung ein : ");
            quadratmeteranzahl = Convert.ToInt32(Console.ReadLine());

            switch(personen)
            {
                case 1:
                case 2:
                    ergebnis = Math.Round(quadratmeteranzahl * 2 + 10, 2); break;
                case 3:
                    ergebnis = Math.Round(quadratmeteranzahl + 15, 2); break;
                case 4:
                    ergebnis = Math.Round(quadratmeteranzahl * 1.5 + 15, 2); break;
                default:
                    ergebnis = Math.Round(quadratmeteranzahl * 2 + 25, 2); break;

            }
            Console.WriteLine("\nIhre Prämie beläuft sich auf " + ergebnis + " Euro.");
        }
    }
}
