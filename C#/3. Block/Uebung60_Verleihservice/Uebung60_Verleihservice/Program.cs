using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///
///
///Autor:       Florian Fabian
///Datum:       23.09.2022
///Funktion:    Verleihservice objektorientiert
///

namespace Uebung60_Verleihservice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baumaschine b1 = new Baumaschine("B20258", "Mobilbagger 17,5t", 280.00, 30.00, 42.00, true);
            Baumaschine b2 = new Baumaschine("B20233", "Radlader 4,9t", 157.00, 25.00, 25.00, false);
            Transporter t1 = new Transporter("T30124", "VW Transporter T5 Prtischenwagen", 95.00, 32.00, 2.8);
            Transporter t2 = new Transporter("T31123", "Mercedes-Benz Atego Kipper", 215.00, 55.00, 7.5);

            Console.WriteLine("b1 = " + b1 + " Verleih bei 6 Stunden : ";
            Console.WriteLine("\nb2 = " + b2);
            Console.WriteLine("\nt1 = " + t1 + " Benötigter Führerschein : " + t1.BenoetigterFuehrerschein(t1.ZulaessigesGesamtgewicht));
            Console.WriteLine("\nt2 = " + t2 + " Benötigter Führerschein : " + t2.BenoetigterFuehrerschein(t2.ZulaessigesGesamtgewicht));
        }
    }
}
