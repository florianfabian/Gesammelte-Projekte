using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 17.11.2021
/// Funktion: Rabatt ausrechnen für bestimmte Kaufmengen
/// </summary>

namespace Übung16_Rabattstaffel
{
    class Program
    {
        static void Main(string[] args)
        {
            const double rabatthundert = 0.02;
            const double rabattzhundert = 0.03;
            const double rabattfhundert = 0.05;
            const double rabatttausend = 0.10;
            const double stueckpreis = 10.00;
            int eingabe = 0;
            double rechner = 0.00, preisohne = 0.00, preismit = 0.00;
            

            Console.WriteLine("Programm zum Rabatt ausrechnen. Preis pro Stück beträgt 10 €.\n");
            Console.WriteLine("Wie viele Artikel möchten Sie kaufen?\n");
            eingabe = Convert.ToInt32(Console.ReadLine());
            preisohne = eingabe * stueckpreis;
            if (eingabe >= 1000)
            {
                Console.WriteLine("Sie bekommen einen Rabatt von 10 %!");
                rechner = (stueckpreis * eingabe) * rabatttausend;
            }
            else if (eingabe >= 500)
            {
                Console.WriteLine("Sie bekommen einen Rabatt von 5 %!");
                rechner = (stueckpreis * eingabe) * rabattfhundert;
            }
            else if (eingabe >= 200)
            {
                Console.WriteLine("Sie bekommen einen Rabatt von 3 %!");
                rechner = (stueckpreis * eingabe) * rabattzhundert;
            }
            else if (eingabe >= 100)
            {
                Console.WriteLine("Sie bekommen einen Rabatt von 2 %!");
                rechner = (stueckpreis * eingabe) * rabatthundert;
            }

            if (eingabe < 100)
            {
                Console.WriteLine("\nSie bekommen leider keinen Rabatt.");
                Environment.Exit(0);

            }

            preismit = preisohne - rechner;

            Console.WriteLine("\nPreis ohne Rabatt: " + preisohne + " Euro.");
            Console.WriteLine("\nSie bekommen einen Rabatt von " + rechner + " Euro.");
            Console.WriteLine("\nDer Gesamtbetrag für Sie beträgt also " + preismit + " Euro.");


        }
    }
}
