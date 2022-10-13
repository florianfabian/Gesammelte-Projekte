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
    internal class Pizza
    {
        private string name;
        private int anzahlZutaten;
        private double preis;

        public Pizza(string name, int anzahlZutaten, double preis)
        {
            this.name = name;
            this.anzahlZutaten = anzahlZutaten;
            this.preis = preis;
        }

        public string Name { get => name; set => name = value; }
        public int AnzahlZutaten
        {
            get { return anzahlZutaten; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Anzahl der Zutaten muss >= 0 sein.");
                }
                anzahlZutaten = value;
            }
        }
        public double Preis
        {
            get
            {
                if (preis < 0)
                {
                    throw new ArgumentOutOfRangeException("Preis unter 0!");
                }
                else
                {
                    return preis;
                }
            }
            set { preis = value; }
        }

        public double BerechneMiniPreis()
        {
            return Math.Round(preis * 0.7,1);
        }
        public double BerechneMaxiPreis()
        {
            return Math.Round(preis * 1.45,1);
        }
        public static Pizza[] Lesepizzakarte()
        {
            string[] lines = File.ReadAllLines(@"Datenn\Pizzakarte.csv");
            Pizza[] pizza = new Pizza[lines.Length];

            string name = lines[0];
            int anzahlZutaten = Convert.ToInt32(lines[1]);
            double preis = Convert.ToDouble(lines[2]);

            return pizza;
        }

        public static Pizza[] BestimmeTeuerstePizza()
        {
            string[] lines = File.ReadAllLines(@"Datenn\Pizzakarte.csv");
            Pizza[] pizza = new Pizza[lines.Length];

            double teuerstePizza = 0;
            for (int i = 0; i < lines[2].Length; i++)
            {
                if (teuerstePizza < Convert.ToDouble(lines[2]))
                {
                    teuerstePizza = Convert.ToDouble(lines[2][i]);
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"Die teuerste Pizza kostet: {teuerstePizza}");
            }
            return pizza;
        }

        public static Pizza[] BestimmeGuenstigstePizza()
        {
            string[] lines = File.ReadAllLines(@"Datenn\Pizzakarte.csv");
            Pizza[] pizza = new Pizza[lines.Length];

            double guenstigstePizza = 0;
            for (int i = 0; i > lines[2].Length; i++)
            {
                if (guenstigstePizza < Convert.ToDouble(lines[2]))
                {
                    guenstigstePizza = Convert.ToDouble(lines[2][i]);
                }
                else
                {
                    continue;
                }
                Console.WriteLine($"Die teuerste Pizza beträgt: {guenstigstePizza}");
            }
            return pizza;
        }

        public static Pizza[] AnzahlZustaten()
        {
            string[] lines = File.ReadAllLines(@"Datenn\Pizzakarte.csv");
            Pizza[] pizza = new Pizza[lines.Length];

            int anzahlzutaten = 0;

            for (int i = 0; i < lines[1].Length; i++)
            {
                if (anzahlzutaten < Convert.ToInt32(lines[1]))
                {
                    anzahlzutaten = Convert.ToInt32(lines[1][i]);
                }
                else
                {
                    continue;
                }
            }
            return pizza; ;
        }
        public override string ToString()
        {
            return $"Pizza [Name = {Name}, anzahlZutaten = {anzahlZutaten}, Preis = {Preis}]";
        }
    }
}
