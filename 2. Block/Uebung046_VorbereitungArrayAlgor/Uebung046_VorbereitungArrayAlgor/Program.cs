using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      05.05.2022
/// Funktion:   Werte von einem Array werden in zwei Variablen geschrieben + getauscht
/// </summary>

namespace Uebung046_VorbereitungArrayAlgor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int index1 = 3;
            int index2 = 7;
            Console.WriteLine(String.Join(" | ", array));
            Console.WriteLine("\n"+array[index1] + " ist die erste Stelle vor Swap");
            Console.WriteLine(array[index2] + " ist die zweite Stelle vor Swap\n\n\n");
            Swap(array, index1, index2);
            Console.WriteLine(String.Join(" | ", array));
            Console.WriteLine("\n"+array[index1] + " ist die erste Stelle nach dem Swap");
            Console.WriteLine(array[index2] + " ist die zweite Stelle nach dem Swap");
        }
        public static void Swap(int[] array, int index1, int index2)
        {
            int rechner = array[index1];
            array[index1] = array[index2];
            array[index2] = rechner;
        }
    }
}
