using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/// <summary>
/// Autor: Florian Fabian
/// Datum: 03.12.2021
/// Funktion: While und Do-While Schleifen
/// </summary>
namespace Übung021_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 1, summe = 0;

            while (zahl <= 100)
            {
                Console.WriteLine(zahl);
                summe = summe + zahl;
                zahl++;
            }
            Console.WriteLine("\nSumme der Zahlen 1-100: " + summe);
            zahl = 1;
            summe = 1;
            do
            {
                zahl++;
                summe = summe + zahl;
                
            } while (summe <= 100);
            Console.WriteLine("\nZahl, die bei Summierung das Ergebnis über 100 streckt: " + zahl);
            zahl = 100; 
            do
            {      
                Console.WriteLine("\nCOUNTDOWN T-" + zahl + " SEKUNDEN");
                zahl--;
                Thread.Sleep(1000);
            } while (zahl >= 0);

        }
    }
}
