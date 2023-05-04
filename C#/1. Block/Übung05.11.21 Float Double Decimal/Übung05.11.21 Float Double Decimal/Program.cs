using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 05.11.2021
/// Funktion des Programms: Float, Double und Decimal ausprobieren und ausgeben
/// </summary>

namespace Übung05._11._21_Float_Double_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float f1 = 15.3f, f2 = 12345.6789f;
            double d1 = -3.5, d2 = 12345.6789, d3 = -1.602176620898 * (10 ^ -19);
            decimal m1 = 0.123456789012345678901234567890123456789m;

            Console.WriteLine("F1  : " + f1 + "\nF2  : " + f2 + "\nD1  : " + d1 + "\nD2  : " + d2 + "\nD3  : " + d3 + "\nm1  : " + m1);
        }
    }
}
