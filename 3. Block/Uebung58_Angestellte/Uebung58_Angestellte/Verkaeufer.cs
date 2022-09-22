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
    internal class Verkaeufer : Angestellter
    {
        private double provision;

        public double Provision { get => provision; set => provision = value; }

        public Verkaeufer(double grundgehalt, double provision)
        : base(grundgehalt)
        {
            Provision = provision;
        }

        public override double BerechneMonatsgehalt()
        {
            return base.BerechneMonatsgehalt() + provision;
        }


        public override string ToString()
        {
            return $"\nVerkaufer [grundgehalt = {Grundgehalt}, provision = {Provision}]";
        }
    }
}
