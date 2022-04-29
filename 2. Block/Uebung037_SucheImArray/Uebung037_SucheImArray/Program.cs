using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      27.04.2022
/// Funktion:   Zahlensuche in einem Array in ausgelagerter Funktion
/// Edit:       29.04.2022:
///                             Die drei Funktionen Haeufigkeit(), Maximum() und IndexMaximum() + Aufruf/Ausgabe hinzugefügt
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

            int ergebnishaeufig = Haufigkeit(zufallszahl, wert);
            Console.WriteLine("\nHäufigkeit der Zufallszahl : " + ergebnishaeufig);

            int ergebnismaximum = Maximum(zufallszahl);
            Console.WriteLine("\nDer höchste Wert im Array : " + ergebnismaximum);

            int ergebnisindexmax = IndexMaximum(zufallszahl);
            Console.WriteLine("\nDer höchste Wert befindet sich an der Stelle : " + ergebnisindexmax);


        }
        /// <summary>
        /// Eingegebene Zahl vom Benutzer wird im Array gesucht, wenn sie vorhanden ist wird TRUE zurückgegeben
        /// </summary>
        /// <param name="array"></param>
        /// <param name="wert"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Zahl wird gesucht und kategorisiert (falls die Zahl gefunden wurde, Bedinung in der Main
        /// Wenn zahl gefunden, wird die Stelle durch Schleifenvariable "i" zurückgegeben
        /// </summary>
        /// <param name="array"></param>
        /// <param name="wert"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Wie Häufig kommt ein Wert vor
        /// </summary>
        /// <param name="array"></param>
        /// <param name="wert"></param>
        /// <returns></returns>
        public static int Haufigkeit(int[] array, int wert)
        {
            int zaehler = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == wert)
                {
                    zaehler++;
                }
            }
            return zaehler;
        }

        /// <summary>
        /// Was ist der höchste Wert in dem Array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int Maximum(int[] array)
        {
            int zaehler = array.Length;
            int wert = 0;
            for(int i = 0; i < zaehler; i++)
            {
                if (array[i] > wert)
                {
                    wert = array[i];
                }
            }
            return wert;
        }
        
        /// <summary>
        /// An welcher Stelle ist der höchste Wert
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int IndexMaximum(int[] array)
        {
            int wert = Maximum(array);
            for (int i = 0; i < array.Length; i++)
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
