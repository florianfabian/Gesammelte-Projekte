using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:          Florian Fabian
/// Datum:          22.08.22
/// Funktion:       Klasse für die Eigenschaften eines Luftballons
///

namespace Übung50_KlasseLuftballon_FF
{
    internal class Luftballon
    {
        private string farbe;
        private string form;
        private double maxVolumen;
        private double volumen;
        private bool verknotet;

        public Luftballon(string farbe, string form, double maxVolumen)
        {
            this.farbe = farbe;
            this.form = form;
            this.maxVolumen = maxVolumen;

        }

        public override string ToString()
        {
            return $"Luftballon [farbe={farbe}, form={form}, maxVolumen={maxVolumen}" +
                $"volumen={volumen}, verknotet={verknotet}]";
        }
    }
}
