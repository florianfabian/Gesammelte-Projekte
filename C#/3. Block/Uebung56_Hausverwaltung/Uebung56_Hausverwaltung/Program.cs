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
    internal class Program
    {
        static void Main(string[] args)
        {
            Haus Haus1 = new Haus(1, 1, 50.00, 300.00, "Müller");
            Haus Haus2 = new Haus(1, 2, 75.00, 550.00, "Meier");
            Haus Haus3 = new Haus(1, 3, 100.00, 820.00, "Schmidt");
            Haus Haus4 = new Haus(1, 2, 55.00, 700.00, "Fuchs");
            Haus Haus5 = new Haus(1, 1, 110.00, 1030.00, "Vogel");
            Haus Haus6 = new Haus(1, 2, 33.00, 460.00, "Rose");
            Haus Haus7 = new Haus(1, 1, 38.00, 500.00, "Strauch");
            Haus Haus8 = new Haus(1, 2, 38.00, 510.00, "Baum");

            Console.WriteLine($"{Haus1.Hausnr}, {Haus1.Nummer}, {Haus1.Flaeche}, {Haus1.Monatsmiete}, {Haus1.Name}");
            Console.WriteLine($"{Haus2.Hausnr}, {Haus2.Nummer}, {Haus2.Flaeche}, {Haus2.Monatsmiete}, {Haus2.Name}");
            Console.WriteLine($"{Haus3.Hausnr}, {Haus3.Nummer}, {Haus3.Flaeche}, {Haus3.Monatsmiete}, {Haus3.Name}");
            Console.WriteLine($"{Haus4.Hausnr}, {Haus4.Nummer}, {Haus4.Flaeche}, {Haus4.Monatsmiete}, {Haus4.Name}");
            Console.WriteLine($"{Haus5.Hausnr}, {Haus5.Nummer}, {Haus5.Flaeche}, {Haus5.Monatsmiete}, {Haus5.Name}");
            Console.WriteLine($"{Haus6.Hausnr}, {Haus6.Nummer}, {Haus6.Flaeche}, {Haus6.Monatsmiete}, {Haus6.Name}");
            Console.WriteLine($"{Haus7.Hausnr}, {Haus7.Nummer}, {Haus7.Flaeche}, {Haus7.Monatsmiete}, {Haus7.Name}");
            Console.WriteLine($"{Haus8.Hausnr}, {Haus8.Nummer}, {Haus8.Flaeche}, {Haus8.Monatsmiete}, {Haus8.Name}");

            double miete1 = Haus1.Monatsmiete + Haus2.Monatsmiete + Haus3.Monatsmiete;
            double miete2 = Haus4.Monatsmiete + Haus5.Monatsmiete;
            double miete3 = Haus6.Monatsmiete + Haus7.Monatsmiete + Haus8.Monatsmiete;
            Console.WriteLine("Mieteinnahmen vom 1. Haus: " + miete1 + " Euro.");
            Console.WriteLine("Mieteinnahmen vom 2. Haus: " + miete2 + " Euro.");
            Console.WriteLine("Mieteinnahmen vom 3. Haus: " + miete3 + " Euro.");
        }
    }
}
