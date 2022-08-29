using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:      Florian Fabian
/// Datum:      22.08.22
/// Funktion:   Klasse zur Konstruktion einer Immobilie
/// Funktion:   Ergänzung 29.08.:Zugriffsmethoden Getter/Setter hinzugefügt
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

        public string GetBeschreibung()
        {
            return beschreibung;
        }
        public void SetBeschreibung(string BeschreibungVAR)
        {
            beschreibung=BeschreibungVAR;
        }
        public double GetWohnflaeche()
        {
            return wohnflaeche;
        }
        public void SetWohnflaeche(double WohnflaecheVAR)
        {
            wohnflaeche = WohnflaecheVAR;
        }
        public int GetAnzahlZimmer()
        {
            return anzahlZimmer;
        }
        public void SetAnzahlZimmer(int anzahlzimmerVAR)
        {
            anzahlZimmer=anzahlzimmerVAR;
        }
        public int GetBaujahr()
        {
            return baujahr;
        }
        public void SetBaujahr(int baujahrVAR)
        {
            baujahr = baujahrVAR;
        }

        public double GetKaufpreis()
        {
            return kaufpreis;
        }
        public void SetKaufpreis(double KaufpreisVAR)
        {
            kaufpreis = KaufpreisVAR;
        }
        public bool GetVerkauft()
        {
            return verkauft;
        }
        public void SetVerkauft(bool VerkauftVAR)
        {
            verkauft = VerkauftVAR;
        }

        public override string ToString()
        {
            return $"Immobilie [Beschreibung = {beschreibung}, wohnflaeche = {wohnflaeche}, anzahlZimmer = {anzahlZimmer}" +
                $" Baujahr = {baujahr}, Kaufpreis = {kaufpreis}, verkauft = {verkauft}]";
        }
    }
}
