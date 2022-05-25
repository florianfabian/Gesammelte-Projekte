using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      19.05.2022
/// Funktion:   2D Array - Albrecht Dürer, magisches Quadrat
///             !Unfinished, da falsch verstanden (es ging um die Summe der Zahlen)
/// </summary>

namespace Uebung043_MagischesQuadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] magischesquadrat = { { 16, 3, 2, 13 }, { 5, 10, 11, 8 }, { 9, 6, 7, 12 }, { 4, 15, 14, 1 } };
            int summezeilen = 0;
            for(int i = 0; i < magischesquadrat.GetLength(0); i++)
            {
                summezeilen++;
            }
            Console.WriteLine("Summe Zeilen : " + summezeilen);
            int summespalten = 0;
            for (int i = 0; i < magischesquadrat.GetLength(1); i++)
            {
                summespalten++;
            }
            Console.WriteLine("Summe Spalten : " + summespalten);
            int summediagonale = 0;
            for (int i = 0; i < magischesquadrat.GetLength(0) + magischesquadrat.GetLength(1) - 1; i++)
            {
                summediagonale++;
            }
            Console.WriteLine("Summe Diagonale : " + summediagonale);
            int rechner = 0;
            int mittelwert = 0;
            for (int i = 0; i < magischesquadrat.GetLength(0); i++)
            {
                rechner += magischesquadrat[i, i];
            }
            int rechner2 = magischesquadrat.GetLength(0) + magischesquadrat.GetLength(1);
            mittelwert = rechner / rechner2;
            Console.WriteLine("Mittelwert aller Zahlen im Quadrat : " + mittelwert);
        }
    }
}
