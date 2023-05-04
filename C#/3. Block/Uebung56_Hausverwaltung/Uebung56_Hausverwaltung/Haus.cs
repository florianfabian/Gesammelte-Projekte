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
    /// <summary>
    /// Meine Argumentation für die Vererbung Mieter -> Wohnung -> Haus wäre, 
    /// dass ein Vermieter die Mieteinnahmen der PERSONEN kontrollieren möchte, 
    /// nicht die Immobilien selbst, die aus meiner Sicht erst nach der im Mietvertrag stehenden Person betrachtet werden.
    /// Problem ist mir erst nachher aufgefallen: Haus1-8, anstatt Mieter 1-8 - Namenskonvention ist für den Programmierer verwirrend.
    /// Ebenfalls steht das Haus ja im Vordergrund! Habe ich nicht mehr umgmeschrieben...
    /// Entschuldigen Sie das bitte, Dr. Langeheinecke! :(
    /// </summary>
    internal class Haus : Wohnung
    {
        private int hausnr;



        public Haus(int hausnr, int nummer, double flaeche, double monatsmiete, string name) : base(nummer, flaeche, monatsmiete, name)
        {
            Hausnr = hausnr;
        }

        public int Hausnr { get => hausnr; set => hausnr = value; }

        public override string ToString()
        {
            return $"Hausnummer = {hausnr}";
        }
    }
}
