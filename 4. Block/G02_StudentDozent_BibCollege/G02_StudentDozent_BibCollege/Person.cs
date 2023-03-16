using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_StudentDozent_BibCollege
{
    internal class Person
    {
        private string _vorname;
        private string _nachname;
        public Person(string vorname, string nachname)
        {
            this._vorname = vorname;
            this._nachname = nachname;
        }
        public override string ToString()
        {
            return _nachname + ", " + _vorname;
        }
    }
}
