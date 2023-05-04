using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      03.12.2021
/// Funktion:   Dualzahl
/// </summary>

namespace Uebung22C_Dualzahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0, quersumme = 0, rechnung = 0;
            Console.WriteLine("Programm stellt eine positive Dezimalzahl als Dualzahl dar.");
            Console.WriteLine("\nBitte geben Sie eine positive Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl != 0)
            {
                rechnung = zahl % 2;
                quersumme += rechnung;
                zahl = zahl / 10;
            }
            Console.WriteLine("\nQuersumme Ihrer Zahl ist: " + quersumme);
        }
    }
}
