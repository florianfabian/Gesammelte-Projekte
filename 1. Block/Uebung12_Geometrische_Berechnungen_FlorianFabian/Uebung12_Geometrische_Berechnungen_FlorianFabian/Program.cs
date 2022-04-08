using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor: Florian Fabian
/// Datum: 09.11.2021
/// Funktion des Programmes: Umfang und Fläche eines Kreises und Volumen einer Kugel anhand einer Radiuseingabe
/// </summary>

namespace Uebung12_Geometrische_Berechnungen_FlorianFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaration variablen
            double radius, umfang, flaeche, volumen;
            //output an den Anwender
            Console.WriteLine("Programm berechnet Umfang und Fläche eines Kreises und Volumen einer Kugel anhand von einmaligen Eingabewerten.\n");
            Console.WriteLine("Bitte Radius eingeben: ");
            //eingabeeinlesung und konvertierung in passenden datentyp
            radius = Convert.ToDouble(Console.ReadLine());
            //Berechnung umfang, flaeche und volumen
            umfang = (2.0 * Math.PI) * radius;
            flaeche = Math.PI * (radius * radius);
            volumen = 4.0 / 3.0 * Math.PI * radius * radius * radius;
            //ausgabe werte
            Console.WriteLine("\nDer Umfang eines Kreises mit dem Radius " + radius + " beträgt: " + Math.Round(umfang,2));
            Console.WriteLine("\nDie Fläche eines Kreises mit dem Radius " + radius + " beträgt: " + Math.Round(flaeche,2));
            Console.WriteLine("\nDas Volumen eines Kreises mit dem Radius " + radius + " beträgt: " + Math.Round(volumen,2));


            // Anstatt Math.Round sollte man in der Ausgabe :F benutzen (an hinteres Ende der Variable angeschlossen [umfang:F2]) damit der Wert nicht korrumpiert wird
            //Zusätzlich $ am Anfang der Ausgabe, dann kann man über {umfang:F2} ohne + Werte die Werte ausgeben
        }
    }
}
