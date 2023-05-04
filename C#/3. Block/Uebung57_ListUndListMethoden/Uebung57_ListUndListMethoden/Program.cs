using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///
///
/// Datum:      09.09.2022
/// Autor:      Florian Fabian nach Tafelbild
/// Funktion:   Mit Listen rumspielen
///
///

namespace Uebung57_ListUndListMethoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> zahlen = new List<int>();

            Console.WriteLine("Count: " + zahlen.Count);
            Console.WriteLine("Capacity: " + zahlen.Capacity);

            zahlen.Add(4);

            Console.WriteLine("Count: " + zahlen.Count);
            Console.WriteLine("Capacity: " + zahlen.Capacity);

            zahlen.Add(15);
            zahlen.Add(8);
            zahlen.Add(-5);

            Console.WriteLine("Count: " + zahlen.Count);
            Console.WriteLine("Capacity: " + zahlen.Capacity);

            zahlen.Add(-50);

            Console.WriteLine("Count: " + zahlen.Count);
            Console.WriteLine("Capacity: " + zahlen.Capacity);

            zahlen.Add(15);
            zahlen.Add(8);
            zahlen.Add(-5);

            Console.WriteLine("Count: " + zahlen.Count);
            Console.WriteLine("Capacity: " + zahlen.Capacity);

            //Es findet eine Speicherreservierung nach Verdoppelung statt,
            //immer wenn der Speicherplatz  ausgereizt ist und neuer gebraucht wird, wird ein Bit hinzugefügt
            //Die Kapazität hat aber anscheinend nichts mit der realen Kapazität der Liste zu tun...?
            //Warum findet eine Verdoppelung statt. Listen scheinen viel Speicherplatz zu verbrauchen.

            Console.WriteLine("");

            List<string> lieblingsalben = new List<string>();
            lieblingsalben.Add("Mezmerize ");
            lieblingsalben.Add("Hypnotize ");
            lieblingsalben.Add("Nord Nord Ost ");
            lieblingsalben.Add("Kreuzfeuer ");
            lieblingsalben.Add("Sagas ");
            lieblingsalben.Add("Victory Songs ");
            lieblingsalben.Add("Symphonien AD ");
            lieblingsalben.Add("Symphonien B ");
            lieblingsalben.Add("Neon (live) ");
            lieblingsalben.Add("Living Things ");


            Console.WriteLine(lieblingsalben.BinarySearch("Vic"));

            for (int i = 0; i < lieblingsalben.Count; i++)
            {
                Console.WriteLine(lieblingsalben[i]);
            }

            /*lieblingsalben.Clear();
            int zaehler = 0;
            do {
                Console.WriteLine("Existieren noch Elemente...? : ");
                if(lieblingsalben.Count > 0)
                {
                    Console.WriteLine(lieblingsalben[zaehler]);
                }
                else
                {
                    Console.WriteLine("Ab hier nicht mehr!\n\n\n");
                }
            }while(zaehler < lieblingsalben.Count);*/


            if(lieblingsalben.Contains("Mezmerize ") == true) //Hier gibt er kein true zurück...? Weil ich .Clear benutzt habe!!!!! auskommentiert
            {
                Console.WriteLine("Mezmerize ist in der Liste! \n\n\n");
            }
            else
            {
                Console.WriteLine("Mezmerize ist nicht in der Liste\n\n\n");
            }

            lieblingsalben.Sort();

            for (int i = 0; i < lieblingsalben.Count; i++)
            {
                Console.WriteLine(lieblingsalben[i]);
            }


            List<string> lieblingsinterpreten = new List<string>();

            lieblingsinterpreten.Add("\n\n\nSystem of a Down ");
            lieblingsinterpreten.Add("Subway to Sally ");
            lieblingsinterpreten.Add("Equilibrium ");
            lieblingsinterpreten.Add("Ensiferum ");
            lieblingsinterpreten.Add("Antonín Dvorák ");
            lieblingsinterpreten.Add("Beethoven ");
            lieblingsinterpreten.Add("Linkin Park ");

            for (int i = 0; i < lieblingsinterpreten.Count; i++)
            {
                Console.WriteLine(lieblingsinterpreten[i]);
            }


            

        }
    }
}
