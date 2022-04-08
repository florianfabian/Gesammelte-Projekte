using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 03.12.2021
/// Funktion: Reverse Zahl
/// </summary>

namespace Uebung22B_RevrseZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0, quersumme = 0, rechnung = 0;
            Console.WriteLine("Programm berechnet Reversion einer Zahl.");
            Console.WriteLine("\nBitte geben Sie eine positive Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl != 0)
            {
                rechnung = zahl % 10;              
                quersumme += rechnung;
                quersumme = quersumme * 10;
                zahl = zahl / 10;
            }
            quersumme = quersumme / 10;
            Console.WriteLine("\nReversion Ihrer Zahl ist: " + quersumme);
        }
    }
}
