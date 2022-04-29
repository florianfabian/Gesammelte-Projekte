using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      29.04.2022
/// Funktion:   Durchschnittsnote errechnen, Eingabe der Noten erfolgt über Konsole, zuerst aber Anzahl der Noten
/// </summary>

namespace Uebung038_Notenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;
            Console.WriteLine("\nWie viele Noten wollen Sie eingeben?   : ");
            eingabe = Convert.ToInt32(Console.ReadLine());

            double[] noten = new double[eingabe];
            for (int i = 0; i < eingabe; i++)
            {
                int ausgabe = i + 1;
                Console.WriteLine("\n" + ausgabe + ". Note : ");
                noten[i] = Convert.ToDouble(Console.ReadLine());
            }

            double rechner = 0;
            for(int i = 0; i < noten.Length; i++)
            {
                rechner += noten[i];
            }
            double durchschnitt = rechner / noten.Length;
            Console.WriteLine($"Durchschnittsnote ist :  {durchschnitt:F}");
        }
    }
}
