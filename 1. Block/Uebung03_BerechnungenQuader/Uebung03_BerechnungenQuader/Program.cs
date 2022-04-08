///Autor: Florian Fabian
///Datum: 29.10.2021
///Funktion des Programms: Berechnung Volumen und Flächeninhalt des Quaders
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung03_BerechnungenQuader
{
    class Program
    {
        static void Main(string[] args)
        {
            int breite = 3, länge = 3, höhe = 3;                    //Definition Breite, Länge und Höhe des Quaders
            int grundfläche;                                        //Deklaration einer Grundflächenvariable
            int volumen;                                            //Deklaration Variable Volumen

            volumen = breite * länge * höhe;                        //Berechnung Volumen
            grundfläche = 2*(breite * höhe + breite * länge + länge * höhe);        //Berechnung Grundfläche

            Console.WriteLine("Das Volumen des voreingestellten Quaders beträgt: " + volumen + " cm^3");            //Ausgabe Volumen
            Console.WriteLine("Die Grundfläche des voreingestellten Quaders beträgt: " + grundfläche + " cm^2");    //Ausgabe Grundfläche





        }
    }
}
