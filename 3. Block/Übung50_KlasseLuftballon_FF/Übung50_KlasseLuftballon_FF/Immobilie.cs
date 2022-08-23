using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:      Florian Fabian
/// Datum:      22.08.22
/// Funktion:   Klasse zur Konstruktion einer Immobilie
///

namespace Übung50_KlasseLuftballon_FF
{
    internal class Immobilie
    {
        private string beschreibung;
        private double wohnflaeche;
        private int anzahlZimmer;
        private int baujahr;
        private double kaufpreis;
        private bool verkauft;

        public Immobilie(string beschreibung, double wohnflaeche, int anzahlZimmer, int baujahr, double kaufpreis, bool verkauft)
        {
            this.beschreibung = beschreibung;
            this.wohnflaeche = wohnflaeche;
            this.anzahlZimmer = anzahlZimmer;
            this.baujahr = baujahr;
            this.kaufpreis = kaufpreis;
            this.verkauft = verkauft;
        }

        public override string ToString()
        {
            return $"Immobilie [Beschreibung = {beschreibung}, wohnflaeche = {wohnflaeche}, anzahlZimmer = {anzahlZimmer}" +
                $" Baujahr = {baujahr}, Kaufpreis = {kaufpreis}, verkauft = {verkauft}]";
        }
    }
}
