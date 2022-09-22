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
    internal class Leibeigener : Bauer
    {
        public Leibeigener(int einkommen) : base(einkommen)
        { }

        public override int zuVersteuerndesEinkommen()
        {
            return Einkommen;
        }
        public override int steuer()
        {
            return Einkommen;
        }
        public override string ToString()
        {
            return $"Einkommen : {Einkommen}, ZuVersteuern : {zuVersteuerndesEinkommen()}, Steuer : {steuer()}";
        }
    }
}
