﻿using System;
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
    internal class Bauer : Einwohner
    {
        public Bauer(int einkommen) : base(einkommen)
        { }

        public override int zuVersteuerndesEinkommen()
        {
            return Einkommen / 2;
        }
        public override int steuer()
        {
            return zuVersteuerndesEinkommen() / 2;
        }
        public override string ToString()
        {
            return $"Einkommen : {Einkommen}, ZuVersteuern : {zuVersteuerndesEinkommen()}, Steuer : {steuer()}";
        }
    }
}