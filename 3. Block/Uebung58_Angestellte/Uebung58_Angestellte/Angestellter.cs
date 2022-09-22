using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
///Autor:       Florian Fabian
///Datum:       12.09.22
///Funktion:    Vererbungen darstellen am Objekt der Angestellten
///Edit:        15.09.22 : Klasse Manager hinzugefügt, mit Override Klassenfremder Methoden
///
///

namespace Uebung58_Angestellte
{
    internal class Angestellter
    {
        private double grundgehalt;

        public Angestellter(double grundgehalt)
        {
            this.grundgehalt = grundgehalt;
        }

        public double Grundgehalt { get => grundgehalt; set => grundgehalt = value; }

        public virtual double BerechneMonatsgehalt()
        {
            return grundgehalt;
        }
        public double BerechneJahresgehalt()
        {
            return BerechneMonatsgehalt() * 12;
        }

        public override string ToString()
        {
            return $"\nGrundgehalt = {grundgehalt}";
        }
    }
}