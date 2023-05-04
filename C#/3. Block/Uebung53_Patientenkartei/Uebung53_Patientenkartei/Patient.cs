using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


///
/// Autor:      Florian Fabian
/// Datum:      29.08.2022
/// Funktion:   Digitalisierung Patientenkartei, Objektorientiert mit Get/Set
///


namespace Uebung53_Patientenkartei
{
    internal class Patient
    {
        private string name;
        private string vorname;
        private int alter;
        private char geschlecht;
        private double koerpergroesse;
        private double koerpergewicht;

        public Patient(string name, string vorname, int alter, char geschlecht, double koerpergroesse, double koerpergewicht)
        {
            this.name = name;
            this.vorname = vorname;
            this.alter = alter;
            this.geschlecht = geschlecht;
            this.koerpergroesse = koerpergroesse;
            this.koerpergewicht = koerpergewicht;
        }

        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public int Alter { get => alter; set => alter = value; }
        public char Geschlecht { get => geschlecht; set => geschlecht = value; }
        public double Koerpergroesse { get => koerpergroesse; set => koerpergroesse = value; }
        public double Koerpergewicht { get => koerpergewicht; set => koerpergewicht = value; }


        public double BerechneBMI()
        {
            double bmi = koerpergewicht / Math.Pow(koerpergroesse, 2);
            return bmi;
        }

        public override string ToString()
        {
            return $"Patient [Name = {name}, Vorname = {vorname}, Alter = {alter}, Geschlecht = {geschlecht}, Körpergröße = {koerpergroesse}, Körpergewicht = {koerpergewicht}]";
        }

    }
}
