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
/// 
///

namespace Uebung55_KundeMitAdressen
{
    internal class Adresse
    {
        private string strasse;
        private string ort;



        public string Strasse { get => strasse; set => strasse = value; }
        public string Ort { get => ort; set => ort = value; }

        public Adresse(string strasse, string ort)
        {
            this.strasse = strasse;
            this.ort = ort;
        }
        public override string ToString()
        {
            return $"Adresse [strasse={Strasse}, ort={Ort}]";
        }
    }
}
