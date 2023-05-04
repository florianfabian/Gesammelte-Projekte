using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
///Autor:       Florian Fabian
///Datum:       22.09.22
///Funktion:    Finanz und Steuerwesen im Mittelalter digitalisieren
///
///

namespace Uebung59_Koenigreich
{
    internal class Einwohner
    {
        private int einkommen;

        public Einwohner(int einkommen)
        {
            this.einkommen = einkommen;
        }

        public int Einkommen { get => einkommen; set => einkommen = value; }

        public virtual int zuVersteuerndesEinkommen()
            { return einkommen; }

        public virtual int steuer()
        { return einkommen; }

        public override string ToString()
        {
            return $"Einkommen = {Einkommen}";
        }
    }
}
