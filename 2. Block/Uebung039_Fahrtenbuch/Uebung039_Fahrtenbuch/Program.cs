using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      05.05.2022
/// Funktion:   Durchschnittsgeschwindigkeit ausrechnen Pendler
/// </summary>

namespace Uebung039_Fahrtenbuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] strecke = { 134, 177, 123, 145, 152 };
            int[] fahrtzeit = { 95, 230, 115, 110, 125 };
            double[] werte = durchschnitt(strecke, fahrtzeit);
            Console.WriteLine($"Montag:  {werte[0]:F2}");
            Console.WriteLine($"Dienstag:  {werte[1]:F2}");
            Console.WriteLine($"Mittwoch:  {werte[2]:F2}");
            Console.WriteLine($"Donnerstag:  {werte[3]:F2}");
            Console.WriteLine($"Freitag:  {werte[4]:F2}");
            Console.WriteLine($"Durchschnitt:  {werte[5]:F2}");
        }
        public static double[] durchschnitt(int[] fahrtzeit, int[] strecke)
        {
            double[] array = new double[fahrtzeit.Length + 1];
            double rechner = 0;
            for(int i = 0; i < fahrtzeit.Length; i++)
            {
                array[i] = strecke[i] / (fahrtzeit[i] / 60.0);
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                rechner += array[i];
            }
            array[5] = rechner / 5.0;
            return array;
        }
    }
}
