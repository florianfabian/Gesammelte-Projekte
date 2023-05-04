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
    internal class Sekretaerin : Angestellter
    {
        private Angestellter arbeitetFuer;
        public Sekretaerin(double grundgehalt, Angestellter arbeitetFuer)
            : base(grundgehalt)
        {
            this.arbeitetFuer = arbeitetFuer;
        }

        internal Angestellter ArbeitetFuer { get => arbeitetFuer; set => arbeitetFuer = value; }

        public override string ToString()
        {
            return $"\nSekräterin [grundgehalt = {Grundgehalt}, arbeitet für = {arbeitetFuer}]";
        }
    }
}
