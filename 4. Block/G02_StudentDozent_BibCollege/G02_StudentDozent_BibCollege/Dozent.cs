using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_StudentDozent_BibCollege
{
    internal class Dozent : Mitarbeiter
    {
        /// <summary>
        /// Das zusätzliche Attribut '_fach'.
        /// </summary>
        private string _fach;
        public Dozent(string vorname, string nachname, float gehalt, string fach)
        : base(vorname, nachname, gehalt) // Konstruktor der Klasse 'Mitarbeiter'.
        {
            this._fach = fach;
        }
        public override string ToString()
        {
            // ToString()-Methode von 'Mitarbeiter'.
            return base.ToString() + " unterrichtet " + _fach + "";
        }
    }
}
