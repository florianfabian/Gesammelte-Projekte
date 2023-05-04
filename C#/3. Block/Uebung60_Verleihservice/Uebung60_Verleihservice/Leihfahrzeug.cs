using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
///
///Autor:       Florian Fabian
///Datum:       23.09.2022
///Funktion:    Verleihservice objektorientiert
///

namespace Uebung60_Verleihservice
{
    internal class Leihfahrzeug
    {
        private string fahrzeugID;
        private string bezeichnung;
        public double miettarifProTag;
        private double versicherungspauschale;

        public Leihfahrzeug(string fahrzeugID, string bezeichnung, double miettarifProTag, double versicherungspauschale)
        {
            this.fahrzeugID = fahrzeugID;
            this.bezeichnung = bezeichnung;
            this.miettarifProTag = miettarifProTag;
            this.versicherungspauschale = versicherungspauschale;
        }

        public string FahrzeugID { get => fahrzeugID; set => fahrzeugID = value; }
        public string Bezeichnung { get => bezeichnung; set => bezeichnung = value; }
        public double MiettarifProTag { get => miettarifProTag; set => miettarifProTag = value; }
        public double Versicherungspauschale { get => versicherungspauschale; set => versicherungspauschale = value; }


        public virtual double BerechneMietpreis(TimeSpan dauer)
        {
            int tage = dauer.Days;
            if (dauer.Hours > 0)
            { tage += 1; }

            double ergebnis = miettarifProTag * tage;

            if (Versicherungspauschale != 0)
            {
                ergebnis += Versicherungspauschale;
            }
            if (dauer.Hours < 8)
            {
                ergebnis *= 1.5; //kein Wert angegeben, deshalb 50 % Aufschlag für unter 8 Stunden
            }
            
            return ergebnis;
        }

        public string BenoetigterFuehrerschein(double gesamtgewicht)
        {
            if (gesamtgewicht < 3.5)
                return "Klasse B";
            else
                return "LKW-Führerschein";
        }
        public override string ToString()
        {
            return $"Leihfahrzeug: [FahrzeugID = {FahrzeugID}, Bezeichnung = {Bezeichnung}, Miettarif pro Tag = {MiettarifProTag}, " +
                $"Versicherungspauschale = {Versicherungspauschale}]";
        }
    }
}
