using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      20.05.2022
/// Funktion:   Hit the jackpot - zweite Übung, um den Umgang mit 2D Arrays zu lernen
/// </summary>

namespace Uebung44_HitTheJackpot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Testprogramm
            char[,] maxilos = GenerateMaxilos(0.5);

            PrintMaxilos(maxilos);

            if (HitTheJackpot(maxilos))
            {
                Console.WriteLine("\n*******");
                Console.WriteLine("JACKPOT");
                Console.WriteLine("*******");
            }

            Console.WriteLine();
            #endregion
        }

        private static bool HitTheJackpot(char[,] maxilos)
        {
            int zaehler = 0;
            for(int i = 0; i < maxilos.GetLength(0); i++)
            {
                for (int c = 0; c < maxilos.GetLength(1); i++)
                {
                    if (maxilos[i, c] == '$' /*&& maxilos[i + 1, c + 1] == '$' && maxilos[i + 2, c + 2] == '$'*/)
                    {
                        zaehler++;          //Hier bin ich etwas verwirrt, selbst ohne den Kommentar mit den i+1, +2 gibt er "außerhalb der Arraylänge" aus
                                            //Die Logik müsste aber stimmen...?
                                            //evtl. sehen, ob man die Abfragen auf die Länge restrainen kann
                                            //indexof Methode wir auch nichts bringen...?
                                            //Bearbeite erst die zweite Aufgabe und warte auf Besprechung, da 8:50 Uhr
                    }
                }
            }
            if(zaehler >= 3)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Druckt das als Parameter übergebene Maxilos aus.
        /// 
        /// </summary>
        /// <param name="maxilos"></param>
        private static void PrintMaxilos(char[,] maxilos)
        {
            for (int i = 0; i < maxilos.GetLength(0); i++)
            {
                for (int j = 0; j < maxilos.GetLength(1); j++)
                {
                    Console.Write($"| {maxilos[i, j]} ");
                }
                Console.WriteLine("|");
            }
        }

        /// <summary>
        /// Generiert ein Maxilos (2D-Array) mit verschiedenen Zeichen
        /// </summary>
        /// <param name="percentage">Prozentsatz der Dollarzeichen $ im Array</param>
        /// <returns>2D char-Array</returns>
        private static char[,] GenerateMaxilos(double percentage)
        {
            char[,] maxilos = new char[7, 6];

            Random rn = new Random();
            for (int i = 0; i < maxilos.GetLength(0); i++)
            {
                for (int j = 0; j < maxilos.GetLength(1); j++)
                {
                    if (rn.NextDouble() > percentage)
                    {
                        maxilos[i, j] = (char)('\u0031' + rn.Next(0, 10));
                    }
                    else
                    {
                        maxilos[i, j] = '$';
                    }
                }
            }

            return maxilos;
        }
    }
}
