using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
/// Autor:      Florian Fabian
/// Datum:      14.09.2022
/// Funktion:   Mieteinnahmen einer Hausverwaltung digitalisieren
///
///

namespace Uebung56_Hausverwaltung
{
    internal class Mieter
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public Mieter(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"NameMieter = {name}";
        }


    }
}
