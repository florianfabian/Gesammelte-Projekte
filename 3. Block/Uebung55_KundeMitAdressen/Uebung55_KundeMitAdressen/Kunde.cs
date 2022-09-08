using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
/// Autor:          Florian Fabian
/// Datum:          07.09.2022
/// Funktion:       Kunde wird angelegt mit Datensatz Adresse (Klasse Kunde, Klasse Adresse)
/// Funktion:       Selber Tag/Stunde: In Klasse Adresse Lieferadresse hinzugefügt
/// 
///

namespace Uebung55_KundeMitAdressen
{
    internal class Kunde
    {
        private string name;
        private Adresse rechnungsadresse;
        private Adresse lieferadresse;



        public string Name { get => name; set => name = value; }
        public Adresse Rechnungsadresse { get => rechnungsadresse; set => rechnungsadresse = value; }
        internal Adresse Lieferadresse { get => lieferadresse; set => lieferadresse = value; }

        public Kunde(string name, Adresse rechnungsadresse)
        {
            this.name = name;
            this.rechnungsadresse = rechnungsadresse;
        }

        public Kunde(Adresse lieferadresse)
        {
            this.lieferadresse = lieferadresse;
        }

        public override string ToString()
        {
            return $"Kunde [name={Name}], Rechnungsadresse={Rechnungsadresse}, Lieferadresse={Lieferadresse}";
        }

    }
}
