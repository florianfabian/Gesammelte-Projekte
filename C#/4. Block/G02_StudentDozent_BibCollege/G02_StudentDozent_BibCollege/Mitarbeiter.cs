using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_StudentDozent_BibCollege
{
    internal class Mitarbeiter : Person
    {
        /// <summary>
        /// Das zusätzliche Attribut '_gehalt'.
        /// </summary>
        private float _gehalt;
        public Mitarbeiter(string vorname, string nachname, float gehalt)
        : base(vorname, nachname) // Konstruktor der Klasse 'Person'.
        {
            this._gehalt = gehalt;
        }
        public override string ToString()
        {
            // ToString()-Methode von 'Person'.
            return base.ToString() + " (" + _gehalt + " Euro)";
        }
    }
}
