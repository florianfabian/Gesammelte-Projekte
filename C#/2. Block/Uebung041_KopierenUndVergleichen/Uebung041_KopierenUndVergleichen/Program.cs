using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Autor:      Florian Fabian
/// Datum:      05.05.2022
/// Funktion:   Kopie eines Arrays erstellen
///             Dazu:
///                    Zwei Methoden
///                    Methode 1 = Kopie erstellen
///                    Methode 2 = Arrays vergleichen, ob gleiche Werte
/// </summary>

namespace Uebung041_KopierenUndVergleichen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }
            int[] arraycopy = Copy(array);
            Console.WriteLine("Gefüllter Grundarray:\n");
            Console.WriteLine(String.Join("|",array));
            Console.WriteLine("\n\n\nKopierter array hat den gleichen Inhalt...? (Überprüfung durch Methode)");
            if(Equals(array, arraycopy) == true)
            {
                Console.WriteLine("Die Arrays haben den gleichen Inhalt!");
            }
            else
            {
                Console.WriteLine("Die Arrays haben leider nicht den gleichen Inhalt :(");
            }
            Console.WriteLine("\n\n\nKontrolle:\n");
            Console.WriteLine(String.Join("|",arraycopy));
        }
        public static int[] Copy(int[] array)
        {
            int[] copy = new int[array.Length];
            for(int i = 0; i != array.Length; i++)
            {
                copy[i] = array[i];
            }
            return copy;
        }
        public static bool Equals(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            { 
                return false; 
            }
            else
            {
                for(int i = 0; i < array1.Length; i++)
                {
                    if(array1[i] != array2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
