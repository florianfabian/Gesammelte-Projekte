using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 30.03.2022
/// Funktion: Primzahltest
/// </summary>

namespace Primzahltest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 3;
            int schleifenende = 1000;
            bool pruefung = true;
            Console.WriteLine("Primzahlen bis "+schleifenende+": ");
            Console.WriteLine("2\t");
            while (max < schleifenende)
            {
                pruefung = IstPrimzahl(max);
                if (pruefung == false)
                {
                    Console.WriteLine(max + "\t");
                }
                max++;
            }
        }

        public static bool IstPrimzahl (int zahl)
        {
            int pruefung = 2;
            do
            {
                if (zahl % pruefung == 0)
                {
                    return true;
                }
                pruefung++;

            } while (pruefung < zahl);
            return false;

        }
    }
}
