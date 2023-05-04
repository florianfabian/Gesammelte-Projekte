using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_StudentDozent_BibCollege
{
    internal class Student : Person
    {
        /// <summary>
        /// Das zusätzliche Attribut '_string'.
        /// </summary>
        private string _klasse;
        public Student(string vorname, string nachname, string klasse)
        : base(vorname, nachname) // Konstruktor der Klasse 'Person'.
        {
            this._klasse = klasse;
        }
        public override string ToString()
        {
            // ToString()-Methode von 'Person'.
            return base.ToString() + " (" + _klasse + ")";
        }
    }
}
