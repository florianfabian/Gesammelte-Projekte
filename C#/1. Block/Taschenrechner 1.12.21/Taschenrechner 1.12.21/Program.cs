using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Autor:          Florian Fabian
/// Datum:          1.12.21
/// Funktion:       Taschenrechner für 2 Ganzzahlen mit Grundrechenarten
/// </summary>

namespace Taschenrechner_1._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 0, zahl2 = 0, ergebnis = 0;
            string operation = "";
            Console.WriteLine("Programm zur Berechnung zweier Zahlen durch Grundrechenarten.\n");
            Console.WriteLine("Bitte geben Sie die erste Zahl ein : ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBitte geben Sie die zweite Zahl ein : ");
            zahl2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Operator (+ - * /) ein: ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    ergebnis = zahl1 + zahl2; break;
                case "-":
                    ergebnis = zahl1 - zahl2; break;
                case "*":
                    ergebnis = zahl1 * zahl2; break;
                case "/":
                    ergebnis = zahl1 / zahl2; break;
                default:
                    Console.WriteLine("\nUngültiger Operator!!");
                    Environment.Exit(0); break;

            }
            Console.WriteLine("\nIhr Ergebnis lautet:" + ergebnis);
               
                    


        }
    }
}
