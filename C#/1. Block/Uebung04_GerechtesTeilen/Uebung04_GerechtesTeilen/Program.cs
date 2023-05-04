///Autor: Florian Fabian
///Datum: 29.10.2021
///Funktion des Programms: Eine bestimmte Menge an Produkten gerecht an eine bestimmte Menge von Personen verteilen durch Modulo Operator
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung04_GerechtesTeilen
{
    class Program
    {
        static void Main(string[] args)
        {
            int produktzahl, konsumenten;                       //Deklaration Variablen
            Console.WriteLine("Hallo! Dieses Programm teilt Ihnen ein Produkt gerecht auf beliebig viele Personen auf.");       //Erklärung für Anwender
            Console.WriteLine("Bitte geben Sie die Menge der Produkte an: ");                  //Aufforderung Eingabe Anzahl der Produkte
            produktzahl = Convert.ToInt32(Console.ReadLine());          //Eingabe, String -> Int convert
            Console.WriteLine("Bitte geben Sie die Menge an Personen an, die sich die Produkte teilen sollen.");    //Aufforderung Eingabe Anzahl Konsumenten
            konsumenten = Convert.ToInt32(Console.ReadLine());          //Eingabe, String -> Int convert

            int rest = produktzahl % konsumenten;               //Module um Rest zu berechnen
            Console.WriteLine("Nicht verteilter Rest = " + rest);       //Ausgabe Rest
            int konsument_stueck = (produktzahl - rest) / konsumenten;      //Berechnung Produktzahl - Rest, Stückzahl pro Konsument
            Console.WriteLine("Stückzahl pro Empfänger = " + konsument_stueck);     //Ausgabe der Produkte die jeder Konsument bekommt
            



        }
    }
}
