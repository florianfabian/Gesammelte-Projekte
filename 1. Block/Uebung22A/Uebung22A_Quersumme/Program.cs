using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 03.12.2021
/// Funktion: Quersumme
/// </summary>

namespace Uebung22A_Quersumme
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 0, quersumme = 0, rechnung = 0;
            Console.WriteLine("Programm berechnet Quersumme einer Zahl.");
            Console.WriteLine("\nBitte geben Sie eine Zahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());

            while (zahl != 0)
            {
                rechnung = zahl % 10;
                quersumme += rechnung;
                zahl = zahl / 10;
            }
            Console.WriteLine("\nQuersumme Ihrer Zahl ist: " + quersumme);
        }
    }
}
