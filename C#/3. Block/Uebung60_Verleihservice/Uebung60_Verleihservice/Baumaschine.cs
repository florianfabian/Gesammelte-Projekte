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
    internal class Baumaschine : Leihfahrzeug
    {
        private double miettarifProStunde;
        private bool lieferservice;

        public Baumaschine(string fahrzeugID, string bezeichnung, double miettarifProTag, double versicherungspauschale, double miettarifProStunde, bool lieferservice)
            : base(fahrzeugID, bezeichnung, miettarifProTag, versicherungspauschale)
        {
            this.miettarifProStunde = miettarifProStunde;
            this.lieferservice = lieferservice;
        }

        public double MiettarifProStunde { get => miettarifProStunde; set => miettarifProStunde = value; }
        public bool Lieferservice { get => lieferservice; set => lieferservice = value; }


        public override double BerechneMietpreis(TimeSpan dauer)
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
            if (Lieferservice == true)
            {
                ergebnis += 100;
            }

            return ergebnis;
        }
        public override string ToString()
        {
            return $"Baumaschine: [Miettarif pro Stunde = {MiettarifProStunde}, Lieferservice = {lieferservice}, FahrzeugID = {FahrzeugID}, Bezeichnung = {Bezeichnung}, Miettarif pro Tag = {MiettarifProTag}, " +
                $"Versicherungspauschale = {Versicherungspauschale}]";
        }

    }
}
