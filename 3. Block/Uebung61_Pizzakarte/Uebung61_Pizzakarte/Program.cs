using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
///
/// Autor:      Florian Fabian
/// Datum:      11.10.2022
/// Funktion:   Digitalisierung Pizzakarte
///
///

namespace Uebung61_Pizzakarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzaKarte = LesePizzaKarte();

            Console.WriteLine(string.Join("\n", pizzaKarte));

            //Teuerste Pizza
            Pizza teuerste = pizzaKarte[0];

            foreach (var item in pizzaKarte)
            {
                if(item.Preis > teuerste.Preis)
                {
                    teuerste = item;
                }
            }

            Console.WriteLine("\nTeuerste Pizza: " + teuerste);

            //Max AnzahlZutaten
            int indexMaxZutaten = 0;

            for(int i = 0; i < pizzaKarte.Count; i++)
            {
                if (pizzaKarte[i].AnzahlZutaten > pizzaKarte[indexMaxZutaten].AnzahlZutaten)
                {
                    indexMaxZutaten = i;
                }
            }

            Pizza maxZutaten = pizzaKarte[indexMaxZutaten];

            Console.WriteLine("\nPizza mit den meisten Zutaten: " + maxZutaten);

            //Pizzen bis zum Höchstpreis
            Console.WriteLine("Höchstpreis? : ");
            double maxPreis = Convert.ToDouble(Console.ReadLine());

            List<Pizza> teilkarte = new List<Pizza>();

            foreach (var item in pizzaKarte)
            {
                if(item.Preis <= maxPreis)
                {
                    teilkarte.Add(item);
                }
            }
            Console.WriteLine(String.Join("\n",teilkarte));
            Console.ReadLine();

            //Sortieren
            pizzaKarte.Sort(ComparePreis);
            Console.WriteLine("\nSortiert nach Preis");
            Console.WriteLine(string.Join("\n", pizzaKarte));
            Console.ReadLine();

            Console.WriteLine("Sortiert nach Namen"); //TODO
            pizzaKarte.Sort(ComparePreis);
            Console.WriteLine(string.Join("\n", pizzaKarte));
            Console.ReadLine();

            Console.WriteLine("Sortiert nach AnzahlZutaten und Preis");
            pizzaKarte.Sort(CompareAnzahlZutatenUndPreis);
            Console.WriteLine(string.Join("\n", pizzaKarte));
            Console.ReadLine();
        }

        private static int CompareAnzahlZutatenUndPreis(Pizza p1, Pizza p2)
        {
            if (p1.AnzahlZutaten == p2.AnzahlZutaten)
            {
                return p1.Preis.CompareTo(p2.Preis);
            }
            return p1.AnzahlZutaten.CompareTo(p2.AnzahlZutaten);    
        }

        private static int ComparePreis(Pizza p1, Pizza p2)
        {
            if(p1.Preis < p2.Preis)
            { return -1; }
            else if (p1.Preis == p2.Preis)
            { return 0; }
            else
            { return +1; }

            /*
             * Alternativ:
             * return p1.Preis.CompareTo(p2.Preis);
             * Hierarchie: ZUERST.ComparTo(ZULETZT)
             * umgekehrt (von hoch zu tief) also:
             * entweder -p1.Preis.CompareTo(p2.Preis);
             * oder p2.Preis.CompareTo(p1.Preis);
             */
        }

        private static List<Pizza> LesePizzaKarte()
        {
            List<Pizza> pizzen = new List<Pizza>();
            string[] lines = File.ReadAllLines(@"Pizzakarte\pizzakarte.csv");

            foreach(var item in lines)
            {
                string[] data = item.Split(';');

                string name = data[0];
                int anzahlZutaten = Convert.ToInt32(data[1]);
                double preis = Convert.ToDouble(data[2]);

                Pizza pizza = new Pizza(name, anzahlZutaten, preis);

                pizzen.Add(pizza);
            }

            return pizzen;

        }

        public static void PrintPizzaKarte(List<Pizza> pizzaKarte)
        {
            Console.WriteLine($"************************");
            Console.WriteLine($"*                 Pizzakarte Ristorante bib                       *");
            Console.WriteLine($"************************");
            Console.WriteLine($"| Nr |  Name        | # | Preis 20 cm | Preis 30 cm | Preis 40 cm | ");
        }
    }
}
