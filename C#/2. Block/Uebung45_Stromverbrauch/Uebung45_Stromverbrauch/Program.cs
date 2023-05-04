using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      20.05.2022
/// Funktion:   Stromverbrauch ausgeben 
/// </summary>

namespace Uebung45_Stromverbrauch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testdaten
            int[,] verbrauch = { { 1001, 23, 28, 31, 35, 42, 45, 47, 50, 56, 61, 67, 73, 78},
                     {1002, 25, 29, 33, 37, 42, 46, 49, 53, 58, 62, 66, 72, 78 },
                     {1003, 22, 30, 33, 36, 41, 42, 44, 51, 53, 58, 62, 69, 74 },
                     {5999, 24, 30, 34, 40, 44, 48, 55, 62, 66, 71, 77, 82, 88 }};

            Statistik(verbrauch, 6);

        }

        public static void Statistik(int[,] verbrauch, int limit)
        {
            int minVerbrauch = int.MaxValue;
            int maxVerbrauch = int.MinValue;

            for (int i = 0; i < verbrauch.GetLength(0); i++)
            {
                int verbrauchNr = verbrauch[i, 0];


                for(int j = 2; j < verbrauch.GetLength(1); j++)
                {
                    int monatsVerbrauch = verbrauch[i, j] - verbrauch[i, j - 1];

                    if (monatsVerbrauch > maxVerbrauch)
                    {
                        maxVerbrauch = monatsVerbrauch;
                    }
                    if(monatsVerbrauch < minVerbrauch)
                    {
                        minVerbrauch = monatsVerbrauch;
                    }


                    //über limit
                    if(monatsVerbrauch > limit)
                    {
                        PrintVerbrauch(verbrauchNr, j-1, monatsVerbrauch);
                    }
                }
            }
            
        }

        private static void PrintJahresstatistik(int minVerbrauch, int maxVerbrauch)
        {
            Console.WriteLine("\nJahresstatistik:");
            Console.WriteLine("Minimaler Verbrauch: " + minVerbrauch);
            Console.WriteLine("Maximaler Verbrauch: " + maxVerbrauch);

        }

        public static void PrintVerbrauch(int verbraucherNr, int monat, int monatsverbrauch)
        {
            string[] monate = { "Jan", "Feb", "Mrz", "Apr", "Mai",
                "Jun", "Jul", "Aug", "Sep", "Okt", "Nov", "Dez" };
            Console.WriteLine($"Verbraucher: {verbraucherNr} " +
                $"=> Monatsverbrauch von {monatsverbrauch} im {monate[monat - 1]}");
        }
    }
}
