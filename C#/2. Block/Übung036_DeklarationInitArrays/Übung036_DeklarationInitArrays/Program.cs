using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      27.04.2022
/// Funktion:   Arraydeklaration
/// </summary>

namespace Übung036_DeklarationInitArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration Arrays:
            int i = 0;
            
            int[]       zahlen = { 4, 2, 10, 3, -5, 0, 17 };
            
            double[] temperaturen = { 9.8, 2.4, 5.6, 10.3, 4.9 };
            
            string[] wochentage = { "Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag" };
            
            char[] buchstaben = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //Nächstes mal mit char start = 'a', danach for Schleife mit buchstaben[i] = start++;   funktioniert weil Buchstaben zugewiesene Zahlenwerte haben

            int[] geradeZahlen = new int[50];
            for (i = 0; i < geradeZahlen.Length; i++)
            {
                geradeZahlen[i] = i * 2;
            }

            int[] zufallsZahlen = new int[100];
            Random rnd = new Random();
            for (i = 0; i < zufallsZahlen.Length; i++)
            {
                zufallsZahlen[i] = rnd.Next(1,11);      //Hier 11, da die obere Grenze EXKLUSIV ist, sonst kommt 10 nicht als zufällig Zahl vor
            }

            //Ausgabe Arrays:
            Console.WriteLine("\nAusgabe Array zahlen[]: \n");
            for (i = 0; i < zahlen.Length; i++)
            {
                Console.Write(zahlen[i] + "\t");
            }
            Console.WriteLine("\n\nAusgabe Array temperaturen[]: \n");
            for (i = 0; i < temperaturen.Length; i++)
            {
                Console.Write(temperaturen[i] + "\t");
            }
            Console.WriteLine("\n\nAusgabe Array wochentage[]: \n");
            for (i = 0; i < wochentage.Length; i++)
            {
                Console.Write(wochentage[i] + "\t");
            }
            Console.WriteLine("\n\nAusgabe Array buchstaben[]: \n");
            for (i = 0; i < buchstaben.Length; i++)
            {
                Console.Write(buchstaben[i] + "\t");
            }
            Console.WriteLine("\n\nAusgabe Array geradeZahlen[]: \n");
            for (i = 0; i < geradeZahlen.Length; i++)
            {
                Console.Write(geradeZahlen[i] + "\t");
            }
            Console.WriteLine("\n\nAusgabe Array zufallsZahlen[]: \n");
            for (i = 0; i < zufallsZahlen.Length; i++)
            {
                Console.Write(zufallsZahlen[i] + "\t");
            }
        }
    }
}
