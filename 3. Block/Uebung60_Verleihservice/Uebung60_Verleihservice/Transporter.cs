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
    internal class Transporter : Leihfahrzeug
    {
        private double zulaessigesGesamtgewicht;

        public Transporter(string fahrzeugID, string bezeichnung, double miettarifProTag, double versicherungspauschale, double zulaessigesGesamtgewicht) 
            : base(fahrzeugID, bezeichnung, miettarifProTag, versicherungspauschale)
        {
            this.zulaessigesGesamtgewicht = zulaessigesGesamtgewicht;
        }

        public double ZulaessigesGesamtgewicht { get => zulaessigesGesamtgewicht; set => zulaessigesGesamtgewicht = value; }

        public override string ToString()
        {
            return $"Transporter: [Zulässiges Gesamtgewicht = {ZulaessigesGesamtgewicht}, FahrzeugID = {FahrzeugID}, Bezeichnung = {Bezeichnung}, Miettarif pro Tag = {MiettarifProTag}, " +
                $"Versicherungspauschale = {Versicherungspauschale}]";
        }
    }
}
