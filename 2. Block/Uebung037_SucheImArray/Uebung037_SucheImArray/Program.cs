using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      27.04.2022
/// Funktion:   Zahlensuche in einem Array in ausgelagerter Funktion
/// </summary>

namespace Uebung037_SucheImArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zufallszahl = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < zufallszahl.Length; i++)
            {
                zufallszahl[i] = rnd.Next(1, 1000);
            }
            int wert = 0;
            Console.WriteLine("Array mit 1000 Zufallszahlen erstellt!\n");
            Console.WriteLine("Welche Zahl wollen Sie suchen?     :    ");
            wert = Convert.ToInt32(Console.ReadLine());
            bool ergebnis = Suche(zufallszahl, wert);

            if (ergebnis == true)
            {
                Console.WriteLine("Ihre Zahl ist vorhanden!");
            }
            else
            {
                Console.WriteLine("Ihre Zahle ist nicht vorhanden :(");
            }

            int ergebniszwei = SucheIndex(zufallszahl, wert);
            if (ergebniszwei > 0)
            {
                Console.WriteLine("Ihre Zahl befindet sich an der " + ergebniszwei + ". Stelle im Array");
            }


        }
        public static bool Suche(int[] array, int wert)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == wert)
                {
                    return true;
                }
            }
            return false;
        }
        public static int SucheIndex(int[] array, int wert)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == wert)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
