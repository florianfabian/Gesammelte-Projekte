using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:      Florian Fabian
/// Datum:      25.08.2022
/// Funktion:   Klasse Kreis + Methoden, um mit dem Kreis grundlegene Manipulationen durchzuführen
/// Funktion:   Ergänzung 29.08.:Zugriffsmethoden Getter/Setter hinzugefügt
///

namespace Uebung51_Kreis
{
    internal class Kreis
    {
        private double radius;
        private double flaeche;
        private double umfang;
        private double durchmesser;

        public double Radius    { get => radius;
            set { 
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ungültiger Wert!");
                }            
                radius = value; }
                                }

        public Kreis(double radius)
        {
            this.radius = radius;
        }

        public double BerechneFlaeche()
        {
            flaeche = (radius * Math.PI) * 2;
            return flaeche;
        }

        public double BerechneUmfang()
        {
            umfang = (2 * radius) * Math.PI;
            return umfang;
        }

        public double BerechneDurchmesser()
        {
            durchmesser = 2.00 * radius;
            return durchmesser;
        }

        public override string ToString()
        {
            return $"Kreis [Radius = {radius:N2},  Flaeche = {flaeche:N2}, Umfang = {umfang:N2}, Durchmesser = {durchmesser:N2}";
        }
    }
}
