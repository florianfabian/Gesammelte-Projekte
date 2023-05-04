using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
/// Autor:          Florian Fabian
/// Datum:          22.08.22
/// Funktion:       Klasse für die Eigenschaften eines Luftballons
/// Funktion:       Ergänzung 25.08.: Klasse Luftballon um Objektmethoden ergänzt
/// Funktion:       Ergänzung 29.08.:Zugriffsmethoden Getter/Setter hinzugefügt
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

        public string Farbe { get => farbe; set => farbe = value; }
        public string Form { get => form; set => form = value; }
        public double MaxVolumen { get => maxVolumen; set => maxVolumen = value; }
        public double Volumen { get => volumen; set => volumen = value; }
        public bool Verknotet { get => verknotet; set => verknotet = value; }

        public Luftballon(string farbe, string form, double maxVolumen)
        {
            this.farbe = farbe;
            this.form = form;
            this.maxVolumen = maxVolumen;

        }


        public void Aufpusten(double volumen)
        {
            if (!IstVerknotet() && !IstZerplatzt())
            {
                this.volumen += volumen;

                if (this.volumen > maxVolumen)
                {
                    Platzen();
                }
            }
        }
        
        public void Verknoten()
        {
            verknotet = true;
        }

        public void Platzen()
        {
            Console.WriteLine("KAWOUUUUMM.....");
            this.volumen = 0;
            this.maxVolumen = 0;    
        }

        public bool IstVerknotet()
        {
            return verknotet;
        }

        public bool IstZerplatzt()
        {
            return maxVolumen == 0;
        }

        public override string ToString()
        {
            return $"Luftballon [farbe={farbe}, form={form}, maxVolumen={maxVolumen}" +
                $"volumen={volumen}, verknotet={verknotet}]";
        }
    }
}
