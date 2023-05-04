/// <summary>
/// Autor: Florian Fabian
/// Datum: 29.10.2021
/// Programm zur ersten Übung von C#
/// C++ vorerfahrungen, deshalb habe ich ein wenig mit Schleifen/IfBedingungen rumgespielt
///</summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung1
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;

            //Ausführen mit STRG-F5 (Read-Modus)
            Console.WriteLine("Hello World!");      //Generischer Hello World Output
            eingabe = Console.ReadLine();           //Übung zur ersten Einlesung
            Console.WriteLine(eingabe);             //Einlesung in der Konsole wieder ausgeben
            string choice = "c";                    //String Variable zur Schleifenbedingung
            do                                      //Schleife zur Übung
            {
                string wahl;                                                                                                        //Variable für eine Bedingung
                Console.WriteLine("Möchten Sie Option a oder b?");                      //Frage zum User Input
                wahl = Console.ReadLine();                                              //User Input in die Wahl Variable speichern

                if (wahl == "a")                                                        //Wenn User Input = a...
                {
                    Console.WriteLine("Sie haben Option a gewählt!");
                    Console.WriteLine("Deshalb wird jetzt xx und yy gemacht");          //Kurze Rückmeldung über Konsole und Text
                }
                else if (wahl == "b")                                                   //Wenn User Input = b
                {
                    Console.WriteLine("Sie haben die Option b gewählt!");
                    Console.WriteLine("Deshalb wird jetzt xx und yy gemacht");          //Kurze Rückmeldung über Konsole und Text
                }
                else                                                                    //Wenn User Input != a oder b...
                {
                    Console.WriteLine("Ungültige Eingabe!");                            //dann Rückmeldung der ungültigen Eingabe
                }
                Console.WriteLine("Noch einmal? (Option c), wenn nicht, dann bitte eine beliebige andere Taste drücken!");          //User wird gefragt, ob die Schleife weiterlaufen soll
                choice = Console.ReadLine();                                            //User wird nach input gefragt, wenn "c" dann weiter, jede andere Taste = beenden
            } while (choice == "c");




        }
    }
}
