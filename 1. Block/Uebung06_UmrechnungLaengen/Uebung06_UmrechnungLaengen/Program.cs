///
///Autor: Florian Fabian
///Datum: 03.11.2021 
///Funktion des Programms: Rechnet eine beliebige Zahl von der Maßeinheit mm in die einzelnen Maßeinheitenanteile km, m, cm und mm um

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung06_UmrechnungLaengen
{
    class Program
    {
        static void Main(string[] args)
        {
            int mm;     //Deklaration Variable für den Ursprungswert der zur Berechnung herangezogen wird
            Console.WriteLine("Programm rechnet Millimeter in Kilometer, Meter, Centimeter und Millimeter um");     //Funktion des Programms dem Anwender erklären
            Console.WriteLine("Bitte geben Sie eine bestimmte Länge in Millimetern ein: ");     //Frage den Anwender nach mm-Eingabe
            mm = Convert.ToInt32(Console.ReadLine());       //Eingabe des Benutzers wird in die "mm" Variable eingelesen und direkt von String in Int umgewandelt
            int km, m, cm, mmrest;              //Deklaration Variablen für die nötigen Parameter
            km = mm / 1000000;                  //KM-Parameter berechnen
            mmrest = mm % 1000000;              //Rest des Ursprungswertes berechnen
            m = mmrest / 1000;                  //M-Parameter berechnen
            mmrest = mmrest % 1000;             //Rest des Ursprungswertes berechnen
            cm = mmrest / 10;                   //CM-Parameter berechnen
            mmrest = mmrest  % 10;              //MM-Parameter berechnen
            Console.WriteLine(mm + " mm entsprechen " + km + " km " + m + " m " + cm + " cm " + mmrest + " mm"); //Ausgabe der Parameter
        }
    }
}
