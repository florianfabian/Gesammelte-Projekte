using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace H15_PizzaKonfigurator
{
    internal class PizzaDatei : Pizza
    {
        private string datei = @"pizzaliste.txt";
        


        public PizzaDatei(string typ, string größe, List<string> extras, List<string> toppings, string datei) : base(typ, größe, extras, toppings)
        {
            this.datei = datei;
        }

        public void speichern(Pizza pizza)
        {
            using (StreamWriter writer = new StreamWriter(@"pizzaliste.txt", true))
            {
                writer.WriteLine($"Typ: {pizza.Typ}");
                writer.WriteLine($"Größe: {pizza.Größe}");
                writer.WriteLine("Extras:");

                foreach (string extra in pizza.Extras)
                {
                    writer.WriteLine($"- {extra}");
                }

                writer.WriteLine("Toppings:");

                foreach (string topping in pizza.Toppings)
                {
                    writer.WriteLine($"- {topping}");
                }

                writer.WriteLine();
            }
        }
    }
}
