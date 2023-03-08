using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H15_PizzaKonfigurator
{
    internal class Pizza
    {

            public string Typ { get; set; }
            public string Größe { get; set; }
            public List<string> Extras { get; set; }
            public List<string> Toppings { get; set; }

            public Pizza(string typ, string größe, List<string> extras, List<string> toppings)
            {
                Typ = typ;
                Größe = größe;
                Extras = extras;
                Toppings = toppings;
            }
    }
}
