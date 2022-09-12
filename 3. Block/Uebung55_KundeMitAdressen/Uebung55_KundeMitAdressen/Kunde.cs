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
/// Edit:           12.09.2022: add + remove Lieferadresse mit List<Adresse>
/// 
///

namespace Uebung55_KundeMitAdressen
{
    internal class Kunde
    {
        private string name;
        private Adresse rechnungsadresse;
        private Adresse lieferadresse;
        private List<Adresse> adresseList;




        public string Name { get => name; set => name = value; }
        public Adresse Rechnungsadresse { get => rechnungsadresse; set => rechnungsadresse = value; }
        internal Adresse Lieferadresse { get => lieferadresse; set => lieferadresse = value; }
        public List<Adresse> AdresseList { get => adresseList; set => adresseList = value; }

        public Kunde(string name, Adresse rechnungsadresse, Adresse lieferadresse)
        {
            this.name = name;
            this.rechnungsadresse = rechnungsadresse;
            this.lieferadresse = lieferadresse;
            adresseList = new List<Adresse>
            {
                lieferadresse,
                rechnungsadresse
            };
        }

        public void AddLieferadresse(Adresse a)
        {
            if(a == null)
            {
                throw new ArgumentNullException(nameof(a) + " darf nicht verwendet werden, da Inhalt nicht existent ist");
            }
            adresseList.Add(a);
        }
        
        public bool RemoveLieferadressen(Adresse a)
        {
            return adresseList.Remove(a);
        }
        

        public override string ToString()
        {
            return $"Kunde [name={Name}], Rechnungsadresse={Rechnungsadresse}, Lieferadresse={Lieferadresse}";
        }

    }
}
