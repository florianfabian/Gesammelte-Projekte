using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
/// Autor:      Florian Fabian
/// Datum:      14.09.2022
/// Funktion:   Mieteinnahmen einer Hausverwaltung digitalisieren
///
///

namespace Uebung56_Hausverwaltung
{
    internal class Wohnung : Mieter
    {
        private int nummer;
        private double flaeche;
        private double monatsmiete;


        public int Nummer { get => nummer; set => nummer = value; }
        public double Flaeche { get => flaeche; set => flaeche = value; }
        public double Monatsmiete { get => monatsmiete; set => monatsmiete = value; }

        public Wohnung(int nummer, double flaeche, double monatsmiete, string name) : base(name) {
            this.nummer = nummer;
            this.flaeche = flaeche;
            this.monatsmiete = monatsmiete;
        }

        public override string ToString()
        {
            return $"Nummer = {nummer}, Fläche = {flaeche}, Monatsmiete = {monatsmiete}";
        }
    }
}
