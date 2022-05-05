using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      05.05.2022
/// Funktion:   Sortieren eines Arrays
/// </summary>

namespace Uebung42_ASelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[30];
            for(int i = 0; i < 30; i++)
            {
                array[i] = random.Next(1, 101);
            }

            Console.WriteLine("Array vor dem Sortieren:\n");
            Console.WriteLine(string.Join("|",array));
            SelectionSort(array);
            Console.WriteLine("\n\n\nArray nach dem Sortieren:\n");
            Console.WriteLine(String.Join("|",array));
        }

        public static int IndexOfMinimum(int[] array, int startIndex)
        {
            int index2 = startIndex;
            for (int i = startIndex; i < array.Length; i++)
            {
                if(array[index2] > array[i])
                {
                    index2 = i;
                }
            }
            return index2;
        }
        public static void Swap(int[] array, int index1, int index2)
        {
            int rechner = array[index1];
            array[index1] = array[index2];
            array[index2] = rechner;
        }
        public static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int rechner = IndexOfMinimum(array, i);
                Swap(array, i, rechner);
            }
        }
    }
}
